namespace XamarinNative.ViewModels
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Xamarin.Forms;
    using XamarinNative.Common.Models;
    using XamarinNative.Services;

    public class ProductsViewModel : BaseViewModel
    {
        private ApiService apiService { get; set; }

        private ObservableCollection<Product> products;

        public ObservableCollection<Product> Products
        {
            get
            {
                return this.products;
            }

            set
            {
                this.SetValue(ref this.products, value);
            }

        }

        public ProductsViewModel()
        {
            this.apiService = new ApiService();
            this.LoadProducts();
        }

        private async void LoadProducts()
        {
            //var response = await this.apiService.GetList<Product>("OJO URL", "", "");
            var response = await this.apiService.GetList<Product>("https://salesapiservices.azurewebsites.net", "/api", "/Products");
            if (!response.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert("Error", response.Message, "Ok");
                return;
            }

            var list = (List<Product>)response.Result; //Casteo debido a que se obtiene un objeto
            this.Products = new ObservableCollection<Product>(list);
        }
    }
}
