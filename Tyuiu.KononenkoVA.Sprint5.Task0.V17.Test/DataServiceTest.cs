using Tyuiu.KononenkoVA.Sprint5.Task0.V17.Lib;

namespace Tyuiu.KononenkoVA.Sprint5.Task0.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int x = 3;
            string path = ds.SaveToFileTextData(x);

            Assert.IsTrue(File.Exists(path));

            string fileContent = File.ReadAllText(path);

            double expectedResult = 2.4 * Math.Pow(x, 3) + 0.4 * Math.Pow(x, 2) - 1.4 * x + 4.1;
            expectedResult = Math.Round(expectedResult, 3);

            Assert.AreEqual(expectedResult.ToString(), fileContent);

            Assert.AreEqual("68,3", fileContent);
        }
    }
}