using DimStock.Auxiliarys;

namespace DimStock.Models
{
    public class ProductValidationModel
    {
        public static bool ValidateToInsert(ProductModel product)
        {
            bool isValid = false;

            if (product.Description == string.Empty || product.Description == null)
            {
                MessageNotifier.Message = "Informe a descrição do produto!";
                MessageNotifier.Title = "Não Informado";

                return isValid;
            }

            if (product.Category.Id == 0 || product.Category.Description == string.Empty)
            {
                MessageNotifier.Message = "Selecione a categoria do produto!";
                MessageNotifier.Title = "Não Selecionada";

                return isValid;
            }

            if (product.CostPrice == 0.00)
            {
                MessageNotifier.Message = "Informe o preço de custo do prouto!";
                MessageNotifier.Title = "Não Informado";

                return isValid;
            }

            return isValid = true;
        }

        public static bool ValidateToUpdate(ProductModel product)
        {
            bool isValid = false;

            if (product.Description == string.Empty || product.Description == null)
            {
                MessageNotifier.Message = "Informe a descrição do produto!";
                MessageNotifier.Title = "Não Informado";

                return isValid;
            }

            if (product.Category.Id == 0 || product.Category.Description == string.Empty)
            {
                MessageNotifier.Message = "Selecione a categoria do produto!";
                MessageNotifier.Title = "Não Selecionada";

                return isValid;
            }

            if (product.CostPrice == 0.00)
            {
                MessageNotifier.Message = "Informe o preço de custo do prouto!";
                MessageNotifier.Title = "Não Informado";

                return isValid;
            }

            return isValid = true;
        }

        public static bool ValidateToDelete(ProductModel product)
        {
            bool isValid = false;

            if (product.Id == 0)
            {
                MessageNotifier.Message = "Selecione o produto para excluir!";
                MessageNotifier.Title = "Não Selecionado";

                return isValid;
            }

            if (ValidateIfExists(product) == false)
            {
                MessageNotifier.Message = "Esse produto ja foi excluido, atualize sua lista de produtos!";
                MessageNotifier.Title = "Atualize a Lista";

                return isValid;
            }

            return isValid = true;
        }

        public static bool ValidateIfExists(ProductModel product)
        {
            using (var db = new AccessConnection())
            {
                var sql = "SELECT * FROM Product WHERE Id = @Id";
                var found = false;

                db.ClearParameter();
                db.AddParameter("@Id", product.Id);

                using (var reader = db.GetReader(sql))
                {
                    while (reader.Read())
                    {
                        found = true;
                    }
                }

                if (found == false)
                {
                    MessageNotifier.Message = "Esse produto não encontra-se registrado em sua base de dados!";
                    MessageNotifier.Title = "Não Encontrado";
                }

                return found;
            }
        }
    }
}
