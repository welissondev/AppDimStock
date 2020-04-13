using System;
using System.Data;

namespace DimStock.Models
{
    /// <summary>
    /// Representa o modelo de transação no banco de dados
    /// </summary>
    public partial class TransactionModel : IDisposable
    {
        private bool disposed = false;
        private ConnectionModel dataBase;

        public string SqlQuery { get; set; }
        public string SqlScala { get; set; }
    }

    public partial class TransactionModel 
    {
        public TransactionModel(ConnectionModel connection, bool beginAutomaticTransaction = true)
        {
            dataBase = connection;

            if (beginAutomaticTransaction == true)
                Begin();
        }

        public void AddParameter(string name, object value)
        {
            dataBase.AddParameter(name, value);
        }
        public void ClearParameter()
        {
            dataBase.ClearParameter();
        }

        public void Begin()
        {
            if (dataBase.Connection.State == ConnectionState.Closed)
                dataBase.Transaction = dataBase.Open().BeginTransaction();
        }
        public void Commit()
        {
            dataBase.Transaction.Commit();
        }

        public int Execute()
        {
            dataBase.SqlQuery = SqlQuery;
            return dataBase.ExecuteTransaction();
        }
        public int Scalar()
        {
            dataBase.SqlScala = SqlScala;
            return Convert.ToInt32(dataBase.ExecuteScalar());
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                dataBase.Dispose();
            }

            disposed = true;
        }
    }
}
