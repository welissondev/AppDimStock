using System;

namespace DimStock.Models
{
    public class TransactionModel : IDisposable
    {
        private ConnectionModel connection;
        private bool disposed = false;

        public ConnectionModel DataBase { get => connection; set => connection = value; }

        public TransactionModel(ConnectionModel connection)
        {
            this.connection = connection;
        }

        public void BeginTransaction()
        {
            connection.Transaction = connection.Open().BeginTransaction();
        }

        public void Commit()
        {
            connection.Transaction.Commit();
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
                connection.Dispose();
            }

            disposed = true;
        }
    }
}
