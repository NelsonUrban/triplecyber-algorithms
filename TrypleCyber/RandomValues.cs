using System;
using System.Collections.Generic;
using System.Linq;

namespace TrypleCyber
{
    public class RandomValues
    {
        private readonly Random random = new Random();
        private readonly List<int> listResult = new List<int>();
        public RandomValues() { }

        public List<int> GetRandomList(int number = 5)
        {
            if (number >= 1 && number <= 20)
            {
                for (int i = 0; i < number; i++)
                {
                    listResult.Add(GenerateRamdom());
                }
                return listResult;
            }
            throw new Exception("The number is not in the range of 1 to 20");
        }

        private int GenerateRamdom()
        {
            while (true)
            {
                var numberRandom = random.Next(100);
                var newNumber = listResult.Exists(x => x == numberRandom);
                if (!newNumber)
                {
                    return numberRandom;
                }
            }
            
        }
    }
}
