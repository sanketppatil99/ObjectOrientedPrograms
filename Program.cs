namespace InventoryManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Object Oriented Programs");
            InventoryManagement.FetchInvertory json = new InventoryManagement.FetchInvertory();
            json.convert("D:\\257\\JsonInventory\\InventoryManagement\\Inventory.json");

        }
    }
}