using DimStock.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimStock.Business
{
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
}
