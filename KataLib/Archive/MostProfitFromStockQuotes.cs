using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public static class MostProfitFromStockQuotes
    {
        public static int GetMostProfitFromStockQuotes(this int[] quotes, int coins = 0, int profit = 0)
            => quotes.Count() == 1
                    ? profit + coins * quotes.First()
                 : quotes.First() > quotes.Skip(1).Max()
                        ? quotes.Skip(1).ToArray().GetMostProfitFromStockQuotes(0, profit + coins * quotes.First())
                        : quotes.Skip(1).ToArray().GetMostProfitFromStockQuotes(coins + 1, profit - quotes.First());



        //public static int GetMostProfitFromStockQuotes(int[] quotes)
        //{
        //    return quotes.Select((q, i) => quotes[i..].Max() - q).Sum();
        //}


        //public static int GetMostProfitFromStockQuotes(int[] quotes)
        //{
        //    var profit = 0;
        //    var coins = 0;

        //    for (int i = 0; i < quotes.Length - 1; i++)
        //    {
        //        var max = quotes.Skip(i + 1).Max();
        //        if (i == quotes.Length - 1 || quotes[i] > quotes.Skip(i + 1).Max())
        //        {
        //            (coins, profit) = quotes[i].Sell(coins, profit);
        //        }
        //        else
        //        {
        //            (coins, profit) = quotes[i].Buy(coins, profit);
        //        }
        //    }

        //    profit += coins * quotes.Last();
        //    coins = 0;

        //    return profit;
        //}
    }


}

