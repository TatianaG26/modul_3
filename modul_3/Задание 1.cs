using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul_3
{
    internal class Program
    {
        /*Задание 1
        Напишите метод, который отображает квадрат из некоторого символа.
        Метод принимает в качестве параметра: длину стороны квадрата, символ.*/
        public static void DrawSquare(int size, char symbol)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(symbol + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            DrawSquare(5, '*');
        }
    }
}
