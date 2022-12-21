using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;
using XamarinFormMapDemo.ViewModel;

namespace XamarinFormMapDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UberDemo : ContentPage
    {
        UberViewModel uberViewModel;
        public UberDemo()
        {
            InitializeComponent();
            uberViewModel = new UberViewModel();
            this.BindingContext= uberViewModel;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var contents = await uberViewModel.LoadVehicles();

            if (contents != null)
            {
                foreach (var item in contents)
                {
                    Pin VehiclePins = new Pin()
                    {
                        Label = "Cars",
                        Type = PinType.Place,
                        Position = new Position(Convert.ToDouble(item.Latitude), Convert.ToDouble(item.Longitude)),

                    };
                    map.Pins.Add(VehiclePins);
                }
            }

            ////This is your location and it should be near to your car location.
            var positions = new Position(28.126825, 82.297106);//Latitude, Longitude
            map.MoveToRegion(MapSpan.FromCenterAndRadius(positions, Distance.FromMeters(10)));
        }
    }
}