using DimStock.Auxiliary;
using DimStock.Model;
using System;
using System.Collections.Generic;

namespace DimStock.Business
{
    public class BllProduto
    {
        #region Registrar()
        public bool Registrar()
        {
            MdlProduto produto = new MdlProduto(this);

            if (produto.Registrar() == true)
            {
                BllUsuarioHistorico historico = new BllUsuarioHistorico()
                {
                    Login = AxlLogin.Login,
                    Operacao = "Cadastrou",
                    Modulo = "Produto",
                    Data = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                    Hora = DateTime.Now.ToString("HH:mm:ss"),
                    DadosRegistroAfetado = produto.PegarDadosAfetados(Id)
                };

                return historico.Registrar();
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Alterar()
        public bool Alterar(int id)
        {
            MdlProduto produto = new MdlProduto(this);

            if (produto.Alterar(id) == true)
            {
                BllUsuarioHistorico historico = new BllUsuarioHistorico()
                {
                    Login = AxlLogin.Login,
                    Operacao = "Editou",
                    Modulo = "Produto",
                    Data = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                    Hora = DateTime.Now.ToString("HH:mm:ss"),
                    DadosRegistroAfetado = produto.PegarDadosAfetados(id)
                };

                return historico.Registrar();
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Deletar()
        public bool Deletar(int id)
        {
            MdlProduto produto = new MdlProduto(this);

            var dadosRegistroDeletado = produto.PegarDadosAfetados(id);

            if (produto.Deletar(id) == true)
            {
                BllUsuarioHistorico historico = new BllUsuarioHistorico()
                {
                    Login = AxlLogin.Login,
                    Operacao = "Deletou",
                    Modulo = "Produto",
                    Data = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                    Hora = DateTime.Now.ToString("HH:mm:ss"),
                    DadosRegistroAfetado = dadosRegistroDeletado
                };

                return historico.Registrar();
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Listar()
        public void Listar(int numeroDeRegistros = 100)
        {
            MdlProduto produto = new MdlProduto();
            Lista = produto.Listar(numeroDeRegistros);
        }
        #endregion

        #region VisualizarDados()
        public void VisualizarDados(int id)
        {
            MdlProduto produto = new MdlProduto(this);
            produto.VisualizarDados(id);
        }
        #endregion

        #region Consultar()
        public void Consultar(string codigo, string tamanho, string referencia, string descricao, int numeroDeRegistros = 100)
        {
            MdlProduto produto = new MdlProduto();
            Lista = produto.Consultar(codigo, tamanho, referencia, descricao, numeroDeRegistros);
        }
        #endregion

        #region Get e Set
        public int Id { get; set; }
        public string Fornecedor { get; set; }
        public string Descricao { get; set; }
        public string Codigo { get; set; }
        public string Tamanho { get; set; }
        public string Referencia { get; set; }
        public double PrecoCusto { get; set; }
        public double PrecoVenda { get; set; }
        public int EstoqueMin { get; set; }
        public int EstoqueMax { get; set; }
        public string CodigoBarras { get; set; }
        public string FotoNome { get; set; }
        public string PastaDiretorioDasFotos { get => BllProdutoFoto.PegarCaminho(); }
        public List<BllProduto> Lista { get; set; }
        #endregion 
    }
}
