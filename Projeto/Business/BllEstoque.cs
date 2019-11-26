using DimStock.Model;
using System.Collections.Generic;

namespace DimStock.Business
{
    public class BllEstoque
    {
        #region Get  e Set
        public int Id { get; set; }
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }
        #endregion 

        #region AdicionarEntradas()
        public bool AdicionarEntradas(List<BllEstoque> listaEstoque, int idEstoqueAtividade)
        {
            bool transacao = false;

            MdlEstoque estoque = new MdlEstoque();

            if (estoque.AdicionarEntradas(listaEstoque, idEstoqueAtividade) == true)
            {
                transacao = true;
            }

            return transacao;
        }
        #endregion

        #region AdicionarSaidas()
        public bool AdicionarSaidas(List<BllEstoque> listaEstoque, int idEstoqueAtividade)
        {
            bool transacao = false;

            MdlEstoque estoque = new MdlEstoque();

            if (estoque.AdicionarSaidas(listaEstoque, idEstoqueAtividade) == true)
            {
                transacao = true;
            }

            return transacao;
        }
        #endregion

        #region Reset()
        public bool Reset(List<BllEstoqueItem> listaEstoqueItem)
        {
            var transacao = false;

            MdlEstoque estoque = new MdlEstoque();
            if (estoque.Reset(listaEstoqueItem) == true)
            {
                transacao = true;
            }

            return transacao;
        }
        #endregion 

    }
}
