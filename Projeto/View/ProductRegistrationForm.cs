﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using DimStock.Business;
using DimStock.Auxiliary;
using DimStock.Properties;
using System.IO;

namespace DimStock.View
{
    public partial class ProductRegistrationForm : Form
    {
        #region Get & Set

        public int Id { get; set; }

        #endregion

        #region Variables

        private ProductPhoto productPhoto = new ProductPhoto();

        #endregion 

        #region Constructs

        public ProductRegistrationForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Button

        private void RegisterNew_Click(object sender, EventArgs e)
        {
            var user = new User();
            user.ViewDetails(LoginAssistant.Id);

            if (Id == 0)
            {
                if (user.PermissionToRegister == false)
                {
                    MessageBox.Show("Você não tem permissão para cadastrar!", "NÃO PERMITIDO",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                Register();
            }

            if (Id > 0)
            {
                if (user.PermissionToEdit == false)
                {
                    MessageBox.Show("Você não tem permissão para editar!", "NÃO PERMITIDO",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                Edit();
            };
        }

        private void ClearFields_Click(object sender, EventArgs e)
        {
            CallAllResets();
        }

        #endregion

        #region PictureBox

        private void ProductPhoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (UploadPhoto() == false)
                {
                    if (productPhoto.FindInDirectory(productPhoto.GetDirectoryPeth() +
                        ProductPhoto.IndentificationPhotoNumber).Equals(false))
                    {
                        ProductPhoto.IndentificationPhotoNumber = "";
                        ProductPhoto.SelectedDirectory = "";
                        ProductPhoto.Image = Resources.FotoNothing;
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }

        #endregion

        #region MethodsAuxiliarys

        private void Register()
        {
            try
            {
                if (ValidateData() == false)
                {
                    return;
                }

                var product = new Product
                {
                    Code = Convert.ToInt32(ProductCode.Text),
                    Size = Convert.ToInt32(ProductSize.Text),
                    Reference = Convert.ToInt32(ProductReference.Text),
                    Supplier = Supplier.Text,
                    Description = Description.Text,
                    MinStock = Convert.ToInt32(MinStock.Text),
                    MaxStock = Convert.ToInt32(MaxStock.Text),
                    CostPrice = Convert.ToDouble(CostPrice.DecimalValue),
                    SalePrice = Convert.ToDouble(SalePrice.DecimalValue),
                    BarCode = BarCode.Text,
                    PhotoName = ProductPhoto.IndentificationPhotoNumber
                };

                if (product.Register() == false)
                {
                    MessageBox.Show(MessageNotifier.Message, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }

                productPhoto.CopyToDirectory(ProductPhoto.SelectedDirectory,
                productPhoto.GetDirectoryPeth() + product.PhotoName);

                MessageBox.Show(MessageNotifier.Message, "SUCESSO",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                CallAllResets();
            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }

        private void Edit()
        {
            try
            {
                if (ValidateData() == false)
                {
                    return;
                }

                var product = new Product()
                {
                    Code = Convert.ToInt32(ProductCode.Text),
                    Size = Convert.ToInt32(ProductSize.Text),
                    Reference = Convert.ToInt32(ProductReference.Text),
                    Supplier = Supplier.Text,
                    Description = Description.Text,
                    MinStock = Convert.ToInt32(MinStock.Text),
                    MaxStock = Convert.ToInt32(MaxStock.Text),
                    CostPrice = Convert.ToDouble(CostPrice.DecimalValue),
                    SalePrice = Convert.ToDouble(SalePrice.DecimalValue),
                    BarCode = BarCode.Text,
                    PhotoName = ProductPhoto.IndentificationPhotoNumber,
                };

                if (product.Edit(Id) == false)
                {
                    MessageBox.Show(MessageNotifier.Message, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }

                var photoPath = productPhoto.GetDirectoryPeth()
                + product.PhotoName;

                //Apaga a foto atual do diretório, caso a foto do produto
                //seja alterada
                if (productPhoto.FindInDirectory(photoPath) == false)
                    productPhoto.DeleteFromDirectory(
                    ProductPhoto.PathOfLastSelectedPhoto);

                productPhoto.CopyToDirectory(ProductPhoto.SelectedDirectory,
                photoPath);

                MessageBox.Show(MessageNotifier.Message, "SUCESSO",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }

        private bool ValidateData()
        {

            if (ProductCode.Text == string.Empty)
            {
                MessageBox.Show("Campo código produto é obrigatório!",
                "OBRIGATÓRIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                ProductCode.Select();

                return false;
            }

            if (ProductSize.Text == string.Empty)
            {
                MessageBox.Show("Campo tamanho é obrigatório!", "OBRIGATÓRIO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                ProductSize.Select();

                return false;
            }

            if (ProductReference.Text == string.Empty)
            {
                MessageBox.Show("Campo código estampa é obrigatório!", "OBRIGATÓRIO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                ProductReference.Select();

                return false;
            }

            if (Description.Text == string.Empty)
            {
                MessageBox.Show("Campo descrição é obrigatório!", "OBRIGATÓRIO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                Description.Select();

                return false;
            }

            if (MinStock.Text == string.Empty)
            {
                MessageBox.Show("Quantidade mínima obrigatória!", "OBRIGATÓRIO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                MinStock.Select();

                return false;
            }

            if (MaxStock.Text == string.Empty)
            {
                MessageBox.Show("Quantidade máxima obrigatória!", "OBRIGATÓRIO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                MaxStock.Select();

                return false;
            }

            if (Convert.ToInt32(MinStock.Text) > Convert.ToInt32(MaxStock.Text))
            {
                MessageBox.Show("Quantidade mínima não pode ser maior que quantidade máxima!", "OBRIGATÓRIO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                MaxStock.Select();

                return false;

            }

            return true;
        }

        private bool UploadPhoto()
        {
            var picture = new ImageAssistant();
            var uploadState = false;

            picture.OpenFileDialog();

            if (picture.DirectoryFile != string.Empty)
            {
                using (var fileStream = new FileStream(picture.DirectoryFile,
                FileMode.Open, FileAccess.Read))
                {
                    ProductPhoto.Image = Image.FromStream(fileStream);
                    ProductPhoto.IndentificationPhotoNumber = productPhoto.GetIndentificationNumber() + ".jpg";
                    ProductPhoto.SelectedDirectory = picture.DirectoryFile;

                    uploadState = true;
                }
            }

            return uploadState;
        }

        public void ReloadPhoto(string photoIdNumber, bool newIdNumber = false)
        {
            var photoPath = productPhoto.GetDirectoryPeth() + photoIdNumber;

            if (productPhoto.FindInDirectory(photoPath) == false)
            {
                ProductPhoto.Image = Resources.FotoNothing;
                return;
            }

            using (var fileStream = new FileStream(photoPath, FileMode.Open, FileAccess.Read))
            {
                ProductPhoto.Image = Image.FromStream(fileStream);
                ProductPhoto.SelectedDirectory = photoPath;
                ProductPhoto.PathOfLastSelectedPhoto = photoPath;
                ProductPhoto.IndentificationPhotoNumber = photoIdNumber;

                if (newIdNumber == true)
                {
                    photoIdNumber = productPhoto.GetIndentificationNumber() + ".jpg";
                    ProductPhoto.IndentificationPhotoNumber = photoIdNumber;
                }

            }
        }

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
                        ctl.Text = string.Empty;
                    }
                }

                ProductPhoto.Image = Resources.FotoNothing;
                ProductPhoto.IndentificationPhotoNumber = string.Empty;
                ProductPhoto.SelectedDirectory = string.Empty;
                ProductPhoto.PathOfLastSelectedPhoto = string.Empty;

                ProductCode.Select();
            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }

        private void ResetVariables()
        {
            Id = 0;
        }

        private void CallAllResets()
        {
            ResetControls();
            ResetVariables();
        }

        #endregion
    }
}


