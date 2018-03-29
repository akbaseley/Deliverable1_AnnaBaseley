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
            Numbers newNumber = new Numbers();
            newNumber.GetNumbers();

            Console.ReadKey();
        }
    }

    class Numbers
    {
        public string userNumber1;
        public string userNumber2;

        public void GetNumbers()
        {
            //The computer asks the user for two three digit numbers.
            Console.WriteLine("Hello. Please enter a three digit number.");

            userNumber1 = Console.ReadLine();

            while (userNumber1.Length != 3)
            {
                Console.WriteLine("I'm sorry.  Could you try that again?  The number needs to be a whole number with three digits.");

                userNumber1 = Console.ReadLine();
            }

            Console.WriteLine("Thanks!  Could I have one more three digit number?");

            userNumber2 = Console.ReadLine();

            while (userNumber2.Length != 3)
            {
                Console.WriteLine("I'm sorry.  Could you try that again?  The number needs to be a whole number with three digits.");

                userNumber2 = Console.ReadLine();
            }

            // The three-digit numbers is now changed from variables to integers.
            int number1 = int.Parse(userNumber1.ToString());
            int number2 = int.Parse(userNumber2.ToString());

            // The strings are divided into lists of integers.
            List<int> List1 = new List<int>();
            while (number1 > 0)
            {
                int digit;
                number1 = Math.DivRem(number1, 10, out digit);
                List1.Add(digit);
            }
            List1.Reverse();


            List<int> List2 = new List<int>();
            while (number2 > 0)
            {
                int digit2;
                number2 = Math.DivRem(number2, 10, out digit2);
                List2.Add(digit2);
            }
            List2.Reverse();

            // The integer lists are divided into Int[]s.
            int[] Array1 = List1.ToArray();
            int[] Array2 = List2.ToArray();

            // The Arrays are now added together to form a third Array.
            var List3 = Enumerable.Zip(Array1, Array2, (a, b) => a + b);
            int[] Array3 = List3.ToArray();

            //The parts of Array3 are compared, and the output is listed as True or False.
            if (Array3[0] == Array3[1] &&
                Array3[1] == Array3[2] &&
                Array3[0] == Array3[2])
            {
                Console.WriteLine("Each corresponding place in these two numbers add up to the same total: True");
            }
            else
            {
                Console.WriteLine("Each corresponding place in these two numbers add up to the same total: False");
            }
        }
    }
}
