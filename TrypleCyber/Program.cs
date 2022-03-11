using System;

namespace TrypleCyber
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Random Values | Enter the number of Random values you want to generate.");
            var randon = Convert.ToInt32(Console.ReadLine());
            RandomValues random = new();
            var result = random.GetRandomList(randon);
            Console.WriteLine("This is your list of random numbers: ");
            result.ForEach(delegate (int number)
            {
                Console.WriteLine(number);
            });


            Console.WriteLine("prime numbers | Enter the number of Random values you want to generate.");
            var prime = Convert.ToInt32(Console.ReadLine());
            PrimeNumbers primeNumbers = new();
            var resultPrime = primeNumbers.GeneratePrimeNumbers(prime);
            Console.WriteLine("This is your list of Prime numbers: ");
            resultPrime.ForEach(delegate (int number)
            {
                Console.WriteLine(number);
            });


            Console.WriteLine("ATM Emulator | Enter the amount of money to withdraw.");
            var cash = Convert.ToInt32(Console.ReadLine());
            CashMachine cashMachine = new();
            var resultCash = cashMachine.GenerateCash(cash);
            Console.WriteLine("This is their distribution of Cash: ");
            resultCash.ForEach(delegate (int number)
            {
                Console.WriteLine(number);
            });

            Console.WriteLine("Coincidences | Now we will generate the matches between random numbers and prime numbers and the Fibonacci series");
            Coincidences coincidences = new();
            coincidences.GenerateCondicences(resultPrime, result);
           
            Console.ReadLine();
        }
    }
}
