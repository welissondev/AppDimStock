using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysEstoque.Relatorio
{
    public class RelEstoque
    {
        #region Get e Set
        public int CodigoProduto { get; set; }
        public int TamanhoProduto { get; set; }
        public int ReferenciaProduto{ get; set; }
        public string DescricaoProduto { get; set; }
        public string FornecedorProduto { get; set; }
        public int EstoqueMin { get; set; }
        public int EstoqueMax { get; set; }
        public int EstoqueQuant { get; set; }
        public double ValorEmEstoque { get; set; }
        public string ResumoEstoque { get; set; }
        public string ResultadoEstoque { get; set; }
        public List<RelEstoque> Lista { get; set; }
        #endregion
    }
}
