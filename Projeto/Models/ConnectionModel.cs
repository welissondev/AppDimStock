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
        private OleDbCommand command;
        private OleDbConnection connection;
    }

    public partial class ConnectionModel : IDisposable
    {
        public ConnectionModel()
        {
            connection = new OleDbConnection(AppSettingModel.GetConnectionString());
            command = new OleDbCommand();
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

        public int ExecuteNonQuery(string sql)
        {
            try
            {
                SetParameters(command);
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
                SetParameters(command);
                command.CommandText = sql;
                command.Connection = Open();
                return Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception)
            {
                throw;
            }
        }

        public OleDbDataReader ExecuteReader(string sql)
        {
            try
            {
                SetParameters(command);
                command.CommandText = sql;
                command.Connection = Open();

                return command.ExecuteReader();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable ExecuteDataAdapter(string sql, int startRegister = 0, int finalRegister = 20)
        {
            var table = new DataTable();

            Open();

            SetParameters(command);
            command.CommandText = sql;
            command.Connection = connection;

            var adapter = new OleDbDataAdapter
            {
                SelectCommand = command
            };

            adapter.Fill(startRegister, finalRegister, table);

            return table;
        }

        public void SetParameters(OleDbCommand command)
        {
            command.Parameters.Clear();

            for (int i = 0; i < ParameterModel.Collection.Count; i++)
                command.Parameters.Add(ParameterModel.Collection[i]);
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
            }

            disposed = true;
        }
    }
}
