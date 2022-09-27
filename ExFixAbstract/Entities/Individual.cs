using System.Globalization;

namespace ExFixAbstract.Entities
{
    class Individual:TaxPayer
    {

        public Individual(string name,double income,double healthEx):base(name,income,healthEx)
        {

        }

        public override double TaxPaid()
        {
            double total = Income;
            if (Income < 20000)
            {
                total *= 0.15;
            }
            else 
            {
                total *= 0.25;
            }
            total -= HealthEx * 0.5;
            return total;
        }
    }
}
