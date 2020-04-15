using DimStock.Properties;
using System;
using System.Data;
using System.Data.OleDb;

namespace DimStock.Models
{
    /// <summary>
    /// Representa o modelo de conexão com o banco de dados
    /// </summary>
    public partial class ConnectionModel
    {
        private bool disposed = false;
        private OleDbParameter parameter;
        private OleDbCommand command;
        private OleDbConnection connection;
        private OleDbTransaction transaction;
    }

    public partial class ConnectionModel : IDisposable
    {
        public ConnectionModel()
        {
            connection = new OleDbConnection(GetConnectionString());
            command = new OleDbCommand();
            parameter = new OleDbParameter();
        }

        public OleDbConnection Open()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                return connection;
            }
            catch (OleDbException)
            {
                throw;
            }
        }

        public int ExecuteCommand(string sql)
        {
            try
            {
                command.CommandText = sql;
                command.Connection = Open();
                return command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public int ExecuteScalar(string sql)
        {
            try
            {
                command.CommandText = sql;
                command.Connection = Open();
                return Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int TransactionExecuteCommand(string sql)
        {
            try
            {
                command.CommandText = sql;
                command.Connection = transaction.Connection;
                command.Transaction = transaction;
                return command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                transaction.Rollback();
                throw;
            }
        }
        public void TransactionExecuteCommit()
        {
            transaction.Commit();
        }
        public void BeginTransaction(OleDbConnection connection)
        {
            transaction = connection.BeginTransaction();
        }

        public OleDbDataReader GetDataReader(string sql)
        {
            try
            {
                command.CommandText = sql;
                command.Connection = Open();

                return command.ExecuteReader();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable GetDataTable(string sql, int startRegister = 0, int finalRegister = 20)
        {
            var table = new DataTable();

            Open();

            command.CommandText = sql;
            command.Connection = connection;

            var adapter = new OleDbDataAdapter
            {
                SelectCommand = command
            };

            adapter.Fill(startRegister, finalRegister, table);

            return table;
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
                if (transaction != null) transaction.Dispose();
            }

            disposed = true;
        }
    }
}
