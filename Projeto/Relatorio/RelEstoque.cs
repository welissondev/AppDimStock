using SysEstoque.Business;
using System;
using System.Collections.Generic;

namespace SysEstoque.Relatorio
{
    public class RelEstoque
    {
        #region Get e Set
        public int CodigoProduto { get; set; }
        public int TamanhoProduto { get; set; }
        public int ReferenciaProduto { get; set; }
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

        #region GerarRelatorio()
        public void GerarRelatorio(List<BllEstoqueProduto> listaEstoque)
        {
            Lista = new List<RelEstoque>();

            for (int i = 0; i < listaEstoque.Count; i++)
            {
                RelEstoque relEstoque = new RelEstoque
                {
                    CodigoProduto = Convert.ToInt32(listaEstoque[i].CodigoProduto),
                    TamanhoProduto = Convert.ToInt32(listaEstoque[i].TamanhoProduto),
                    ReferenciaProduto = Convert.ToInt32(listaEstoque[i].ReferenciaProduto),
                    DescricaoProduto = listaEstoque[i].DescricaoProduto,
                    FornecedorProduto = listaEstoque[i].Fornecedor,
                    EstoqueMin = listaEstoque[i].EstoqueMin,
                    EstoqueMax = listaEstoque[i].EstoqueMax,
                    EstoqueQuant = listaEstoque[i].QuantidadeEstoque,
                    ValorEmEstoque = listaEstoque[i].ValorEstoque,
                    ResumoEstoque = ObterResumo(listaEstoque[i].QuantidadeEstoque, listaEstoque[i].EstoqueMin, listaEstoque[i].EstoqueMax),
                    ResultadoEstoque = ObterResultado(listaEstoque[i].QuantidadeEstoque, listaEstoque[i].EstoqueMin, listaEstoque[i].EstoqueMax)
                };

                Lista.Add(relEstoque);
            }
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

        #region VerRelatorio()
        public void VerRelatorio()
        {
            FrmEstoqueRelatorio view = new FrmEstoqueRelatorio();
            view.RpvEstoque.LocalReport.DataSources.Clear();
            view.RpvEstoque.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DsRelEstoque", Lista));
            view.RpvEstoque.RefreshReport();
            view.Show();
        }
        #endregion
    }
}
