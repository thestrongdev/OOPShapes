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
            List<Square> squareList = new List<Square>();

            do
            {
                Console.WriteLine("please input a side length for a square: ");
                string userLength = Console.ReadLine();
                
                if(int.TryParse(userLength, out int length))
                {
                    Square newSquare = new Square();
                    newSquare.SideLength = length;
                    Console.WriteLine($"\nThe square has side length {length}. Its area is {newSquare.CalculateArea()} and its perimeter is {newSquare.CalculatePerimeter()}");
                    squareList.Add(newSquare);
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }

            } while (Continue());

            List<int> sides = new List<int>();
            List<int> area = new List<int>();
            List<int> perim = new List<int>();

            for (int i = 0; i<squareList.Count(); i++)
            {
                sides.Add(squareList[i].SideLength);
                area.Add(squareList[i].CalculateArea());
                perim.Add(squareList[i].CalculatePerimeter());
            }

            Console.WriteLine($"\nYou created {squareList.Count()} squares.");
            Console.WriteLine($"Largest side length: {sides.Max()}");
            Console.WriteLine($"Smallest side length: {sides.Min()}");
            Console.WriteLine($"Average Area: {area.Average()}");
            Console.WriteLine($"Average Perimeter: {perim.Average()}");
          
        }

        static void GetTriangleLength()
        {
            Console.WriteLine("Welcome to the triangle class");
            Triangle newTriangle = new Triangle();
            List<Triangle> triangleList = new List<Triangle>();

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

                newTriangle.side1Length = triangleLengths[0];
                newTriangle.side2Length = triangleLengths[1];
                newTriangle.side3length = triangleLengths[2];

                triangleList.Add(newTriangle);

             
                //Console.WriteLine($"\nThis triangle has side lengths {newTriangle.side1Length}, {newTriangle.side2Length}, and {newTriangle.side3length}. " +
                //    $"Its area is {newTriangle.CalculateArea()} and its perimeter is {newTriangle.CalculatePerimeter()}");

            } while (Continue());

            List<double> triAreas = new List<double>();
            List<double> triPerim = new List<double>();

            for (int i = 0; i < triangleList.Count(); i++)
            {
                triAreas.Add(triangleList[i].CalculateArea());
                triPerim.Add(triangleList[i].CalculatePerimeter());
            }

            Console.WriteLine($"\nAverage Area: {triAreas.Average()}");
            Console.WriteLine($"Average Perimeter: {triPerim.Average()}");

        }


        static bool Continue()
        {
            Console.WriteLine("\nWould you like to continue (y/n)?");

            do
            {
                string userChoice = Console.ReadLine();

                if (userChoice.Equals("n", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("GOODBYE!");
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
