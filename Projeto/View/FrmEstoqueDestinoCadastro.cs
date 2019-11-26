using System;
using System.Windows.Forms;
using DimStock.Auxiliary;
using DimStock.Business;

namespace DimStock.View
{
    public partial class FrmEstoqueDestinoCadastro : Form
    {

        #region Propriedades privadadas
        private int id = 0;
        #endregion 

        #region Construtores
        public FrmEstoqueDestinoCadastro()
        {
            InitializeComponent();

            InitializeDefinicoes();
        }
        #endregion

        #region FrmEstoqueDestinoCadastro_Load
        private void FrmEstoqueDestinoCadastro_Load(object sender, EventArgs e)
        {
            Listar();
        }
        #endregion 

        #region BtnCadastrar_Click()
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarDadosEntrada() == true)
                {
                    BllEstoqueDestino estoqueDestino = new BllEstoqueDestino
                    {
                        Nome = TxtDestino.Text.TrimStart().TrimEnd()
                    };

                    if (estoqueDestino.Cadastrar() == true)
                    {
                        MessageBox.Show(BllNotificar.Message, "SUCESSO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        CallAllReset();
                    }
                    else
                    {
                        MessageBox.Show(BllNotificar.Message, "ATENÇÃO",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region BtnEditar_Click()
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (id > 0)
                {
                    BllEstoqueDestino estoqueDestino = new BllEstoqueDestino
                    {
                        Nome = TxtDestino.Text.TrimStart().TrimEnd()
                    };

                    if (estoqueDestino.Editar(id) == true)
                    {
                        MessageBox.Show(BllNotificar.Message, "SUCESSO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um registro para editar!", "SELECIONE",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region BtnDeleta_Click()
        private void BtnDeleta_Click(object sender, EventArgs e)
        {
            try
            {
                if (id > 0)
                {
                    BllEstoqueDestino estoqueDestino = new BllEstoqueDestino();

                    if (estoqueDestino.Deletar(id) == true)
                    {
                        MessageBox.Show(BllNotificar.Message, "SUCESSO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um registro para deletar!", "SELECIONE",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
            finally
            {
                CallAllReset();
            }
        }
        #endregion

        #region BtnAtualizar_Click()
        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            Listar();
            CallAllReset();
        }
        #endregion 

        #region GridListaDestinos_DoubleClick()
        private void GridListaDestinos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (GridListaDestinos.Rows.Count > 0)
                {
                    id = Convert.ToInt32(GridListaDestinos.CurrentRow.Cells["idColumn"].Value);

                    BllEstoqueDestino estoqueDestino = new BllEstoqueDestino();
                    estoqueDestino.Visualizar(id);

                    TxtDestino.Text = estoqueDestino.Nome;
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion 

        #region ValidarDadosEntrada()
        private bool ValidarDadosEntrada()
        {
            bool isValid = false;

            if (TxtDestino.Text == "" || TxtDestino.Text == null)
            {
                MessageBox.Show("Informe o nome de um destino Ex: Loja1", "OBRIGATÓRIO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                isValid = true;
            }

            return isValid;
        }
        #endregion

        #region Listar()
        private void Listar()
        {
            try
            {
                BllEstoqueDestino estoqueDestino = new BllEstoqueDestino();
                estoqueDestino.Listar();

                GridListaDestinos.Rows.Clear();

                for (int item = 0; item < estoqueDestino.Lista.Count; item++)
                {
                    GridListaDestinos.Rows.Add(
                    estoqueDestino.Lista[item].Id,
                    estoqueDestino.Lista[item].Nome);
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region DefinirGridColumns()
        private void DefinirGridColumns()
        {
            try
            {
                DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn nomeColumn = new DataGridViewTextBoxColumn();

                DataGridView dtg = GridListaDestinos;

                dtg.Columns.Add(idColumn);
                dtg.Columns[0].Name = "idColumn";
                dtg.Columns[0].HeaderText = "ID";
                dtg.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[0].Visible = false;
                dtg.Columns[0].ReadOnly = true;

                dtg.Columns.Add(nomeColumn);
                dtg.Columns[1].Width = 400;
                dtg.Columns[1].Name = "nomeColumn";
                dtg.Columns[1].HeaderText = "NOME";
                dtg.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dtg.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dtg.Columns[1].ReadOnly = true;

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region InitializeDefinicoes()
        public void InitializeDefinicoes()
        {
            DefinirGridColumns();

            AxlDataGridViewLealt.DefaultLayoutDarkblue(GridListaDestinos);

        }
        #endregion

        #region ResetControles()
        private void ResetControles()
        {
            try
            {
                TxtDestino.Text = string.Empty;
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region ResetVatiaveis()
        private void ResetVatiaveis()
        {
            try
            {
                id = 0;
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region CallAllReset()
        private void CallAllReset()
        {
            ResetControles();
            ResetVatiaveis();
        }
        #endregion
    }
}
