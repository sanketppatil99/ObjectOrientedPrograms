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
        public InventoryDetails Read(string path)
        {
            using (StreamReader file = new StreamReader(path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<InventoryDetails>(json);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return null;
                }
            }
        }
    }
}


