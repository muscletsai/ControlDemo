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
        public CalculatorPage()
        {
            InitializeComponent();

            _colorList.Add(Color.Red);
            _colorList.Add(Color.Orange);
            _colorList.Add(Color.Yellow);
            _colorList.Add(Color.Green);
            _colorList.Add(Color.Blue);
            _colorList.Add(Color.Honeydew);
            _colorList.Add(Color.DarkSlateGray);
            load();

        }

        private void load()
        {
            Grid a = this.Content as Grid;

            for (int rowIndex = 1; rowIndex < a.RowDefinitions.Count; rowIndex++)
            {
                for (int colIndex = 0; colIndex < a.ColumnDefinitions.Count; colIndex++)
                {
                    List<View> v = a.Children.Where(c => Grid.GetRow(c) == rowIndex && Grid.GetColumn(c) == colIndex).ToList();
                    if (v.Count > 0)
                    {
                        if (v[0] is Button)
                        {
                            Button btn = v[0] as Button;
                            btn.Clicked += Btn_Clicked;
                            
                        }
                    }
                    // Button btn = (Button)a.Children.Where(c => Grid.GetRow(c) == rowIndex && Grid.GetColumn(c) == colIndex);

                }
            }
        }

        int _indexColor = 0;
        List<Color> _colorList = new List<Color>();

        private void Btn_Clicked(object sender, EventArgs e)
        {
            //  Grid a = ((Button)sender).Parent as Grid;

            //  Label lab = (Label)(a.Children.Where(c => Grid.GetRow(c) == 0 && Grid.GetColumn(c) == 0));
            string value = ((Button)sender).Text.ToUpper();

            if (value == "C")
                labResult.Text = "";
            else if (value == "大" || value == "小")
            {
                
                Grid a = this.Content as Grid;
                a.BackgroundColor = _colorList[_indexColor];
                _indexColor++;
                if (_indexColor == 7)
                    _indexColor = 0;
            }
            else
                labResult.Text += ((Button)sender).Text;
            // lab.Text = ((Button)sender).Text;
        }

        private void Btn_SizeChanged(bool large)
        {
            Grid a = this.Content as Grid;

            for (int rowIndex = 1; rowIndex < a.RowDefinitions.Count; rowIndex++)
            {
                for (int colIndex = 0; colIndex < a.ColumnDefinitions.Count; colIndex++)
                {
                    List<View> v = a.Children.Where(c => Grid.GetRow(c) == rowIndex && Grid.GetColumn(c) == colIndex).ToList();
                    if (v.Count > 0)
                    {
                        if (v[0] is Button)
                        {
                            Button btn = v[0] as Button;
                            if (large)
                                btn.FontSize += 2;
                            else
                                btn.FontSize -= 2;
                        }
                    }
                }
            }

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            labResult.FontSize += 2;
            Btn_SizeChanged(true);
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            labResult.FontSize -= 2;
            Btn_SizeChanged(false);
        }
    }
}