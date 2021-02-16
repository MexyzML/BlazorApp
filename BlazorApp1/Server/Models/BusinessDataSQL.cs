using BlazorApp1.Shared;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace BlazorApp1.Server.Models
{
    public class BusinessDataSQL : IBusinessData, IDisposable
    {
        private SqlConnection cnct;
        public BusinessDataSQL(string connectionString)
        {
            cnct = new SqlConnection(connectionString);
         

        }
        public void Dispose()
        {
            cnct.Dispose();
        }
        public IEnumerable<Facture> Factures => cnct.Query<Facture>("SELECT * FROM Factures ORDER BY ID ");

        public double TotalPayé => throw new NotImplementedException();

        public double TotalManquant => throw new NotImplementedException();

    }
}
