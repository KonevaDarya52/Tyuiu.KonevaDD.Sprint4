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
            string[] testArray = { "������", "������", "������", "���������", "�������", "�����", "������" };

            int expected = 2; 
            int actual = ds.Calculate(testArray);

            Assert.AreEqual(expected, actual, "����� Calculate ������ ���������� ���������� ���������� ��������� � ������ ������ 6.");
        }
    }
}