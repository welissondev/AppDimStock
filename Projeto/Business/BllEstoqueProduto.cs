using SysEstoque.Model;
using System;
using System.Collections.Generic;
using SysEstoque.Relatorio;

namespace SysEstoque.Business
{
    public class BllEstoqueProduto
    {
        #region Get e Set
        public int IdEstoque { get; set; }
        public string Fornecedor { get; set; }
        public int QuantidadeEstoque { get; set; }
        public double ValorEstoque { get; set; }
        public int EstoqueMin { get; set; }
        public int EstoqueMax { get; set; }
        public int IdProduto { get; set; }
        public string CodigoProduto { get; set; }
        public string TamanhoProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public string ReferenciaProduto { get; set; }
        public double PrecoCustoProduto { get; set; }
        public string FotoNomeProduto { get; set; }
        public int RecordCount { get; set; }
        public List<BllEstoqueProduto> Lista { get; set; }
        #endregion 

        #region Listar()
        public void Listar(int numeroDeRegistros = 100)
        {
            MdlEstoqueProduto estoqueProduto = new MdlEstoqueProduto();
            Lista = estoqueProduto.Listar(numeroDeRegistros);
        }
        #endregion

        #region Filtrar()
        public void Filtrar(string codigo, string tamanho, string referencia, string descricao, int numeroDeRegistros = 100)
        {
            MdlEstoqueProduto estoqueProduto = new MdlEstoqueProduto();
            Lista = estoqueProduto.Filtrar(codigo, tamanho, referencia, descricao, numeroDeRegistros);
        }
        #endregion

        #region ConsultaPorCriterioDeResumo()
        public void ConsultaPorCriterioDeResumo(string codigo, string tamanho, string referencia, 
        string descricao, string resumo = "")
        {
            var estoqueProduto = new MdlEstoqueProduto();
            Lista = estoqueProduto.ConsultaPorCriterioDeResumo(codigo, tamanho, referencia, 
            descricao, resumo);
        }
        #endregion

        #region ObterResumo()
        public string ObterResumo(int qtdEstoque, int estoqueMin, int estoqueMax)
        {
            if (qtdEstoque > 0 && qtdEstoque >= estoqueMin && qtdEstoque <= estoqueMax)
            {
                return "Ok";
            }

            if (qtdEstoque > estoqueMax)
            {
                return "Alto";
            }

            if (qtdEstoque < estoqueMin)
            {
                return "Baixo";
            }

            return "???";
        }
        #endregion

        #region ObterResultado()
        public string ObterResultado(int estoqueQuantidade, int estoqueMin, int estoqueMax)
        {
            if (estoqueQuantidade < estoqueMin)
            {
                return "+ " + Convert.ToString(estoqueMin - estoqueQuantidade);
            }

            if (estoqueQuantidade > estoqueMax)
            {
                return "- " + Convert.ToString(estoqueQuantidade - estoqueMax);
            }

            if (estoqueQuantidade >= estoqueMin && estoqueQuantidade <= estoqueMax)
            {
                return Convert.ToString(estoqueMax - estoqueQuantidade);
            }

            return "";
        }
        #endregion

        #region Visualizar()
        public void Visualizar(int id)
        {
            MdlEstoqueProduto estoqueProduto = new MdlEstoqueProduto(this);
            estoqueProduto.Visualizar(id);
        }
        #endregion

        #region GerarRelatorio()
        public void GerarRelatorio(string codigo, string tamanho, string referencia, 
        string descricao, string resumo = "")
        {

            ConsultaPorCriterioDeResumo(codigo, tamanho, referencia,
            descricao, resumo);

            var relatorio = new RelEstoque();
            relatorio.GerarRelatorio(Lista);
            relatorio.VerRelatorio();
        }
        #endregion

    }
}
