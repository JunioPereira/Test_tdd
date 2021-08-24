using NUnit.Framework;
using System.Collections.Generic;
using Test_tdd.Challenge;

namespace Test_tdd_test
{
    public class UnitTestChallengeService
    {
        IChallengeService _test;

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

            Assert.Equals(3, _result);

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

            Assert.Equals(new int[]{ 2, 4, 6, 8 }, _result);

        }

        [Test]
        public void FormatWordsTest()
        {
            string _result = _test.FormatWords(new string[] {"junio", "cesar", "pereira" });

            Assert.Equals("junio, cesar and pereira", _result);

        }
    }
}
