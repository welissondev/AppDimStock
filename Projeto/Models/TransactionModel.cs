using System;
using System.Data;

namespace DimStock.Models
{
    public class TransactionModel : IDisposable
    {
        private ConnectionModel dataBase;
        private bool disposed = false;

        public ConnectionModel DataBase { get => dataBase; set => dataBase = value; }

        public TransactionModel(ConnectionModel connection, bool beginAutomaticTransaction = false)
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
