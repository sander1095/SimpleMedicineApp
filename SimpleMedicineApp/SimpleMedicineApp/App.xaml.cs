using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Distribute;
using SimpleMedicineApp.Helpers;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleMedicineApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        { 
            // Handle when your app starts
            AppCenter.Start(
                appSecret:$"android={Secrets.AppCenterAndroidSecret}",
                typeof(Analytics), typeof(Crashes), typeof(Distribute));
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
