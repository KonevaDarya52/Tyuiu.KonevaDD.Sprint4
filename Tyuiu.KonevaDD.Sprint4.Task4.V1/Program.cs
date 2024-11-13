using System;
using Tyuiu.KonevaDD.Sprint4.Task4.V1.Lib;

namespace Tyuiu.KonevaDD.Sprint4.Task4.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5];

            Console.WriteLine("Введите элементы массива 5x5 (значения от 1 до 9):");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"Элемент [{i}, {j}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int result = ds.Calculate(matrix);

            Console.WriteLine($"Сумма четных элементов массива: {result}");
        }
    }
}
