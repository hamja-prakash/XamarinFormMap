using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace XamarinFormMapDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void FrmBasicMap_Tapped(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new BasicMapPage());
        }

        private void FrmNearbyUber_Tapped(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new UberDemo());
        }

        private async void FrmEssentialMap_Tapped(object sender, System.EventArgs e)
        {
            await Xamarin.Essentials.Map.OpenAsync(22.31081, 73.18088);
        }

        private async void FrmMapDirection_Tapped(object sender, System.EventArgs e)
        {
            var location = new Location(47.645160, -122.1306032);
            var options = new MapLaunchOptions { NavigationMode = NavigationMode.Driving };

            await Xamarin.Essentials.Map.OpenAsync(location, options);

            //var location = new Location(22.34561, 73.17540);
            //var options = new MapLaunchOptions { NavigationMode = NavigationMode.None };
            //await Xamarin.Essentials.Map.OpenAsync(location, options);
        }

        private async void FrmMapPlacemark_Tapped(object sender, EventArgs e)
        {
            var placemark = new Placemark
            {
                CountryName = "India",
                AdminArea = "Vadodara",
                Thoroughfare = "Prakash Software Solution",
                Locality = "Chani"
            };
            var options = new MapLaunchOptions { Name = "Prakash Software Solution" };

            try
            {
                await Xamarin.Essentials.Map.OpenAsync(placemark, options);
            }
            catch (Exception ex)
            {
                // No map application available to open or placemark can not be located
            }
        }

        private void FrmDaynamicMap_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DynamicMapDemo());
        }
    }
}
