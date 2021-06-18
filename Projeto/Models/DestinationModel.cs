using DimStock.AuxilyTools.AuxilyClasses;
using System;
using System.Data;

namespace DimStock.Models
{
    public class DestinationModel
    {
        public int Id { get; set; }
        public string LocationDescription { get; set; }

        public DestinationModel()
        {
        }

        public bool Insert()
        {
            var actionResult = false;
            var sql = string.Empty;

            if (DestinationValidationModel.ValidateToInsert(this) == false)
                return actionResult;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"INSERT INTO Destination
                (LocationDescription)VALUES(@LocationDescription)";

                dataBase.ClearParameter();
                dataBase.AddParameter("@LocationDescription", LocationDescription);

                if (dataBase.ExecuteNonQuery(sql) > 0)
                {
                    MessageNotifier.Show("Destino cadastrado " +
                    "com sucesso!", "Sucesso", "!");

                    actionResult = true;
                }
            }

            return actionResult;
        }

        public bool Update()
        {
            var actionResult = false;
            var sql = string.Empty;

            if (DestinationValidationModel.ValidateToUpdate(this) == false)
                return actionResult;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"UPDATE Destination SET 
                LocationDescription = @LocationDescription WHERE Id = @Id";

                dataBase.ClearParameter();
                dataBase.AddParameter("@LocationDescription", LocationDescription);
                dataBase.AddParameter("@Id", Id);

                if (dataBase.ExecuteNonQuery(sql) > 0)
                {
                    MessageNotifier.Show("Destino editado " +
                    "com sucesso!", "Sucesso", "!");

                    actionResult = true;
                }
            }

            return actionResult;
        }

        public bool Delete()
        {
            var actionResult = false;
            var sql = string.Empty;

            if (DestinationValidationModel.ValidateToDelete(this) == false)
                return actionResult;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"DELETE FROM Destination WHERE Id = @Id";

                dataBase.ClearParameter();
                dataBase.AddParameter("@Id", Id);

                if (dataBase.ExecuteNonQuery(sql) > 0)
                {
                    MessageNotifier.Show("Destino deletado " +
                    "com sucesso!", "Sucesso", "!");

                    actionResult = true;
                }
            }

            return actionResult;
        }

        public bool GetDetails()
        {
            var sql = string.Empty;
            var actionResult = false;

            if (DestinationValidationModel.ValidateToGetDetails(this) == false)
                return actionResult;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"SELECT * FROM Destination 
                WHERE Id = @Id";

                dataBase.ClearParameter();
                dataBase.AddParameter("@Id", Id);

                using (var reader = dataBase.ExecuteReader(sql))
                {
                    while (reader.Read())
                    {
                        Id = Convert.ToInt32(reader["Id"]);
                        LocationDescription = Convert.ToString(reader["LocationDescription"]);
                        actionResult = true;
                    }
                }
            }

            return actionResult;
        }

        public bool CheckRegisterStatus()
        {
            /*Essa verificação também precisou ser feita pelo 
             nome do local de destino, porque a regra de negócio não 
             permiti dois destinos com o mesmo nome*/

            var registrationStatus = false;
            var sqlSelect = string.Empty;
            var sqlParameter = string.Empty;
            var query = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                sqlSelect = @"SELECT * FROM Destination WHERE Id = @Id ";

                dataBase.ClearParameter();
                dataBase.AddParameter("@Id", Id);

                if (LocationDescription != string.Empty && LocationDescription != null)
                {
                    sqlParameter += @"OR LocationDescription = @LocationDescription";
                    dataBase.AddParameter("@LocationDescription", LocationDescription);
                }

                query += sqlSelect + sqlParameter;

                if (dataBase.ExecuteScalar(query) == 0)
                    return registrationStatus;
            }

            return registrationStatus = true;
        }

        public DataTable SearchData()
        {
            var sql = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"SELECT * From Destination WHERE LocationDescription 
                LIKE @LocationDescription";

                dataBase.ClearParameter();
                dataBase.AddParameter("@LocationDescription", string.Format("%{0}%", LocationDescription));

                return dataBase.ExecuteDataAdapter(sql);
            }
        }
    }
}
