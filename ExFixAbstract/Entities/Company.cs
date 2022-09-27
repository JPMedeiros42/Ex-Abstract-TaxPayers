using System.Globalization;

namespace ExFixAbstract.Entities
{
    class Company:TaxPayer
    {
        public int Employees { get; set; }

        public Company(string name,double income,int employees):base(name,income)
        {
            Employees = employees;
        }

        public override double TaxPaid()
        {
            double total = Income;
            if (Employees > 10)
            {
                total *= 0.14;
            }
            else
            {
                total *= 0.16;
            }
            return total;
        }
    }
}
