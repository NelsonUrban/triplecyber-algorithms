using System;

namespace TrypleCyber
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.	Valores Aleatorios
            RandomValues random = new RandomValues();
            var result = random.GetRandomList(10);

            //2.	números primos
            PrimeNumbers primeNumbers = new PrimeNumbers();
            var resultPrime = primeNumbers.GeneratePrimeNumbers();

            //3.	Emulador de Cajero automático
            CashMachine cashMachine = new CashMachine();
            cashMachine.GenerateCash(2537);

            //4.	Coincidencias
            Coincidences coincidences = new Coincidences();
            coincidences.GenerateCondicences(resultPrime, result);

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
