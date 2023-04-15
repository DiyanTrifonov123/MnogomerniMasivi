using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrednoaritmetichnoPoRedove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи брой редове: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Въведи брой колони: ");
            int m = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, m];

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write($"Въведи число на индекс [{row},{col}]: ");
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }

            for (int row = 0; row < n; row++)
            {
                long sumRow = 0;
                for (int col = 0; col < m; col++)
                {
                    sumRow += matrix[row, col];
                    Console.Write($"[{row},{col}] = {matrix[row, col]} ");
                }
                Console.WriteLine($" -> {sumRow/(double)m}");
            }
        }
    }
}
