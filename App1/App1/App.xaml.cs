using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace App1
{
    public partial class App : Application
    {
        public NavigationPage NavigationPage { get; private set; }

        public App()
        {
            InitializeComponent();

            //var MainPage = new MainPage();
            // MainPage = new NavigationPage(new MainPage());

            var menuPage = new MenuPage();
            NavigationPage = new NavigationPage(new MainPage());
            var rootPage = new RootPage();
            rootPage.Master = menuPage;
            rootPage.Detail = NavigationPage;
            MainPage = rootPage;

            //for (int i = 0; i < 10; i++)
            //{
            //    ToolbarItem tb = new ToolbarItem();
            //    tb.Text = "123";
            //    tb.Icon = "aa";
            //    NavigationPage.ToolbarItems.Add(tb);
            //}

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
