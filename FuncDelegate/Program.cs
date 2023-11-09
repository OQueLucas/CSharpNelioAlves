using Predicate.Entities;

namespace FuncDelegate
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

            //Func<Product, string> func = p => p.Name.ToUpper(); 
            //Func<Product, string> func = NameUpper;

            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();
            //List<string> result = list.Select(func).ToList();
            //List<string> result = list.Select(NameUpper).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        //static string NameUpper(Product p)
        //{
        //    return p.Name.ToUpper();
        //}
    }
}