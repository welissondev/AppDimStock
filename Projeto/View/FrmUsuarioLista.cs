using DimStock.Auxiliary;
using System;
using System.Windows.Forms;
using DimStock.Business;
using DimStock.Properties;

namespace DimStock.View
{
    public partial class FrmUsuarioLista : Form
    {
        #region Propriedades
        private readonly int numeroDeRegistros = 100;
        #endregion

        #region FrmUsuarioLista
        public FrmUsuarioLista()
        {
            InitializeComponent();

            DefinirGridColumn();

            AxlDataGridViewLealt.DefaultLayoutDarkblue(BtnListaUsuario);

            LblDataLong.Text = DateTime.Now.ToLongDateString();

        }
        #endregion

        #region FrmUsuarioLista_Load()
        private void FrmUsuarioLista_Load(object sender, EventArgs e)
        {
            Listar();
        }
        #endregion

        #region BtnNovo_Click()
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            using (FrmUsuarioCadastro usuarioCadastro = new FrmUsuarioCadastro())
            {
                usuarioCadastro.ShowDialog();
            }
        }
        #endregion

        #region BtnAtualizar_Click()
        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }
        #endregion

        #region TimerExecuteConsulta_Tick()
        private void TimerExecuteConsulta_Tick(object sender, EventArgs e)
        {
            PicCarregando.Visible = false;
            TimerExecuteConsulta.Enabled = false;
            Filtrar();
        }
        #endregion

        #region TxtBuscar_KeyPress()
        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            TimerExecuteConsulta.Enabled = false;
            TimerExecuteConsulta.Enabled = true;
            PicCarregando.Visible = true;
        }
        #endregion

        #region GridListaUsuario_CellMouseClick()
        private void GridListaUsuario_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var columnName = BtnListaUsuario.Columns[e.ColumnIndex].Name;

                if (BtnListaUsuario.Rows.Count > 0)
                {

                    int id = Convert.ToInt32(BtnListaUsuario.CurrentRow.Cells["idColumn"].Value);

                    if (columnName == "btnDeletarColumn")
                    {

                        Deletar(id);
                    }
                    else if (columnName == "btnEditarColumn")
                    {
                        Visualizar(id);
                    }
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region GridListaUsuario_CellMouseMove()
        private void GridListaUsuario_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var columnIndexName = BtnListaUsuario.Columns[e.ColumnIndex].Name;
                if (columnIndexName == "btnEditarColumn" || columnIndexName == "btnDeletarColumn")
                {
                    BtnListaUsuario.Cursor = Cursors.Hand;
                }
                else
                {
                    BtnListaUsuario.Cursor = Cursors.Arrow;
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion 

        #region Listar()
        private void Listar()
        {
            try
            {
                BtnListaUsuario.Rows.Clear();

                BllUsuario usuario = new BllUsuario();
                usuario.Listar(numeroDeRegistros);

                for (int item = 0; item < usuario.Lista.Count; item++)
                {
                    BtnListaUsuario.Rows.Add(
                    usuario.Lista[item].Id,
                    usuario.Lista[item].Nome,
                    usuario.Lista[item].Email);
                }

                AxlDataGridViewLealt.SortcolumnDesc(BtnListaUsuario, 0);
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region Visualizar()
        public void Visualizar(int id)
        {
            try
            {
                BllUsuario usuario = new BllUsuario();
                usuario.VisualizarDados(id);

                using (FrmUsuarioCadastro frm = new FrmUsuarioCadastro(usuario.Id))
                {
                    frm.TxtNome.Text = usuario.Nome;
                    frm.TxtEmail.Text = usuario.Email;
                    frm.TxtEmail.Enabled = false;
                    frm.TxtLogin.Text = usuario.Login;
                    frm.TxtLogin.Enabled = false;
                    frm.TxtSenha.Text = usuario.Senha;
                    frm.TxtConfirmarSenha.Text = usuario.Senha;
                    frm.ChkPermissaoCadastrar.Checked = usuario.PermissaoCadastrar;
                    frm.ChkPermissaoEditar.Checked = usuario.PermissaoEditar;
                    frm.ChkPermissaoDeletar.Checked = usuario.PermissaoDeletar;
                    frm.ChkPermissaoVisualizar.Checked = usuario.PermissaoVisualizar;
                    frm.ChkPermissaoTodas.Checked = usuario.PermissaoTodas;

                    frm.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion 

        #region Filtrar()
        private void Filtrar()
        {
            try
            {
                BtnListaUsuario.Rows.Clear();

                BllUsuario usuario = new BllUsuario();
                usuario.Consultar(TxtBuscar.Text, numeroDeRegistros);

                for (int item = 0; item < usuario.Lista.Count; item++)
                {
                    BtnListaUsuario.Rows.Add(
                    usuario.Lista[item].Id,
                    usuario.Lista[item].Nome,
                    usuario.Lista[item].Email);
                }

                AxlDataGridViewLealt.SortcolumnDesc(BtnListaUsuario, 0);
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region Deletar()
        private void Deletar(int id)
        {
            try
            {
                if (MessageBox.Show("Confirma essa operação?", "CONFIRME", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    BllUsuario usuario = new BllUsuario();

                    if(usuario.Deletar(id) == true)
                    {
                        MessageBox.Show(BllNotificar.Message, "SUCESSO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        #region DefinirGridColumn()
        private void DefinirGridColumn()
        {
            try
            {
                DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn nomeColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn emailColumn = new DataGridViewTextBoxColumn();
                DataGridViewImageColumn btnEditarColumn = new DataGridViewImageColumn();
                DataGridViewImageColumn btnDeletarColumn = new DataGridViewImageColumn();

                DataGridView dtg = BtnListaUsuario;

                dtg.Columns.Add(idColumn);
                dtg.Columns[0].Name = "idColumn";
                dtg.Columns[0].HeaderText = "ID";
                dtg.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[0].ReadOnly = false;
                dtg.Columns[0].Visible = false;

                dtg.Columns.Add(nomeColumn);
                dtg.Columns[1].Width = 250;
                dtg.Columns[1].Name = "nomeColumn";
                dtg.Columns[1].HeaderText = "Nome";
                dtg.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dtg.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dtg.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtg.Columns[1].ReadOnly = true;

                dtg.Columns.Add(emailColumn);
                dtg.Columns[2].Name = "emailColumn";
                dtg.Columns[2].HeaderText = "Email";
                dtg.Columns[2].ReadOnly = true;
                dtg.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dtg.Columns.Add(btnEditarColumn);
                btnEditarColumn.Image = Resources.Editar;
                btnEditarColumn.ToolTipText = "Editar";
                btnEditarColumn.ImageLayout = DataGridViewImageCellLayout.Normal;
                dtg.Columns[3].Name = "btnEditarColumn";
                dtg.Columns[3].HeaderText = "";
                dtg.Columns[3].Width = 70;
                dtg.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[3].ReadOnly = true;

                dtg.Columns.Add(btnDeletarColumn);
                btnDeletarColumn.ToolTipText = "Deletar";
                btnDeletarColumn.Image = Resources.Deletar;
                btnDeletarColumn.ImageLayout = DataGridViewImageCellLayout.Normal;
                dtg.Columns[4].Name = "btnDeletarColumn";
                dtg.Columns[4].HeaderText = "";
                dtg.Columns[4].Width = 70;
                dtg.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[4].ReadOnly = true;

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion
    }
}
