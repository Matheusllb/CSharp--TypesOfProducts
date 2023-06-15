using System.Globalization;
using TypesOfProducts.Entities;

namespace TypesOfProducts
{
    public class Program
    {
        public static void Main()
        {
            List<Product> products = new List<Product>();
            Console.Write("Enter the numbers of products: ");
            int times = int.Parse(Console.ReadLine());

            for (int i = 1; i <= times; i++)
            {
                Console.Write($"\nProduct #{i} data:\nCommon, Used or Imported? (c/u/i): ");
                string type = Console.ReadLine();
                if (type == "c")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: $ ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Product p = new Product(name, price);
                    products.Add(p);
                }
                else if (type == "u")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: $ ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Manufacture date (dd/MM/yyyy): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    Product p = new UsedProduct(name, price, manufactureDate);
                    products.Add(p);
                }else if (type == "i")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: $ ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Customs fee: $ ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Product p = new ImportedProduct(name, price, customsFee);
                    products.Add(p);
                }
                else 
                { 
                    Console.WriteLine("Unknown product type");
                    break;
                }
            }

            Console.WriteLine("PRICE TAGS:");
            foreach (Product p in products)
            {
                Console.WriteLine(p.PriceTag());
            }
        }
    }
}