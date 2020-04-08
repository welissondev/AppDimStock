using DimStock.AuxilyTools.AuxilyClasses;
using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace DimStock.Models
{
    public class StockDestinationModel
    {
        #region Builder
        
        public StockDestinationModel()
        {
            List = new List<StockDestinationModel>();
        }

        #endregion

        #region Get e Set

        public int Id { get; set; }
        public string Location { get; set; }
        public List<StockDestinationModel> List { get; set; }

        #endregion

        #region Function

        public bool Save()
        {
            var transaction = false;

            using (var connection = new ConnectionModel())
            {
                if (CheckIfExists() == true)
                {
                    MessageNotifier.Message = "Esse destino já existe, cadastre outro!";
                    return transaction;
                }

                var sqlCommand = @"INSERT INTO StockDestination
                (Location)VALUES(@Location)";

                connection.AddParameter("@Location", Location);

                if (connection.ExecuteCommand(sqlCommand) > 0)
                {
                    transaction = true;
                    MessageNotifier.Message = "Cadastrado com sucesso!";
                }
            }

            return transaction;
        }

        public bool Edit(int id)
        {
            var transaction = false;

            using (var connection = new ConnectionModel())
            {
                var sqlCommand = @"UPDATE StockDestination SET 
                Location = @Location WHERE Id = @Id";

                connection.AddParameter("@Location", Location);
                connection.AddParameter("@Id", id);

                if (connection.ExecuteCommand(sqlCommand) > 0)
                {
                    MessageNotifier.Message = "Editado com sucesso!";
                    transaction = true;
                }
            }

            return transaction;
        }

        public bool Remove(int id)
        {
            bool transaction = false;

            using (var connection = new ConnectionModel())
            {
                var sqlCommand = @"DELETE FROM StockDestination 
                WHERE Id = @Id";

                connection.AddParameter("@Id", id);

                if (connection.ExecuteCommand(sqlCommand) > 0)
                {
                    MessageNotifier.Message = "Deletado com sucesso!";
                    transaction = true;
                }
                else
                {
                    MessageNotifier.Message = "Esse registro já foi " +
                    "deletado, atualize a lista de dados!";
                }
            }

            return transaction;
        }

        public void ListData()
        {
            var sqlQuery = @"SELECT * From StockDestination";

            using (var connection = new ConnectionModel())
            {
                using (var reader = connection.GetReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        var destination = new StockDestinationModel()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Location = Convert.ToString(reader["Location"])
                        };

                        List.Add(destination);
                    }
                }
            }
        }

        public void GetDetail(int id)
        {
            using (var connection = new ConnectionModel())
            {
                var sqlQuery = @"SELECT * FROM StockDestination 
                WHERE Id = @Id";

                connection.AddParameter("@Id", id);

                using (var reader = connection.GetReader(sqlQuery))
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

            using (var connection = new ConnectionModel())
            {
                var sqlQuery = @"SELECT Location From StockDestination 
                WHERE Location LIKE @Location";

                connection.AddParameter("@Location", Location);

                using (var reader = connection.GetReader(sqlQuery))
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
