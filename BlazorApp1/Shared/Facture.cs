using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Shared
{
    public class Facture
    {
        private static int id =0;
        public Facture(string num, string cli, double du, double regle, DateTime Demission, DateTime Dattendu  )
        {
            Id = ++id;
            NumeroFacture = num;
            Client = cli;
            MontantDu = du;
            MontantRegle = regle;
            MontantRestant = du - regle;
            DateEmission = Demission;
            DateAttendu = Dattendu;
        }
      

       public int Id { get; }

       [Required(ErrorMessage = "Le numero de facture est requis")]
       public string NumeroFacture { get; }
       public string Client { get; }

       public double MontantDu{ get; }

       public double MontantRegle { get; }
        
       public double MontantRestant { get; }

       public DateTime DateAttendu { get; }

       public DateTime DateEmission { get; }
    }
}