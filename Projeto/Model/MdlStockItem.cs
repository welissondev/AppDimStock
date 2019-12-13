using DimStock.Business;
using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace DimStock.Model
{
    public class MdlStockItem
    {
        #region Properties
        private readonly BllStockItem stockItem;
        #endregion 

        #region Constructs
        public MdlStockItem() { }

        public MdlStockItem(BllStockItem stockItem)
        {
            this.stockItem = stockItem;
        }
        #endregion

        #region Add()
        public void Add()
        {
            using (var connection = new MdlConnection())
            {
                var commandSQL = @"INSERT INTO TBEstoqueItem(IdEstoqueAtividade, IdProduto, IdEstoque, 
                Quantidade, ValorUnitario, ValorTotal)VALUES(@IdEstoqueAtividade, @IdProduto, @IdEstoque, 
                @Quantidade, @ValorUnitario, @ValorTotal)";

                connection.AddParameter("@IdEstoqueMovimento", OleDbType.Integer, stockItem.StockActivityId);
                connection.AddParameter("@IdProduto", OleDbType.Integer, stockItem.ProductId);
                connection.AddParameter("@IdEstoque", OleDbType.Integer, stockItem.StockId);
                connection.AddParameter("@Quantidade", OleDbType.Integer, stockItem.Quantity);
                connection.AddParameter("@ValorUnitario", OleDbType.Double, stockItem.UnitaryValue);
                connection.AddParameter("@ValorTotal", OleDbType.Double, stockItem.TotalValue);

                connection.ExecuteNonQuery(commandSQL);
            }
        }
        #endregion

        #region ListItem()
        public List<BllStockItem> ListItem(int id)
        {
            using (var connection = new MdlConnection())
            {
                var commandSQL = @"SELECT TBEstoqueItem.*, TBProduto.Descricao, TBProduto.Codigo, TBProduto.Tamanho,
                TBProduto.Referencia FROM TBEstoqueItem INNER JOIN TBProduto ON TBEstoqueItem.IdProduto = TBProduto.Id WHERE 
                TBEstoqueItem.IdEstoqueAtividade LIKE '" + id + "'";

                var itemList = new List<BllStockItem>();

                using (var dr = connection.QueryWithDataReader(commandSQL))
                {
                    while (dr.Read())
                    {
                        var item = new BllStockItem()
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            StockId = Convert.ToInt32(dr["IdEstoque"]),
                            ProductCode = dr["Codigo"].ToString(),
                            ProductSize = dr["Tamanho"].ToString(),
                            ProductReference = dr["Referencia"].ToString(),
                            ProductDescription = dr["Descricao"].ToString(),
                            Quantity = Convert.ToInt32(dr["Quantidade"]),
                            UnitaryValue = Convert.ToDouble(dr["ValorUnitario"]),
                            TotalValue = Convert.ToDouble(dr["ValorTotal"])
                        };

                        itemList.Add(item);
                    }
                }

                return itemList;
            }
        }
        #endregion

        #region Delete()
        public void Delete(int id)
        {
            using (var connection = new MdlConnection())
            {
                var commandSQL = @"DELETE FROM TBEstoqueItem Where Id =" + id;

                connection.ExecuteNonQuery(commandSQL);
            }
        }
        #endregion 
    }
}
