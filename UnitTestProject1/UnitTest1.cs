using L5_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            L5_1.Pool s = new Pool();

            int m = 180;
            int[] num = { 150, 200, 120, 180, 250 };
            int result = s.Average(num);
            Assert.AreEqual(m, result);
        }
    }
}
