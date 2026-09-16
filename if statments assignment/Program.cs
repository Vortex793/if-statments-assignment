using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace if_statments_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which part of the code would you like to run (choose between 1-3)");
            Console.WriteLine("1 - Compass Bearings");
            Console.WriteLine("2 - Dice Roller");
            Console.WriteLine("3 - Random Decimal Numbers");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1) Part1();
            else if (choice == 2) Part2();
            else if (choice == 3) Part3();


            else Console.WriteLine("Invalid number :(");

            Console.ReadLine();

        }
        public static void Part1() 
        {
            Console.Clear();
            int degree;
            Console.Write("Enter from 0-360;");
            degree = Convert.ToInt32(Console.ReadLine());

            if (degree >= 315 || degree <= 45)
            {
                Console.WriteLine("The angle is North.");
            }
            else if (degree > 45 && degree <= 135)
            {
                Console.WriteLine("The angle is East.");
            }
            else if (degree > 135 && degree <= 225)
            {
                Console.WriteLine("The angle is South.");
            }
            else if (degree > 225 && degree < 315)
            {
                Console.WriteLine("The angle is West.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a value between 0 and 360.");
            }

        }
        public static void Part2()
        {
            Console.Clear();
            int minutes, cost = 0, hours;
            

            Console.Write("How many minutes have you been parked at the garage?: ");
            minutes = Convert.ToInt32(Console.ReadLine());

            if (minutes <= 60) 
            { 
                cost += 40;
            }
            if (minutes >= 61 && minutes <= 120) 
            { 
                cost += 20;
            }

            hours = cost / 60; 
            Console.WriteLine($"The cost of parking is: {hours}");
        }

        public static void Part3()
        {

        }
    }
}
