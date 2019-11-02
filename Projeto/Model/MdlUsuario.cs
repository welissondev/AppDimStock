using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using SysEstoque.Auxiliary;
using SysEstoque.Business;

namespace SysEstoque.Model
{
    public class MdlUsuario
    {
        #region Construtores
        public MdlUsuario()
        {

        }

        public MdlUsuario(BllUsuario usuario)
        {
            this.usuario = usuario;
        }
        #endregion

        #region Propriedades privadas
        private readonly BllUsuario usuario;
        #endregion

        #region Acessar()
        public bool Acessar()
        {
            bool loginAcesso = false;

            using (MdlAccessConnection connection = new MdlAccessConnection())
            {
                var sql = @"SELECT * FROM TBUsuario WHERE Login LIKE @Login AND Senha = @Senha";

                var e = connection.Command.Parameters;
                e.AddWithValue("@Login", usuario.Login);
                e.AddWithValue("@Senha", usuario.Senha);

                using (OleDbDataReader dr = connection.ExecuteParameterQuery(sql))
                {
                    while (dr.Read())
                    {
                        usuario.Id = Convert.ToInt32(dr["Id"]);
                        usuario.Nome = dr["Nome"].ToString();
                        usuario.Login = dr["Login"].ToString();
                        usuario.PermissaoCadastrar = Convert.ToBoolean(dr["PermissaoCadastrar"]);
                        usuario.PermissaoEditar = Convert.ToBoolean(dr["PermissaoEditar"]);
                        usuario.PermissaoDeletar = Convert.ToBoolean(dr["PermissaoDeletar"]);
                        usuario.PermissaoVisualizar = Convert.ToBoolean(dr["PermissaoVisualizar"]);

                        loginAcesso = true;
                    }
                }
            }

            if(loginAcesso == false)
            {
                BllNotificar.Message = "Usuário não encontrado!";
            }

            return loginAcesso;
        }
        #endregion 

        #region Registrar()
        public bool Registrar()
        {
            bool registrar = false;

            if (ChegarSeLoginJaExiste() == false)
            {
                using (MdlAccessConnection connection = new MdlAccessConnection())
                {
                    var commandSQL = @"INSERT INTO TBUsuario(Nome, Email, Login, Senha, PermissaoCadastrar, 
                    PermissaoEditar, PermissaoDeletar, PermissaoVisualizar, PermissaoTodas)VALUES(@Nome, @Email, @Login, @Senha, @PermissaoCadastrar, 
                    @PermissaoEditar, @PermissaoDeletar, @PermissaoVisualizar, @PermissaoTodas)";

                    connection.AddParameter("@nome", OleDbType.VarChar, usuario.Nome);
                    connection.AddParameter("@email", OleDbType.VarChar, usuario.Email);
                    connection.AddParameter("@login", OleDbType.VarChar, usuario.Login);
                    connection.AddParameter("@senha", OleDbType.VarChar, usuario.Senha);
                    connection.AddParameter("@PermissaoCadastra", OleDbType.Boolean, usuario.PermissaoCadastrar);
                    connection.AddParameter("@PermissaoEditar", OleDbType.Boolean, usuario.PermissaoEditar);
                    connection.AddParameter("@PermissaoDeletar", OleDbType.Boolean, usuario.PermissaoDeletar);
                    connection.AddParameter("@PermissaoVisualizar", OleDbType.Boolean, usuario.PermissaoVisualizar);
                    connection.AddParameter("@PermissaoTodas", OleDbType.Boolean, usuario.PermissaoDeletar);

                    if (connection.ExecuteNonQuery(commandSQL) > 0)
                    {
                        usuario.Id = Convert.ToInt32(connection.ExecuteScalar("SELECT MAX(Id) FROM TBUsuario"));

                        if(usuario.Id > 0)
                        {
                            BllNotificar.Message = "Dados registrados com sucesso!";
                            registrar = true;
                        }  
                    }
                }

                return registrar;
            }
            else
            {
                return registrar;
            }
        }
        #endregion

        #region Alterar()
        public bool Alterar(int id)
        {
            bool alterar = false;

            using (MdlAccessConnection connection = new MdlAccessConnection())
            {
                var sql = @"UPDATE TBUsuario Set Nome = @Nome, Email = @Email, Login = @Login, Senha = @Senha, PermissaoCadastrar = @PermissaoCadastrar,
                PermissaoEditar = @PermissaoEditar, PermissaoDeletar = @PermissaoDeletar, PermissaoVisualizar = @PermissaoVisualizar, PermissaoTodas = @PermissaoTodas WHERE Id = " + id;

                connection.AddParameter("@nome", OleDbType.VarChar, usuario.Nome);
                connection.AddParameter("@email", OleDbType.VarChar, usuario.Email);
                connection.AddParameter("@login", OleDbType.VarChar, usuario.Login);
                connection.AddParameter("@senha", OleDbType.VarChar, usuario.Senha);
                connection.AddParameter("@PermissaoCadastra", OleDbType.Boolean, usuario.PermissaoCadastrar);
                connection.AddParameter("@PermissaoEditar", OleDbType.Boolean, usuario.PermissaoEditar);
                connection.AddParameter("@PermissaoDeletar", OleDbType.Boolean, usuario.PermissaoDeletar);
                connection.AddParameter("@PermissaoVisualizar", OleDbType.Boolean, usuario.PermissaoVisualizar);
                connection.AddParameter("@PermissaoTodas", OleDbType.Boolean, usuario.PermissaoDeletar);

                if (connection.ExecuteNonQuery(sql) > 0)
                {
                    BllNotificar.Message = "Dados alterados com sucesso!";
                    alterar = true;
                }
            }

            return alterar;
        }
        #endregion

        #region Deletar()
        public bool Deletar(int id)
        {
            bool deletar = false;

            using (MdlAccessConnection connection = new MdlAccessConnection())
            {
                if (ChecarSeEstaTentandoDeletarSiMesmo(id) == false)
                {
                    if (connection.ExecuteNonQuery(@"DELETE FROM TBUsuario WHERE Id = " + id) > 0)
                    {
                        deletar = true;
                        BllNotificar.Message = "Dados deletados com sucesso!"; 
                    }
                    else
                    {
                        BllNotificar.Message = "Esse registro já foi deletado," +
                        "atualize a lista de dados!";
                    }
                }
                else
                {
                    BllNotificar.Message = "Você não pode deletar seu " +
                    "próprio registro de usuário!";
                }
            }

            return deletar;
        }
        #endregion

        #region ChecarSeEstaTentandoDeletarSiMesmo()
        public bool ChecarSeEstaTentandoDeletarSiMesmo(int idDelete)
        {
            if (AxlLogin.Id == idDelete)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region ChegarSeLoginJaExiste()
        public bool ChegarSeLoginJaExiste()
        {
            using (MdlAccessConnection connection = new MdlAccessConnection())
            {
                string commandSQL = @"SELECT Login FROM TBUsuario WHERE Login LIKE '" + usuario.Login + "'";
                int cont = 0;

                using (OleDbDataReader dr = connection.ExecuteQuery(commandSQL))
                {
                    while (dr.Read())
                    {
                        cont = +1;
                    }
                }

                if (cont > 0)
                {
                    BllNotificar.Message = "Já existe um usuário com o login [" + usuario.Login + "]. " +
                    "Por favor, informe outro nome de login!";
                }

                return cont > 0;
            }
        }
        #endregion 

        #region Listar()
        public List<BllUsuario> Listar(int numeroDeRegistros = 100)
        {
            using (MdlAccessConnection connection = new MdlAccessConnection())
            {
                var sql = "SELECT TOP " + numeroDeRegistros + @" Id, Nome, Email FROM TBUsuario";

                List<BllUsuario> listaUsuario = new List<BllUsuario>();

                using (OleDbDataReader dr = connection.ExecuteQuery(sql))
                {
                    while (dr.Read())
                    {
                        BllUsuario usuario = new BllUsuario()
                        {
                            Id = Convert.ToInt32(dr["id"]),
                            Nome = Convert.ToString(dr["Nome"]),
                            Email = Convert.ToString(dr["Email"])
                        };

                        listaUsuario.Add(usuario);
                    }

                    return listaUsuario;
                }
            }
        }
        #endregion

        #region Consultar()
        public List<BllUsuario> Consultar(string query, int numeroDeRegistros = 100)
        {
            using (MdlAccessConnection connection = new MdlAccessConnection())
            {
                var sql = "SELECT TOP " + numeroDeRegistros + @" * FROM TBUsuario WHERE Nome LIKE @Nome Or Email LIKE @Email";

                var e = connection.Command.Parameters;
                e.AddWithValue("@Nome", string.Format("%{0}%", query));
                e.AddWithValue("@Email", string.Format("%{0}%", query));

                List<BllUsuario> listaUsuario = new List<BllUsuario>();

                using (OleDbDataReader dr = connection.ExecuteParameterQuery(sql))
                {
                    while (dr.Read())
                    {
                        BllUsuario usuario = new BllUsuario()
                        {
                            Id = Convert.ToInt32(dr["id"]),
                            Nome = Convert.ToString(dr["Nome"]),
                            Email = Convert.ToString(dr["Email"])
                        };

                        listaUsuario.Add(usuario);
                    }

                    return listaUsuario;
                }
            }
        }
        #endregion

        #region VisualizarDados()
        public void VisualizarDados(int id)
        {
            using (MdlAccessConnection connection = new MdlAccessConnection())
            {
                var sql = @" SELECT * FROM TBUsuario WHERE Id = " + id;

                using (OleDbDataReader dr = connection.ExecuteQuery(sql))
                {
                    while (dr.Read())
                    {
                        usuario.Id = Convert.ToInt32(dr["Id"]);
                        usuario.Nome = Convert.ToString(dr["Nome"]);
                        usuario.Email = Convert.ToString(dr["Email"]);
                        usuario.Login = Convert.ToString(dr["Login"]);
                        usuario.Senha = Convert.ToString(dr["Senha"]);
                        usuario.PermissaoCadastrar = Convert.ToBoolean(dr["PermissaoCadastrar"]);
                        usuario.PermissaoEditar = Convert.ToBoolean(dr["PermissaoEditar"]);
                        usuario.PermissaoDeletar = Convert.ToBoolean(dr["PermissaoDeletar"]);
                        usuario.PermissaoTodas = Convert.ToBoolean(dr["PermissaoTodas"]);
                        usuario.PermissaoVisualizar = Convert.ToBoolean(dr["PermissaoVisualizar"]);
                    }
                }
            }
        }
        #endregion

        #region PegarDadosAfetados()
        public string PegarDadosAfetados(int id)
        {
            using (MdlAccessConnection connection = new MdlAccessConnection())
            {

                var commandSQL = @" SELECT * FROM TBUsuario WHERE Id = " + id;

                List<string> listaUsuario = new List<string>();

                using (OleDbDataReader dr = connection.ExecuteQuery(commandSQL))
                {
                    while (dr.Read())
                    {
                        listaUsuario.Add("Id:" + dr["Id"].ToString());
                        listaUsuario.Add("Nome:" + dr["Nome"].ToString());
                        listaUsuario.Add("Email:" + dr["Email"].ToString());
                        listaUsuario.Add("Login:" + dr["Login"].ToString());
                        listaUsuario.Add("Senha:" + dr["Senha"].ToString());
                        listaUsuario.Add("PermissãoCadastrar:" + dr["PermissaoCadastrar"].ToString().Replace("True","Sím").Replace("False","Não"));
                        listaUsuario.Add("PermissãoEditar:" + dr["PermissaoEditar"].ToString().Replace("True", "Sím").Replace("False", "Não"));
                        listaUsuario.Add("PermissãoDeletar:" + dr["PermissaoDeletar"].ToString().Replace("True", "Sím").Replace("False", "Não"));
                        listaUsuario.Add("PermissãoTodas:" + dr["PermissaoTodas"].ToString().Replace("True", "Sím").Replace("False", "Não"));
                    }
                }

                return string.Join(" | ", listaUsuario.Select(x => x.ToString()));
            }
        }
        #endregion

    }
}

