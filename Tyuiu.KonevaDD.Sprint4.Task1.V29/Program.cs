using Tyuiu.KonevaDD.Sprint4.Task1.V29.Lib;
namespace Tyuiu.KonevaDD.Sprint4.Task1.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[] array = new int[14];
            Console.WriteLine("Введите 14 чисел от 1 до 9:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите число {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            int sumOfOddNumbers = ds.Calculate(array);
            Console.WriteLine($"Сумма нечётных элементов массива: {sumOfOddNumbers}");
        }
    }
}
