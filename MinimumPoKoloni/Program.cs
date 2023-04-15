using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumPoKoloni
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
                string[] elements = Console.ReadLine().Split(' ');
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = int.Parse(elements[col]);
                }
            }
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
            int[] columnMin = new int[m];
            for (int i = 0; i < columnMin.Length; i++)
            {
                columnMin[i] = int.MaxValue;
            }
            for (int col = 0; col < m; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    if (matrix[row, col] < columnMin[col])
                    {
                        columnMin[col] = matrix[row, col];
                    }
                }
            }
            foreach (int min in columnMin)
            {
                Console.Write($"{min} ");
            }
            Console.WriteLine();
        }
    }
}
