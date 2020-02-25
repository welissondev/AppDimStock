﻿using DimStock.Auxiliarys;
using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace DimStock.Business
{
    public class StockDestination
    {
        #region Get e Set

        public int Id { get; set; }
        public string Location { get; set; }
        public List<StockDestination> List { get; set; }

        #endregion

        #region Function

        public bool Save()
        {
            var transaction = false;

            using (var connection = new DatabaseConnection())
            {
                if (CheckIfExists() == true)
                {
                    AxlMessageNotifier.Message = "Esse destino já existe, cadastre outro!";
                    return transaction;
                }

                var sqlCommand = @"INSERT INTO StockDestination
                (Location)VALUES(@Location)";

                connection.AddParameter("@Location",
                OleDbType.VarChar, Location);

                if (connection.ExecuteNonQuery(sqlCommand) > 0)
                {
                    transaction = true;
                    AxlMessageNotifier.Message = "Cadastrado com sucesso!";
                }
            }

            return transaction;
        }

        public bool Edit(int id)
        {
            var transaction = false;

            using (var connection = new DatabaseConnection())
            {
                var sqlCommand = @"UPDATE StockDestination SET 
                Location = @Location WHERE Id = @Id";

                connection.AddParameter("@Location", OleDbType.VarChar, Location);
                connection.AddParameter("@Id", OleDbType.Integer, id);

                if (connection.ExecuteNonQuery(sqlCommand) > 0)
                {
                    AxlMessageNotifier.Message = "Editado com sucesso!";
                    transaction = true;
                }
            }

            return transaction;
        }

        public bool Remove(int id)
        {
            bool transaction = false;

            using (var connection = new DatabaseConnection())
            {
                var sqlCommand = @"DELETE FROM StockDestination 
                WHERE Id = @Id";

                connection.AddParameter("@Id", OleDbType.Integer, id);

                if (connection.ExecuteNonQuery(sqlCommand) > 0)
                {
                    AxlMessageNotifier.Message = "Deletado com sucesso!";
                    transaction = true;
                }
                else
                {
                    AxlMessageNotifier.Message = "Esse registro já foi " +
                    "deletado, atualize a lista de dados!";
                }
            }

            return transaction;
        }

        public void ListData()
        {
            var destinationList = new List<StockDestination>();

            var sqlQuery = @"SELECT * From StockDestination";

            using (var connection = new DatabaseConnection())
            {
                using (var reader = connection.QueryWithDataReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        var stockDestination = new StockDestination()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Location = Convert.ToString(reader["Location"])
                        };

                        destinationList.Add(stockDestination);
                    }
                }

                List = destinationList;
            }
        }

        public void GetDetail(int id)
        {
            using (var connection = new DatabaseConnection())
            {
                var sqlQuery = @"SELECT * FROM StockDestination 
                WHERE Id = @Id";

                connection.AddParameter("@Id", OleDbType.Integer, id);

                using (var reader = connection.QueryWithDataReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        Id = Convert.ToInt32(reader["Id"]);
                        Location = Convert.ToString(reader["Location"]);
                    }
                }
            }
        }

        public bool CheckIfExists()
        {
            var destinationsFound = 0;

            using (var connection = new DatabaseConnection())
            {
                var sqlQuery = @"SELECT Location From StockDestination 
                WHERE Location LIKE @Location";

                connection.AddParameter("@Location",
                OleDbType.VarChar, Location);

                using (var reader = connection.QueryWithDataReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        destinationsFound += 1;
                    }
                }
            }

            return destinationsFound > 0;
        }

        #endregion
    }
}
