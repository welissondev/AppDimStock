using SysEstoque.Auxiliary;
using SysEstoque.Model;
using System;
using System.Collections.Generic;

namespace SysEstoque.Business
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

    public class BllEstoqueProduto
    {
        #region Get e Set
        public int IdEstoque { get; set; }
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

        #region ObterResumo()
        public string ObterResumo(int estoqueQuantidade, int estoqueMin, int estoqueMax)
        {
            if (estoqueQuantidade == 0 || estoqueQuantidade < estoqueMin)
            {
                return "Baixo";
            }

            if (estoqueQuantidade > estoqueMax)
            {
                return "Alto";
            }

            if (estoqueQuantidade >= estoqueMin && estoqueQuantidade <= estoqueMax)
            {
                return "Ok";
            }

            return "";
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
    }

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
        (string tipo, string situacao, string dataInicio, string dataFinal, int numeroRegistro = 100)
        {
            MdlEstoqueAtividade atividade = new MdlEstoqueAtividade();
            Lista = atividade.Consultar(tipo, situacao, dataInicio, dataFinal, numeroRegistro);
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

    public class BllEstoqueDestino
    {
        #region Get e Set
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<BllEstoqueDestino> Lista { get; set; }
        #endregion

        #region Cadastrar()
        public bool Cadastrar()
        {
            bool transacao = false;

            MdlEstoqueDestino estoqueDestino = new MdlEstoqueDestino(this);

            if(estoqueDestino.ChecarSeDestinoExiste() == false)
            {
                if (estoqueDestino.Cadastrar() == true)
                {
                    transacao = true;
                    BllNotificar.Message = "Cadastrado com sucesso!";
                }
            }
            else
            {
                BllNotificar.Message = "Esse destino já existe, cadastre outro!";
            }

            return transacao;
        }
        #endregion

        #region Editar()
        public bool Editar(int id)
        {
            MdlEstoqueDestino estoqueDestino = new MdlEstoqueDestino(this);

            bool transacao = false;

            if (estoqueDestino.Editar(id) == true)
            {
                BllNotificar.Message = "Editado com sucesso!";
                transacao = true;
            }

            return transacao;
        }
        #endregion

        #region Deletar()
        public bool Deletar(int id)
        {
            MdlEstoqueDestino estoqueDestino = new MdlEstoqueDestino(this);

            bool transacao = false;

            if(estoqueDestino.Deletar(id) == true)
            {
                BllNotificar.Message = "Deletado com sucesso!";
                transacao = true;
            }
            else
            {
                BllNotificar.Message = "Esse registro já foi deletado, atualize a lista de dados!";
            }

            return transacao;
        }
        #endregion

        #region Listar()
        public void Listar()
        {
            MdlEstoqueDestino estoqueDestino = new MdlEstoqueDestino();
            Lista = estoqueDestino.Listar();
        }
        #endregion

        #region Visualizar()
        public void Visualizar(int id)
        {
            MdlEstoqueDestino estoqueDestino = new MdlEstoqueDestino(this);
            estoqueDestino.Visualizar(id);
        }
        #endregion
    }
}

