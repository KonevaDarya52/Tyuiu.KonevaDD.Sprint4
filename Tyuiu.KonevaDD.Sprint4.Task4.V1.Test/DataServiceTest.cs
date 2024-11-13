using Tyuiu.KonevaDD.Sprint4.Task4.V1.Lib;
namespace Tyuiu.KonevaDD.Sprint4.Task4.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[,]
            {
                { 2, 5, 1, 7, 5 },
                { 4, 4, 7, 4, 4 },
                { 7, 1, 6, 8, 8 },
                { 8, 1, 5, 8, 4 },
                { 8, 9, 1, 7, 3 }
            };

            int result = ds.Calculate(matrix);

            Assert.AreEqual(68, result);
        }
    }
}