using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sum2FilterLib;

namespace Sum_2Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSum2()
        {
            var sum2Filter = new Sum2Filter(-20, 20);
            sum2Filter.Add(-79);
            sum2Filter.Add(15);
            sum2Filter.Add(60);
            sum2Filter.ApplyFilter();
            Assert.AreEqual(1, sum2Filter.Count);
        }
    }
}
