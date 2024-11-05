using Tyuiu.KonevaDD.Sprint4.Task0.V17.Lib;
namespace Tyuiu.KonevaDD.Sprint4.Task0.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] numsArray = { 4, 8, 7, 6, 5, 8, 2, 4, 3, 2 };
            Console.WriteLine("Исходный массив: ");
            foreach (int num in numsArray)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.GetSumEvenArrEl(numsArray);
            Console.WriteLine("Сумма четных элементов массива: " + result);
            Console.ReadKey();



        }
       


    }





}