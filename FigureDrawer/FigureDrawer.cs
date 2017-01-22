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

        public void DrawTriangle(int numero)
        {
            int numColumnas = CalcularNumeroColumnas(numero);

            for (int fila = 1; fila <= numero; fila++)
            {
                for (int columna = 1; columna <= numColumnas; columna++)
                {
                    if (CasillaSeraEspacioEnBlanco(fila, columna, numero))
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(fila.ToString());
                    }
                }

                Console.WriteLine();
            }
        }
        

        public void DrawTriangleTurbo(int numero) 
        {
            for (int fila = 1; fila <= numero; fila++)
            {
                for (int columna = 1; columna <= numero + fila - 1; columna++)
                {
                    if (CasillaSeraEspacioEnBlanco(fila, columna, numero))
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(fila.ToString());
                    }
                }

                Console.WriteLine();
            }        
        }

        private bool CasillaSeraEspacioEnBlanco(int fila, int columna, int numero)
        {
            return columna <= numero - fila || columna >= numero + fila;
        }

        private int CalcularNumeroColumnas(int numero)
        {
            return numero * 2 - 1;
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
