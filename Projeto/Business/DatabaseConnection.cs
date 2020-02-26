
using DimStock.Properties;
using System;
using System.Data;
using System.Data.OleDb;

namespace DimStock.Business
{
    public class DatabaseConnection : IDisposable
    {
        #region Builder

        public DatabaseConnection()
        {
            Connection = new OleDbConnection(GetConnectionString());
            Command = new OleDbCommand();
            Parameter = new OleDbParameter();
        }

        #endregion

        #region Properties

        private bool disposed = false;

        #endregion

        #region Get & Set 

        public OleDbConnection Connection { get; set; }
        public OleDbCommand Command { get; set; }
        public OleDbParameter Parameter { get; set; }
        public OleDbTransaction Transaction { get; set; }

        #endregion

        #region Function

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

        public void AddParameter(string name, OleDbType type, object value)
        {
            var parameter = new OleDbParameter
            {
                ParameterName = name,
                OleDbType = type,
                Value = value
            };
            Command.Parameters.Add(parameter);
        }

        public void ParameterClear()
        {
            Command.Parameters.Clear();
        }

        public int ExecuteNonQuery(string sql)
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

        public string ExecuteScalar(string sql)
        {
            try
            {
                Command.CommandText = sql;
                Command.Connection = Open();
                return Command.ExecuteScalar().ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public OleDbDataReader QueryWithDataReader(string sql)
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

        public DataTable QueryWithDataTable(string sql, int startReg = 0, int maxReg = 20)
        {
            var dt = new DataTable();

            Open();

            Command.CommandText = sql;
            Command.Connection = Connection;

            var adapter = new OleDbDataAdapter
            {
                SelectCommand = Command
            };

            adapter.Fill(startReg, maxReg, dt);

            return dt;
        }

        private string GetConnectionString()
        {
            return @"Provider = Microsoft.jet.oledb.4.0; Data Source =" +
            Settings.Default.MainAppDirectory + @"\dimstock-database.mdb;jet oledb:database password=#admin#";
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

        #endregion
    }
}
