using Syncfusion.Windows.Forms.Tools;
using SysEstoque.Auxiliary;
using SysEstoque.Business;
using SysEstoque.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SysEstoque.View
{
    public partial class FrmEstoqueAtividade : Form
    {
        #region Propriedades
        public string TipoAtividade { get; set; }
        public int IdEstoqueAtividade { get; set; }

        private string situcaoAtividade;
        private int idEstoque;
        private int idProduto;
        private int quantidadeEstoque;
        #endregion

        #region Construtores
        public FrmEstoqueAtividade()
        {

            InitializeComponent();

            DefinirColunasGridListaItens();
        }
        #endregion

        #region FrmEstoqueAtividade_Load
        private void FrmEstoqueAtividade_Load(object sender, EventArgs e)
        {
            LblDataLong.Text = DateTime.Now.ToLongDateString();
        }
        #endregion 

        #region FrmEstoqueAtividade_Resize()
        private void FrmEstoqueAtividade_Resize(object sender, EventArgs e)
        {
            try
            {
                // Centraliza image gif carregando no formulário
                PicCarregando.Left = GridListaPrincipal.Width / 2 - PicCarregando.Width / 2;
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
            TimerExecultaConsulta.Enabled = false;
            TimerExecultaConsulta.Enabled = true;
        }
        #endregion 

        #region TxtQuantidade_KeyPress()
        private void TxtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            CalcularTotal();
        }
        #endregion

        #region TxtValorUnitario_KeyPress()
        private void TxtValorUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            CalcularTotal();
        }
        #endregion 

        #region TimerExecultaConsulta_Tick()
        private void TimerExecultaConsulta_Tick(object sender, EventArgs e)
        {
            PicCarregando.Visible = false;
            TimerExecultaConsulta.Enabled = false;
            FiltrarEstoqueProduto();
        }
        #endregion

        #region BtnNovaAtividade_Click
        private void BtnNovaAtividade_Click(object sender, EventArgs e)
        {
            try
            {
                if (AdicionarAtividade() == true)
                {
                    GetDetalhesAtividade(IdEstoqueAtividade);
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region BtnAdcionarItem_Click()
        private void BtnAdcionarItem_Click(object sender, EventArgs e)
        {
            if (TxtSituacao.Text != "Finalizada")
            {
                AdicionarItem();
            }
        }
        #endregion

        #region BtnConfirmar_Click()
        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            AdicionarEstoque();
        }
        #endregion

        #region LblCadastrarNovo_LinkClicked()
        private void LblCadastrarNovo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var frm = new FrmEstoqueDestinoCadastro();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion 

        #region BtnDeletarAtividade_Click()
        private void BtnDeletarAtividade_Click(object sender, EventArgs e)
        {
            DeletarAtividade();
        }
        #endregion

        #region GridListaPrincipal_DoubleClick()
        private void GridListaPrincipal_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (GridListaPrincipal.ListTypeEstoque.Equals(true))
                {
                    idProduto = Convert.ToInt32(GridListaPrincipal.CurrentRow.Cells["idProdutoColumn"].Value);
                    GetEstoqueProduto(idProduto);
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region GridListaPrincipal_CellClick()
        private void GridListaPrincipal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var columnName = GridListaPrincipal.Columns[e.ColumnIndex].Name;

                if (columnName == "btnDeleteItemColumn")
                {
                    int id = Convert.ToInt32(GridListaPrincipal.CurrentRow.Cells["idItemColumn"].Value);
                    DeletarItem(id);
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region GridListaPrincipal_RowPrePaint()
        private void GridListaPrincipal_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //Remove o focus do controle datagriview
            e.PaintParts = DataGridViewPaintParts.All ^ DataGridViewPaintParts.Focus;
        }
        #endregion

        #region LblLimpar_LinkClicked()
        private void LblLimpar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LimparBuscas();
            ListEstoqueItens();
        }
        #endregion

        #region CboEstoqueDestino_DropDown()
        private void CboEstoqueDestino_DropDown(object sender, EventArgs e)
        {
            ListaEstoqueDestino();
        }
        #endregion

        #region CboEstoqueDestino_SelectedIndexChanged()
        private void CboEstoqueDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (situcaoAtividade == "Em Aberto")
                {
                    var atividade = new BllEstoqueAtividade();
                    atividade.Destino = ((ComboBox)sender).SelectedItem.ToString();

                    atividade.AdicionarDestino(IdEstoqueAtividade);
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion


        /// <summary>
        /// -----------------------------------------------------------------------------
        /// </summary>

        #region FiltrarEstoqueProduto()
        private void FiltrarEstoqueProduto()
        {
            try
            {
                BllStockProduct estoqueProduto = new BllStockProduct();

                estoqueProduto.Filter(TxtBuscarCodigo.Text, TxtBuscarTamanho.Text,
                TxtBuscarReferencia.Text, TxtBuscarDescricao.Text, 100);

                GridListaPrincipal.Columns.Clear();

                DefinirColunasGridListaEstoque();

                for (var item = 0; item < estoqueProduto.ListOfRecords.Count; item++)
                {
                    GridListaPrincipal.Rows.Add(
                    estoqueProduto.ListOfRecords[item].StockId,
                    estoqueProduto.ListOfRecords[item].ProductId,
                    estoqueProduto.ListOfRecords[item].ProductCode,
                    estoqueProduto.ListOfRecords[item].ProductDescription,
                    estoqueProduto.ListOfRecords[item].ProductCostPrice
                    );

                    var diretorioFotoProduto = BllProdutoFoto.PegarCaminho() + estoqueProduto.ListOfRecords[item].ProductPhotoName;
                    if (BllProdutoFoto.EncontrarArquivo(diretorioFotoProduto).Equals(true))
                    {
                        using (FileStream file = new FileStream(diretorioFotoProduto, FileMode.Open, FileAccess.Read))
                        {
                            GridListaPrincipal.Rows[item].Cells["fotoProdutoColumn"].Value = Image.FromStream(file);
                        }
                    }
                }

                GridListaPrincipal.Visible = true;

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region DefinirColunasGridListaEstoque()
        private void DefinirColunasGridListaEstoque()
        {
            try
            {

                DataGridViewTextBoxColumn idEstoqueColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn idProdutoColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn codigoProdutoColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn descricaoProdutoColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn precoCustoProdutoColumn = new DataGridViewTextBoxColumn();
                DataGridViewImageColumn fotoProdutoColumn = new DataGridViewImageColumn();

                var dtg = GridListaPrincipal;
                dtg.ListTypeEstoque = true;

                if (TipoAtividade == "Entrada")
                {
                    AxlDataGridViewLealt.DefaultLayoutDarkblue(dtg);
                }
                else
                {
                    AxlDataGridViewLealt.DefaultLayoutDarkblue(dtg);
                }

                dtg.Columns.Add(idEstoqueColumn);
                dtg.Columns[0].Width = 100;
                dtg.Columns[0].Name = "idEstoqueColumn";
                dtg.Columns[0].HeaderText = "ID ESTOQUE";
                dtg.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[0].Visible = false;

                dtg.Columns.Add(idProdutoColumn);
                dtg.Columns[1].Width = 100;
                dtg.Columns[1].Name = "idProdutoColumn";
                dtg.Columns[1].HeaderText = "ID PRODUTO";
                dtg.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[1].Visible = false;

                dtg.Columns.Add(codigoProdutoColumn);
                dtg.Columns[2].Width = 80;
                dtg.Columns[2].Name = "codigoProdutoColumn";
                dtg.Columns[2].HeaderText = "CÓDIGO PRODUTO";
                dtg.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[2].ReadOnly = true;

                dtg.Columns.Add(descricaoProdutoColumn);
                dtg.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtg.Columns[3].Name = "descricaoProdutoColumn";
                dtg.Columns[3].HeaderText = "DESCRIÇÃO PRODUTO";
                dtg.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dtg.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dtg.Columns[3].ReadOnly = true;

                dtg.Columns.Add(precoCustoProdutoColumn);
                dtg.Columns[4].Name = "precoCustoProdutoColumn";
                dtg.Columns[4].HeaderText = "PREÇO CUSTO";
                dtg.Columns[4].DefaultCellStyle.Format = "c2";
                dtg.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dtg.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dtg.Columns[4].ReadOnly = true;

                dtg.Columns.Add(fotoProdutoColumn);
                fotoProdutoColumn.Image = Resources.FotoNothing;
                fotoProdutoColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dtg.Columns[5].Name = "fotoProdutoColumn";
                dtg.Columns[5].HeaderText = "FOTO";
                dtg.Columns[5].Width = 40;
                dtg.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[5].DisplayIndex = 0;
                dtg.Columns[5].ReadOnly = true;
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region DefinirColunasGridListaItens()
        private void DefinirColunasGridListaItens()
        {
            try
            {
                DataGridViewTextBoxColumn idItemColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn idEstoqueColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn codigoProdutoColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn descricaoProdutoColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn quantidadeColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn precoCustoProdutoColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn valorTotalColumn = new DataGridViewTextBoxColumn();
                DataGridViewImageColumn btnDeleteItemColumn = new DataGridViewImageColumn();

                var dtg = GridListaPrincipal;
                dtg.ListTypeItem = true;
                AxlDataGridViewLealt.DefaultLayoutDarkblue(dtg);

                dtg.Columns.Add(idItemColumn);
                dtg.Columns[0].Width = 100;
                dtg.Columns[0].Name = "idItemColumn";
                dtg.Columns[0].HeaderText = "ID ITEM";
                dtg.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dtg.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dtg.Columns[0].ReadOnly = true;
                dtg.Columns[0].Visible = false;

                dtg.Columns.Add(idEstoqueColumn);
                dtg.Columns[1].Width = 100;
                dtg.Columns[1].Name = "idEstoqueColumn";
                dtg.Columns[1].HeaderText = "ID ESTOQUE";
                dtg.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dtg.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dtg.Columns[1].ReadOnly = true;
                dtg.Columns[1].Visible = false;

                dtg.Columns.Add(codigoProdutoColumn);
                dtg.Columns[2].Width = 80;
                dtg.Columns[2].Name = "codigoProdutoColumn";
                dtg.Columns[2].HeaderText = "CÓDIGO PRODUTO";
                dtg.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[2].ReadOnly = true;

                dtg.Columns.Add(descricaoProdutoColumn);
                dtg.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtg.Columns[3].Name = "descricaoProdutoColumn";
                dtg.Columns[3].HeaderText = "DESCRIÇÃO PRODUTO";
                dtg.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dtg.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dtg.Columns[3].ReadOnly = true;

                dtg.Columns.Add(quantidadeColumn);
                dtg.Columns[4].Width = 50;
                dtg.Columns[4].Name = "quantidadeColumn";
                dtg.Columns[4].HeaderText = "QTD.";
                dtg.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dtg.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dtg.Columns[4].ReadOnly = true;

                dtg.Columns.Add(precoCustoProdutoColumn);
                dtg.Columns[5].Name = "precoCustoProdutoColumn";
                dtg.Columns[5].HeaderText = "VALOR UNI.";
                dtg.Columns[5].DefaultCellStyle.Format = "c2";
                dtg.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dtg.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dtg.Columns[5].ReadOnly = true;

                dtg.Columns.Add(valorTotalColumn);
                dtg.Columns[6].Name = "valorTotalColumn";
                dtg.Columns[6].HeaderText = "VALOR TOTAL";
                dtg.Columns[6].DefaultCellStyle.Format = "c2";
                dtg.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dtg.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dtg.Columns[6].ReadOnly = true;

                dtg.Columns.Add(btnDeleteItemColumn);
                btnDeleteItemColumn.Image = Resources.deletar2;
                btnDeleteItemColumn.ImageLayout = DataGridViewImageCellLayout.Normal;
                dtg.Columns[7].Name = "btnDeleteItemColumn";
                dtg.Columns[7].HeaderText = "";
                dtg.Columns[7].Width = 40;
                dtg.Columns[7].DisplayIndex = 0;
                dtg.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[7].ReadOnly = true;

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region AdicionarItem()
        public void AdicionarItem()
        {
            try
            {
                if (ChecarDadosParaAddItem().Equals(true))
                {
                    BllEstoqueItem estoqueItem = new BllEstoqueItem()
                    {
                        IdEstoqueAtividade = IdEstoqueAtividade,
                        IdEstoque = idEstoque,
                        IdProduto = idProduto,
                        Quantidade = Convert.ToInt32(TxtQuantidade.Text),
                        ValorUnitario = Convert.ToDouble(TxtValorUnitario.Text.Replace("R$", "").Replace("$", "")),
                        ValorTotal = Convert.ToDouble(TxtValorTotal.Text.Replace("R$", "").Replace("$", ""))
                    };

                    estoqueItem.Adicionar();

                    ListEstoqueItens();
                    LimparBuscas();
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region ChecarDadosParaAddItem()
        private bool ChecarDadosParaAddItem()
        {
            if (TxtQuantidade.Text == "" || TxtQuantidade.Text == null || Convert.ToInt32(TxtQuantidade.Text) < 1)
            {
                MessageBox.Show("Informe a quantidade de estoque", "OBRIGATÓRIO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtQuantidade.Select();
                return false;
            }
            else if (Convert.ToDouble(TxtValorUnitario.Text.Replace("R$", "").Replace("$", "")) == 0)
            {
                MessageBox.Show("Informe o valor unitário!", "OBRIGATÓRIO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtValorUnitario.Select();
                return false;
            }
            else if (TipoAtividade == "Saída" && quantidadeEstoque < 1)
            {
                MessageBox.Show("Não é possível adicionar esse produto, " +
                "porque ele não tem estoque!", "SEM ESTOQUE",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }
            else if (TipoAtividade == "Saída" && Convert.ToInt32(TxtQuantidade.Text) > quantidadeEstoque)
            {
                MessageBox.Show("Esse produto não possui estoque suficiente, " +
                "atualize o estoque e tente novamente!", "ESTOQUE BAIXO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }
            else if (ChecarSeItemExiste().Equals(true))
            {
                MessageBox.Show("Esse produto já foi adicionado!", "NÃO PERMITIDO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }
            else
            {
                return true;
            }
        }

        #endregion

        #region AdicionarAtividade()
        public bool AdicionarAtividade()
        {
            var estoqueAtividade = new BllEstoqueAtividade();
            var atividadeState = false;

            if (TipoAtividade == "Entrada")
            {
                estoqueAtividade.Tipo = "Entrada";
            }
            else if (TipoAtividade == "Saída")
            {
                estoqueAtividade.Tipo = "Saída";
            }

            estoqueAtividade.Data = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy"));
            estoqueAtividade.Hora = DateTime.Now.ToString("HH:mm:ss");
            estoqueAtividade.Situacao = "Em Aberto";

            if (estoqueAtividade.Adicionar() == true)
            {
                atividadeState = true;

                //Pega id Atividade
                IdEstoqueAtividade = estoqueAtividade.Id;

            }

            return atividadeState;
        }
        #endregion 

        #region AdicionarEstoque()
        private void AdicionarEstoque()
        {
            try
            {
                if (ValidarParaAddEstoque() == true)
                {
                    List<BllEstoque> listaEstoque = GetGridItens();

                    BllEstoque estoque = new BllEstoque
                    {
                        Id = idEstoque
                    };

                    if (MessageBox.Show("Confirma essa operação?", "CONFIRME", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {

                        if (TipoAtividade == "Entrada")
                        {
                            if (estoque.AdicionarEntradas(listaEstoque, IdEstoqueAtividade) == true)
                            {
                                MessageBox.Show(BllNotificar.Message, "SUCESSO",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                                TxtSituacao.Text = "Finalizada";
                                situcaoAtividade = "Finalizada";
                            }
                        }

                        else if (TipoAtividade == "Saída")
                        {
                            if (estoque.AdicionarSaidas(listaEstoque, IdEstoqueAtividade).Equals(true))
                            {
                                MessageBox.Show(BllNotificar.Message, "SUCESSO",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                                TxtSituacao.Text = "Finalizada";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region ValidarParaAddEstoque()
        private bool ValidarParaAddEstoque()
        {
            if (TxtSituacao.Text == "Finalizada")
            {
                MessageBox.Show("Não é possível realizar essa operação pois a situação do cadastro consta como finalizada!", "NÃO PERMITIDO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (GetGridItens().Count == 0)
            {
                MessageBox.Show("Nenhum estoque foi adicionado para essa operação!", "OBRIGATÓRIO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        #region ChecarSeItemExiste()
        private bool ChecarSeItemExiste()
        {
            try
            {
                bool result = false;

                for (int i = 0; i < GridListaPrincipal.Rows.Count; i++)
                {
                    if (Convert.ToInt32(GridListaPrincipal.Rows[i].Cells["idEstoqueColumn"].Value) == idEstoque)
                    {
                        result = true;
                    }
                }

                return result;

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
                return false;
            }
        }
        #endregion 

        #region GetGridItens()
        private List<BllEstoque> GetGridItens()
        {
            List<BllEstoque> listaEstoque = new List<BllEstoque>();

            for (int item = 0; item < GridListaPrincipal.Rows.Count; item++)
            {

                var idEstoque = GridListaPrincipal.Rows[item].Cells["idEstoqueColumn"].Value;
                var quantidade = GridListaPrincipal.Rows[item].Cells["quantidadeColumn"].Value;
                var valorTotal = GridListaPrincipal.Rows[item].Cells["valorTotalColumn"].Value;

                valorTotal.ToString().Replace("R$", "");
                valorTotal.ToString().Replace("$", "");

                BllEstoque estoqueItem = new BllEstoque()
                {
                    Id = Convert.ToInt32(idEstoque),
                    Quantidade = Convert.ToInt32(quantidade),
                    Valor = Convert.ToDouble(valorTotal)
                };

                listaEstoque.Add(estoqueItem);
            }

            return listaEstoque;
        }
        #endregion 

        #region GetEstoqueProduto()
        private void GetEstoqueProduto(int id)
        {
            BllStockProduct estoqueProduto = new BllStockProduct();
            estoqueProduto.ViewData(id);

            TxtBuscarCodigo.Text = estoqueProduto.ProductCode;
            TxtBuscarTamanho.Text = estoqueProduto.ProductSize;
            TxtBuscarReferencia.Text = estoqueProduto.ProductReference;
            TxtBuscarDescricao.Text = estoqueProduto.ProductDescription;
            TxtValorUnitario.Text = estoqueProduto.ProductCostPrice.ToString();
            idProduto = estoqueProduto.ProductId;
            idEstoque = estoqueProduto.StockId;
            quantidadeEstoque = estoqueProduto.StockQuantity;
            TxtQuantidade.Text = "0";
            TxtQuantidade.Select();

            GridListaPrincipal.Columns.Clear();
            ListEstoqueItens();
        }

        #endregion

        #region ListEstoqueItens()
        public void ListEstoqueItens()
        {
            try
            {
                BllEstoqueItem estoqueItens = new BllEstoqueItem();

                estoqueItens.Listar(IdEstoqueAtividade);

                GridListaPrincipal.Columns.Clear(); DefinirColunasGridListaItens();
                for (int item = 0; item < estoqueItens.Lista.Count; item++)
                {
                    GridListaPrincipal.Rows.Add(
                    estoqueItens.Lista[item].Id,
                    estoqueItens.Lista[item].IdEstoque,
                    estoqueItens.Lista[item].CodigoProduto,
                    estoqueItens.Lista[item].DescricaoProduto,
                    estoqueItens.Lista[item].Quantidade,
                    estoqueItens.Lista[item].ValorUnitario,
                    estoqueItens.Lista[item].ValorTotal
                    );
                }

                var subTotal = estoqueItens.Lista.Sum(item => item.ValorTotal);
                var itensTotal = estoqueItens.Lista.Count;

                TxtSubTotal.Text = subTotal.ToString("c2");
                TxtTotalItens.Text = itensTotal.ToString();

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region ListaEstoqueDestino()
        public void ListaEstoqueDestino()
        {
            try
            {
                var estoqueDestino = new BllEstoqueDestino();
                estoqueDestino.Listar();

                List<string> itens = new List<string>();

                for (int i = 0; i < estoqueDestino.Lista.Count; i++)
                {
                    itens.Add(estoqueDestino.Lista[i].Nome);
                }

                CboEstoqueDestino.DataSource = itens;

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region CalcularTotal()
        private void CalcularTotal()
        {
            try
            {
                int quantidade = Convert.ToInt32(TxtQuantidade.Text);
                double valorUnitario = Convert.ToDouble(TxtValorUnitario.Text.Replace("R$", "").Replace("$", ""));
                double valorTotal = quantidade * valorUnitario;

                TxtValorTotal.Text = valorTotal.ToString();

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion 

        #region LimparBuscas()
        private void LimparBuscas()
        {
            try
            {
                foreach (Control ctl in bunifuCards1.Controls)
                {
                    if (ctl.GetType() == typeof(TextBoxExt))
                        ctl.Text = string.Empty;
                    if (ctl.GetType() == typeof(CurrencyTextBox))
                        ctl.Text = string.Empty;
                    if (ctl.GetType() == typeof(IntegerTextBox))
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

        #region ReseteControles()
        private void ReseteControles()
        {
            GridListaPrincipal.Columns.Clear();
            DefinirColunasGridListaItens();

            TxtTotalItens.Text = "0";
            TxtSubTotal.Text = "R$0,00";
            TxtBuscarCodigo.Select();
        }
        #endregion

        #region DeletarItem()
        private void DeletarItem(int id)
        {
            if (TxtSituacao.Text != "Finalizada")
            {
                BllEstoqueItem estoqueItem = new BllEstoqueItem();
                estoqueItem.Deletar(id);

                ListEstoqueItens();
            }
        }
        #endregion

        #region DeletarAtividade()
        private void DeletarAtividade()
        {
            try
            {
                if (IdEstoqueAtividade > 0 && situcaoAtividade == "Finalizada")
                {
                    if (MessageBox.Show("Confirma essa operação?", "CONFIRME", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        BllEstoqueAtividade atividade = new BllEstoqueAtividade();

                        if (atividade.Deletar(IdEstoqueAtividade) == true)
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
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region GetDetalhesAtividade()
        public void GetDetalhesAtividade(int id)
        {
            try
            {
                var estoqueAtividade = new BllEstoqueAtividade();
                estoqueAtividade.GetDetalhesAtividade(id);

                TxtAtividadeNumero.Text = id.ToString();
                TxtAtividadeTipo.Text = estoqueAtividade.Tipo;
                TxtData.Text = Convert.ToString(estoqueAtividade.Data.ToString("dd-MM-yyyy"));
                TxtHorario.Text = estoqueAtividade.Hora;
                TxtSituacao.Text = estoqueAtividade.Situacao;

                ListaEstoqueDestino();
                if (estoqueAtividade.Destino != "" || estoqueAtividade.Destino != null)
                    CboEstoqueDestino.Text = estoqueAtividade.Destino;

                //Passa para variáveis no scopo
                IdEstoqueAtividade = id;
                TipoAtividade = estoqueAtividade.Tipo;
                situcaoAtividade = estoqueAtividade.Situacao;

                if (estoqueAtividade.Tipo == "Entrada")
                {
                    LblCaptionAtividade.Text = "Entrada de Estoque";
                }
                else
                {
                    LblCaptionAtividade.Text = "Saída de Estoque";
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        #endregion

    }
}
