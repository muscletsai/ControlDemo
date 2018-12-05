using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.Vibrate;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void BtnCalc_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CalculatorPage());
        }

        private async void BtnLine_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RootPage());
        }



    }
}
