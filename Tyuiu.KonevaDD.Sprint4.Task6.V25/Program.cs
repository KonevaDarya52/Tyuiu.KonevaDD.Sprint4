using Tyuiu.KonevaDD.Sprint4.Task6.V25.Lib;
namespace Tyuiu.KonevaDD.Sprint4.Task6.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sports = { "Теннис", "Футбол", "Крикет", "Баскетбол", "Бейсбол", "Регби", "Хоккей" };

            DataService ds = new DataService();
            int result = ds.Calculate(sports);
            Console.WriteLine("Количество элементов, длина которых больше 6: " + result);
        }
    }
}