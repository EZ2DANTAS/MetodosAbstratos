using MetodosAbstratos.Entities;
using System;
using System.Globalization;

// Metodos e Classes Abstratas são usados para não deixar que classes sejam instanciadas pois por muitas vezes são genericas
// OBS: Se voce tem um metodo abstrato a classe por padrão deve ser abstrata
namespace MetodosAbstratos{
    class Program
    {
        static void Main(string[] args)
        {
            List<People> people = new List<People>();

            Console.WriteLine("Enter the numbers of tax payers: ");
            int taxPayers = int.Parse(Console.ReadLine());

            for(int i = 1; i <= taxPayers; i++) 
            {
                Console.WriteLine($"Tax payer {i} data: ");
                Console.WriteLine("Individual or Company (i/c): ");
                char option = char.Parse(Console.ReadLine().ToLower());

                while(option != 'i' && option != 'c') 
                {
                    Console.WriteLine("Type Corretly: ");
                    Console.WriteLine("Individual or Company (i/c): ");
                    option = char.Parse(Console.ReadLine().ToLower());
                }
                if(option == 'i')
                {
                    Console.WriteLine("Name: ");
                    string name = Console.ReadLine();

                    Console.WriteLine("Annual Income: ");
                    double annualIncome = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                    Console.WriteLine("Health Expenditure: ");
                    double healthExpenditure = double.Parse(Console.ReadLine());

                    people.Add(new NaturalPerson(name,annualIncome,healthExpenditure));
                }
                else
                {
                    Console.WriteLine("Name: ");
                    string name = Console.ReadLine();

                    Console.WriteLine("Annual Income: ");
                    double annualIncome = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                    Console.WriteLine("Employees Number: ");
                    int employeesnumber = int.Parse(Console.ReadLine());

                    people.Add(new LegalEntity(name, annualIncome, employeesnumber));
                }

            }

            Console.WriteLine("TAXES PAID: ");

            double totalTax = 0;
            foreach(People item in people)
            {
                Console.WriteLine($"{item.Name} $ {item.Tax()} ");
                totalTax += item.Tax();
            }

            Console.WriteLine( $" \n TOTAL TAXES: $ {totalTax.ToString("F2")}");
        }
    }
}