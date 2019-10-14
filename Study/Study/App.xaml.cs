using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Study
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();

            switch (Device.Idiom)
            {
                case TargetIdiom.Desktop:
                    MainPage = new Page_Desktop();
                    break;
                case TargetIdiom.Phone:
                    MainPage = new MainPage();
                    break;
            }
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
