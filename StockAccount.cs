using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoomertialDataProcesssing
{
    
    class StockAccount
    {
        string FileName;
        string symbol;
        int amount;

        public static void Filename()
        { 
        
            StockAccount stock = new StockAccount();

            stock.FileName = "nifty50";
         
            Console.WriteLine(stock.FileName);

            
        
        }

        public static void buy()
        { 
        StockAccount stock = new StockAccount();

            stock.symbol = "TATA";
            stock.amount = 1000;

            Console.WriteLine(stock.symbol);
            Console.WriteLine(stock.amount);
        
        }

        public static void sell()
        { 
        StockAccount stock = new StockAccount();

            stock.symbol = "TATA";
            stock.amount = 1500;

            Console.WriteLine(stock.symbol);
            Console.WriteLine(stock.amount);

        }

        
    

    }
}
