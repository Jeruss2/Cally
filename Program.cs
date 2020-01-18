using System;

namespace Cally
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculate = 0; ;


            while (calculate != 4)
            {

                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Pick: \n 0 to add \n 1 to subtract \n 2 to multiply \n 3 to divide \n 4 to exit.");

                 calculate = int.Parse(Console.ReadLine());

                if (calculate == 0)
                {
                    Console.WriteLine("What is the first number you want to add?");
                    int firstNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("What is the second number you want to add?");
                    int secondNumber = int.Parse(Console.ReadLine());

                    int add = method.GetAdd(firstNumber, secondNumber);

                    Console.WriteLine($"Your results are: {add}");

                }

                else if (calculate == 1)
                {
                    Console.WriteLine("What is the first number you want to subtract?");
                    int thirdNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("What is the second number you want to subtract?");
                    int forthNumber = int.Parse(Console.ReadLine());

                    int subtract = method.GetSubtract(thirdNumber, forthNumber);

                    Console.WriteLine($"Your results are: {subtract}");

                }

                else if (calculate == 2)
                {
                    Console.WriteLine("What is the first number you want to multiply?");
                    int fifthNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("What is the second number you want to mulitply?");
                    int sixthNumber = int.Parse(Console.ReadLine());

                    int multiply = method.GetMultiply(fifthNumber, sixthNumber);

                    Console.WriteLine($"Your results are: {multiply}");

                }

                else if (calculate == 3)
                {
                    Console.WriteLine("What is the first number you want to divide?");
                    int seventhNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("What is the second number you want to divide?");
                    int eighthNumber = int.Parse(Console.ReadLine());

                    int divide = method.GetDivide(seventhNumber, eighthNumber);

                    Console.WriteLine($"Your results are: {divide}");
                }

                else
                {
                    return;
                }

            }
        }
    }
}
