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
                if (ParameterModel.Collection != null)
                    SetParameters(command);

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
                if (ParameterModel.Collection != null)
                    SetParameters(command);

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

        public void SetParameters(OleDbCommand command)
        {
            try
            {
                command.Parameters.Clear();

                for (int i = 0; i < ParameterModel.Collection.Count; i++)
                    command.Parameters.Add(ParameterModel.Collection[i]);
            }
            catch (Exception)
            {
                throw;
            }
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

                if (ParameterModel.Collection != null)
                    ParameterModel.Clear();
            }

            disposed = true;
        }
    }
}
