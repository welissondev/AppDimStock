using DimStock.Business;
using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace DimStock.Model
{
    public class StockDestinationModel
    {
        #region Properties
        private readonly StockDestinationController stockDestination;
        #endregion

        #region Construtores
        public StockDestinationModel() { }

        public StockDestinationModel(StockDestinationController stockDestination)
        {
            this.stockDestination = stockDestination;
        }
        #endregion 

        #region Methods

        public bool Insert()
        {
            using (var connection = new ConnectionModel())
            {
                var sqlCommand = @"INSERT INTO StockDestination(Location)VALUES(@Location)";

                connection.AddParameter("@Location", OleDbType.VarChar, stockDestination.Location);

                return connection.ExecuteNonQuery(sqlCommand) > 0;
            }
        }

        public bool Update(int id)
        {
            using (var connection = new ConnectionModel())
            {
                var sqlCommand = @"UPDATE StockDestination SET Location = @Location WHERE Id = @Id";

                connection.AddParameter("@Location", OleDbType.VarChar, stockDestination.Location);
                connection.AddParameter("@Id", OleDbType.Integer, id);

                return connection.ExecuteNonQuery(sqlCommand) > 0;

            }
        }

        public bool Delete(int id)
        {
            var deleteState = false;

            using (var connection = new ConnectionModel())
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

        public void ListData()
        {
            var destinationList = new List<StockDestinationController>();

            var sqlQuery = @"SELECT * From StockDestination";

            using (var connection = new ConnectionModel())
            {
                using (var reader = connection.QueryWithDataReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        var stockDestination = new StockDestinationController()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Location = Convert.ToString(reader["Location"])
                        };

                        destinationList.Add(stockDestination);
                    }
                }

                stockDestination.ListOfRecords = destinationList;
            }
        }

        public void ViewDetails(int id)
        {
            using (var connection = new ConnectionModel())
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

        public bool CheckIfDestinationExists()
        {
            var destinationsFound = 0;

            using (var connection = new ConnectionModel())
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
