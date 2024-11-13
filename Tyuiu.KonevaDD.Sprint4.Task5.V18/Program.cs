using Tyuiu.KonevaDD.Sprint4.Task5.V18.Lib;
namespace Tyuiu.KonevaDD.Sprint4.Task5.V18

{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int[,] array = new int[5, 5];
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = rand.Next(-6, 8);
                }
            }

            Console.WriteLine("Исходный массив:");
            PrintMatrix(array);

            int[,] modifiedArray = ds.Calculate(array);

            Console.WriteLine("\nМодифицированный массив:");
            PrintMatrix(modifiedArray);
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}