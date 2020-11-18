using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace sales
{
    using Views;
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage (new ProductsPages());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
