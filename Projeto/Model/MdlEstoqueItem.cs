using SysEstoque.Business;
using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace SysEstoque.Model
{
    public class MdlEstoqueItem
    {
        #region Propriedades
        private readonly BllEstoqueItem estoqueItem;
        #endregion 

        #region Construtores
        public MdlEstoqueItem() { }

        public MdlEstoqueItem(BllEstoqueItem estoqueItem)
        {
            this.estoqueItem = estoqueItem;
        }
        #endregion

        #region Adicionar()
        public void Adicionar()
        {
            using (MdlAccessConnection connection = new MdlAccessConnection())
            {
                var sql = @"INSERT INTO TBEstoqueItem(IdEstoqueAtividade, IdProduto, IdEstoque, 
                Quantidade, ValorUnitario, ValorTotal)VALUES(@IdEstoqueAtividade, @IdProduto, @IdEstoque, 
                @Quantidade, @ValorUnitario, @ValorTotal)";

                connection.AddParameter("@IdEstoqueMovimento", OleDbType.Integer, estoqueItem.IdEstoqueAtividade);
                connection.AddParameter("@IdProduto", OleDbType.Integer, estoqueItem.IdProduto);
                connection.AddParameter("@IdEstoque", OleDbType.Integer, estoqueItem.IdEstoque);
                connection.AddParameter("@Quantidade", OleDbType.Integer, estoqueItem.Quantidade);
                connection.AddParameter("@ValorUnitario", OleDbType.Double, estoqueItem.ValorUnitario);
                connection.AddParameter("@ValorTotal", OleDbType.Double, estoqueItem.ValorTotal);

                connection.ExecuteNonQuery(sql);
            }
        }
        #endregion

        #region Listar()
        public List<BllEstoqueItem> ListItens(int idEstoqueAtividade)
        {
            using (MdlAccessConnection connection = new MdlAccessConnection())
            {
                var sql = @"SELECT TBEstoqueItem.*, TBProduto.Descricao, TBProduto.Codigo 
                FROM TBEstoqueItem INNER JOIN TBProduto ON TBEstoqueItem.IdProduto = TBProduto.Id WHERE 
                TBEstoqueItem.IdEstoqueAtividade LIKE '" + idEstoqueAtividade + "'";

                List<BllEstoqueItem> listaItens = new List<BllEstoqueItem>();

                using (OleDbDataReader dr = connection.QueryWithDataReader(sql))
                {
                    while (dr.Read())
                    {
                        BllEstoqueItem item = new BllEstoqueItem()
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            IdEstoque = Convert.ToInt32(dr["IdEstoque"]),
                            CodigoProduto = dr["Codigo"].ToString(),
                            DescricaoProduto = dr["Descricao"].ToString(),
                            Quantidade = Convert.ToInt32(dr["Quantidade"]),
                            ValorUnitario = Convert.ToDouble(dr["ValorUnitario"]),
                            ValorTotal = Convert.ToDouble(dr["ValorTotal"])
                        };

                        listaItens.Add(item);
                    }
                }

                return listaItens;
            }
        }
        #endregion

        #region Deletar()
        public void Deletar(int id)
        {
            using (MdlAccessConnection connection = new MdlAccessConnection())
            {
                var sql = @"DELETE FROM TBEstoqueItem Where Id =" + id;

                connection.ExecuteNonQuery(sql);
            }
        }
        #endregion 
    }
}
