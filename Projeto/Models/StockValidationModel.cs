using DimStock.AuxilyTools.AuxilyClasses;
using System.Data;

namespace DimStock.Models
{
    public class StockValidationModel
    {
        public static bool ValidatePostingItems(DataTable postedItems)
        {
            var isValid = false;

            if (postedItems.Rows.Count == 0)
            {
                MessageNotifier.Set("Nenhum item adicionado para " +
                "essa operação!", "Itens Não Adicionados");

                return isValid;
            }

            return isValid = true;
        }

        public static bool ValidateToUpdateValue(StockModel stock)
        {
            var isValid = false;

            if (stock.Product.Id == 0)
            {
                MessageNotifier.Set("É necessário informar o produto para " +
                "atualizar seu valor no estoque!", "Não Informado");

                return isValid;
            }

            if (stock.Product.CostPrice == 0.00)
            {
                MessageNotifier.Set("Para atualizar o valor no estoque, " +
                "é preciso informar o preço de custo do produto!",
                "Não Informado");

                return isValid;
            }

            return isValid = true;
        }

        public static bool ValidateToGetDetail(StockModel stock)
        {
            var isValid = false;

            if (stock.Id == 0)
            {
                MessageNotifier.Set("Selecione um estoque para " +
                "visualizar!", "Não Selecionado");

                return isValid;
            }

            if (ValidateIfExists(stock) == false)
            {
                MessageNotifier.Set("Não é possivel visualizar porque " +
                "esse registro foi excluido!", "Atualize a Lista");

                return isValid;
            }

            return isValid = true;
        }

        public static bool ValidateIfExists(StockModel stock)
        {
            var sql = string.Empty;
            var actionResult = false;

            using (var dataBase = new ConnectionModel())
            {
                sql = "SELECT Id FROM Stock WHERE Id = @Id";

                dataBase.ClearParameter();
                dataBase.AddParameter("@Id", stock.Id);

                using (var reader = dataBase.ExecuteReader(sql))
                {
                    if (reader.Read() == false)
                    {
                        MessageNotifier.Set("Esse estoque não encontra-se registrado " +
                        "em sua base de dados!", "Não Encontrado");

                        return actionResult;
                    }
                }
            }

            return actionResult = true;
        }
    }
}
