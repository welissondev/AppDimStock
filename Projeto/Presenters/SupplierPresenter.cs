using DimStock.AuxilyTools.AuxilyClasses;
using DimStock.Models;
using DimStock.Views;
using System;

namespace DimStock.Presenters
{
    public class SupplierPresenter
    {
        private ISupplierAddView view;

        public SupplierPresenter(ISupplierAddView view)
        {
            this.view = view;
        }

        public bool Update()
        {
            var actionResult = false;
            var supplier = new SupplierModel();

            supplier.Id = view.Id;
            supplier.TypeOfRegistration = view.TypeOfRegistration;
            supplier.CompyName = view.CompyName;
            supplier.FantasyName = view.FantasyName;
            supplier.IndentyCard_StateRegister = view.IndentyCard_StateRegister;
            supplier.SocialSecurity_NationalRegister = view.SocialSecurity_NationalRegister;
            supplier.Address.Description = view.AddressDescription;
            supplier.Address.District = view.District;
            supplier.Address.City = view.City;
            supplier.Address.StateLocation = view.StateLocation;
            supplier.Address.ZipCode = view.ZipCode;
            supplier.Address.StreetNumber = view.StreetNumber;
            supplier.Contact.FixePhone = view.FixePhone;
            supplier.Contact.MobilePhone = view.MobilePhone;
            supplier.Contact.Email = view.Email;

            //Insert register
            if (view.Id == 0)
            {
                if (supplier.Insert() == true)
                {
                    actionResult = true;
                    Clear();
                }
            }

            //Update register
            if (view.Id > 0)
            {
                if (supplier.Update() == true)
                {
                    actionResult = true;
                }               
            }

            return actionResult;
        }

        public bool Delete()
        {
            var actionResult = false;

            if (new SupplierModel() { Id = view.Id }.Delete() == true)
            {
                actionResult = true;
                Clear();
            }

            return actionResult;
        }

        public void Clear()
        {
            try
            {
                view.Id = 0;
                view.TypeOfRegistration = string.Empty;
                view.CompyName = string.Empty;
                view.FantasyName = string.Empty;
                view.IndentyCard_StateRegister = string.Empty;
                view.SocialSecurity_NationalRegister = string.Empty;
                view.AddressDescription = string.Empty;
                view.District = string.Empty;
                view.City = string.Empty;
                view.StateLocation = string.Empty;
                view.ZipCode = string.Empty;
                view.StreetNumber = 0;
                view.FixePhone = string.Empty;
                view.MobilePhone = string.Empty;
                view.Email = string.Empty;
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
    }
}
