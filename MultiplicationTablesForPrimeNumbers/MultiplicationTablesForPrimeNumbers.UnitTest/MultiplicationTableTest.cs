using MultiplicationTablesForPrimeNumbers.Core;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MultiplicationTablesForPrimeNumbers.UnitTest
{
    public class MultiplicationTableTest
    {
        MultiplicationTable _underTest;

        public MultiplicationTableTest()
        {
            _underTest = new MultiplicationTable();
        }

        [Fact]
        public void Empty_Input_Returns_Empty()
        {
            Assert.Empty(_underTest.GetTable(new List<int>()));
        }

        [Fact]
        public void Returns_Correct_Table()
        {
            var input = new List<int> { 2, 7, 29 };
            var output = _underTest.GetTable(input);

            Assert.Equal(4, output[0, 0]);
            Assert.Equal(14, output[0, 1]);
            Assert.Equal(58, output[0, 2]);
            Assert.Equal(14, output[1, 0]);
            Assert.Equal(49, output[1, 1]);
            Assert.Equal(203, output[1, 2]);
            Assert.Equal(58, output[2, 0]);
            Assert.Equal(203, output[2, 1]);
            Assert.Equal(841, output[2, 2]);
        }
    }
}
