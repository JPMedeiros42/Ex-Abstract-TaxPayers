
namespace ExFixAbstract.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double Income { get; set; }
        public double HealthEx { get; set; }

        protected TaxPayer(string name, double income)
        {
            Name = name;
            Income = income;
        }

        protected TaxPayer(string name, double income, double healthEx)
        {
            Name = name;
            Income = income;
            HealthEx = healthEx;
        }

        public abstract double TaxPaid();
    }
}
