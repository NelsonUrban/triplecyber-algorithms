using System;
using System.Collections.Generic;
using System.Linq;

namespace TrypleCyber
{
    public class Coincidences
    {
        private List<int> list = new List<int>();
        public Coincidences() { }

        public void GenerateCondicences(List<int> primeNumber, List<int> randomValues)
        {
            if (primeNumber.Count() == 0 || randomValues.Count() == 0) throw new Exception("The list must be have values!");

            foreach (var prime in primeNumber)
            {
                foreach (var random in randomValues)
                {
                    if (prime > random)
                    {
                        list.Add(prime);
                        continue;
                    }
                    if (random > prime)
                    {
                        list.Add(random);
                        continue;
                    }

                }

            }

            Fibonacci(list.Max());

        }

        private void Fibonacci(int number)
        {
            int a = 0, b = 1, c = 0;

            for (int i = 2; i < number; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
        }


    }
}
