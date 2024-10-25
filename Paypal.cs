using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    public class Paypal
    {
        public string Email { get; set; }

        public Paypal(string email)

        {
            Email = email;
        }

        public void EffectuerPaiement()
        {
            Console.WriteLine($" effectué via PayPal à l'adresse {Email}");
        }
   
   /*static void Main (string[] args)
    {
        Paypal paiement1 = new Paypal("email1@example.com");
        Paypal paiement2 = new Paypal("email2@example.com");

        paiement1.EffectuerPaiement();
        paiement2.EffectuerPaiement();
    }*/
    }
}
