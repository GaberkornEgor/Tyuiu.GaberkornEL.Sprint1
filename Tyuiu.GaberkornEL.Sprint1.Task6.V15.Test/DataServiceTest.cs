using Tyuiu.GaberkornEL.Sprint1.Task6.V15.Lib;

namespace Tyuiu.GaberkornEL.Sprint1.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCheckLettersCount()
        {
            DataService ds = new DataService();
            string value = "stropa.";
            bool result = ds.CheckLettersCount(value);
            Assert.AreEqual(true, result);
        }
    }
}