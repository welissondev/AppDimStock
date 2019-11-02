using SysEstoque.Model;
using System.Collections.Generic;

namespace SysEstoque.Business
{
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

            if (estoqueDestino.ChecarSeDestinoExiste() == false)
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

            if (estoqueDestino.Deletar(id) == true)
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
