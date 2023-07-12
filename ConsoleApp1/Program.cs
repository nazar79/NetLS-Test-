using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("При вводi координат потрiбно враховувати нуль!");

            Console.Write("Input top-left coordinate of the x1: ");
            int x1 = Int32.Parse(Console.ReadLine());
            Console.Write("Input top-left coordinate of the y1: ");
            int y1 = Int32.Parse(Console.ReadLine());

            Console.Write("Input bottom-right coordinate of the x2: ");
            int x2 = Int32.Parse(Console.ReadLine());
            Console.Write("Input bottom-right coordinate of the y2: ");
            int y2 = Int32.Parse(Console.ReadLine());

            if (checkSquare(x1, y1, x2, y2))
            {
                Console.Clear();
                drawSquare(x1, y1, x2, y2);
            }
            else
            {
                Console.WriteLine("Incorrect data entered");
            }
        }

        private static bool checkSquare(int x1, int y1, int x2, int y2)
        {
            var isSquare = x2 - x1 == y2 - y1;
            return isSquare;
        }
        private static void drawSquare(int x1, int y1, int x2, int y2)
        {
            for (int row = y1; row < y2; row++)
            {
                for (int col = x1; col < x2; col++)
                {
                    Console.SetCursorPosition(col, row);
                    Console.Write('X');
                }
            }

            Console.WriteLine();
            Console.WriteLine("Enter the coordinates of the point");

            Console.Write("Input X: ");
            var x = Int32.Parse(Console.ReadLine());
            Console.Write("Input Y: ");
            var y = Int32.Parse(Console.ReadLine());

            drawPoint(x, y);

            Console.SetCursorPosition(0, x2 + 8);
            if (checkPoint(x1, y1, x2, y2, x, y))
            {
                Console.Write("Yes");
            }
            else Console.Write("No");

            Console.ReadKey();
        }

        private static void drawPoint(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("@");
        }
        private static bool checkPoint(int x1, int y1, int x2, int y2, int pointX, int pointY)
        {
            if (((x1 + x2) / 2) == pointX && ((y1 + y2) / 2) == pointY)
                return true;

            return false;
        }
    }
}
