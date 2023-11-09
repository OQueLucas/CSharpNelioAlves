using ExercicioResolvido.Entities;
using System.Globalization;

namespace ExercicioResolvido
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter full file path: ");
            string path = "C:/temp/products.txt";
            //string path = Console.ReadLine();

            List<Product> list = new();

            using StreamReader sr = File.OpenText(path);
            while (!sr.EndOfStream)
            {
                string[] fields = sr.ReadLine().Split(",");
                string name = fields[0];
                double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                list.Add(new Product(name, price));
            }

            //var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average(); // Caso estiver vazio
            var avg = list.Select(p => p.Price).Average();
            Console.WriteLine("Average price = " + avg.ToString("F2", CultureInfo.InvariantCulture));

            var names = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}