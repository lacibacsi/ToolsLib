using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Math
    {
        /// <summary>
        /// Returns the list of prime numbers equal or below the input parameter
        /// uses the Sieve of Eratosthenes
        /// </summary>
        /// <param name="m">upper inclusive limit</param>
        /// <returns>List of prime numbers</returns>
        public List<int> GetPrimes(int m)
        {
            List<int> list = new List<int>(Enumerable.Range(2, m - 1));

            //find and remove multiples of primes 
            for (int i = 2; i < m + 1; i++)
            {

                for (int inner = list.Count - 1; inner > 0; inner--)
                {
                    if (list[inner] % i == 0 && list[inner] != i)
                        list.RemoveAt(inner);
                }

            }

            return list;
        }
    }
}
