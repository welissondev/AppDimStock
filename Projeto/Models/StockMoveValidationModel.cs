using DimStock.AuxilyTools.AuxilyClasses;

namespace DimStock.Models
{
    public class StockMoveValidationModel
    {
        public static bool ValidateToStart(StockMoveModel stockMove)
        {
            var validationStatus = false;

            if (stockMove.MoveType.Description == string.Empty)
            {
                MessageNotifier.Show("Para iniciar uma operação " +
                "de movimentação é obrigatório informar seu tipo!",
                "Obrigatório", "?");

                return validationStatus;
            }

            return validationStatus = true;
        }
        public static bool ValidateToGetDetails(StockMoveModel stockMove)
        {
            var validationStatus = false;

            if (stockMove.Id == 0)
            {
                MessageNotifier.Show("Selecione a movimentação " +
                "para visualizar!", "Não Selecionada", "?");

                return validationStatus;
            }

            if (stockMove.CheckRegisterStatus() == false)
            {
                MessageNotifier.Show("Não é possivel visualizar " +
                "porque esse registro foi excluido!",
                "Atualize a Lista", "?");

                return validationStatus;
            }

            return validationStatus = true;
        }
        public static bool ValidateToDelete(StockMoveModel stockMove)
        {
            var validationStatus = false;

            if (stockMove.Id == 0)
            {
                MessageNotifier.Show("Selecione a movimentação " +
                "para excluir!", "Não Selecionada", "?");

                return validationStatus;
            }

            if (stockMove.MoveType.Description == string.Empty)
            {
                MessageNotifier.Show("Para deletar uma operação " +
                "de movimentação é obrigatório informar seu tipo!",
                "Obrigatório", "?");

                return validationStatus;
            }

            switch (stockMove.MoveType.Description)
            {
                case "Entrada":

                    if (new StockInModel(stockMove).CheckRelationWithStockMove() == true &&
                    stockMove.Situation == "Finalizada")
                    {
                        MessageNotifier.Show("Não foi possível deletar essa entrada pois ela " +
                        "ja foi finalizada, cancele a operação e tente excluir novamente!",
                        "Não Permitido", "?");

                        return validationStatus;
                    }

                    break;

                case "Saída":

                    if (new StockOutModel(stockMove).CheckRelationWithStockMove() == true &&
                    stockMove.Situation == "Finalizada")
                    {
                        MessageNotifier.Show("Não foi possível deletar essa saída pois ela " +
                        "ja foi finalizada, cancele a operação e tente excluir novamente!",
                        "Não Permitido", "?");

                        return validationStatus;
                    }

                    break;
            }

            if (stockMove.CheckRegisterStatus() == false)
            {
                MessageNotifier.Show("Não é possivel deletar " +
                "porque esse registro já foi excluido!",
                "Atualize a Lista", "?");

                return validationStatus;
            }

            if (MessageNotifier.Reply("Confirma mesmo a exclusão dessa " +
            "movimentação?", "IMPORTANTE") == false) return validationStatus;

            return validationStatus = true;
        }
    }
}
