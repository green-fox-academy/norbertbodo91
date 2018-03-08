using NUnit.Framework;
using Apple;

namespace Apple.Test
{
    [TestFixture]
    public class Appletest
    {
        [Test]
        public void TestMethod1()
        {
            var alma = new AppleClass();

            Assert.AreEqual("apple",alma.GetApple());
        }
    }
}
