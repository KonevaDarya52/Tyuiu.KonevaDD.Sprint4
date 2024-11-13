using Tyuiu.KonevaDD.Sprint4.Task2.V1.Lib;
namespace Tyuiu.KonevaDD.Sprint4.Task2.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[] array = new int[10];
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 10);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
            int result = ds.Calculate(array);
            Console.WriteLine("Произведение четных элементов: " + result);
        }
    }
}