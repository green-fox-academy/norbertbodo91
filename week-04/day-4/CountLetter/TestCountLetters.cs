using NUnit.Framework;
using Countletter;

namespace TestCountLetter
{
    [TestFixture]
    public class TestCountLetters
    {
        [Test]
        public void TestCountWord()
        {
            ClassCountLetter word = new ClassCountLetter();

            string input = "jozsi";

            Assert.AreEqual(0, word.CountMyLetter(input)['j']);
        }
    }
}
