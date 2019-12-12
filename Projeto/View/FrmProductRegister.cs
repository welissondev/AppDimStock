using System;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using DimStock.Business;
using DimStock.Auxiliary;
using DimStock.Properties;
using System.IO;

namespace DimStock.View
{
    public partial class FrmProductRegister : Form
    {
        #region Variables

        int id = 0;

        public int Id { get => id; set => id = value; }
        #endregion

        #region Constructs

        #region FrmProductRegister()
        public FrmProductRegister()
        {
            InitializeComponent();

            LblTodayIsDay.Text = DateTime.Now.ToLongDateString();
        }

        #endregion

        #endregion

        #region Button

        #region BtnSave_Click()
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (Id == 0)
            {
                if (AxlLogin.PermissionToRegister == false)
                {
                    MessageBox.Show("Você não tem permissão para cadastrar produtos!", "NÃO PERMITIDO",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Register();
                }
            }
            else if (id > 0)
            {
                if (AxlLogin.PermissionToEdit == false)
                {
                    MessageBox.Show("Você não tem permissão para alterar produtos!", "NÃO PERMITIDO",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Edit();
                }
            };
        }
        #endregion

        #region BtnClear_Click()
        private void BtnClear_Click(object sender, EventArgs e)
        {
            CallAllResets();
        }
        #endregion

        #endregion

        #region PictureBox

        #region PicProductPhoto_Click()
        private void PicProductPhoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (UploadPhoto() == false)
                {
                    if (BllProductPhotho.FindFile(BllProductPhotho.GetPeth() + PicProductPhoto.FotoNome).Equals(false))
                    {
                        PicProductPhoto.FotoNome = "";
                        PicProductPhoto.ArquivoDiretorioSelecionado = "";
                        PicProductPhoto.Image = Resources.FotoNothing;
                    }
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #endregion

        #region Methods

        #region ValidateInputData()
        private bool ValidateInputData()
        {
            if (TxtCode.Text == string.Empty)
            {
                MessageBox.Show("Campo código produto é obrigatório!", 
                "OBRIGATÓRIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                TxtCode.Select();

                return false;
            }

            else if (TxtSize.Text == string.Empty)
            {
                MessageBox.Show("Campo tamanho é obrigatório!", "OBRIGATÓRIO", 
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                TxtSize.Select();

                return false;
            }

            else if (TxtReference.Text == string.Empty)
            {
                MessageBox.Show("Campo código estampa é obrigatório!", "OBRIGATÓRIO", 
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                TxtReference.Select();
                
                return false;
            }

            else if (TxtDescription.Text == string.Empty)
            {
                MessageBox.Show("Campo descrição é obrigatório!", "OBRIGATÓRIO", 
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                TxtDescription.Select();

                return false;
            }

            else if (TxtMinStock.Text == string.Empty)
            {
                MessageBox.Show("Quantidade mínima obrigatória!", "OBRIGATÓRIO", 
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                TxtMinStock.Select();

                return false;
            }
            else if (TxtMaxStock.Text == string.Empty)
            {
                MessageBox.Show("Quantidade máxima obrigatória!", "OBRIGATÓRIO", 
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                TxtMaxStock.Select();
                
                return false;
            }

            else if (Convert.ToInt32(TxtMinStock.Text) > Convert.ToInt32(TxtMaxStock.Text))
            {
                MessageBox.Show("Quantidade mínima não pode ser maior que quantidade máxima!", "OBRIGATÓRIO", 
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                TxtMaxStock.Select();
                
                return false;
            }

            else
            {
                return true;
            }
        }
        #endregion 

        #region Register()
        private void Register()
        {
            try
            {
                if (ValidateInputData() == false)
                {
                    return;
                }
                {
                    var product = new BllProduct
                    {
                        Code = Convert.ToInt32(TxtCode.Text),
                        Size = Convert.ToInt32(TxtSize.Text),
                        Reference = Convert.ToInt32(TxtReference.Text),
                        Supplier = TxtSupplier.Text,
                        Description = TxtDescription.Text,
                        MinStock = Convert.ToInt32(TxtMinStock.Text),
                        MaxStock = Convert.ToInt32(TxtMaxStock.Text),
                        CostPrice = Convert.ToDouble(TxtCostPrice.Text.Replace("R$", "").Replace("$", "")),
                        SalePrice = Convert.ToDouble(TxtSalePrice.Text.Replace("R$", "").Replace("$", "")),
                        BarCode = TxtBarCode.Text,
                        PhotoName = PicProductPhoto.FotoNome
                    };

                    if (product.Register() == true)
                    {
                        BllProductPhotho.CopyToDirectory(PicProductPhoto.ArquivoDiretorioSelecionado,
                        product.FolderDirectoryOfPhothos + product.PhotoName);

                        MessageBox.Show(BllNotification.Message, "SUCESSO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        CallAllResets();
                    }
                    else
                    {
                        MessageBox.Show(BllNotification.Message, "ATENÇÃO",
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

        #region Edit()
        private void Edit()
        {
            try
            {
                if (ValidateInputData() == false)
                {
                    return;
                }
                else
                {
                    var product = new BllProduct()
                    {
                        Code = Convert.ToInt32(TxtCode.Text),
                        Size = Convert.ToInt32(TxtSize.Text),
                        Reference = Convert.ToInt32(TxtReference.Text),
                        Supplier = TxtSupplier.Text,
                        Description = TxtDescription.Text,
                        MinStock = Convert.ToInt32(TxtMinStock.Text),
                        MaxStock = Convert.ToInt32(TxtMaxStock.Text),
                        CostPrice = Convert.ToDouble(TxtCostPrice.Text.Replace("R$", "").Replace("$", "")),
                        SalePrice = Convert.ToDouble(TxtSalePrice.Text.Replace("R$", "").Replace("$", "")),
                        BarCode = TxtBarCode.Text,
                        PhotoName = PicProductPhoto.FotoNome,
                    };

                    if (product.Edit(id) == true)
                    {

                        if (BllProductPhotho.FindFile(product.FolderDirectoryOfPhothos
                        + product.PhotoName).Equals(false)) BllProductPhotho.DeleteFile(PicProductPhoto.UltimaFoto);

                        BllProductPhotho.CopyToDirectory(PicProductPhoto.ArquivoDiretorioSelecionado,
                        product.FolderDirectoryOfPhothos + product.PhotoName);

                        MessageBox.Show(BllNotification.Message, "SUCESSO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region UploadPhoto()
        private bool UploadPhoto()
        {

            var image = new AxlImage();

            image.OpenFileDialog();

            if (image.DirectoryFile != "")
            {
                using (var file = new FileStream(image.DirectoryFile, FileMode.Open, FileAccess.Read))
                {
                    PicProductPhoto.Image = Image.FromStream(file);
                    PicProductPhoto.FotoNome = BllProductPhotho.GetGuid() + ".jpg";
                    PicProductPhoto.ArquivoDiretorioSelecionado = image.DirectoryFile;

                    return true;
                }
            }

            return false;
        }
        #endregion

        #region ReloadPhoto()
        public void ReloadPhoto(string photoName, bool newGuid = false)
        {
            var photoDirectoryPath = BllProductPhotho.GetPeth() + photoName;

            if (BllProductPhotho.FindFile(photoDirectoryPath).Equals(true))
            {
                using (var file = new FileStream(photoDirectoryPath, FileMode.Open, FileAccess.Read))
                {
                    PicProductPhoto.Image = Image.FromStream(file);
                    PicProductPhoto.ArquivoDiretorioSelecionado = photoDirectoryPath;
                    PicProductPhoto.UltimaFoto = photoDirectoryPath;

                    if (newGuid.Equals(true)) photoName = BllProductPhotho.GetGuid() + ".jpg";
                    PicProductPhoto.FotoNome = photoName;
                }
            }
            else
            {
                PicProductPhoto.Image = Resources.FotoNothing;
            }
        }
        #endregion 

        #region ResetControls()
        private void ResetControls()
        {
            try
            {
                foreach (Control ctl in Controls)
                {
                    if (ctl.GetType() == typeof(TextBoxExt))
                    {
                        ctl.Text = string.Empty;
                    }
                    else if (ctl.GetType() == typeof(CurrencyTextBox))
                    {
                        ctl.Text = string.Empty;
                    }
                    else if (ctl.GetType() == typeof(IntegerTextBox))
                    {
                        ctl.Text = "";
                    }
                }

                PicProductPhoto.Image = Resources.FotoNothing;
                PicProductPhoto.FotoNome = "";
                PicProductPhoto.ArquivoDiretorioSelecionado = "";
                PicProductPhoto.UltimaFoto = "";
                TxtCode.Select();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region ResetVariables()
        private void ResetVariables()
        {
            id = 0;
        }
        #endregion

        #region CallAllResets()
        private void CallAllResets()
        {
            ResetControls();
            ResetVariables();
        }
        #endregion

        #endregion
    }
}


