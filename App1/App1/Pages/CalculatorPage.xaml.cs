using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;
using App1.Models;
using Plugin.Vibrate;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalculatorPage : ContentPage
    {
        ObservableCollection<NumberImage> _number = new ObservableCollection<NumberImage>();
        bool _fuistNumber = true;

        public CalculatorPage()
        {
            InitializeComponent();

            //_colorList.Add(Color.Red);
            //_colorList.Add(Color.Orange);
            //_colorList.Add(Color.Yellow);
            //_colorList.Add(Color.Green);
            //_colorList.Add(Color.Blue);
            //_colorList.Add(Color.Honeydew);
            //_colorList.Add(Color.DarkSlateGray);
            load();
            createData();
            girdData.BindingContext = _number[0];
        }

        private void createData()
        {
            _number.Clear();

            NumberImage n1 = new NumberImage();
            n1.Number0 = "http://www.haipic.com/icon/55036/55036.png";
            n1.Number1 = "http://www.haipic.com/icon/55038/55038.png";
            n1.Number2 = "http://www.haipic.com/icon/55040/55040.png";
            n1.Number3 = "http://www.haipic.com/icon/55042/55042.png";
            n1.Number4 = "http://www.haipic.com/icon/55044/55044.png";
            n1.Number5 = "http://www.haipic.com/icon/55046/55046.png";
            n1.Number6 = "http://www.haipic.com/icon/55048/55048.png";
            n1.Number7 = "http://www.haipic.com/icon/55050/55050.png";
            n1.Number8 = "http://www.shejiye.com/uploadfile/icon/2017/0203/shejiyeiconmxnzwamtfxp.png";
            n1.Number9 = "http://bpic.588ku.com/element_pic/00/33/44/4656d3b87629e8a.jpg";
            n1.Add = "https://static.thenounproject.com/png/434546-200.png";
            n1.Del = "https://static.thenounproject.com/png/367883-200.png";
            n1.Multiply = "https://static.thenounproject.com/png/1655472-200.png";
            n1.Except = "https://static.thenounproject.com/png/958881-200.png";
            n1.Point = "https://static.thenounproject.com/png/739878-200.png";
            n1.Anser = "https://cdn.icon-icons.com/icons2/37/PNG/512/equalsign_igual_3159.png";
            n1.Clear = "http://chittagongit.com//images/letter-c-icon/letter-c-icon-22.jpg";
            n1.Tool = "https://cdn4.iconfinder.com/data/icons/mosaicon-01/512/usersettings-512.png";
            n1.Back = "https://static.thenounproject.com/png/1317021-200.png";
            n1.Percent = "https://cdn.icon-icons.com/icons2/37/PNG/512/percentage_3932.png";
            _number.Add(n1);

            //NumberImage n2 = new NumberImage();
            //n2.Number0 = "";
            //n2.Number1 = "";
            //n2.Number2 = "";
            //n2.Number3 = "";
            //n2.Number4 = "";
            //n2.Number5 = "";
            //n2.Number6 = "";
            //n2.Number7 = "";
            //n2.Number8 = "";
            //n2.Number9 = "";
            //n2.Add = "";
            //n2.Del = "";
            //n2.Multiply = "";
            //n2.Except = "";
            //n2.Point = "";
            //n2.Anser = "";
            //n2.Clear = "";
            //n2.Tool = "";

            //_number.Add(n2);
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
                        if (v[0] is Image)
                        {
                            Image img = v[0] as Image;
                            img.Aspect = Aspect.AspectFit;

                            // img.BackgroundColor = Color.Black;
                            var tapGestureRecognizer = new TapGestureRecognizer();
                            tapGestureRecognizer.Tapped += TapGestureRecognizer_Tapped1;
                            img.GestureRecognizers.Add(tapGestureRecognizer);

                        }
                    }
                }
            }
        }

        private async void TapGestureRecognizer_Tapped1(object sender, EventArgs e)
        {
            var v = CrossVibrate.Current;
            v.Vibration(TimeSpan.FromSeconds(0.1));
            var meg = ((Image)sender).StyleId;
            
            switch (meg.ToUpper())
            {
                case "TOOL":

                    break;
                case "=":
                    labMethod.Text = "";
                    break;
                case "+":
                    labMethod.Text = meg;
                    break;
                case "-":
                    labMethod.Text = meg;
                    break;
                case "*":
                    labMethod.Text = meg;
                    break;
                case "/":
                    labMethod.Text = meg;
                    break;
                case "%":
                    labMethod.Text = meg;
                    break;
                case "C":
                    labResult.Text = "0";
                    labMethod.Text = "";
                    break;
                case "B":
                    if (labResult.Text.Length == 1)
                        labResult.Text = "0";
                    else
                        labResult.Text = labResult.Text.Substring(0, labResult.Text.Length - 1);
                    break;
                default:

                    if (labResult.Text.Length <= 9)
                    {
                        if (labResult.Text == "0")
                            labResult.Text = meg;
                        else
                            labResult.Text += meg;
                        _fuistNumber = false;
                    }
                    break;
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

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

        }

    }


}