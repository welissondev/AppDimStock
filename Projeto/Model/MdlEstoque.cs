using SysEstoque.Auxiliary;
using SysEstoque.Business;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;

namespace SysEstoque.Model
{
    public class MdlEstoque
    {
        #region Propriedades
        private readonly BllEstoque estoque;
        #endregion 

        #region Construtores
        public MdlEstoque() { }

        public MdlEstoque(BllEstoque estoque)
        {
            this.estoque = estoque;
        }
        #endregion 

        #region AdicionarEntradas()
        public bool AdicionarEntradas(List<BllEstoque> listaEstoque, int idEstoqueAtividade)
        {
            bool transacao = false;

            using (MdlAccessConnection connection = new MdlAccessConnection())
            {
                using (connection.Transaction = connection.OpenConnection().BeginTransaction())
                {
                    for (int item = 0; item < listaEstoque.Count; item++)
                    {

                        var idEstoque = listaEstoque[item].Id;
                        var quantidade = listaEstoque[item].Quantidade;
                        var valorTotal = listaEstoque[item].Valor;

                        var commandSQL = @"UPDATE TBEstoque Set Quantidade = Quantidade + '" + quantidade +
                        "', Valor = Valor + '" + valorTotal + "' WHERE Id = " + idEstoque;

                        connection.ExecuteTransaction(commandSQL);
                    }

                    MdlEstoqueAtividade atividade = new MdlEstoqueAtividade();

                    if (atividade.AtualizarSituacao(connection, idEstoqueAtividade) == true)
                    {
                        connection.Transaction.Commit();
                        transacao = true;
                        BllNotificar.Message = "OK! todos os estoques foram adicionados!";
                    }

                    return transacao;
                }
            }
        }
        #endregion

        #region AdicionarSaidas()
        public bool AdicionarSaidas(List<BllEstoque> listaEstoque, int idEstoqueAtividade)
        {
            using (MdlAccessConnection connection = new MdlAccessConnection())
            {
                using (connection.Transaction = connection.OpenConnection().BeginTransaction())
                {
                    for (int item = 0; item < listaEstoque.Count; item++)
                    {

                        var idEstoque = listaEstoque[item].Id;
                        var quantidade = listaEstoque[item].Quantidade;
                        var valorTotal = listaEstoque[item].Valor;

                        var commandSQL = @"UPDATE TBEstoque Set Quantidade = Quantidade - '" + quantidade +
                        "', Valor = Valor - '" + valorTotal + "' WHERE Id = " + idEstoque;

                        connection.ExecuteTransaction(commandSQL);
                    }

                    MdlEstoqueAtividade estoqueAtividade = new MdlEstoqueAtividade();
                    estoqueAtividade.AtualizarSituacao(connection, idEstoqueAtividade);

                    connection.Transaction.Commit();

                    BllNotificar.Message = "Ok! Todos os estoque foram removidos!";

                    return true;
                }
            }
        }
        #endregion

        #region RelacionarProduto()
        public bool RelacionarProduto(MdlAccessConnection connection, int idProduto)
        {
            var commandSQL = @"INSERT INTO TBEstoque(IdProduto)VALUES(@IdProduto)";

            connection.ParameterClear();
            connection.AddParameter("@IdProduto", OleDbType.Integer, idProduto);

            var transacao = false;

            if (connection.ExecuteTransaction(commandSQL) > 0)
            {
                transacao = true;
            }

            return transacao;
        }
        #endregion

        #region AtualizarValor()
        public bool AtualizarValor(MdlAccessConnection connection, double produtoPrecoCusto, int idProduto)
        {
            var sql = @"UPDATE TBEstoque Set Valor = '" + produtoPrecoCusto + "' * Quantidade WHERE IdProduto = " + idProduto;
            var transacao = false;

            if (connection.ExecuteTransaction(sql) > 0)
            {
                transacao = true;
            }

            return transacao;
        }
        #endregion

        #region Reset()
        public bool Reset(List<BllEstoqueItem> listaEstoqueItem)
        {
            using (MdlAccessConnection connection = new MdlAccessConnection())
            {
                using (connection.Transaction = connection.OpenConnection().BeginTransaction())
                {
                    for (int item = 0; item < listaEstoqueItem.Count; item++)
                    {
                        var commandSQL = @"UPDATE TBEstoque Set Quantidade = '0', Valor = '0' WHERE Id = " + listaEstoqueItem[item].IdEstoque;

                        connection.ExecuteTransaction(commandSQL);
                    }

                    connection.Transaction.Commit();

                    BllNotificar.Message = "Ok! Todos os estoques foram removidos!";

                    return true;
                }
            }
        }
        #endregion 

        #region PegarDadosAfetados()
        public string PegarDadosAfetados(int id)
        {
            using (MdlAccessConnection connection = new MdlAccessConnection())
            {

                var commandSQL = @"SELECT * From TBEstoque Where Id = " + id;

                List<string> listaEstoque = new List<string>();

                using (OleDbDataReader dr = connection.ExecuteQuery(commandSQL))
                {
                    while (dr.Read())
                    {
                        listaEstoque.Add("Id:" + dr["Id"].ToString());
                        listaEstoque.Add("IdProduto:" + dr["IdProduto"].ToString());
                        listaEstoque.Add("Quantidade:" + dr["Quantidade"].ToString());
                        listaEstoque.Add("Valor:" + dr["Valor"].ToString());
                    }
                }

                return string.Join(" | ", listaEstoque.Select(x => x.ToString()));
            }
        }
        #endregion
    }

    public class MdlEstoqueProduto
    {
        #region Propriedades
        private BllEstoqueProduto estoqueProduto;
        #endregion

        #region Construtores
        public MdlEstoqueProduto() { }

        public MdlEstoqueProduto(BllEstoqueProduto estoqueProduto)
        {
            this.estoqueProduto = estoqueProduto;
        }
        #endregion 

        #region Listar()
        public List<BllEstoqueProduto> Listar(int namberOfRecords = 100)
        {
            var sqlSelecionarEstoqueProduto = @"Select TOP " + namberOfRecords + @" TBEstoque.Id, TBEstoque.Quantidade, TBEstoque.Valor, 
            TBProduto.Id, TBProduto.Descricao, TBProduto.Codigo, TBProduto.Referencia, TBProduto.Tamanho, TBProduto.EstoqueMin, 
            TBProduto.EstoqueMax, TBProduto.PrecoCusto, TBProduto.FotoNome From TBProduto INNER JOIN TBEstoque ON TBEstoque.IdProduto 
            = TBProduto.Id Order By Codigo, Tamanho, Referencia Asc";

            List<BllEstoqueProduto> listaEstoqueProduto = new List<BllEstoqueProduto>();

            using (MdlAccessConnection connection = new MdlAccessConnection())
            {

                using (OleDbDataReader dr = connection.ExecuteQuery(sqlSelecionarEstoqueProduto))
                {
                    while (dr.Read())
                    {
                        BllEstoqueProduto estoqueProduto = new BllEstoqueProduto
                        {
                            IdEstoque = Convert.ToInt32(dr["TBEstoque.Id"]),
                            IdProduto = Convert.ToInt32(dr["TBProduto.Id"]),
                            CodigoProduto = Convert.ToString(dr["Codigo"]),
                            ReferenciaProduto = Convert.ToString(dr["Referencia"]),
                            TamanhoProduto = Convert.ToString(dr["Tamanho"]),
                            DescricaoProduto = Convert.ToString(dr["Descricao"]),
                            EstoqueMin = Convert.ToInt32(dr["EstoqueMin"]),
                            EstoqueMax = Convert.ToInt32(dr["EstoqueMax"]),
                            QuantidadeEstoque = Convert.ToInt32(dr["Quantidade"]),
                            ValorEstoque = Convert.ToDouble(dr["Valor"]),
                            PrecoCustoProduto = Convert.ToDouble(dr["PrecoCusto"]),
                            FotoNomeProduto = Convert.ToString(dr["FotoNome"]),
                        };

                        listaEstoqueProduto.Add(estoqueProduto);
                    }
                }

                return listaEstoqueProduto;
            }
        }
        #endregion

        #region Filtrar()
        public List<BllEstoqueProduto> Filtrar(string codigo, string tamanho, string referencia, string descricao, int numeroDeRegistros = 100)
        {

            List<BllEstoqueProduto> listaEstoqueProduto = new List<BllEstoqueProduto>();

            using (MdlAccessConnection connection = new MdlAccessConnection())
            {
                var sqlSelectEstoqueProduto = @"SELECT TOP " + numeroDeRegistros + @" TBEstoque.Id, TBEstoque.Quantidade, TBEstoque.Valor, 
                TBProduto.Id, TBProduto.Descricao, TBProduto.PrecoCusto, TBProduto.Codigo, TBProduto.Referencia, TBProduto.Tamanho, 
                TBProduto.EstoqueMin, TBProduto.EstoqueMax, TBProduto.PrecoCusto, TBProduto.FotoNome From TBProduto INNER JOIN TBEstoque ON 
                TBEstoque.IdProduto = TBProduto.Id WHERE Descricao LIKE @Descricao ";

                var criterio = "";

                if (codigo != "")
                    criterio += " AND Codigo LIKE @Codigo ";

                if (tamanho != "")
                    criterio += " AND Tamanho LIKE @Tamanho ";

                if (referencia != "")
                    criterio += " AND Referencia LIKE @Referencia ";

                sqlSelectEstoqueProduto += criterio + " Order By Codigo, Tamanho, Referencia Asc";

                var e = connection.Command.Parameters;
                    e.AddWithValue("@Descricao", string.Format("%{0}%", descricao));

                if (codigo != "")
                    e.AddWithValue("@Codigo", string.Format("{0}", codigo));

                if (tamanho != "")
                    e.AddWithValue("@Tamanho", string.Format("{0}", tamanho));

                if (referencia != "")
                    e.AddWithValue("@Referencia", string.Format("{0}", referencia));

                using (OleDbDataReader dr = connection.ExecuteParameterQuery(sqlSelectEstoqueProduto))
                {
                    while (dr.Read())
                    {
                        BllEstoqueProduto estoqueProduto = new BllEstoqueProduto
                        {
                            IdEstoque = Convert.ToInt32(dr["TBEstoque.Id"]),
                            IdProduto = Convert.ToInt32(dr["TBProduto.Id"]),
                            CodigoProduto = Convert.ToString(dr["Codigo"]),
                            ReferenciaProduto = Convert.ToString(dr["Referencia"]),
                            TamanhoProduto = Convert.ToString(dr["Tamanho"]),
                            DescricaoProduto = Convert.ToString(dr["Descricao"]),
                            EstoqueMin = Convert.ToInt32(dr["EstoqueMin"]),
                            EstoqueMax = Convert.ToInt32(dr["EstoqueMax"]),
                            QuantidadeEstoque = Convert.ToInt32(dr["Quantidade"]),
                            ValorEstoque = Convert.ToDouble(dr["Valor"]),
                            PrecoCustoProduto = Convert.ToDouble(dr["PrecoCusto"]),
                            FotoNomeProduto = Convert.ToString(dr["FotoNome"]),
                        };

                        listaEstoqueProduto.Add(estoqueProduto);
                    }
                }

                return listaEstoqueProduto;
            }
        }
        #endregion

        #region Visualizar()
        public void Visualizar(int id)
        {

            var sql = @"SELECT TBProduto.*, TBEstoque.* From TBProduto INNER JOIN TBEstoque ON TBProduto.Id = TBEstoque.IdProduto
            WHERE TBProduto.Id = " + id;

            using (MdlAccessConnection connection = new MdlAccessConnection())
            {
                using (OleDbDataReader dr = connection.ExecuteQuery(sql))
                {
                    while (dr.Read())
                    {
                        estoqueProduto.IdEstoque = Convert.ToInt32(dr["TBEstoque.Id"]);
                        estoqueProduto.IdProduto = Convert.ToInt32(dr["TBProduto.Id"]);
                        estoqueProduto.CodigoProduto = Convert.ToString(dr["Codigo"]);
                        estoqueProduto.DescricaoProduto = dr["Descricao"].ToString();
                        estoqueProduto.ReferenciaProduto = dr["Referencia"].ToString();
                        estoqueProduto.TamanhoProduto = dr["Tamanho"].ToString();
                        estoqueProduto.PrecoCustoProduto = Convert.ToDouble(dr["PrecoCusto"]);
                        estoqueProduto.QuantidadeEstoque = Convert.ToInt32(dr["Quantidade"]);
                    }
                }
            }
        }
        #endregion
    }

    public class MdlEstoqueAtividade
    {
        #region Propriedades
        private readonly BllEstoqueAtividade estoqueAtividade;
        #endregion

        #region Construtores
        public MdlEstoqueAtividade() { }

        public MdlEstoqueAtividade(BllEstoqueAtividade estoqueAtividade)
        {
            this.estoqueAtividade = estoqueAtividade;
        }
        #endregion

        #region Adicionar()
        public bool Adicionar()
        {
            bool adicionar = false;

            using (MdlAccessConnection connection = new MdlAccessConnection())
            {
                var sql = @"INSERT INTO TBEstoqueAtividade(Tipo, Data, Hora, Situacao)
                VALUES(@Tipo, @Data, @Hora, @Situacao)";

                connection.AddParameter("@Tipo", OleDbType.VarChar, estoqueAtividade.Tipo);
                connection.AddParameter("@Data", OleDbType.Date, estoqueAtividade.Data);
                connection.AddParameter("@Hora", OleDbType.VarChar, estoqueAtividade.Hora);
                connection.AddParameter("@Situacao", OleDbType.VarChar, estoqueAtividade.Situacao);

                if (connection.ExecuteNonQuery(sql) > 0)
                {
                    estoqueAtividade.Id = Convert.ToInt32(connection.ExecuteScalar(@"SELECT MAX(Id) FROM TBEstoqueAtividade"));

                    if (estoqueAtividade.Id > 0)
                    {
                        adicionar = true;
                    }

                }

                return adicionar;
            }
        }
        #endregion

        #region AdicionarDestino()
        public bool AdicionarDestino(int id)
        {
            bool adicionar = false;

            if (estoqueAtividade.Destino != "")
            {
                using (MdlAccessConnection connection = new MdlAccessConnection())
                {
                    var sql = @"UPDATE TBEstoqueAtividade SET Destino = @Destino WHERE Id =" + id;

                    connection.AddParameter("@Destino", OleDbType.VarChar, estoqueAtividade.Destino);

                    adicionar = connection.ExecuteNonQuery(sql) > 0;

                }
            }

            return adicionar;
        }
        #endregion

        #region Deletar()
        public bool Deletar(int id)
        {
            bool deletar = false;

            using (MdlAccessConnection connection = new MdlAccessConnection())
            {
                var commandSQL = @"DELETE FROM TBEstoqueAtividade WHERE Id = " + id;

                if (connection.ExecuteNonQuery(commandSQL) > 0)
                {
                    BllNotificar.Message = "Atividade deletada com sucesso!";
                    deletar = true;
                }
                else
                {
                    BllNotificar.Message = "Essa atividade já foi deletada, " +
                    "atualize a lista de dados!";
                }
            }

            return deletar;
        }
        #endregion 

        #region AtualizarSituacao()
        public bool AtualizarSituacao(MdlAccessConnection connection, int idEstoqueAtividade)
        {
            var sql = @"UPDATE TBEstoqueAtividade Set Situacao = 'Finalizada' Where Id = " + idEstoqueAtividade;
            var transacao = false;

            if (connection.ExecuteTransaction(sql) > 0)
            {
                BllUsuarioHistorico historico = new BllUsuarioHistorico()
                {
                    Login = AxlLogin.Login,
                    Operacao = "Confirmou",
                    Modulo = "Atividade",
                    Data = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                    Hora = DateTime.Now.ToString("HH:mm:ss"),
                    DadosRegistroAfetado = PegarDadosAfetados(idEstoqueAtividade)
                };
                if (historico.Registrar() == true)
                {
                    transacao = true;
                }
            }

            return transacao;
        }
        #endregion

        #region Listar()
        public List<BllEstoqueAtividade> Listar(int numeroDeRegistros = 100)
        {
            using (MdlAccessConnection connection = new MdlAccessConnection())
            {
                var sql = @"SELECT TOP " + numeroDeRegistros + " * From TBEstoqueAtividade";

                List<BllEstoqueAtividade> listaEstoqueAtividade = new List<BllEstoqueAtividade>();

                using (OleDbDataReader dr = connection.ExecuteQuery(sql))
                {
                    while (dr.Read())
                    {
                        BllEstoqueAtividade estoqueAtividade = new BllEstoqueAtividade()
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            Tipo = dr["Tipo"].ToString(),
                            Data = Convert.ToDateTime(dr["Data"]),
                            Hora = dr["Hora"].ToString(),
                            Situacao = dr["Situacao"].ToString(),
                        };

                        listaEstoqueAtividade.Add(estoqueAtividade);

                    }
                }

                return listaEstoqueAtividade;
            }
        }
        #endregion

        #region Consultar()
        public List<BllEstoqueAtividade> Consultar
        (string numeroAtividade, string tipo, string operacao, string dataInicio, string dataFinal, int numeroRegistros = 100)
        {
            using (MdlAccessConnection connection = new MdlAccessConnection())
            {
                var commandSQL = @"SELECT TOP " + numeroRegistros +
                @" * From TBEstoqueAtividade WHERE Data >= @DataInicio AND Data <= @DataFinal";

                var criterio = "";

                if (numeroAtividade != "")
                    criterio += " And Id LIKE @Id";

                if (tipo != "")
                    criterio += " And Tipo LIKE @Tipo";

                if (operacao != "")
                    criterio += " And Situacao LIKE @Situacao";

                commandSQL += criterio;

                var e = connection.Command.Parameters;
                    e.AddWithValue("@DataInicio", string.Format("{0}", dataInicio));
                    e.AddWithValue("@DataFinal", string.Format("{0}", dataFinal));

                if (numeroAtividade != "")
                    e.AddWithValue("@Id", string.Format("{0}", numeroAtividade));

                if (tipo != "")
                    e.AddWithValue("@Tipo", string.Format("{0}", tipo));

                if (operacao != "")
                    e.AddWithValue("@Situacao", string.Format("{0}", operacao));

                List<BllEstoqueAtividade> listaEstoqueAtividade = new List<BllEstoqueAtividade>();

                using (OleDbDataReader dr = connection.ExecuteQuery(commandSQL))
                {
                    while (dr.Read())
                    {
                        BllEstoqueAtividade estoqueAtividade = new BllEstoqueAtividade()
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            Tipo = dr["Tipo"].ToString(),
                            Data = Convert.ToDateTime(dr["Data"]),
                            Hora = dr["Hora"].ToString(),
                            Situacao = dr["Situacao"].ToString(),
                        };

                        listaEstoqueAtividade.Add(estoqueAtividade);

                    }
                }

                return listaEstoqueAtividade;
            }
        }
        #endregion

        #region GetDetalhesAtividade()
        public void GetDetalhesAtividade(int id)
        {
            var sql = @"SELECT * FROM TBEstoqueAtividade WHERE Id = " + id;

            using (MdlAccessConnection connection = new MdlAccessConnection())
            {
                using (OleDbDataReader dr = connection.ExecuteQuery(sql))
                {
                    while (dr.Read())
                    {
                        estoqueAtividade.Id = Convert.ToInt32(dr["Id"]);
                        estoqueAtividade.Tipo = Convert.ToString(dr["Tipo"]);
                        estoqueAtividade.Data = Convert.ToDateTime(dr["Data"]);
                        estoqueAtividade.Hora = Convert.ToString(dr["Hora"]);
                        estoqueAtividade.Situacao = Convert.ToString(dr["Situacao"]);
                        estoqueAtividade.Destino = Convert.ToString(dr["Destino"]);
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

                var commandSQL = @"SELECT * From TBEstoqueAtividade Where Id = " + id;

                List<string> listaAtividade = new List<string>();

                using (OleDbDataReader dr = connection.ExecuteQuery(commandSQL))
                {
                    while (dr.Read())
                    {
                        listaAtividade.Add("Id:" + dr["Id"].ToString());
                        listaAtividade.Add("Tipo:" + dr["Tipo"].ToString());
                        listaAtividade.Add("Data:" + Convert.ToDateTime(dr["Data"]).ToString("dd-MM-yyyy"));
                        listaAtividade.Add("Hora:" + dr["Hora"].ToString());
                        listaAtividade.Add("Situacao:" + dr["Situacao"].ToString());
                    }
                }

                return string.Join(" | ", listaAtividade.Select(x => x.ToString()));
            }
        }
        #endregion
    }

    public class MdlEstoqueItem
    {
        #region Propriedades
        private readonly BllEstoqueItem estoqueItem;
        #endregion 

        #region Construtores
        public MdlEstoqueItem() { }

        public MdlEstoqueItem(BllEstoqueItem estoqueItem)
        {
            this.estoqueItem = estoqueItem;
        }
        #endregion

        #region Adicionar()
        public void Adicionar()
        {
            using (MdlAccessConnection connection = new MdlAccessConnection())
            {
                var sql = @"INSERT INTO TBEstoqueItem(IdEstoqueAtividade, IdProduto, IdEstoque, 
                Quantidade, ValorUnitario, ValorTotal)VALUES(@IdEstoqueAtividade, @IdProduto, @IdEstoque, 
                @Quantidade, @ValorUnitario, @ValorTotal)";

                connection.AddParameter("@IdEstoqueMovimento", OleDbType.Integer, estoqueItem.IdEstoqueAtividade);
                connection.AddParameter("@IdProduto", OleDbType.Integer, estoqueItem.IdProduto);
                connection.AddParameter("@IdEstoque", OleDbType.Integer, estoqueItem.IdEstoque);
                connection.AddParameter("@Quantidade", OleDbType.Integer, estoqueItem.Quantidade);
                connection.AddParameter("@ValorUnitario", OleDbType.Double, estoqueItem.ValorUnitario);
                connection.AddParameter("@ValorTotal", OleDbType.Double, estoqueItem.ValorTotal);

                connection.ExecuteNonQuery(sql);
            }
        }
        #endregion

        #region Listar()
        public List<BllEstoqueItem> ListItens(int idEstoqueAtividade)
        {
            using (MdlAccessConnection connection = new MdlAccessConnection())
            {
                var sql = @"SELECT TBEstoqueItem.*, TBProduto.Descricao, TBProduto.Codigo 
                FROM TBEstoqueItem INNER JOIN TBProduto ON TBEstoqueItem.IdProduto = TBProduto.Id WHERE 
                TBEstoqueItem.IdEstoqueAtividade LIKE '" + idEstoqueAtividade + "'";

                List<BllEstoqueItem> listaItens = new List<BllEstoqueItem>();

                using (OleDbDataReader dr = connection.ExecuteQuery(sql))
                {
                    while (dr.Read())
                    {
                        BllEstoqueItem item = new BllEstoqueItem()
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            IdEstoque = Convert.ToInt32(dr["IdEstoque"]),
                            CodigoProduto = dr["Codigo"].ToString(),
                            DescricaoProduto = dr["Descricao"].ToString(),
                            Quantidade = Convert.ToInt32(dr["Quantidade"]),
                            ValorUnitario = Convert.ToDouble(dr["ValorUnitario"]),
                            ValorTotal = Convert.ToDouble(dr["ValorTotal"])
                        };

                        listaItens.Add(item);
                    }
                }

                return listaItens;
            }
        }
        #endregion

        #region Deletar()
        public void Deletar(int id)
        {
            using (MdlAccessConnection connection = new MdlAccessConnection())
            {
                var sql = @"DELETE FROM TBEstoqueItem Where Id =" + id;

                connection.ExecuteNonQuery(sql);
            }
        }
        #endregion 
    }

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
                using (OleDbDataReader dr = connection.ExecuteQuery(commandSQL))
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
                using (OleDbDataReader dr = connection.ExecuteQuery(sql))
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

                using (OleDbDataReader dr = connection.ExecuteQuery(commandSQL))
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
