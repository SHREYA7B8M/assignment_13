using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // C# Basics Revision

            //Task #1: Hello World

            //Console.WriteLine("Hello World");


            //// Task #2: Variables and User Input

            //Console.WriteLine("Input Name: ");
            //string name=Console.ReadLine();
            //Console.WriteLine($"Hello {name}!");


            ////Task #3: Basic Arithmetic
            //float a, b;
            //Console.WriteLine("Input 1st #: ");
            //a=float.Parse(Console.ReadLine());
            //Console.WriteLine("Input 2nd #: ");
            //b=float.Parse(Console.ReadLine());
            //float sum = (a + b);
            //float difference = (a - b);
            //float product = (a * b);

            //if (b != 0)
            //{
            //    float quotient = (a / b);
            //    float remainder = (a % b);  

            //    Console.WriteLine($"Sum: {sum}");
            //    Console.WriteLine($"Difference: {difference}");
            //    Console.WriteLine($"Product: {product}");
            //    Console.WriteLine($"Quotient: {quotient}");
            //    Console.WriteLine($"Remainder: {remainder}");
            //}
            //else
            //{
            //    Console.WriteLine("Division by zero is not allowed!");
            //}


            //Task #4: Control Structures

            //Console.Write("Input a #: ");
            //int num = int.Parse(Console.ReadLine());

            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("The number is even.");
            //}
            //else
            //{
            //    Console.WriteLine("The number is odd.");
            //}


            // Task #5: Loops

            //using 'for' loop
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            // using 'while' loop
            //int count = 1;
            //while (count <= 10)
            //{
            //    Console.WriteLine(count);
            //    count++;
            //}


            //Task #6: Arrays

            //int[] elements  = {11,22,33,44,55};
            //int sum = 0;
            //foreach (int num in elements)
            //{
            //    sum += num;
            //}

            //double average = (double)sum / elements.Length;

            //Console.WriteLine($"Sum: {sum}");
            //Console.WriteLine($"Average: {average}");


            // Task #7: Methods

            //        Console.WriteLine("Factorial Calculation");
            //        Console.Write("Input a #: ");
            //        int fac = int.Parse(Console.ReadLine());

            //        long factorial = FactorialCalculate(fac);
            //        Console.WriteLine($"Factorial of {fac} is: {factorial}");

            //}

            //        static long FactorialCalculate(int f)
            //        {
            //            if (f == 0 || f == 1)
            //            {
            //                return 1;
            //            }

            //            else
            //            {
            //                return f * FactorialCalculate(f - 1);
            //            }
            //        }


            // Task #8: Exception Handling

            int age;

            while (true)
            {
                Console.Write("Input age: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out age))
                {
                    if (age < 0)
                    {
                        Console.WriteLine("Age can't be negative. Please enter a valid age.");
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }

            if (age < 18)
            {
                Console.WriteLine("You are a minor.");
            }
            else if (age >= 18 && age <= 60)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a senior citizen.");
            }
        }
    }
}



