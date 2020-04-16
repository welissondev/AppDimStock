using DimStock.AuxilyTools.AuxilyClasses;
using System.Data;

namespace DimStock.Models
{
    public class StockValidationModel
    {
        public static bool ValidatePostingItems(DataTable postingItems)
        {
            var isValid = false;

            if (postingItems.Rows.Count == 0)
            {
                MessageNotifier.Message = "Nenhum item adicionado para essa operação!";
                MessageNotifier.Title = "Itens Não Adicionados";
                return isValid;
            }

            return isValid = true;
        }

        public static bool ValidateToUpdateValue(StockModel stock)
        {
            var isValid = false;

            if (stock.Product.Id == 0)
            {
                MessageNotifier.Message = "É necessário informar o produto para atualizar seu valor no estoque!";
                MessageNotifier.Title = "Não Informado";
                return isValid;
            }

            if (stock.Product.CostPrice == 0.00)
            {
                MessageNotifier.Message = "O preço de custo precisa ser informado!";
                MessageNotifier.Title = "Não Informado";
                return isValid;
            }

            return isValid = true;
        }

        public static bool ValidateToGetDetail(StockModel stock)
        {
            var isValid = false;

            if (stock.Id == 0)
            {
                MessageNotifier.Message = "Selecione um estoque para visualizar!";
                MessageNotifier.Title = "Não Selecionado";

                return isValid;
            }

            if (ValidateIfExists(stock) == false)
            {
                MessageNotifier.Message = "Não é possivel visualizar porque esse registro foi excluido!";
                MessageNotifier.Title = "Atualize a Lista";

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

                ParameterModel.Clear();
                ParameterModel.Add("@Id", stock.Id);

                using (var reader = dataBase.ExecuteReader(sql))
                {
                    if (reader.Read() == false)
                    {
                        MessageNotifier.Message = "Esse estoque não encontra-se registrado em sua base de dados!";
                        MessageNotifier.Title = "Não Encontrada";

                        return actionResult;
                    }
                }
            }

            return actionResult = true;
        }
    }
}
