using System.Collections.Generic;

namespace MultiplicationTablesForPrimeNumbers.Core
{
    public interface IFirstNPrimes
    {
        IEnumerable<int> GetPrimes(int input);
    }
}