using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormMapDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DynamicMapDemo : ContentPage
    {
        public DynamicMapDemo()
        {
            InitializeComponent();
        }

        private async void FrmFindLocation_Tapped(object sender, EventArgs e)
        {
            await FrmFindLcn.ScaleTo(0.9, 100, Easing.Linear);
            await FrmFindLcn.ScaleTo(1.0, 100, Easing.Linear);
            if (!string.IsNullOrEmpty(txtLatitude.Text) && !string.IsNullOrEmpty(txtLongitude.Text))
            {
                var location = new Location(Convert.ToDouble(txtLatitude.Text), Convert.ToDouble(txtLongitude.Text));
                await Map.OpenAsync(location);
            }
        }
    }
}