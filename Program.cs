using System;
using System.Collections.Generic;
using System.Linq;

namespace OOPShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetSquareLength();
            GetTriangleLength();
        }

        static void GetSquareLength()
        {
            Console.WriteLine("Welcome to the Square Class");
            do
            {
                Console.WriteLine("please input a side length for a square: ");
                string userLength = Console.ReadLine();

                if(int.TryParse(userLength, out int length))
                {
                    Square newSquare = new Square();
                    newSquare.SideLength = length;
                    Console.WriteLine($"\nThe square has side length {length}. Its area is {newSquare.CalculateArea()} and its perimeter is {newSquare.CalculatePerimeter()}");

                }
                else
                {
                    Console.WriteLine("Invalid input");
                }

            } while (Continue());
        }

        static void GetTriangleLength()
        {
            Console.WriteLine("Welcome to the triangle class");

            do
            {
                Console.WriteLine("\nPlease input 3 side lengths for a triangle separated by a space");
                string userLength = Console.ReadLine();

                string[] userTriangleLengths = userLength.Split();
                List<double> triangleLengths = new List<double>();

                bool anyNonNum = false;

                foreach (string item in userTriangleLengths) {

                    if (double.TryParse(item, out double sidelength))
                    {
                        triangleLengths.Add(sidelength);
                    }
                    else
                    {
                        anyNonNum = true;
                    }
                }

                if (anyNonNum)
                {
                    Console.WriteLine("INVALID ENTRY!");
                    continue;
                }

                Triangle newTriangle = new Triangle();
                newTriangle.side1Length = triangleLengths[0];
                newTriangle.side2Length = triangleLengths[1];
                newTriangle.side3length = triangleLengths[2];

                Console.WriteLine($"\nThis triangle has side lengths {newTriangle.side1Length}, {newTriangle.side2Length}, and {newTriangle.side3length}. " +
                    $"Its area is {newTriangle.CalculateArea()} and its perimeter is {newTriangle.CalculatePerimeter()}");


            } while (Continue());
        }


        static bool Continue()
        {
            Console.WriteLine("\nWould you like to continue (y/n)?");

            do
            {
                string userChoice = Console.ReadLine();

                if (userChoice.Equals("n", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("GOODBYE");
                    return false;
                }
                else if (userChoice.Equals("y", StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("that's not a valid input. please enter y or n");
                }

            } while (true);
        }
    }
}
