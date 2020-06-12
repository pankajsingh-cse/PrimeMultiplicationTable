using System;
using System.Collections.Generic;
using System.Text;

namespace MultiplicationTablesForPrimeNumbers.Core
{
    public class FirstNPrimes : IFirstNPrimes
    {
        /// <summary>
        /// Assumes input is sanitised. Loops over existing primes to check divisibility.
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Enumerable of first (input) number of primes</returns>
        public IEnumerable<int> GetPrimes(int input)
        {
            var result = new List<int>();

            if (input < 1)
            {
                return result;
            }

            result.Add(2);
            
            if (input > 1)
            {
                result.Add(3);
                var lastPrime = 3;
                bool isPrime;

                while (result.Count < input)
                {
                    lastPrime = lastPrime + 2;
                    isPrime = true;

                    foreach (var prime in result)
                    {
                        if (lastPrime % prime == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime)
                    {
                        result.Add(lastPrime);
                    }
                }
            }

            return result;
        }
    }
}
