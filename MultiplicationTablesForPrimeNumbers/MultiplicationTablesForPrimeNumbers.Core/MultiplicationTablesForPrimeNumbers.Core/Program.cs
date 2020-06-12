using System;
using System.Linq;

namespace MultiplicationTablesForPrimeNumbers.Core
{
    public class Program
    {
        static void Main(string[] args)
        {
            var primeTest = new FirstNPrimes();
            var primes = primeTest.GetPrimes(5);
            foreach (var prime in primes)
            {
                Console.WriteLine(prime);
            }

            var tableTest = new MultiplicationTable();
            var table = tableTest.GetTable(primes);

            for (int i = 0; i < primes.Count(); i++)
            {
                for (int j = 0; j < primes.Count(); j++)
                {
                    Console.Write(table[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
