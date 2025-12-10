using Tyuiu.OzdoevaLM.Sprint6.Task0.V24.Lib;
namespace Tyuiu.OzdoevaLM.Sprint6.Task0.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            var dataService = new DataService();
            Assert.AreEqual(4294967296, dataService.Calculate(5));
        }
    }
}
