

namespace sales.ViewModels
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel; 
    using sales.common.models;
    using sales.Services;
    using Xamarin.Forms;

    public class ProductsViewModel : BaseViewModel
    {

        private ApiService apiService;

        private ObservableCollection<Product> products;
        public ObservableCollection <Product> Products 
        
        {
            get { return this.products; }
            set { this.SetValue(ref this.products, value); }
        }

        public ProductsViewModel()
        {
            this.apiService = new ApiService();
            this.LoadProducts();
          }

        private async void LoadProducts()
        {
            var response = await this.apiService.GetList<Product>("https://salesapi20201028102947.azurewebsites.net", "/Api", "/Products");
            if (!response.IsSuccess)
            {
                 await Application.Current.MainPage.DisplayAlert("Error",response.Message,"Accept");
                return;
            }
            var list = (List<Product>)response.Result;
            this.Products = new ObservableCollection<Product>(list);
        }
    }
}
