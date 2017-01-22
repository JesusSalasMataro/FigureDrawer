using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDrawer
{
    class Program
    {
        static void Main(string[] args)
        {
            FigureDrawer squareDrawer = new FigureDrawer();

            int number = AskForNumber();

            squareDrawer.DrawSquare(number);
            Console.WriteLine();
            squareDrawer.DrawTriangle(number);
            Console.WriteLine();
            squareDrawer.DrawTriangleTurbo(number);

            Console.WriteLine();
            Console.WriteLine("Pulsa cualquier tecla para salir...");
            Console.ReadKey();
        }

        private static int AskForNumber()
        {
            Console.Write("Introduce un número: ");

            int number = 0;
            int.TryParse(Console.ReadLine(), out number);

            Console.WriteLine();
            
            return number;
        }
    }
}
