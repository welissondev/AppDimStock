using DimStock.Business;
using System;
using System.Collections.Generic;

namespace DimStock.Report
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

        #region GerarReport()
        public void GerarReport(List<BllStockProduct> listaEstoque)
        {
            Lista = new List<RelEstoque>();

            for (int i = 0; i < listaEstoque.Count; i++)
            {
                RelEstoque relEstoque = new RelEstoque
                {
                    CodigoProduto = Convert.ToInt32(listaEstoque[i].ProductCode),
                    TamanhoProduto = Convert.ToInt32(listaEstoque[i].ProductSize),
                    ReferenciaProduto = Convert.ToInt32(listaEstoque[i].ProductReference),
                    DescricaoProduto = listaEstoque[i].ProductDescription,
                    FornecedorProduto = listaEstoque[i].Supplier,
                    EstoqueMin = listaEstoque[i].MinStock,
                    EstoqueMax = listaEstoque[i].MaxStock,
                    EstoqueQuant = listaEstoque[i].StockQuantity,
                    ValorEmEstoque = listaEstoque[i].StockValue,
                    ResumoEstoque = ObterResumo(listaEstoque[i].StockQuantity, listaEstoque[i].MinStock, listaEstoque[i].MaxStock),
                    ResultadoEstoque = ObterResultado(listaEstoque[i].StockQuantity, listaEstoque[i].MinStock, listaEstoque[i].MaxStock)
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

        #region VerReport()
        public void VerReport()
        {
            //FrmEstoqueReport view = new FrmEstoqueReport();
            //view.RpvEstoque.LocalReport.DataSources.Clear();
            //view.RpvEstoque.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DsRelEstoque", Lista));
            //view.RpvEstoque.RefreshReport();
            //view.Show();
        }
        #endregion
    }
}
