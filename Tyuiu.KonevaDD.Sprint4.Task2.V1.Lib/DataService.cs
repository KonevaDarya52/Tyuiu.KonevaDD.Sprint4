using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KonevaDD.Sprint4.Task2.V1.Lib
{
    public class DataService : ISprint4Task2V1
    {
        public int Calculate(int[] array)
        {
            int product = 1;
            bool hasEven = false; 

            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    product *= num;
                    hasEven = true;
                }
            }

            return hasEven ? product : 0;
        }
    }
}
