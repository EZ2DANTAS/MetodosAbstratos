using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosAbstratos.Entities
{
    internal class NaturalPerson : People
    {
        public double HealthExpenditure { get; set; }


        public NaturalPerson() { }

        public NaturalPerson(string name, double annualIncome, double healthExpenditure) : base(name, annualIncome)
        {
            HealthExpenditure = healthExpenditure;
        }

        public override double Tax()
        {
            if(AnnualIncome < 20000)
            {
                double value = (AnnualIncome* 0.15) -(HealthExpenditure * 0.5);
                if(value < 0)
                {
                    value = value * (-1) ;
                }
               
                return value;
            }
            else
            {
                
                return (AnnualIncome * 0.25) - (HealthExpenditure * 0.5);
            }
        }
    }
}
