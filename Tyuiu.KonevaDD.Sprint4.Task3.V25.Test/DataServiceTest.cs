using Tyuiu.KonevaDD.Sprint4.Task3.V25.Lib;
namespace Tyuiu.KonevaDD.Sprint4.Task3.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate()
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
            int res = ds.Calculate(array);
            Assert.AreEqual(3 * 5 * 3 * 6 * 3, res);


        }
    }
}