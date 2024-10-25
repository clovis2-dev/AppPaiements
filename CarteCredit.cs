using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    
    
        public class CarteCredit
        {
            public int NumeroCarte { get; set; }

            public CarteCredit(int numeroCarte)

            {
                NumeroCarte = numeroCarte;

            }

            public void EffectuerPaiement()
            {
                Console.WriteLine($"le numéro de la  carte de crédit est : {NumeroCarte} ");
            }
       
    /*static void Main (string[] args)
    {
        CarteCredit achat1 = new CarteCredit(30050);
        CarteCredit achat2 = new CarteCredit(20075);
        CarteCredit achat3 = new CarteCredit(5000);

        achat1.EffectuerPaiement();
        achat2.EffectuerPaiement();
        achat3.EffectuerPaiement();
    }*/
    }
}

