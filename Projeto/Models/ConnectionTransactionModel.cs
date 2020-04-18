using DimStock.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace DimStock.Models
{
    /// <summary>
    /// Representa o modelo que executa transações no banco de dados
    /// </summary>
    public partial class ConnectionTransactionModel : IDisposable
    {
        private bool disposed;
        private OleDbTransaction transaction = null;
        private OleDbConnection connection;
        private OleDbCommand command;
    }

    public partial class ConnectionTransactionModel
    {
        public ConnectionTransactionModel(bool beginAutomaticTransaction = true)
        {
            command = new OleDbCommand();
            connection = new OleDbConnection(AppSettingModel.GetConnectionString());

            if (beginAutomaticTransaction == true)
                Begin();
        }

        public void Begin()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    transaction = connection.BeginTransaction();
                }
            }
            catch (OleDbException)
            {
                throw;
            }
        }

        public void Commit()
        {
            try
            {
                transaction.Commit();
            }
            catch (OleDbException)
            {
                throw;
            }
        }

        public int ExecuteNonQuery(string sql)
        {
            try
            {
                command.CommandText = sql;
                command.Connection = transaction.Connection;
                command.Transaction = transaction;

                return command.ExecuteNonQuery();
            }
            catch (OleDbException)
            {
                transaction.Rollback();
                throw;
            }
        }
        public int ExecuteScalar(string sql)
        {
            try
            {
                command.CommandText = sql;
                command.Connection = transaction.Connection;
                command.Transaction = transaction;

                return int.Parse(command.ExecuteScalar().ToString());
            }
            catch (OleDbException)
            {
                throw;
            }
        }

        public void AddParameter(string name, object value)
        {
            var parameter = new OleDbParameter()
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
