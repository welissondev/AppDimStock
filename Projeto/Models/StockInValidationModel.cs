using DimStock.AuxilyTools.AuxilyClasses;

namespace DimStock.Models
{
    public class StockInValidationModel
    {
        public static bool ValidateToInsert(StockInModel stockEntrie)
        {
            var validationStatus = false;

            if (stockEntrie.Supplier.Id == 0)
            {
                validationStatus = false;
                MessageNotifier.Show("Informe o fornecedor!",
                "Obrigatório", "!");
            }

            if (stockEntrie.Movement.Id == 0)
            {
                validationStatus = false;
                MessageNotifier.Show("Selecione uma movimentação!",
                "Obrigatório", "!");
            }

            return validationStatus;
        }
    }
}
