using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algebraWEEK5
{
    class Program
    {
        static void Main(string[] args)
        {
            //TASK 1
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter a letter and this prog will tell you if it is a vowel or not.\n");
            string input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"DING! {input} is a vowel.");                  
                    break;
                               
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"BZZT! {input} is not a vowel.");
                    break;
            }

            //TASK 2
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Task One Finished");

            Console.Write("This prog will now calculate Body Mass Index (BMI).\nPlease Enter your weight in KG:");
            double weight = double.Parse(Console.ReadLine());
            Console.Write("Please enter height in CM:");
            double height = double.Parse(Console.ReadLine())/100;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Your BMI is {weight / (height * 2)}");
            Console.WriteLine("Task Two Finished");

            //TASK 3
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("This prog will ask for 20 numbers and add them all up");
            float total = 0;
            for(int num1 = 1; num1 <= 20; num1++)
            {
                Console.Write("Enter Number:");
                total = total + float.Parse(Console.ReadLine());

            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Total amount is {total}");
            Console.WriteLine("Task 3 Finished");
            

            //TASK 4
            Console.WriteLine("This Prog will find the factorial number of 10");
            int fact = 1;
            int num2 = 1;
            while (num2<=10)
            {
                fact *= num2;
                num2++;
            }
            Console.WriteLine($"Total Factorial Number of 10 is: {fact}");
            Console.ReadLine();




        }

    }
}
