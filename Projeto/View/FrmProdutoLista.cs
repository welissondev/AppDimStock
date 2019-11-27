using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DimStock.Business;
using DimStock.Auxiliary;
using DimStock.Properties;

namespace DimStock.View
{
    public partial class FrmProdutoLista : Form
    {
        #region Propriedades
        public int Id = 0;
        public int NumeroDeRegistros = 100;
        #endregion

        #region FrmProdutoLista()
        public FrmProdutoLista()
        {
            InitializeComponent();
            DefineGridColumns();

            LblDataLong.Text = DateTime.Now.ToLongDateString();

            AxlDataGridViewLealt.DefaultLayoutDarkblue(GridListaProduto);

        }
        #endregion

        #region FrmProdutoLista_Load()
        private void FrmProdutoLista_Load(object sender, EventArgs e)
        {
            Listar();
            ListNumberOfRecords();
            WindowState = FormWindowState.Maximized;
        }
        #endregion

        #region FrmProdutoLista_Resize()
        private void FrmProdutoLista_Resize(object sender, EventArgs e)
        {
            try
            {
                // Centraliza image gif carregando no formulário
                PicCarregando.Left = this.Width / 2 - PicCarregando.Width / 2;
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion 

        #region BtnNovo_Click
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            using (FrmProdutoCadastro frmProdutoAdd = new FrmProdutoCadastro())
            {
                frmProdutoAdd.ShowDialog();
            }
        }
        #endregion

        #region BtnAtualizar_Click()
        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            Listar();
            CallAllResets();
        }
        #endregion

        #region BtnReport_Click()
        private void BtnReport_Click(object sender, EventArgs e)
        {
        }
        #endregion

        #region CboNumeroDeRegistros_SelectedIndexChanged()
        private void CboNumeroDeRegistros_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var itemSelected = CboNumeroDeRegistros.SelectedIndex;

                switch (itemSelected)
                {
                    case 0:
                        NumeroDeRegistros = 10;
                        break;
                    case 1:
                        NumeroDeRegistros = 25;
                        break;
                    case 2:
                        NumeroDeRegistros = 75;
                        break;
                    case 3:
                        NumeroDeRegistros = 100;
                        break;
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region GridListaProduto_Layout()
        private void GridListaProduto_Layout(object sender, LayoutEventArgs e)
        {
            
        }
        #endregion

        #region GridListaProduto_RowPrePaint()
        private void GridListaProduto_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //Remove o focus do controle datagriview
            e.PaintParts = DataGridViewPaintParts.All ^ DataGridViewPaintParts.Focus;
        }
        #endregion

        #region GridListaProduto_CellClick()
        private void GridListaProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridListaProduto.Rows.Count != 0)
            {
                GetGridItens();
            }

            var columnName = GridListaProduto.Columns[e.ColumnIndex].Name;

            if (columnName == "BtnEditarColumn" && e.RowIndex != -1)
            {
                Visualizar();
            }
            else if (columnName == "BtnDeletarColumn" && e.RowIndex != -1)
            {
                Deletar();
            }
            else if (columnName == "BtnReplicarColumn")
            {
                ReplicateRecord();
            }
        }
        #endregion

        #region GridListaProduto_CellMouseMove()
        private void GridListaProduto_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var columnIndexName = GridListaProduto.Columns[e.ColumnIndex].Name;
                if (columnIndexName == "BtnEditarColumn" || columnIndexName == "BtnDeletarColumn" || columnIndexName == "BtnReplicarColumn")
                {
                    GridListaProduto.Cursor = Cursors.Hand;
                }
                else
                {
                    GridListaProduto.Cursor = Cursors.Arrow;
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region GridListaProduto_CellMouseDoubleClick()
        private void GridListaProduto_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Visualizar();
        }
        #endregion

        #region TimeExecutaConsulta_Tick()
        private void TimeExecutaConsulta_Tick(object sender, EventArgs e)
        {
            PicCarregando.Visible = false;
            TimeExecutaConsulta.Enabled = false;

            Filtrar(TxtBuscarCodigo.Text, TxtBuscarTamanho.Text, 
            TxtBuscarReferencia.Text, TxtBuscarDescricao.Text);

        }
        #endregion 

        #region Listar()
        private void Listar()
        {
            try
            {
                
                BllProduto Produto = new BllProduto();

                Produto.Listar(NumeroDeRegistros);

                GridListaProduto.Rows.Clear();

                for (int item = 0; item < Produto.Lista.Count; item++)
                {
                    GridListaProduto.Rows.Add(
                    Produto.Lista[item].Id,
                    Produto.Lista[item].Codigo,
                    Produto.Lista[item].Referencia,
                    Produto.Lista[item].Tamanho,
                    Produto.Lista[item].Fornecedor,
                    Produto.Lista[item].Descricao,
                    Produto.Lista[item].PrecoCusto,
                    Produto.Lista[item].PrecoVenda,
                    Produto.Lista[item].FotoNome);

                    var diretorioFotoProduto = BllProdutoFoto.PegarCaminho() + Produto.Lista[item].FotoNome;
                    ListarFotoNoGrid(GridListaProduto, diretorioFotoProduto, item);
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }

        }
        #endregion

        #region Filtrar()
        private void Filtrar(string codigo, string tamanho, string referencia, string descricao)
        {
            try
            {
                BllProduto produto = new BllProduto();

                produto.Consultar(codigo, tamanho, referencia, descricao, NumeroDeRegistros);

                GridListaProduto.Rows.Clear();

                for (int item = 0; item < produto.Lista.Count; item++)
                {
                    GridListaProduto.Rows.Add(
                    produto.Lista[item].Id,
                    produto.Lista[item].Codigo,
                    produto.Lista[item].Referencia,
                    produto.Lista[item].Tamanho,
                    produto.Lista[item].Fornecedor,
                    produto.Lista[item].Descricao,
                    produto.Lista[item].PrecoCusto,
                    produto.Lista[item].PrecoVenda,
                    produto.Lista[item].FotoNome);

                    var diretorioFotoProduto = produto.PastaDiretorioDasFotos + produto.Lista[item].FotoNome;
                    ListarFotoNoGrid(GridListaProduto, diretorioFotoProduto, item);
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region ExecutaFiltros_KeyPress()
        private void ExecutaFiltros_KeyPress(object sender, KeyPressEventArgs e)
        {
            PicCarregando.Visible = true;
            TimeExecutaConsulta.Enabled = false;
            TimeExecutaConsulta.Enabled = true;
        }

        #endregion

        #region Visualizar()
        private void Visualizar()
        {
            FrmProdutoCadastro frmProdutoAdd = new FrmProdutoCadastro();

            try
            {
                if (Id > 0)
                {
                    BllProduto produto = new BllProduto();

                    produto.VisualizarDados(Id);

                    frmProdutoAdd.Id = Id;
                    frmProdutoAdd.TxtCodigo.Text = produto.Codigo;
                    frmProdutoAdd.TxtCodigo.Enabled = false;
                    frmProdutoAdd.TxtTamanho.Text = produto.Tamanho;
                    frmProdutoAdd.TxtReferencia.Text = produto.Referencia;
                    frmProdutoAdd.TxtFornecedor.Text = produto.Fornecedor;
                    frmProdutoAdd.TxtDescricao.Text = produto.Descricao;
                    frmProdutoAdd.TxtEstoqueMin.Text = produto.EstoqueMin.ToString();
                    frmProdutoAdd.TxtEstoqueMax.Text = produto.EstoqueMax.ToString();
                    frmProdutoAdd.TxtPrecoCusto.Text = produto.PrecoCusto.ToString();
                    frmProdutoAdd.TxtPrecoVenda.Text = produto.PrecoVenda.ToString();
                    frmProdutoAdd.TxtCodigoBarras.Text = produto.CodigoBarras;
                    frmProdutoAdd.RecarregarFoto(produto.FotoNome);
                    frmProdutoAdd.ShowDialog();    
                }
                else
                {
                    MessageBox.Show("Selecione um item para visualizar!", "SELECIONE", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
            finally
            {
                frmProdutoAdd.Dispose();
            }
        }
        #endregion

        #region ListarFotoNoGrid()
        private void ListarFotoNoGrid(DataGridView dataGridView, string diretorioFotoProduto, int item)
        {
            if (BllProdutoFoto.EncontrarArquivo(diretorioFotoProduto) == true)
            {
                using (FileStream file = new FileStream(diretorioFotoProduto, FileMode.Open, FileAccess.Read))
                {
                    dataGridView.Rows[item].Cells["ImgFotoColumn"].Value = Image.FromStream(file);
                }
            }
        }
        #endregion 

        #region ListNumberOfRecords()
        /// <summary>
        /// ListNumberOfRecords() Ou "Listar Número de Registros"
        /// </summary>
        private void ListNumberOfRecords()
        {

            List<string> itens = new List<string>
            {
                "10 Registros",
                "25 Registros",
                "75 Registros",
                "100 Registros"
            };

            CboNumeroDeRegistros.DataSource = itens;
            CboNumeroDeRegistros.Text = "100 Registros";
        }
        #endregion

        #region Deletar()
        private void Deletar()
        {
            try
            {
                if(AxlLogin.PermissaoDeletar == true)
                {
                    if (Id > 0)
                    {
                        if (MessageBox.Show("ATENÇÃO! Exluindo esse registro todas os dados como: Estoque, Entradas, Saidas e etc... " +
                        "também serão deletados, você confirma essa ação?", "IMPORTANTE", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            BllProduto produto = new BllProduto();

                            if (produto.Deletar(Id) == true)
                            {
                                var fotoDiretorioProduto = BllProdutoFoto.PegarCaminho() +
                                Convert.ToString(GridListaProduto.CurrentRow.Cells["NomeFotoColumn"].Value);

                                BllProdutoFoto.DeletarArquivo(fotoDiretorioProduto);

                                MessageBox.Show(BllNotificar.Message, "SUCESSO",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                                CallAllResets();
                            }
                            else
                            {
                                MessageBox.Show(BllNotificar.Message, "ATENÇÃO",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Você não tem permissão para deletar produtos!", "NÃO PERMITIDO",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region ReplicateRecord()
        /// <summary>
        /// ReplicateRecord() Ou "Replicar registro", pega um registro existente e permite a replicação!
        /// </summary>
        private void ReplicateRecord()
        {

            FrmProdutoCadastro frmProdutoAdd = new FrmProdutoCadastro();

            try
            {
                BllProduto produto = new BllProduto();

                produto.VisualizarDados(Id);

                frmProdutoAdd.TxtCodigo.Text = produto.Codigo;
                frmProdutoAdd.TxtTamanho.Text = produto.Tamanho;
                frmProdutoAdd.TxtReferencia.Text = produto.Referencia;
                frmProdutoAdd.TxtFornecedor.Text = produto.Fornecedor;
                frmProdutoAdd.TxtDescricao.Text = produto.Descricao;
                frmProdutoAdd.TxtEstoqueMin.Text = produto.EstoqueMin.ToString();
                frmProdutoAdd.TxtEstoqueMax.Text = produto.EstoqueMax.ToString();
                frmProdutoAdd.TxtPrecoCusto.Text = produto.PrecoCusto.ToString();
                frmProdutoAdd.TxtPrecoVenda.Text = produto.PrecoVenda.ToString();
                frmProdutoAdd.TxtCodigoBarras.Text = produto.CodigoBarras;
                frmProdutoAdd.RecarregarFoto(produto.FotoNome, true);
                frmProdutoAdd.ShowDialog();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
            finally
            {
                frmProdutoAdd.Dispose();
            }
        }
        #endregion

        #region GetGridItens()
        /// <summary>
        /// GetGridItens() Ou "Obter itens da grade"
        /// </summary>
        private void GetGridItens()
        {
            try
            {
                Id = Convert.ToInt32(GridListaProduto.CurrentRow.Cells["IdColumn"].Value);
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region CallAllResets()
        /// <summary>
        /// CallAllResets() Ou "Chamar todas as redefinições", executa todos os métodos de reset da instancia atual
        /// </summary>
        private void CallAllResets()
        {
            ResetVariables();
            ResetControls();
        }

        #endregion

        #region ResetVariables()
        /// <summary>
        /// ResetVariables() Ou "Redefinir variáveis", executa a redefinição das variáveis na instancia atual.
        /// </summary>
        private void ResetVariables()
        {
            Id = 0;
        }
        #endregion

        #region ResetControls()
        /// <summary>
        /// ResetControls() Ou "Redefinir controles", executa rotina para redefinir os objetos da instancia atual.
        /// </summary>
        private void ResetControls()
        {
            try
            {
                foreach (Control ctl in Controls)
                {
                    if (ctl.GetType() == typeof(TextBoxExt))
                        ctl.Text = string.Empty;
                }

                TxtBuscarCodigo.Select();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        #endregion

        #region DefineGridColumns()
        private void DefineGridColumns()
        {
            try
            {
                DataGridViewTextBoxColumn IdColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn CodigoColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn ReferenciaColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn TamanhoColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn FornecedorColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn DescricaoColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn PrecoCustoColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn PrecoVendaColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn NomeFotoColumn = new DataGridViewTextBoxColumn();
                DataGridViewImageColumn BtnEditarColumn = new DataGridViewImageColumn();
                DataGridViewImageColumn BtnDeletarColumn = new DataGridViewImageColumn();
                DataGridViewImageColumn BtnReplicarColumn = new DataGridViewImageColumn();
                DataGridViewImageColumn ImgFotoColumn = new DataGridViewImageColumn();

                DataGridView dtg = GridListaProduto;

                dtg.Columns.Add(IdColumn);
                dtg.Columns[0].Name = "IdColumn";
                dtg.Columns[0].HeaderText = "Id";
                dtg.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[0].Visible = false;
                dtg.Columns[0].ReadOnly = true;

                dtg.Columns.Add(CodigoColumn);
                dtg.Columns[1].Width = 80;
                dtg.Columns[1].Name = "CodigoColumn";
                dtg.Columns[1].HeaderText = "Código";
                dtg.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[1].ReadOnly = true;

                dtg.Columns.Add(ReferenciaColumn);
                dtg.Columns[2].Width = 80;
                dtg.Columns[2].Name = "ReferenciaColumn";
                dtg.Columns[2].HeaderText = "Referência";
                dtg.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[2].ReadOnly = true;

                dtg.Columns.Add(TamanhoColumn);
                dtg.Columns[3].Name = "TamanhoColumn";
                dtg.Columns[3].HeaderText = "Tamanho";
                dtg.Columns[3].Width = 80;
                dtg.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[3].DisplayIndex = 2;
                dtg.Columns[3].ReadOnly = true;
                dtg.Columns[3].Visible = true;

                dtg.Columns.Add(FornecedorColumn);
                dtg.Columns[4].Width = 250;
                dtg.Columns[4].Name = "FornecedorColumn";
                dtg.Columns[4].HeaderText = "Fornecedor";
                dtg.Columns[4].ReadOnly = true;
                dtg.Columns[4].Visible = true;
                dtg.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dtg.Columns.Add(DescricaoColumn);
                dtg.Columns[5].Name = "DescricaoColumn";
                dtg.Columns[5].HeaderText = "Descrição";
                dtg.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtg.Columns[5].ReadOnly = true;

                dtg.Columns.Add(PrecoCustoColumn);
                dtg.Columns[6].Name = "PrecoCustoColumn";
                dtg.Columns[6].HeaderText = "Preço Custo";
                dtg.Columns[6].Width = 80;
                dtg.Columns[6].DefaultCellStyle.Format = "c2";
                dtg.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dtg.Columns[6].ReadOnly = true;

                dtg.Columns.Add(PrecoVendaColumn);
                dtg.Columns[7].Name = "PrecoVendaColumn";
                dtg.Columns[7].HeaderText = "Preço Venda";
                dtg.Columns[7].Width = 80;
                dtg.Columns[7].DefaultCellStyle.Format = "c2";
                dtg.Columns[7].ReadOnly = true;

                dtg.Columns.Add(NomeFotoColumn);
                dtg.Columns[8].Name = "NomeFotoColumn";
                dtg.Columns[8].HeaderText = "Nome da Foto";
                dtg.Columns[8].ReadOnly = true;
                dtg.Columns[8].Visible = false;

                dtg.Columns.Add(ImgFotoColumn);
                ImgFotoColumn.Image = Resources.FotoNothing;
                ImgFotoColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dtg.Columns[9].Name = "ImgFotoColumn";
                dtg.Columns[9].HeaderText = "Foto";
                dtg.Columns[9].Width = 40;
                dtg.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[9].DisplayIndex = 0;
                dtg.Columns[9].ReadOnly = true;

                dtg.Columns.Add(BtnReplicarColumn);
                BtnReplicarColumn.Image = Resources.Duplicar;
                BtnReplicarColumn.ImageLayout = DataGridViewImageCellLayout.Normal;
                dtg.Columns[10].Name = "BtnReplicarColumn";
                dtg.Columns[10].HeaderText = "";
                dtg.Columns[10].Width = 70;
                dtg.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[10].ReadOnly = true;

                dtg.Columns.Add(BtnEditarColumn);
                dtg.Columns[11].Name = "BtnEditarColumn";
                dtg.Columns[11].HeaderText = "";
                dtg.Columns[11].Width = 70;
                dtg.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[11].ReadOnly = true;
                BtnEditarColumn.ImageLayout = DataGridViewImageCellLayout.Normal;
                BtnEditarColumn.Image = Resources.Editar;

                dtg.Columns.Add(BtnDeletarColumn);
                dtg.Columns[12].Name = "BtnDeletarColumn";
                dtg.Columns[12].HeaderText = "";
                dtg.Columns[12].Width = 70;
                dtg.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[12].ReadOnly = true;
                BtnDeletarColumn.ImageLayout = DataGridViewImageCellLayout.Normal;
                BtnDeletarColumn.Image = Resources.Deletar;

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

    }
}


