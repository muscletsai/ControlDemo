using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;
using System.Globalization;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LinePage : ContentPage
    {
        ObservableCollection<string> _friends;

        public LinePage()
        {
            InitializeComponent();
            binding();
            lvFriend.ItemsSource = _friends;

        }

        private void binding()
        {
            _friends = new ObservableCollection<string>()
            {
                "蒼井空","456","789"

            };
        }

        private async void ListView_Refreshing(object sender, EventArgs e)
        {
            await Task.Delay(500);
            lvFriend.IsRefreshing = false;
        }

        private void LvFriend_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            // await
            lvFriend.SelectedItem = null;

        }
    }

    public class DoubleToIntConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double multiplier;

            if (!Double.TryParse(parameter as string, out multiplier))
                multiplier = 1;

            return (int)Math.Round(multiplier * (double)value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double divider;

            if (!Double.TryParse(parameter as string, out divider))
                divider = 1;

            return ((double)(int)value) / divider;
        }
    }
}