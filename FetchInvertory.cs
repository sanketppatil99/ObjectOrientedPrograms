using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class FetchInvertory
    {
        InventoryDetails Inventory = new InventoryDetails();
        List<InventoryDetails> InventoryList = new List<InventoryDetails>();

        public void convert(string jFilePath)
        {
            using (StreamReader reader = new StreamReader(jFilePath))
            {
                var json = reader.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<InventoryDetails>>(json);
                Console.WriteLine("Name weight Price Total value");

                foreach (var item in items)
                {
                    double value = item.price * item.weight;

                    Console.WriteLine(item.name + " " + item.weight + " " + item.price + " " + value);
                }
            }
        }
    }
}


