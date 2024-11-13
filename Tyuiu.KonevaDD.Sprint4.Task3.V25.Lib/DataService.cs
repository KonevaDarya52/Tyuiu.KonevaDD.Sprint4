using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KonevaDD.Sprint4.Task3.V25.Lib
{
    public class DataService : ISprint4Task3V25
    {
        public int Calculate(int[,] array)
        {
            int product = 1;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                product *= array[i, 3]; 
            }
            return product;
        }
    }
}
