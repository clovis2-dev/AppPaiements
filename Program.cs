using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
   // private static void Main(string[] args)
   // {
   //     Console.WriteLine("Hello, World!");
   // }
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
    // Création de la classe enfant CarteCredit
    public class CarteCredit 
    {
        public int NumeroCarte { get; set; }
       
        public CarteCredit( int numeroCarte)
           
        {
            NumeroCarte = numeroCarte;
            
        }

        public  void EffectuerPaiement()
        {
            Console.WriteLine($"le numéro de la  carte de crédit est : {NumeroCarte} ");
        }
    }
    static void Main (string[] args)
    {
        CarteCredit achat1 = new CarteCredit(10050);
        CarteCredit achat2 = new CarteCredit(20075);
        CarteCredit achat3 = new CarteCredit(5000);

        achat1.EffectuerPaiement();
        achat2.EffectuerPaiement();
        achat3.EffectuerPaiement();
    }



}