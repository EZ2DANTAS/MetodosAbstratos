using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosAbstratos
{
    internal abstract class People
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public People() { }

        public People(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }


        // Metodo Abstrato Generico
        public abstract double Tax();
    }
}
