using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosAbstratos.Entities
{
    internal class LegalEntity : People
    {
        public int EmploeeysNumber { get; set; }

        public LegalEntity() { }

        public LegalEntity(string name, double annualIncome, int emploeeysNumber) : base(name, annualIncome)
        {
            EmploeeysNumber = emploeeysNumber;

        }
        public override double Tax()
        {
            if (EmploeeysNumber > 10)
            {
                return AnnualIncome * 0.14;
            }
            else
            {
                return (AnnualIncome * 0.16);

            }
        }
    }
}
