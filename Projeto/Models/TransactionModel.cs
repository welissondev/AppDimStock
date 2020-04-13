using System;
using System.Data;

namespace DimStock.Models
{
    /// <summary>
    /// Representa o modelo de transação no banco de dados
    /// </summary>
    public partial class TransactionModel
    {      
        private bool disposed = false;

        private ConnectionModel dataBase;
        public ConnectionModel DataBase { get => dataBase; set => dataBase = value; }
    }

    public partial class TransactionModel : IDisposable
    {
        public TransactionModel(ConnectionModel connection, bool beginAutomaticTransaction = true)
        {
            dataBase = connection;

            if (beginAutomaticTransaction == true)
                BeginTransaction();
        }

        public void BeginTransaction()
        {
            if (dataBase.Connection.State == ConnectionState.Closed)
                dataBase.Transaction = dataBase.Open().BeginTransaction();
        }

        public void Commit()
        {
            dataBase.Transaction.Commit();
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
