using Tyuiu.GaberkornEL.Sprint1.Task4.V27.Lib;
namespace Tyuiu.GaberkornEL.Sprint1.Task4.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 4;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(1, res);
        }
    }
}