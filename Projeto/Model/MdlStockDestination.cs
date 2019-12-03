using DimStock.Business;
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
                var commandSQL = @"INSERT INTO TBEstoqueDestino(Nome)VALUES(@Nome)";

                connection.AddParameter("@Nome", OleDbType.VarChar, stockDestination.Location);

                return connection.ExecuteNonQuery(commandSQL) > 0;
            }
        }
        #endregion

        #region Edit()
        public bool Edit(int id)
        {
            using (var connection = new MdlConnection())
            {
                var commandSQL = @"UPDATE TBEstoqueDestino SET Nome = @Nome WHERE Id = " + id;

                connection.AddParameter("@Nome", OleDbType.VarChar, stockDestination.Location);

                return connection.ExecuteNonQuery(commandSQL) > 0;

            }
        }
        #endregion

        #region Delete()
        public bool Delete(int id)
        {
            using (var connection = new MdlConnection())
            {
                var commandSQL = @"DELETE FROM TBEstoqueDestino Where Id =" + id;

                return connection.ExecuteNonQuery(commandSQL) > 0;
            }
        }
        #endregion'

        #region Listar()
        public List<BllStockDestination> ListAll()
        {

            var commandSQL = @"SELECT * From TBEstoqueDestino";

            var stockDestinationList = new List<BllStockDestination>();

            using (var connection = new MdlConnection())
            {
                using (var dr = connection.QueryWithDataReader(commandSQL))
                {
                    while (dr.Read())
                    {
                        var stockDestination = new BllStockDestination()
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            Location = Convert.ToString(dr["Nome"])
                        };

                        stockDestinationList.Add(stockDestination);
                    }
                }
            }

            return stockDestinationList;

        }
        #endregion

        #region ViewData()
        public void ViewData(int id)
        {
            var commandSQL = @"SELECT * FROM TBEstoqueDestino WHERE Id = " + id;

            using (var connection = new MdlConnection())
            {
                using (var dr = connection.QueryWithDataReader(commandSQL))
                {
                    while (dr.Read())
                    {
                        stockDestination.Id = Convert.ToInt32(dr["Id"]);
                        stockDestination.Location = Convert.ToString(dr["Nome"]);
                    }
                }
            }
        }
        #endregion

        #region CheckIfDestinationExists()
        public bool CheckIfDestinationExists()
        {
            var commandSQL = @"SELECT Nome From TBEstoqueDestino WHERE Nome LIKE @Nome";

            var destinationsFound = 0;

            using (var connection = new MdlConnection())
            {
                connection.AddParameter("@Nome", OleDbType.VarChar, stockDestination.Location);

                using (var dr = connection.QueryWithDataReader(commandSQL))
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
