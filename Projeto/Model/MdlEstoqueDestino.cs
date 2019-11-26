using SysEstoque.Business;
using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace SysEstoque.Model
{
    public class MdlEstoqueDestino
    {
        #region Propriedades privadas
        private readonly BllEstoqueDestino estoqueDestino;
        #endregion

        #region Construtores()
        public MdlEstoqueDestino() { }

        public MdlEstoqueDestino(BllEstoqueDestino estoqueDestino)
        {
            this.estoqueDestino = estoqueDestino;
        }
        #endregion 

        #region Cadastrar()
        public bool Cadastrar()
        {
            using (MdlAccessConnection connection = new MdlAccessConnection())
            {
                var commandSQL = @"INSERT INTO TBEstoqueDestino(Nome)VALUES(@Nome)";

                connection.AddParameter("@Nome", OleDbType.VarChar, estoqueDestino.Nome);

                return connection.ExecuteNonQuery(commandSQL) > 0;
            }
        }
        #endregion

        #region Editar()
        public bool Editar(int id)
        {
            using (MdlAccessConnection connection = new MdlAccessConnection())
            {
                var commandSQL = @"UPDATE TBEstoqueDestino SET Nome = @Nome WHERE Id = " + id;

                connection.AddParameter("@Nome", OleDbType.VarChar, estoqueDestino.Nome);

                return connection.ExecuteNonQuery(commandSQL) > 0;

            }
        }
        #endregion

        #region Deletar()
        public bool Deletar(int id)
        {
            using (MdlAccessConnection connection = new MdlAccessConnection())
            {
                var sql = @"DELETE FROM TBEstoqueDestino Where Id =" + id;

                return connection.ExecuteNonQuery(sql) > 0;
            }
        }
        #endregion

        #region Listar()
        public List<BllEstoqueDestino> Listar()
        {

            var commandSQL = @"SELECT * From TBEstoqueDestino";

            List<BllEstoqueDestino> listaEstoqueDestino = new List<BllEstoqueDestino>();

            using (MdlAccessConnection connection = new MdlAccessConnection())
            {
                using (OleDbDataReader dr = connection.QueryWithDataReader(commandSQL))
                {
                    while (dr.Read())
                    {
                        BllEstoqueDestino estoqueDestino = new BllEstoqueDestino()
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            Nome = Convert.ToString(dr["Nome"])
                        };

                        listaEstoqueDestino.Add(estoqueDestino);
                    }
                }
            }

            return listaEstoqueDestino;

        }
        #endregion

        #region Visualizar()
        public void Visualizar(int id)
        {
            var sql = @"SELECT * FROM TBEstoqueDestino WHERE Id = " + id;

            using (MdlAccessConnection connection = new MdlAccessConnection())
            {
                using (OleDbDataReader dr = connection.QueryWithDataReader(sql))
                {
                    while (dr.Read())
                    {
                        estoqueDestino.Id = Convert.ToInt32(dr["Id"]);
                        estoqueDestino.Nome = Convert.ToString(dr["Nome"]);
                    }
                }
            }
        }
        #endregion

        #region ChecarSeDestinoExiste()
        public bool ChecarSeDestinoExiste()
        {
            var commandSQL = @"SELECT Nome From TBEstoqueDestino WHERE Nome LIKE @Nome";

            var encontrados = 0;

            using (MdlAccessConnection connection = new MdlAccessConnection())
            {
                connection.AddParameter("@Nome", OleDbType.VarChar, estoqueDestino.Nome);

                using (OleDbDataReader dr = connection.QueryWithDataReader(commandSQL))
                {
                    while (dr.Read())
                    {
                        encontrados = +1;
                    }
                }
            }

            return encontrados > 0;
        }
        #endregion

    }
}
