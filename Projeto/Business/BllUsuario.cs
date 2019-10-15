using System;
using System.Collections.Generic;
using SysEstoque.Auxiliary;
using SysEstoque.Model;

namespace SysEstoque.Business
{
    #region ClassBllUsuario
    public class BllUsuario
    {
        #region Get e Set 
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool PermissaoCadastrar { get; set; }
        public bool PermissaoEditar { get; set; }
        public bool PermissaoDeletar { get; set; }
        public bool PermissaoTodas { get; set; }
        public bool PermissaoVisualizar { get; set; }
        public List<BllUsuario> Lista { get; set; }
        #endregion

        #region Acessar()
        public bool Acessar()
        {
            MdlUsuario usuario = new MdlUsuario(this);
            return usuario.Acessar();
        }
        #endregion 

        #region Registrar()
        public bool Registrar()
        {
            MdlUsuario usuario = new MdlUsuario(this);

            if (usuario.Registrar() == true)
            {
                BllUsuarioHistorico historico = new BllUsuarioHistorico()
                {
                    Login = AxlLogin.Login,
                    Operacao = "Cadastrou",
                    Modulo = "Usuário",
                    Data = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                    Hora = DateTime.Now.ToString("HH:mm:ss"),
                    DadosRegistroAfetado = usuario.PegarDadosAfetados(Id)
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
            MdlUsuario usuario = new MdlUsuario(this);

            if (usuario.Alterar(id) == true)
            {
                BllUsuarioHistorico historicoNegocio = new BllUsuarioHistorico()
                {
                    Login = AxlLogin.Login,
                    Operacao = "Editou",
                    Modulo = "Usuário",
                    Data = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                    Hora = DateTime.Now.ToString("HH:mm:ss"),
                    DadosRegistroAfetado = usuario.PegarDadosAfetados(id)
                };

                return historicoNegocio.Registrar();
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
            MdlUsuario usuario = new MdlUsuario(this);

            var dadosRegistroDeletado = usuario.PegarDadosAfetados(id);

            if (usuario.Deletar(id) == true)
            {
                BllUsuarioHistorico historico = new BllUsuarioHistorico()
                {
                    Login = AxlLogin.Login,
                    Operacao = "Deletou",
                    Modulo = "Usuário",
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
            MdlUsuario usuario = new MdlUsuario();
            Lista = usuario.Listar(numeroDeRegistros);
        }
        #endregion

        #region Consultar()
        public void Consultar(string query, int numeroDeRegistros)
        {
            MdlUsuario usuario = new MdlUsuario();
            Lista = usuario.Consultar(query, numeroDeRegistros);
        }
        #endregion

        #region VisualizarDados()
        public void VisualizarDados(int id)
        {
            MdlUsuario usuario = new MdlUsuario(this);
            usuario.VisualizarDados(id);
        }
        #endregion
    }
    #endregion

    #region ClassBllUsuarioHistorico
    public class BllUsuarioHistorico
    {
        #region Get e Set
        public int Id { get; set; }
        public string Login { get; set; }
        public int IdRegistro { get; set; }
        public DateTime Data { get; set; }
        public string Hora { get; set; }
        public string Operacao { get; set; }
        public string Modulo { get; set; }
        public string DadosRegistroAfetado { get; set; }
        public List<BllUsuarioHistorico> Lista { get; set; }
        #endregion

        #region Registrar()
        public bool Registrar()
        {
            MdlUsuarioHistorico historico = new MdlUsuarioHistorico(this);
            return historico.Cadastrar();
        }
        #endregion

        #region Listar()
        public void Listar(int quantidadeRegistro)
        {
            MdlUsuarioHistorico historico = new MdlUsuarioHistorico();
            Lista = historico.Listar(quantidadeRegistro);
        }
        #endregion

        #region Consultar()
        public void Consultar(string login, string dataInicio, string dataFinal, int quantidadeRegistros = 100)
        {
            MdlUsuarioHistorico historico = new MdlUsuarioHistorico();
            Lista = historico.Consultar(login, dataInicio, dataFinal, quantidadeRegistros);
        }
        #endregion 
    }
    #endregion 
}
