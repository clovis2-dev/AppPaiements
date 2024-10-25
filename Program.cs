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
    /*static void Main (string[] args)
    {
        CarteCredit achat1 = new CarteCredit(10050);
        CarteCredit achat2 = new CarteCredit(20075);
        CarteCredit achat3 = new CarteCredit(5000);

        achat1.EffectuerPaiement();
        achat2.EffectuerPaiement();
        achat3.EffectuerPaiement();
    }*/
    public class Paypal 
    {
        public string Email { get; set; }

        public Paypal(string email)
            
        {
            Email = email;
        }

        public  void EffectuerPaiement()
        {
            Console.WriteLine($" effectué via PayPal à l'adresse {Email}");
        }
    }
      /*static void Main1(string[] args)
        {
        Paypal paiement1 = new Paypal ("email1@example.com");
        Paypal paiement2 = new Paypal( "email2@example.com");

        paiement1.EffectuerPaiement();
        paiement2.EffectuerPaiement();
        }*/

    static void Main(string[] args)
    {
        CarteCredit achat1 = new CarteCredit(10050);
        CarteCredit achat2 = new CarteCredit(20075);
        CarteCredit achat3 = new CarteCredit(5000);
        Paypal paiement1 = new Paypal("email1@example.com");
        Paypal paiement2 = new Paypal("email2@example.com");

        achat1.EffectuerPaiement();
        achat2.EffectuerPaiement();
        achat3.EffectuerPaiement();
        paiement1.EffectuerPaiement();
        paiement2.EffectuerPaiement();
    }



}