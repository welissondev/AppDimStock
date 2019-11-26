using DimStock.Auxiliary;
using DimStock.Model;
using System;
using System.Collections.Generic;


namespace DimStock.Business
{
    public class BllEstoqueAtividade
    {
        #region Get e Set
        public int Id { get; set; }
        public string Tipo { get; set; }
        public DateTime Data { get; set; }
        public string Hora { get; set; }
        public string Situacao { get; set; }
        public string Destino { get; set; }
        public List<BllEstoqueAtividade> Lista { get; set; }
        #endregion

        #region Adicionar()
        public bool Adicionar()
        {
            bool adicionar = false;

            MdlEstoqueAtividade atividade = new MdlEstoqueAtividade(this);

            if (atividade.Adicionar() == true)
            {
                BllUsuarioHistorico historico = new BllUsuarioHistorico
                {
                    Login = AxlLogin.Login,
                    Operacao = "Adicionou",
                    Modulo = "Atividade",
                    Data = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                    Hora = DateTime.Now.ToString("HH:mm:ss"),
                    DadosRegistroAfetado = atividade.PegarDadosAfetados(Id)
                };

                if (historico.Registrar() == true)
                {
                    adicionar = true;
                }
            }

            return adicionar;
        }
        #endregion

        #region AdicionarDestino
        public bool AdicionarDestino(int id)
        {
            var atividade = new MdlEstoqueAtividade(this);
            return atividade.AdicionarDestino(id);
        }
        #endregion

        #region Deletar()
        public bool Deletar(int id)
        {
            var transacao = false;

            MdlEstoqueAtividade atividade = new MdlEstoqueAtividade();
            var dadosRegistroAfetado = atividade.PegarDadosAfetados(id);

            BllEstoqueItem estoqueItem = new BllEstoqueItem();
            estoqueItem.Listar(id);

            BllEstoque estoque = new BllEstoque();
            if (estoque.Reset(estoqueItem.Lista) == true)
            {
                if (atividade.Deletar(id) == true)
                {
                    BllUsuarioHistorico historico = new BllUsuarioHistorico()
                    {
                        Login = AxlLogin.Login,
                        Operacao = "Deletou",
                        Modulo = "Atividade",
                        Data = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                        Hora = DateTime.Now.ToString("HH:mm:ss"),
                        DadosRegistroAfetado = dadosRegistroAfetado
                    };

                    if (historico.Registrar() == true)
                    {
                        transacao = true;
                    }

                }
            }

            return transacao;
        }
        #endregion

        #region Listar()
        public void Listar(int numeroDeRegistros = 100)
        {
            MdlEstoqueAtividade estoqueAtividade = new MdlEstoqueAtividade();
            Lista = estoqueAtividade.Listar(numeroDeRegistros);
        }
        #endregion

        #region Consultar()
        public void Consultar
        (string numeroAtividade, string tipo, string situacao, string dataInicio, string dataFinal, int numeroRegistro = 100)
        {
            MdlEstoqueAtividade atividade = new MdlEstoqueAtividade();
            Lista = atividade.Consultar(numeroAtividade, tipo, situacao, dataInicio, dataFinal, numeroRegistro);
        }
        #endregion 

        #region GetDetalhesAtividade()
        public void GetDetalhesAtividade(int id)
        {
            MdlEstoqueAtividade estoqueAtividade = new MdlEstoqueAtividade(this);
            estoqueAtividade.GetDetalhesAtividade(id);
        }
        #endregion 
    }
}
