namespace FixationExercise2.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual() { }

        public Individual(string name, double anuallncome, double healthExpenditures) 
            : base(name, anuallncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (Anuallncome <= 20000.0)
            {
                return Anuallncome * 0.15 - HealthExpenditures * 0.5;
            }
            else
                return Anuallncome * 0.25 - HealthExpenditures * 0.5;
        }
    }
}
