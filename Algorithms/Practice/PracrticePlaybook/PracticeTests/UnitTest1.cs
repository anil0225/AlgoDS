using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PracticeTests
{
    [TestClass]
    public class UnitTest1
    {
       
        [DataTestMethod]
        [DataRow("a", "b")]
        [DataRow("d", "a")]
        public void TestMethodSample(string value1, string value2)
        {
            Assert.AreEqual(value1 + value2, string.Concat(value1, value2));
        }
    }
}
