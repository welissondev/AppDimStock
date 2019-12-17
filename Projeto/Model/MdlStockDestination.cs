﻿using DimStock.Business;
using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace DimStock.Model
{
    public class MdlStockDestination
    {
        #region Properties
        private readonly BllStockDestination stockDestination;
        #endregion

        #region Construtores()
        public MdlStockDestination() { }

        public MdlStockDestination(BllStockDestination stockDestination)
        {
            this.stockDestination = stockDestination;
        }
        #endregion 

        #region Register()
        public bool Register()
        {
            using (var connection = new MdlConnection())
            {
                var sqlCommand = @"INSERT INTO StockDestination(Location)VALUES(@Location)";

                connection.AddParameter("@Location", OleDbType.VarChar, stockDestination.Location);

                return connection.ExecuteNonQuery(sqlCommand) > 0;
            }
        }
        #endregion

        #region Edit()
        public bool Edit(int id)
        {
            using (var connection = new MdlConnection())
            {
                var sqlCommand = @"UPDATE StockDestination SET Location = @Location WHERE Id = @Id";

                connection.AddParameter("@Location", OleDbType.VarChar, stockDestination.Location);
                connection.AddParameter("@Id", OleDbType.Integer, id);

                return connection.ExecuteNonQuery(sqlCommand) > 0;

            }
        }
        #endregion

        #region Delete()
        public bool Delete(int id)
        {
            var deleteState = false;

            using (var connection = new MdlConnection())
            {
                var sqlCommand = @"DELETE FROM StockDestination Where Id = @Id";

                connection.AddParameter("@Id", OleDbType.Integer, id);

                if (connection.ExecuteNonQuery(sqlCommand) > 0)
                {
                    deleteState = true;
                }
            }

            return deleteState;
        }
        #endregion'

        #region ListAll()
        public List<BllStockDestination> ListAll()
        {
            var destinationList = new List<BllStockDestination>();

            var sqlQuery = @"SELECT * From StockDestination";

            using (var connection = new MdlConnection())
            {
                using (var reader = connection.QueryWithDataReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        var stockDestination = new BllStockDestination()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Location = Convert.ToString(reader["Location"])
                        };

                        destinationList.Add(stockDestination);
                    }
                }
            }

            return destinationList;
        }
        #endregion

        #region ViewData()
        public void ViewData(int id)
        {
            using (var connection = new MdlConnection())
            {
                var sqlQuery = @"SELECT * FROM StockDestination WHERE Id = @Id";

                connection.AddParameter("@Id", OleDbType.Integer, id);

                using (var reader = connection.QueryWithDataReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        stockDestination.Id = Convert.ToInt32(reader["Id"]);
                        stockDestination.Location = Convert.ToString(reader["Location"]);
                    }
                }
            }
        }
        #endregion

        #region CheckIfDestinationExists()
        public bool CheckIfDestinationExists()
        {
            var destinationsFound = 0;

            using (var connection = new MdlConnection())
            {
                var sqlQuery = @"SELECT Location From StockDestination WHERE 
                Location LIKE @Location";

                connection.AddParameter("@Location", OleDbType.VarChar, 
                stockDestination.Location);

                using (var dr = connection.QueryWithDataReader(sqlQuery))
                {
                    while (dr.Read())
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
