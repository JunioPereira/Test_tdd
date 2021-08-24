using NUnit.Framework;
using System.Collections.Generic;
using Test_tdd.Challenge;

namespace Test_tdd_Test
{
    [TestFixture]
    public class UnitTestChallenge
    {
        private IChallengeService _test;

        [SetUp]
        public void SetUp()
        {
            _test = new ChallengeService();
        }

        [Test]
        public void OutlierTest()
        {
            List<int> _lst = new List<int>();
            _lst.Add(2);
            _lst.Add(3);
            _lst.Add(4);
            _lst.Add(6);
            _lst.Add(8);

            int _result = _test.Outlier(_lst);

            Assert.AreEqual(3, _result);

        }

        [Test]
        public void GetIntegerListTest()
        {
            List<object> _lst = new List<object>();
            _lst.Add(2);
            _lst.Add("Junio");
            _lst.Add(4);
            _lst.Add("Cesar");
            _lst.Add(6);
            _lst.Add("Pereira");
            _lst.Add(8);

            int[] _result = _test.GetIntegerList(_lst);

            Assert.AreEqual(new int[] { 2, 4, 6, 8 }, _result);

        }

        [Test]
        public void FormatWordsTest()
        {
            string _result = _test.FormatWords(new string[] { "junio", "cesar", "pereira" });

            Assert.AreEqual("junio, cesar and pereira", _result);

        }
    }
}