using DimStock.Properties;
using System;
using System.Data;
using System.Data.OleDb;

namespace DimStock.Models
{
    /// <summary>
    /// Representa o modelo que executa transações no banco de dados
    /// </summary>
    public partial class TransactionModel : IDisposable
    {
        private bool disposed;
        private OleDbTransaction transaction = null;
        private OleDbConnection connection;
        private OleDbCommand command;
    }

    public partial class TransactionModel
    {
        public TransactionModel(bool beginAutomaticTransaction = true)
        {
            command = new OleDbCommand();
            connection = new OleDbConnection(GetConnectionString());

            if (beginAutomaticTransaction == true)
                Begin();
        }

        public void Begin()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                transaction = connection.BeginTransaction();
            }
        }

        public void Commit()
        {
            transaction.Commit();
        }

        public int ExecuteNonQuery(string sql)
        {
            command.CommandText = sql;
            command.Connection = transaction.Connection;
            command.Transaction = transaction;

            return command.ExecuteNonQuery();
        }
        public int ExecuteScalar(string sql)
        {
            command.CommandText = sql;
            command.Connection = transaction.Connection;
            command.Transaction = transaction;

            return int.Parse(command.ExecuteScalar().ToString());
        }

        public void AddParameter(string name, object value)
        {
            var parameter = new OleDbParameter
            {
                ParameterName = name,
                Value = value
            };
            command.Parameters.Add(parameter);
        }
        public void ClearParameter()
        {
            command.Parameters.Clear();
        }

        private string GetConnectionString()
        {
            return @"Provider = Microsoft.jet.oledb.4.0; Data Source =" +
            Settings.Default.MainAppDirectory + @"\dimstockdatabase.mdb;jet oledb:database password=#admin#";
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
                command.Dispose();
                transaction.Dispose();
            }

            disposed = true;
        }
    }
}
