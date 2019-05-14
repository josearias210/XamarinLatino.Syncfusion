using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Syncfusion.Licensing;

namespace XamarinLatino.Syncfusion
{
    public partial class App : Application
    {
        public App()
        {
            //SyncfusionLicenseProvider.RegisterLicense("codigo de su licencia");
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
