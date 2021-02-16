using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BlazorApp1.Shared
{
    public interface IBusinessData
    {
        IEnumerable<Facture> Factures { get; }

        double TotalPayé { get; }

        double TotalManquant { get; }
    }
}
