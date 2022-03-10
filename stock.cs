using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAccountManagnent
{
    public class MyStocks
    {
        private String companyName;
        private int stockRating;
        private string price;
        private int numberOfShares;

        public String getCompanyName()
        {
            return companyName;
        }

        public int getStockRating()
        {
            return stockRating;
        }

        public String getPrice()
        {
            return price;
        }

        public int getNumberOfShares()
        {
            return numberOfShares;
        }

        public  void Stock(String companyName, int stockRating, string price, int numberOfShares)
        {
            
            this.companyName = companyName;
            this.stockRating = stockRating;
            this.price = price;
            this.numberOfShares = numberOfShares;
        }

        internal static void Stock()
        {
            throw new NotImplementedException();
        }
    }
}

