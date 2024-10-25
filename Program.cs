internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    // Création de la classe abstraite Paiement
    public abstract class Paiement
    {
        public double Montant { get; set; }
        public string Description { get; set; }

        public Paiement(double montant, string description)
        {
            Montant = montant;
            Description = description;
        }

        public abstract void EffectuerPaiement();
    }

}