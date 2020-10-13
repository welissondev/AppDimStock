using DimStock.Models;
using DimStock.Views;

namespace DimStock.Presenters
{
    public class SupplierListingPresenter
    {
        private ISupplierListingView view;

        public SupplierListingPresenter(ISupplierListingView view)
        {
            this.view = view;
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

        public bool GetDetails()
        {
            var actionResult = false;

            var supplier = new SupplierModel() { Id = view.Id };

            if (supplier.GetDetails() == true)
            {
                view.Id = supplier.Id;
                view.TypeOfRegistration = supplier.TypeOfRegistration;
                view.YourName = supplier.YourName;
                view.FantasyName = supplier.FantasyName;
                view.IndentyCard_StateRegister = supplier.IndentyCard_StateRegister;
                view.SocialSecurity_NationalRegister = supplier.SocialSecurity_NationalRegister;
                view.AddressDescription = supplier.Address.Description;
                view.District = supplier.Address.District;
                view.City = supplier.Address.City;
                view.StateLocation = supplier.Address.StateLocation;
                view.ZipCode = supplier.Address.ZipCode;
                view.StreetNumber = supplier.Address.StreetNumber;
                view.FixePhone = supplier.Contact.FixePhone;
                view.MobilePhone = supplier.Contact.MobilePhone;
                view.Email = supplier.Contact.Email;

                actionResult = true;
            }

            return actionResult;
        }

        public void SearchData()
        {
            var supplier = new SupplierModel
            {
                YourName = view.SearchYourName,
                IndentyCard_StateRegister = view.SearchIndentyCard_StateRegister,
                SocialSecurity_NationalRegister = view.SearchSocialSecurity_NationalRegister,
                TypeOfRegistration = view.SearchTypeOfRegistration
            };

            supplier.Contact.Email = view.SearchEmail;

            view.DataList = supplier.SearchData();
        }

        public void Clear()
        {
            view.Id = 0;
            view.TypeOfRegistration = string.Empty;
            view.YourName = string.Empty;
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
            view.SearchYourName = string.Empty;
            view.SearchIndentyCard_StateRegister = string.Empty;
            view.SearchSocialSecurity_NationalRegister = string.Empty;
            view.SearchTypeOfRegistration = string.Empty;

            SearchData();
        }
    }
}
