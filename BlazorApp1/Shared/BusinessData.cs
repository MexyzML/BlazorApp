
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Shared
{
    public class BusinessData : IBusinessData

    {
        public BusinessData()
        {
            Factures = new Facture[]
            {

                new Facture("ABC123", "Legrand", 880, 121, new DateTime(2020, 10, 21),  new DateTime(2020, 11, 20) ),
                new Facture("KLM307", "Chaverou", 154, 30,  new DateTime(2020, 09, 20),  new DateTime(2020, 10, 01) ),
                new Facture("PTG456", "Haming", 600, 600, new DateTime(2020, 04, 15),  new DateTime(2020, 05, 15) ),
                new Facture("GBF654", "Peribere", 93, 12,  new DateTime(2020, 12, 04),  new DateTime(2021, 01, 03) )
            };

        }
        public IEnumerable<Facture> Factures { get; }

        public double TotalPayé => Factures.Sum(Facture => Facture.MontantRegle);

        public double TotalManquant => Factures.Sum(Facture => Facture.MontantRestant);


    }
}
