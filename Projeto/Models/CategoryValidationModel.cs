﻿using DimStock.AuxilyTools;

namespace DimStock.Models
{
    public class CategoryValidationModel
    {
        public static bool ValidateToInsert(CategoryModel category)
        {
            var isValid = false;

            if (category.Description == "" || category.Description == null)
            {
                MessageNotifier.Message = "Descrição da categoria não informada!";
                MessageNotifier.Title = "Obrigatório";

                return isValid;
            }

            if (ValidateIfExists(category) == true)
            {
                MessageNotifier.Message = "Já existe uma categoria registrada com esse nome!";
                MessageNotifier.Title = "Já Existe";

                return isValid;
            }

            return isValid = true;
        }

        public static bool ValidateToUpdate(CategoryModel category)
        {
            var isValid = false;

            if (category.Id == 0)
            {
                MessageNotifier.Message = "Selecione uma categoria para atualizar!";
                MessageNotifier.Title = "Não Selecionada";

                return isValid;
            }

            if (category.Description == "" || category.Description == null)
            {
                MessageNotifier.Message = "Descrição da categoria não informada!";
                MessageNotifier.Title = "Obrigatório";

                return isValid;
            }

            if (ValidateIfExists(category) == false)
            {
                MessageNotifier.Message = "Não foi possivel atualizar porque esse registro foi excluido!";
                MessageNotifier.Title = "Atualize a Lista";

                return isValid;
            }

            return isValid = true;
        }

        public static bool ValidateToDelete(CategoryModel category)
        {
            var isValid = false;

            if (category.Id == 0)
            {
                MessageNotifier.Message = "Selecione uma categoria para deletar!";
                MessageNotifier.Title = "Não Selecionada";
                return isValid;
            }

            if (ValidateIfExists(category) == false)
            {
                MessageNotifier.Message = "Essa categoria já foi excluida, atualize a lista de registros!";
                MessageNotifier.Title = "Atualize a Lista";

                return isValid;
            }

            return isValid = true;
        }

        public static bool ValidateToGetDetail(CategoryModel category)
        {
            bool isValid = false;

            if (category.Id == 0)
            {
                MessageNotifier.Message = "Selecione uma categoria para visualizar!";
                MessageNotifier.Title = "Não Selecionada";

                return isValid;
            }

            if (ValidateIfExists(category) == false)
            {
                MessageNotifier.Message = "Não é possivel visualizar porque esse registro foi excluido!";
                MessageNotifier.Title = "Atualize a Lista";

                return isValid;
            }

            return isValid = true;
        }

        public static bool ValidateIfExists(CategoryModel category)
        {
            var sql = string.Empty;
            var actionResult = false;

            using (var db = new ConnectionModel())
            {
                sql = @"SELECT Id, Description FROM Category WHERE Id = @Id ";

                db.ClearParameter();
                db.AddParameter("@Id", category.Id);

                //Concatena sql se usuário buscar a
                //categoria pela descrição.
                if (category.Description != string.Empty && 
                    category.Description != null)
                {
                    sql += "OR Description = @Description";
                    db.AddParameter("@Description", category.Description);
                }

                using (var reader = db.GetReader(sql))
                {
                    if (reader.Read() == false)
                    {
                        MessageNotifier.Message = "Essa categoria não encontra-se registrada em sua base de dados!";
                        MessageNotifier.Title = "Não Encontrada";

                        return actionResult;
                    }
                }
            }

            return actionResult = true;
        }
    }
}
