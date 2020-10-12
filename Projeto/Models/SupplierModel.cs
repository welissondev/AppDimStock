using DimStock.AuxilyTools.AuxilyClasses;
using System.Data;

namespace DimStock.Models
{
    /// <summary>
    /// Representa o modelo do fornecedor
    /// </summary>
    public class SupplierModel
    {
        public int Id { get; set; }
        public string TypeOfRegistration { get; set; }
        public string CompyName { get; set; }
        public string FantasyName { get; set; }
        public string IndentyCard_StateRegister { get; set; }
        public string SocialSecurity_NationalRegister { get; set; }
        public AddressModel Address { get; set; }
        public ContactModel Contact { get; set; }

        public SupplierModel()
        {
            Address = new AddressModel();
            Contact = new ContactModel();
        }

        public bool Insert()
        {
            var sql = string.Empty;
            var actionResult = false;

            if (SupplierValidationModel.ValidateToInsert(this) == false)
                return actionResult;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"INSERT INTO Supplier(typeOfRegistration, companyName, fantasyName, indentyCard_stateRegister,
                socialSecurity_nationalRegister, addressDescription, district, city, stateLocation, zipCode, streetNumber, fixePhone, 
                mobilePhone, email)VALUES(@typeOfRegistration, @companyName, @fantasyName, @indentyCard_stateRegister, @socialSecurity_nationalRegister, 
                @addressDescription, @district, @city, @stateLocation, @zipCode, @streetNumber, @fixePhone, @mobilePhone, @email)";

                dataBase.ClearParameter();
                dataBase.AddParameter("@typeOfRegistration", TypeOfRegistration);
                dataBase.AddParameter("@compyName", CompyName);
                dataBase.AddParameter("@fantasyName", FantasyName);
                dataBase.AddParameter("@indentyCard_StateRegister", IndentyCard_StateRegister);
                dataBase.AddParameter("@socialSecurity_NationalRegister", SocialSecurity_NationalRegister);
                dataBase.AddParameter("@addressDescription", Address.Description);
                dataBase.AddParameter("@district", Address.District);
                dataBase.AddParameter("@city", Address.City);
                dataBase.AddParameter("@stateLocation", Address.StateLocation);
                dataBase.AddParameter("@zipCode", Address.ZipCode);
                dataBase.AddParameter("@streetNumber", Address.StreetNumber);
                dataBase.AddParameter("@fixePhone", Contact.FixePhone);
                dataBase.AddParameter("@mobilePhone", Contact.MobilePhone);
                dataBase.AddParameter("@email", Contact.Email);

                if (dataBase.ExecuteNonQuery(sql) > 0)
                {
                    MessageNotifier.Show("Fornecedor cadastrado " +
                    "com sucesso!", "Sucesso", "!");

                    actionResult = true;
                }
            }

            return actionResult;
        }

        public bool Update()
        {
            var sql = string.Empty;
            var actionResult = false;

            if (SupplierValidationModel.ValidateToUpdate(this) == false)
                return actionResult;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"UPDATE Supplier set typeOfRegistration = @typeOfRegistration, compyName = @compyName, fantasyName = @fantasyName,
                indentyCard_StateRegister = @indentyCard_StateRegister, socialSecurity_NationalRegister = @socialSecurity_NationalRegister,
                addressDescription = @addressDescription, district = @district, city = @city, stateLocation = @stateLocation, zipCode = @zipCode,
                streetNumber = @streetNumber, fixePhone = @fixePhone, mobilePhone = @mobilePhone, email = @email WHERE id = @ID";

                dataBase.ClearParameter();
                dataBase.AddParameter("@typeOfRegistration", TypeOfRegistration);
                dataBase.AddParameter("@compyName", CompyName);
                dataBase.AddParameter("@fantasyName", FantasyName);
                dataBase.AddParameter("@indentyCard_StateRegister", IndentyCard_StateRegister);
                dataBase.AddParameter("@socialSecurity_NationalRegister", SocialSecurity_NationalRegister);
                dataBase.AddParameter("@addressDescription", Address.Description);
                dataBase.AddParameter("@district", Address.District);
                dataBase.AddParameter("@city", Address.City);
                dataBase.AddParameter("@stateLocation", Address.StateLocation);
                dataBase.AddParameter("@zipCode", Address.ZipCode);
                dataBase.AddParameter("@streetNumber", Address.StreetNumber);
                dataBase.AddParameter("@fixePhone", Contact.FixePhone);
                dataBase.AddParameter("@mobilePhone", Contact.MobilePhone);
                dataBase.AddParameter("@email", Contact.Email);
                dataBase.AddParameter("ID", Id);

                if (dataBase.ExecuteNonQuery(sql) > 0)
                {
                    MessageNotifier.Show("Fornecedor alterado " +
                    "com sucesso!", "Sucesso", "!");

                    actionResult = true;
                }
            }

            return actionResult;
        }

        public bool Delete()
        {
            var sql = string.Empty;
            var actionResult = false;

            if (SupplierValidationModel.ValidateToDelete(this) == false)
                return actionResult;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"DELET FROM Supplier WHERE id = @ID";

                dataBase.ClearParameter();
                dataBase.AddParameter("@ID", Id);

                if (dataBase.ExecuteNonQuery(sql) > 0)
                {
                    MessageNotifier.Show("Fornecedor excluido " +
                    "com sucesso!", "Sucesso", "!");

                    actionResult = true;
                }
            }

            return actionResult;
        }

        public bool GetDetails()
        {
            var actionResult = false;
            var sql = string.Empty;

            if (SupplierValidationModel.ValidateToGetDetails(this) == false)
                return actionResult;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"SELECT * FROM Supplier WHERE id = @ID";

                dataBase.ClearParameter();
                dataBase.AddParameter("@ID", Id);

                using (var reader = dataBase.ExecuteReader(sql))
                {
                    while (reader.Read())
                    {
                        Id = int.Parse(reader["id"].ToString());
                        TypeOfRegistration = reader["typeOfRegistration"].ToString();
                        CompyName = reader["companyName"].ToString();
                        FantasyName = reader["fantasyName"].ToString();
                        IndentyCard_StateRegister = reader["indentyCard_stateRegister"].ToString();
                        SocialSecurity_NationalRegister = reader["socialSecurity_nationalRegister"].ToString();

                        Address.Description = reader["addressDescription"].ToString();
                        Address.District = reader["district"].ToString();
                        Address.City = reader["city"].ToString();
                        Address.StateLocation = reader["stateLocation"].ToString();
                        Address.ZipCode = reader["zipCode"].ToString();

                        if (reader["streetNumber"].ToString() != "0")
                            Address.StreetNumber = int.Parse(reader["streetNumber"].ToString());

                        Contact.FixePhone = reader["fixePhone"].ToString();
                        Contact.MobilePhone = reader["mobilePhone"].ToString();
                        Contact.Email = reader["email"].ToString();

                        actionResult = true;
                    }
                }
            }

            return actionResult;
        }

        public bool CheckRelationWithStock()
        {
            return new StockModel(this).CheckRelationWithSupplier();
        }

        public bool CheckIfRegister()
        {
            var registrationStatus = false;
            var sql = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"SELECT * FROM Supplier WHERE Id = @Id";

                dataBase.ClearParameter();
                dataBase.AddParameter("@Id", Id);

                if (dataBase.ExecuteScalar(sql) == 0)
                {
                    return registrationStatus;
                }
            }

            return registrationStatus = true;
        }

        public DataTable SearchData()
        {
            var sqlSelect = string.Empty;
            var sqlParameter = string.Empty;
            var sqlOderBy = string.Empty;
            var query = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                sqlSelect = @"SELECT id, typeOfRegistration, companyName, indentyCard_stateRegister, 
                socialSecurity_nationalRegister, email FROM supplier WHERE id > 0 ";

                sqlOderBy = "Order By Id Desc";

                if (TypeOfRegistration != string.Empty)
                {
                    sqlParameter += "AND typeOfRegistration LIKE @typeOfRegistration ";

                    dataBase.AddParameter("@typeOfRegistration", string.
                    Format("%{0}%", TypeOfRegistration));
                }

                if (CompyName != string.Empty)
                {
                    sqlParameter += "AND companyName LIKE @companyName ";

                    dataBase.AddParameter("@companyName", string.
                    Format("%{0}%", CompyName));
                }

                if (IndentyCard_StateRegister != string.Empty)
                {
                    sqlParameter += "AND indentyCard_stateRegister LIKE @indentyCard_stateRegister ";

                    dataBase.AddParameter("@indentyCard_stateRegister", string.
                    Format("%{0}%", IndentyCard_StateRegister));
                }

                if (SocialSecurity_NationalRegister != string.Empty)
                {
                    sqlParameter += "AND socialSecurity_nationalRegister LIKE @socialSecurity_nationalRegister ";

                    dataBase.AddParameter("@socialSecurity_nationalRegister", string.
                    Format("%{0}%", SocialSecurity_NationalRegister));
                }

                if (Contact.Email != string.Empty)
                {
                    sqlParameter += "AND email LIKE @email ";

                    dataBase.AddParameter("@email", string.
                    Format("%{0}%", Contact.Email));
                }

                query = sqlSelect + sqlParameter + sqlOderBy;

                return dataBase.ExecuteDataAdapter(query);
            }
        }

        public int GetLastId()
        {
            var sql = string.Empty;
            int lastId;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"SELECT MAX(Id) FROM Supplier";
                lastId = dataBase.ExecuteScalar(sql);
            }

            return lastId;
        }
    }
}
