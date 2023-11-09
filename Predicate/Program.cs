using Predicate.Entities;

namespace Predicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new()
            {
                new Product("Tv", 900.00),
                new Product("Mouse", 50.00),
                new Product("Tablet", 350.50),
                new Product("HD Case", 80.90)
            };

            //list.RemoveAll(p => p.Price >= 100.0);
            list.RemoveAll(ProductTest);

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        public static bool ProductTest(Product p)
        {
            return p.Price >= 100;
        }
    }
}