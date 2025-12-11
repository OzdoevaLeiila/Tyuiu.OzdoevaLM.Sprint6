using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.OzdoevaLM.Sprint6.Task6.V4.Lib;

namespace Tyuiu.OzdoevaLM.Sprint6.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutDataFileTask6V4.txt";

            var res = ds.CollectTextFromFile(path);
            string wait = "SnBC nnndrM RbvnKtNW";

            Assert.AreEqual(wait, res);
        }
    }
}