using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    public class Utilisateur
    {
        public string Name { get; set; }
        public List<Paiement> Payments { get; set; }

        public Utilisateur(string name)
        {
            Name = name;
            Payments = new List<Paiement>();
        }

        public void AddPayment(Paiement payment)
        {
            Payments.Add(payment);
        }

        public void DisplayPayments()
        {
            Console.WriteLine($"Payments for user {Name}:");
            foreach (var payment in Payments)
            {
                payment.EffectuerPaiement();
            }
        }
    }

}
