using DimStock.Properties;
using System;
using System.Data;
using System.Data.OleDb;

namespace DimStock.Models
{
    public class ConnectionModel : IDisposable
    {
        public ConnectionModel()
        {
            Connection = new OleDbConnection(GetConnectionString());
            Command = new OleDbCommand();
            Parameter = new OleDbParameter();
        }

        private bool disposed = false;

        public OleDbConnection Connection { get; set; }
        public OleDbCommand Command { get; set; }
        public OleDbParameter Parameter { get; set; }
        public OleDbTransaction Transaction { get; set; }

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

        public int ExecuteCommand(string sql)
        {
            try
            {
                Command.CommandText = sql;
                Command.Connection = Open();
                return Command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public int ExecuteTransaction(string sql)
        {
            try
            {
                Command.CommandText = sql;
                Command.Connection = Transaction.Connection;
                Command.Transaction = Transaction;
                return Command.ExecuteNonQuery();
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
                Command.CommandText = sql;
                Command.Connection = Open();
                return Convert.ToInt32(Command.ExecuteScalar());
            }
            catch (Exception)
            {
                throw;
            }
        }

        public OleDbDataReader GetReader(string sql)
        {
            try
            {
                Command.CommandText = sql;
                Command.Connection = Open();

                return Command.ExecuteReader();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable GetTable(string sql, int startRegister = 0, int finalRegister = 20)
        {
            var table = new DataTable();

            Open();

            Command.CommandText = sql;
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
