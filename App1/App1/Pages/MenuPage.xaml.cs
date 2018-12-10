using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            Title = "Menu";
            InitializeComponent();
            initial();

        }

        private void initial()
        {
                btnShock.BackgroundColor = Global.IsShock ? Color.LightGreen : Color.Gray;
                btnVoice.BackgroundColor = Global.IsVoice ? Color.LightGreen : Color.Gray;
        }

        private async void btnShock_Clicked(object sender, EventArgs e)
        {
            // Navigation.PushAsync();

            Global.IsShock = !Global.IsShock;
            initial();
        }

        private async void btnVoice_Clicked(object sender, EventArgs e)
        {
            Global.IsVoice = !Global.IsVoice;
            initial();
        }


    }
}