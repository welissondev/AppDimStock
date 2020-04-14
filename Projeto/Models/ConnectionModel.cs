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

        public OleDbConnection Connection { get; set; }
        private OleDbCommand Command { get; set; }
        public OleDbParameter Parameter { get; set; }
        public OleDbTransaction Transaction { get; set; }
        public string SqlQuery { get; set; }
        public string SqlScala { get; set; }
    }

    public partial class ConnectionModel : IDisposable
    {
        public ConnectionModel()
        {
            Connection = new OleDbConnection(GetConnectionString());
            Command = new OleDbCommand();
            Parameter = new OleDbParameter();
        }

        public OleDbConnection Open()
        {
            try
            {
                if (Connection.State == ConnectionState.Closed)
                {
                    Connection.Open();
                }

                return Connection;
            }
            catch (OleDbException)
            {
                throw;
            }
        }

        public void AddParameter(string name, object value)
        {
            var parameter = new OleDbParameter
            {
                ParameterName = name,
                Value = value
            };
            Command.Parameters.Add(parameter);
        }
        public void ClearParameter()
        {
            Command.Parameters.Clear();
        }

        public int ExecuteNonQuery()
        {
            try
            {
                Command.CommandText = SqlQuery;
                Command.Connection = Open();
                return Command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public int ExecuteTransaction()
        {
            try
            {
                Command.CommandText = SqlQuery;
                Command.Connection = Transaction.Connection;
                Command.Transaction = Transaction;
                return Command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                Transaction.Rollback();
                throw;
            }
        }
        public int ExecuteScalar()
        {
            try
            {
                Command.CommandText = SqlScala;
                Command.Connection = Open();
                return Convert.ToInt32(Command.ExecuteScalar());
            }
            catch (Exception)
            {
                throw;
            }
        }

        public OleDbDataReader GetReader()
        {
            try
            {
                Command.CommandText = SqlQuery;
                Command.Connection = Open();

                return Command.ExecuteReader();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable GetTable(int startRegister = 0, int finalRegister = 20)
        {
            var table = new DataTable();

            Open();

            Command.CommandText = SqlQuery;
            Command.Connection = Connection;

            var adapter = new OleDbDataAdapter
            {
                SelectCommand = Command
            };

            adapter.Fill(startRegister, finalRegister, table);

            return table;
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
                Connection.Dispose();
                Command.Dispose();
            }

            disposed = true;
        }
    }
}
