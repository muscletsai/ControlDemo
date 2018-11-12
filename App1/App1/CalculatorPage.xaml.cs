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
	public partial class CalculatorPage : ContentPage
	{
		public CalculatorPage ()
		{
			InitializeComponent ();

            load();

        }

        private void load()
        {
            Grid a = this.Content as Grid;

            for (int rowIndex = 1; rowIndex < a.RowDefinitions.Count; rowIndex++)
            {
                for (int colIndex = 0; colIndex < a.ColumnDefinitions.Count; colIndex++)
                {
                    Button btn = (Button)a.Children.Where(c => Grid.GetRow(c) == rowIndex && Grid.GetColumn(c) == colIndex);
                    btn.Clicked += Btn_Clicked;
                }
            }
        }

        private void Btn_Clicked(object sender, EventArgs e)
        {
            Grid a = ((Button)sender).Parent as Grid;

            Label lab = (Label)(a.Children.Where(c => Grid.GetRow(c) == 0 && Grid.GetColumn(c) == 0));

            lab.Text = ((Button)sender).Text;
        }


    }
}