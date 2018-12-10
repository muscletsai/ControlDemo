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
        int _currIndex = 0;

        public CalculatorPage()
        {
            InitializeComponent();
            load();
            createData();
            girdData.BindingContext = _number[_currIndex];
        }

        private void createData()
        {
            _number.Clear();

            NumberImage n0 = new NumberImage();
            n0.StyleName = "基本版";
            n0.Number0 = "n0";
            n0.Number1 = "n1";
            n0.Number2 = "n2";
            n0.Number3 = "n3";
            n0.Number4 = "n4";
            n0.Number5 = "n5";
            n0.Number6 = "n6";
            n0.Number7 = "n7";
            n0.Number8 = "n8";
            n0.Number9 = "n9";
            n0.Add = "nadd";
            n0.Del = "ndel";
            n0.Multiply = "nmultiply";
            n0.Except = "nexcept";
            n0.Point = "npoint";
            n0.Anser = "nanser";
            n0.Clear = "nclear";
            n0.Tool = "ntool";
            n0.Back = "nback";
            n0.Percent = "npercent";
            _number.Add(n0);

            NumberImage n1 = new NumberImage();
            n1.StyleName = "黑與白(需網路)";
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

            NumberImage n2 = new NumberImage();
            n1.StyleName = "毛筆(需網路)";
            n2.Number0 = "http://img1.tplm123.com/2008/04/04/3421/2310301719241.jpg";
            n2.Number1 = "http://img1.tplm123.com/2008/04/04/3421/2310229844357.jpg";
            n2.Number2 = "http://img1.tplm123.com/2008/04/04/3421/2310150467181.jpg";
            n2.Number3 = "http://img1.tplm123.com/2008/04/04/3421/2310073597436.jpg";
            n2.Number4 = "http://img1.tplm123.com/2008/04/04/3421/2310000317934.jpg";
            n2.Number5 = "http://img1.tplm123.com/2008/04/04/3421/2309846257640.jpg";
            n2.Number6 = "http://img1.tplm123.com/2008/04/04/3421/2309782034450.jpg";
            n2.Number7 = "http://pic.qiantucdn.com/uploadfilepic/ziku/2008-09-15/58PIC_vipvip_200809151734389e96b2361516c84a126.jpg";
            n2.Number8 = "http://pic.qiantucdn.com/uploadfilepic/ziku/2008-09-12/58PIC_vipvip_2008091206180357898bab593f209473.jpg";
            n2.Number9 = "http://img1.tplm123.com/2008/04/04/3421/2309672189899.jpg";
            n2.Add = "http://pic.guoxuedashi.com/shufa/6t1/11288.jpg";
            n2.Del = "http://pic.guoxuedashi.com/shufa/6t2/54320.jpg";
            n2.Multiply = "http://pic.guoxuedashi.com/shufa/ks/R201308025_TM.TXT.0015.016.png";
            n2.Except = "http://pic.guoxuedashi.com/shufa/6t3/101201.jpg";
            n2.Point = "http://pic.guoxuedashi.com/shufa/6t3/109455.jpg";
            n2.Anser = "http://pic.guoxuedashi.com/shufa/6t1/2155.jpg";
            n2.Clear = "http://img1.tplm123.com/2008/04/04/3419/2306845005943.jpg";
            n2.Tool = "http://pic.guoxuedashi.com/shufa/23/235270.jpg";
            n2.Back = "https://en.pimg.jp/008/657/835/1/8657835.jpg";
            n2.Percent = "https://photo.16pic.com/00/70/37/16pic_7037637_b.png";

            _number.Add(n2);
        }

        private int getNext()
        {
            _currIndex++;
            if (_currIndex >= _number.Count)
                _currIndex = 0;

            return _currIndex;
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
            if (Global.IsShock)
            {
                var v = CrossVibrate.Current;
                v.Vibration(TimeSpan.FromSeconds(0.1));
            }

            var meg = ((Image)sender).StyleId;

            switch (meg.ToUpper())
            {
                case "TOOL":
                    girdData.BindingContext = _number[getNext()];
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
                case ".":
                    if(labResult.Text.Contains(".") == false)
                    {
                        if (labResult.Text.Length <= 9)
                        {
                            if (labResult.Text == "0")
                                labResult.Text = meg;
                            else
                                labResult.Text += meg;
                        }
                    }
                    break;
                default:

                    if (labResult.Text.Length <= 9)
                    {
                        if (labResult.Text == "0")
                            labResult.Text = meg;
                        else
                            labResult.Text += meg;
                    }
                    break;
            }

        }

    }


}