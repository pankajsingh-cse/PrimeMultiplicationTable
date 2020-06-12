using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiplicationTablesForPrimeNumbers.Core
{
    public class MultiplicationTable : IMultiplicationTable
    {
        /// <summary>
        /// n2/2 computations
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Returns multiplication table of each element with every other element in the input including the number 1</returns>
        public int[,] GetTable(IEnumerable<int> input)
        {
            var count = input.Count();
            var result = new int[count,count];

            for (int i = 0; i < count; i++)
            {

                for (int j = i; j < count; j++)
                {
                    result[i, j] = input.ElementAt(i) * input.ElementAt(j);
                    result[j, i] = input.ElementAt(i) * input.ElementAt(j);
                }
            }
            return result;
        }
    }
}
