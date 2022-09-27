using System;
using ExFixAbstract.Entities;
using System.Globalization;
using System.Collections.Generic;

namespace ExFixAbstract
{
    class Program
    {
        static void Main(string[] args)
        {

            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer#{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char t = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                if (t == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthEx = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name,income,healthEx));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name,income,employees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID");
            double sum = 0;
            foreach (TaxPayer obj in list)
            {
                sum += obj.TaxPaid();
                Console.WriteLine($"{obj.Name}: $ {obj.TaxPaid().ToString("F2", CultureInfo.InvariantCulture)}");
            }

            Console.WriteLine();
            Console.Write($"TOTAL TAXES: $ {sum.ToString("F2",CultureInfo.InvariantCulture)}");
        
        }
    }
}
