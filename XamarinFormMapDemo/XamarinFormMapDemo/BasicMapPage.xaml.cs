using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace XamarinFormMapDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BasicMapPage : ContentPage
    {
        public BasicMapPage()
        {
            InitializeComponent();
            SetMap();
        }

        public void SetMap()
        {
            Position loc1 = new Position(23.03, 72.40);
            Position loc2 = new Position(22.3072, 73.1812);

            Pin pin1 = new Pin()
            {
                Label = "Vadodara",
                Address = "India",
                Position = loc2,
                Type = PinType.Place
            };
            Pin pin2 = new Pin()
            {
                Position = loc1,
                Address = "India",
                Label= "Ahmedabad",
                Type = PinType.Place
            };
            map.Pins.Add(pin1);
            map.Pins.Add(pin2);
            map.MoveToRegion(MapSpan.FromCenterAndRadius(pin2.Position, Distance.FromMeters(1000)));
            // map.MoveToRegion(MapSpan.FromCenterAndRadius(pin1.Position, Distance.FromMeters(5000)));
        }
    }
}