using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAccount
{
    public class StockCalculation
    {
        public List<StockAccount> stockAccount;
    }
    public class StockAccount
    {
        public string shareName { get; set; }

        public int numberOfShare { get; set; }

        public int sharePrice { get; set; }

    }
}
