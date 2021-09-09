using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyMaker1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("Enter an amount to convert to coins:");
            string totalAsString = Console.ReadLine();
            double totalAsDouble = Convert.ToDouble(totalAsString);
            Console.WriteLine($"{totalAsDouble} cents is equal to: ");
            int gold = 10;
            int silver = 5;

            //Calculates dem dere golden doubloons
            double goldCoins = Math.Floor(totalAsDouble / gold);
            double leftOver = totalAsDouble % gold;
            double silverCoins = Math.Floor(leftOver / silver);
            double remainder = leftOver % silver;

            //All dem dere Moneyz
            Console.WriteLine($"Gold coins: {goldCoins}");
            Console.WriteLine($"Silver coins: {silverCoins}");
            Console.WriteLine($"Bronze coins: {remainder}");
        }
    }
}
