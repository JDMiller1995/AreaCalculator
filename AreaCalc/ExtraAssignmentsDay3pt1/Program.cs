using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraAssignmentsDay3pt1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you struggle to do basic area calculations? Well struggle no longer my friend, I have this handy dandy calculator!");
            Console.WriteLine("Please ignore that I could only put 3 functions in here, math is also not my forte.");
            Console.WriteLine("Choose which shape you'd like to calculate the area of below by entering a 1, 2, or 3 respectively.");
            Console.WriteLine("1. Triangle");
            Console.WriteLine("2. Square");
            Console.WriteLine("3. Rectangle");
            Console.WriteLine("PS, don't forget to add your units of measurement once you get the answer.");
            string shape = Console.ReadLine();
            while (breakMe(shape) == false)
            {
                Console.WriteLine("Please choose one of the shapes provided. I can't do much math, friend.");
                shape = Console.ReadLine();
            }
            loopy(shape);
            Console.WriteLine("Thanks for using my calculator :D");
        }

        static void loopy(string shape)
        {
            if (shape == "1")
            {
                tri();
                Console.WriteLine("Would you like to perform another calculation? Y/N");
                string repeat = Console.ReadLine();
                if (repeat == "Y" || repeat == "y")
                {
                    Console.WriteLine("Choose which shape you'd like to calculate the area of below by entering a 1, 2, or 3 respectively.");
                    Console.WriteLine("1. Triangle");
                    Console.WriteLine("2. Square");
                    Console.WriteLine("3. Rectangle");
                    string shape2 = Console.ReadLine();
                    while (breakMe(shape2) == false)
                    {
                        Console.WriteLine("Please choose one of the shapes provided, I can't do much math, friend.");
                        shape2 = Console.ReadLine();
                    }
                    loopy(shape2);
                }
               
            }
            else if (shape == "2")
            {
                sqr();
                Console.WriteLine("Would you like to perform another calculation? Y/N");
                string repeat = Console.ReadLine();
                if (repeat == "Y" || repeat == "y")
                {
                    Console.WriteLine("Choose which shape you'd like to calculate the area of below by entering a 1, 2, or 3 respectively.");
                    Console.WriteLine("1. Triangle");
                    Console.WriteLine("2. Square");
                    Console.WriteLine("3. Rectangle");
                    string shape2 = Console.ReadLine();
                    while (breakMe(shape2) == false)
                    {
                        Console.WriteLine("Please choose one of the shapes provided, I can't do much math, friend.");
                        shape2 = Console.ReadLine();
                    }
                    loopy(shape2);
                }
                
               
            }
            else if (shape == "3")
            {
                rct();
                Console.WriteLine("Would you like to perform another calculation? Y/N");
                string repeat = Console.ReadLine();
                if (repeat == "Y" || repeat == "y")
                {
                    Console.WriteLine("Choose which shape you'd like to calculate the area of below by entering a 1, 2, or 3 respectively.");
                    Console.WriteLine("1. Triangle");
                    Console.WriteLine("2. Square");
                    Console.WriteLine("3. Rectangle");
                    string shape2 = Console.ReadLine();
                    while (breakMe(shape2) == false)
                    {
                        Console.WriteLine("Please choose one of the shapes provided, I can't do much math, friend.");
                        shape2 = Console.ReadLine();
                    }
                    loopy(shape2);
                }
                
            }
        }
        static void tri()
        {
            Console.WriteLine("What is the base of the triangle?");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("What is the height of the triangle?");
            float num2 = float.Parse(Console.ReadLine());
            float num3 = (num1 * num2) * .5F;
            Console.WriteLine("The area of a triangle with base {0} and height {1} is {2}!", num1, num2, num3);
        }

        static void rct()
        {
            Console.WriteLine("What is the base of the rectangle?");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("What is the height of the rectangle?");
            float num2 = float.Parse(Console.ReadLine());
            float num3 = num1 * num2;
            Console.WriteLine("The area of a rectangle with base {0} and height {1} is {2}!", num1, num2, num3);
        }

        static void sqr()
        {
            Console.WriteLine("What is the length of one side of the square?");
            float num1 = float.Parse(Console.ReadLine());
            float num2 = (num1 * num1);
            Console.WriteLine("The area of a square with a side length of {0} is {1}!", num1, num2);
        }

        static bool breakMe(string shape)
        {
            if (shape == "1" || shape == "2" || shape == "3")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
