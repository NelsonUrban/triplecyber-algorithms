using System;
using System.Collections.Generic;

namespace TrypleCyber
{
    public class PrimeNumbers
    {
        public PrimeNumbers()
        {

        }

        public List<int> GeneratePrimeNumbers(int number = 9)
        {
            var listResult = new List<int>();

            if (number == 0) throw new Exception("The number must be greater than 0");

            for (int i = 1; i < number + 1; i++)
            {
                var valid = true;
                for (int j = 1; j <= i; j++)
                {
                    if (i % 2 == 0)
                    {
                        valid = false;
                        continue;
                    }
                    if (i % j == 0 && i != j && j > 1)
                    {
                        valid = false;
                        continue;
                    }
                }

                if (valid)
                {
                    listResult.Add(i);
                }

            }

            return listResult;

        }
    }
}
