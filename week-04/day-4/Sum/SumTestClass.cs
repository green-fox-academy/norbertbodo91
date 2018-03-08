using NUnit.Framework;
using SumProg;
using System.Collections.Generic;

namespace SumTest
{
    [TestFixture]
    public class SumTestClass
    {
        [Test]
        public void SumTestSumOfList()
        {           
            var sumClass = new SumClass();
            var numList = new List<int>();

            numList.Add(15);
            numList.Add(15);
            numList.Add(5);
            numList.Add(18);

            Assert.AreEqual(53,sumClass.SumMyNms(numList));
        }
        [Test]
        public void SumTestNoEle()
        {
            var sumClass = new SumClass();
            var emptyList = new List<int>();

            Assert.AreEqual(0,sumClass.SumMyNms(emptyList));
        }
        [Test]
        public void SumTestOneEle()
        {
            var sumClass = new SumClass();
            var oneEleList = new List<int>();

            oneEleList.Add(8);

            Assert.AreEqual(8,sumClass.SumMyNms(oneEleList));
        }
        [Test]
        public void SumTestNull()
        {
            var sumClass = new SumClass();
            var nullList = new List<int>();

            nullList = null;

            Assert.AreEqual(null,sumClass.SumMyNms(nullList));
        }
    }
}
