using System;

namespace OOPShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            GetLength();
        }

        static void GetLength()
        {
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



        static bool Continue()
        {
            Console.WriteLine("Would you like to continue (y/n)?");

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
