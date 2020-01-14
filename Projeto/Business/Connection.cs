using System;
using System.Data;
using System.Data.OleDb;

namespace DimStock.Business
{
    public class Connection : IDisposable
    {
        #region Properties 

        private readonly OleDbConnection connection = new OleDbConnection(@"Provider = Microsoft.jet.oledb.4.0; Data Source =" + AppDomain.CurrentDomain.BaseDirectory.ToString() + @"Padrao\dbestoque.mdb;jet oledb:database password=#admin#");
        public OleDbCommand Command = new OleDbCommand();
        public OleDbParameter Parameter = new OleDbParameter();
        public OleDbTransaction Transaction;
        private bool disposed = false;

        #endregion

        #region Methods

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
            Command.Connection = connection;

            var adapter = new OleDbDataAdapter
            {
                SelectCommand = Command
            };

            adapter.Fill(startReg, maxReg, dt);

            return dt;
        }

        public OleDbDataReader ExecuteParameterQuery(string sql)
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
                Command.Dispose();
            }

            disposed = true;
        }

        #endregion
    }
}
