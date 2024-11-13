using Tyuiu.KonevaDD.Sprint4.Task2.V1.Lib;

namespace Tyuiu.KonevaDD.Sprint4.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate()
        {
            DataService ds = new DataService();
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 2 };
            int result = ds.Calculate(array);
            Assert.AreEqual(768, result); 
        }
    }
}
