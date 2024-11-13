using Tyuiu.KonevaDD.Sprint4.Task1.V29.Lib;
namespace Tyuiu.KonevaDD.Sprint4.Task1.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate()
        {
            DataService ds = new DataService();
            int[] testArray = { 5, 3, 3, 4, 1, 3, 3, 5, 6, 2, 7, 2, 1, 8 };

            int result = ds.Calculate(testArray);

            int expectedSum = 5 + 3 + 3 + 1 + 3 + 3 + 5 + 7 + 1; 
            Assert.AreEqual(expectedSum, result, "Метод не вернул правильную сумму нечетных чисел.");
        }
    }
}
