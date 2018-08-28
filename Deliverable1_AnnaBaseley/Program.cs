using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnaBaseley.Deliberable1b
{
    class Program
    {
        static void Main(string[] args)
        {
            int UserNumber1 = GetNumbers("Hello. Please enter a number.");
            int UserNumber2 = GetNumbers("Thanks!  Could I have one more number? Make sure it has the same number of digits as the first number.");

            while (UserNumber1.ToString().Length != UserNumber2.ToString().Length)
            {
                UserNumber2 = GetNumbers("I'm sorry.  Could you try that again?  The number needs to be a whole number with four digits.");
            }

            int[] NumberArr1 = CreateArrays(UserNumber1);
            int[] NumberArr2 = CreateArrays(UserNumber2);

            int[] SumArray = CreateArrays(NumberArr1, NumberArr2);

            Result(SumArray);

            Console.ReadKey();
        }
        public static int GetNumbers(string message)
        {
            Console.WriteLine(message);
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber;
        }

        public static int[] CreateArrays(int UserNumber)
        {
            int[] NumArray = new int[UserNumber.ToString().Length];

            for (int i = 0; i < NumArray.Length; i++)
            {
                NumArray[i] = UserNumber % 10;
                UserNumber /= 10;
            }
            return NumArray;
        }

        public static int[] CreateArrays(int[] NumberArr1, int[] NumberArr2)
        {
            int[] SumArray = new int[NumberArr1.Length];

            for (int i = 0; i < NumberArr1.Length; i++)
            {
                SumArray[i] = NumberArr1[i] + NumberArr2[i];
            }

            return SumArray;
        }

        public static void Result(int[] SumArray)
        {
            int count = 0;
            for (int i = 0; i < SumArray.Length-1; i++)
            {
                if(SumArray[i] != SumArray[i + 1])
                {
                    count++;
                }
            }
            if(count > 0)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }
        }
    }
}
