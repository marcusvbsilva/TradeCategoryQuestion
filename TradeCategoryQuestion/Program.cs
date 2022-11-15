using System;
using System.Globalization;
using TradeCategoryQuestion.Classes;

namespace TradeCategoryQuestion
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            DateTime? referenceDate = null; 
            int? numberOfTrades = null;
            
            Console.WriteLine("Welcome to the Credit Suisse – IT DEV RISK");

            while (referenceDate == null)
            {
                Console.WriteLine("Please inform the reference date");
                string _referenceDate = Console.ReadLine();
                try
                {
                    referenceDate = DateTime.ParseExact(_referenceDate, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                }
                catch
                {
                    Console.WriteLine("This value is not valid");
                }
            }

            while (numberOfTrades == null)
            {
                Console.WriteLine("Please inform the number of trades in the portfolio");
                string _numberOfTrades = Console.ReadLine();

                try
                {
                    numberOfTrades = Convert.ToInt32(_numberOfTrades);
                }
                catch
                {
                    Console.WriteLine("This value is not valid");
                }
            }

            for (int counter = 1; counter <= numberOfTrades; counter++)
            {
                Trade trade = null;

                while (trade == null)
                {
                    string[] _trade;
                    Console.WriteLine("Please inform the trade number {0}", counter);
                    try
                    {
                        _trade = Console.ReadLine().Split(' ');

                        trade = new Trade(
                            Convert.ToDouble(_trade[0]), 
                            _trade[1], 
                            DateTime.ParseExact(_trade[2], "MM/dd/yyyy", CultureInfo.InvariantCulture), 
                            referenceDate);
                    }
                    catch
                    {
                        Console.WriteLine("This trade is not valid");
                    }
                }

                Console.WriteLine(trade.Category);
            }

            Console.ReadLine();
        }
    }
}
