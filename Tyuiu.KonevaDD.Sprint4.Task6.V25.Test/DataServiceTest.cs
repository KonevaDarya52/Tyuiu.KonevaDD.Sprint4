using Tyuiu.KonevaDD.Sprint4.Task6.V25.Lib;
namespace Tyuiu.KonevaDD.Sprint4.Task6.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate()
        {
            DataService ds = new DataService();
            string[] testArray = { "Теннис", "Футбол", "Крикет", "Баскетбол", "Бейсбол", "Регби", "Хоккей" };

            int expected = 2; 
            int actual = ds.Calculate(testArray);

            Assert.AreEqual(expected, actual, "Метод Calculate должен возвращать правильное количество элементов с длиной больше 6.");
        }
    }
}