using Tyuiu.KonevaDD.Sprint4.Task5.V18.Lib;
namespace Tyuiu.KonevaDD.Sprint4.Task5.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate()
        {
            DataService ds = new DataService();
            int[,] array =
            {
                { -1, 2, -3, 4, 5 },
                { 6, -7, 8, -9, 0 },
                { 1, -2, 3, -4, 5 },
                { -5, 6, -6, 7, -8 },
                { 9, -10, 11, -12, 13 }
            };

            int[,] expectedArray =
            {
                { 0, 2, 0, 4, 5 },
                { 6, 0, 8, 0, 0 },
                { 1, 0, 3, 0, 5 },
                { 0, 6, 0, 7, 0 },
                { 9, 0, 11, 0, 13 }
            };

            int[,] resultArray = ds.Calculate(array);

            CollectionAssert.AreEqual(expectedArray, resultArray, "Метод расчета неправильно заменил отрицательные значения на ноль.");
        }
    }
}
