using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите размер матрицы ");
            int n = int.Parse(Console.ReadLine());
            
            int[,] mass = new int[n, n];
            Random ran = new Random();
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mass[i, j] = ran.Next(100);
                    Console.Write(mass[i, j] + "   ");
                }
                Console.WriteLine();
            }
            int [] diagonal = new int[n];
            Console.WriteLine("Массив под диагональю");
            
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    diagonal[i] = mass[j, i];
                    Console.Write(diagonal[i] + "   ");
                }
            }
            Console.ReadLine();
        }
    }
}
