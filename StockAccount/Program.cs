using StockAccount;
using System.Reflection;

namespace StockAccount
{
    class Program
    {
        public static void Main(string[] args)
        {

            int totalStockValue = 0;
            string filePath = @"D:\257\JsonInventory\InventoryManagement\StockAccount\Stocks.json";
            StockDetails stockDetails = new StockDetails();
            StockCalculation data = new StockCalculation();
            data = stockDetails.Read(filePath);



            for (int i = 0; i < data.stockAccount.Count; i++)
            {
                Console.WriteLine("Share Name: " + data.stockAccount[i].shareName);
                Console.WriteLine("Number of Share: " + data.stockAccount[i].numberOfShare);
                Console.WriteLine("Share Price: " + data.stockAccount[i].sharePrice);
                int stockValue = data.stockAccount[i].numberOfShare * data.stockAccount[i].sharePrice;
                Console.WriteLine("Total stock value of {0} is : {1}", data.stockAccount[i].shareName, stockValue);
                totalStockValue += stockValue;

            }
            Console.WriteLine("value of total stocks  is: {0}", totalStockValue);
        }
    }
}