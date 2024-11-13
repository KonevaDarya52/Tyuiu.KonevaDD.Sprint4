using Tyuiu.KonevaDD.Sprint4.Task3.V25.Lib;
namespace Tyuiu.KonevaDD.Sprint4.Task3.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5]
            {
               { 7, 3, 5, 3, 6 },
               { 4, 6, 2, 5, 7 },
               { 2, 3, 3, 3, 5 },
               { 2, 7, 7, 6, 2 },
               { 6, 6, 4, 3, 6 },
            };

            DataService ds = new DataService();
            int result = ds.Calculate(array);
            Console.WriteLine("Произведение элементов четвертого столбца: " + result);
        }
    }
}