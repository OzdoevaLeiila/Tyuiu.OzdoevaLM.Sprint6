using Tyuiu.OzdoevaLM.Sprint6.Task3.V4.Lib;
namespace Tyuiu.OzdoevaLM.Sprint6.Task3.V4.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] input = new int[5, 5]
            {
                {2, 1, 1, 1, 1 },
                {2, 2, 1, 1, 1 },
                {1, 1, 2, 1, 1 },
                {1, 1, 1, 2, 1 },
                {1, 1, 1, 1, 2 }
            };
            int[,] output = new int[5, 5]
            {
                {2, 1, 1, 1, 1 },
                {0, 0, 1, 1, 1 },
                {1, 1, 2, 1, 1 },
                {1, 1, 1, 2, 1 },
                {1, 1, 1, 1, 2 }
            };
            CollectionAssert.AreEqual(output, ds.Calculate(input));
        }
    }
}
