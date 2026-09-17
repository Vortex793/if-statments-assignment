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
        //CURTIS APFELBECK
        static void Main(string[] args)
        {
            Console.WriteLine("Which part of the code would you like to run (choose between 1-3)");
            Console.WriteLine("1 - Compass Bearings");
            Console.WriteLine("2 - Parking Garage Cost");
            Console.WriteLine("3 - Hurricane");

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
                Console.WriteLine("The cost of parking is: $4 for 1 hour");
            }
            else if (minutes >= 120)
            {
                Console.WriteLine("The cost of parking is: $6 for 2 hours");
            }
            else if (minutes >= 180)
            {
                Console.WriteLine("The cost of parking is: $8 for 3 hours");
            }
            else if (minutes >= 240)
            {
                Console.WriteLine("The cost of parking is: $10 for 4 hours");
            }
            else if (minutes >= 300)
            {
                Console.WriteLine("The cost of parking is: $12 for 5 hours");
            }
            else if (minutes >= 360)
            {
                Console.WriteLine("The cost of parking is: $14 for 6 hours");
            }
            else if (minutes >= 420)
            {
                Console.WriteLine("The cost of parking is: $16 for 7 hours");
            }
            else if (minutes >= 480)
            {
                Console.WriteLine("The cost of parking is: $18 for 8 hours");
            }
            else 
            { 
                Console.WriteLine("The maximum cost of parking is: $20 for a day");
            }

            
            
        }

        public static void Part3()
        {
            Console.Clear();

            int input;

            Console.Write("Enter a between 1-5 for a hurricane category: ");
            input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine("Category 1 Hurricane Wind Speeds:");
                    Console.WriteLine("- 74-95 mph");
                    Console.WriteLine("- 64-82 kt");
                    Console.WriteLine("- 119-153 km/hr");
                    break;
                case 2:
                    Console.WriteLine("Category 2 Hurricane Wind Speeds:");
                    Console.WriteLine("- 96-110 mph");
                    Console.WriteLine("- 83-95 kt");
                    Console.WriteLine("- 154-177 km/hr");
                    break;
                case 3:
                    Console.WriteLine("Category 3 Hurricane Wind Speeds:");
                    Console.WriteLine("- 11-130 mph");
                    Console.WriteLine("- 96-113 kt");
                    Console.WriteLine("- 178-209 km/hr");
                    break;
                case 4:
                    Console.WriteLine("Category 4 Hurricane Wind Speeds:");
                    Console.WriteLine("- 131-155 mph");
                    Console.WriteLine("- 114-135 kt");
                    Console.WriteLine("- 210-249 km/hr");
                    break;
                case 5:
                    Console.WriteLine("Category 5 Hurricane Wind Speeds:");
                    Console.WriteLine("- Greater than 155 mph");
                    Console.WriteLine("- Greater than 135 kt");
                    Console.WriteLine("- Greater than 249 km/hr");
                    break;
                default:
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                    break;
            }
        }
    }
}
