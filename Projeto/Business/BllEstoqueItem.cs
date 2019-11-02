using SysEstoque.Model;
using System.Collections.Generic;

namespace SysEstoque.Business
{

    public class BllEstoqueItem
    {
        #region Get e Set
        public int Id { get; set; }
        public int IdEstoque { get; set; }
        public int IdProduto { get; set; }
        public int IdEstoqueAtividade { get; set; }
        public string CodigoProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public int Quantidade { get; set; }
        public double ValorUnitario { get; set; }
        public double ValorTotal { get; set; }
        public double SubTotal { get; set; }
        public List<BllEstoqueItem> Lista { get; set; }
        #endregion

        #region Adicionar()
        public void Adicionar()
        {
            MdlEstoqueItem estoqueMovimentoItem = new MdlEstoqueItem(this);
            estoqueMovimentoItem.Adicionar();
        }
        #endregion

        #region Listar()
        public void Listar(int idAtividade)
        {
            MdlEstoqueItem estoqueItem = new MdlEstoqueItem(this);
            Lista = estoqueItem.ListItens(idAtividade);
        }
        #endregion

        #region Deletar()
        public void Deletar(int id)
        {
            MdlEstoqueItem estoqueItem = new MdlEstoqueItem();
            estoqueItem.Deletar(id);
        }
        #endregion
    }
}
