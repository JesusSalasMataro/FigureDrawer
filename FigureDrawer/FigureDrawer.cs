using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FigureDrawer
{
    public class FigureDrawer
    {
        public void DrawSquare(int number)
        {
            for (int row = 1; row <= number; row++)
            {
                DrawLine(row, number);
            }
        }

        public void DrawTriangle(int number)
        {
            int numColumns = CalculateColumnsNumber(number);

            for (int row = 1; row <= number; row++)
            {
                for (int column = 1; column <= numColumns; column++)
                {
                    if (PositionShouldBeWhiteSpace(row, column, number))
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(row.ToString());
                    }
                }

                Console.WriteLine();
            }
        }
        

        public void DrawTriangleTurbo(int number) 
        {
            for (int row = 1; row <= number; row++)
            {
                for (int column = 1; column <= number + row - 1; column++)
                {
                    if (PositionShouldBeWhiteSpace(row, column, number))
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(row.ToString());
                    }
                }

                Console.WriteLine();
            }        
        }

        private bool PositionShouldBeWhiteSpace(int row, int column, int number)
        {
            return column <= number - row || column >= number + row;
        }

        private int CalculateColumnsNumber(int number)
        {
            return number * 2 - 1;
        }

        private void DrawLine(int row, int number)
        {
            for (int column = 1; column <= number; column++)
            {
                if (PositionIsPerimeter(row, column, number) || PositionIsDiagonal(row, column))
                {
                    Console.Write(row.ToString() + " ");
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }

        private bool PositionIsDiagonal(int row, int column)
        {
            return row == column;
        }

        private bool PositionIsPerimeter(int row, int column, int number)
        {
            return row == 1 || row == number || column == 1 || column == number;
        }
    }
}
