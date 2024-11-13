using Tyuiu.KonevaDD.Sprint4.Task7.V10.Lib;
namespace Tyuiu.KonevaDD.Sprint4.Task7.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "695847142536";
            DataService ds = new DataService();
            int sum = ds.Calculate(3, 4, input);  
            Console.WriteLine("Сумма нечетных чисел в матрице: " + sum);
        }
    }
}