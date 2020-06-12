using MultiplicationTablesForPrimeNumbers.Core;
using System;
using System.Linq;
using Xunit;

namespace MultiplicationTablesForPrimeNumbers.UnitTest
{
    public class FirstNPrimesTest
    {
        FirstNPrimes _underTest;

        public FirstNPrimesTest()
        {
            _underTest = new FirstNPrimes();
        }

        [Fact]
        public void Zero_Returns_No_Elements()
        {
            var result = _underTest.GetPrimes(0);
            Assert.Empty(result);
        }

        [Fact]
        public void One_Returns_Single_Element()
        {
            var result = _underTest.GetPrimes(1);
            Assert.Single(result);
            Assert.Equal(2, result.ElementAt(0));
        }

        [Fact]
        public void Two_Returns_Two_Elements()
        {
            var result = _underTest.GetPrimes(2);

            Assert.Equal(2, result.Count());
            Assert.Equal(2, result.ElementAt(0));
            Assert.Equal(3, result.ElementAt(1));
        }

        [Fact]
        public void Five_Returns_Correct_Fifth_Element()
        {
            var result = _underTest.GetPrimes(5);

            Assert.Equal(5, result.Count());
            Assert.Equal(11, result.ElementAt(4));
        }
    }
}
