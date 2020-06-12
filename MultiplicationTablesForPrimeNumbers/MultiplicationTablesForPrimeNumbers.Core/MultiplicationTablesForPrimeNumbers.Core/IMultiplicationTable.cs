using System.Collections.Generic;

namespace MultiplicationTablesForPrimeNumbers.Core
{
    public interface IMultiplicationTable
    {
        int[,] GetTable(IEnumerable<int> input);
    }
}