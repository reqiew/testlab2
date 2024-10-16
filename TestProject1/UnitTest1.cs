using testlab2;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            testlab2.Class1 cl = new Class1();
            Assert.AreEqual(true, cl.IsPalindrome(121));
            Assert.AreNotEqual(false, cl.IsPalindrome(121));
        }
    }
}