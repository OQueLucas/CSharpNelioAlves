using ExercicioFixacao.Entities;
using System.Globalization;

namespace ExercicioFixacao
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter full file path:");
            Console.WriteLine("c:\\temp\\employees.txt");
            string path = "c:\\temp\\employees.txt";

            Console.Write("Enter salary: ");
            double input = double.Parse(Console.ReadLine());

            List<Employee> list = new();

            using StreamReader sr = new(path);
            while (!sr.EndOfStream)
            {
                var fields = sr.ReadLine().Split(",");
                string name = fields[0];
                string email = fields[1];
                double salary = Double.Parse(fields[2], CultureInfo.InvariantCulture);

                list.Add(new Employee(name, email, salary));
            }

            Console.WriteLine($"Email of people whose salary is more than {input}:");
            var emails = list.Where(p => p.Salary > input).Select(p => p.Email);
            foreach (var email in emails)
            {
                Console.WriteLine(email);
            }

            var sum = list.Where(p => p.Name.ToUpper()[0] == 'M').Sum(p => p.Salary).ToString("F2", CultureInfo.InvariantCulture);
            Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sum);
        }
    }
}