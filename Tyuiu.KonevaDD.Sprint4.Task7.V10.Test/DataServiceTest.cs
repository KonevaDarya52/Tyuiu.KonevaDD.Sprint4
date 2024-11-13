using Tyuiu.KonevaDD.Sprint4.Task7.V10.Lib;
namespace Tyuiu.KonevaDD.Sprint4.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate()
        {
            DataService ds = new DataService();
            string testString = "695847142536";
            int expected = 30;  
            int actual = ds.Calculate(3, 4, testString);
            Assert.AreEqual(expected, actual, "Сумма нечетных чисел в матрице должна быть правильной.");
        }
    }
}