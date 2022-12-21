using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using XamarinFormMapDemo.Model;

namespace XamarinFormMapDemo.ViewModel
{
    public class UberViewModel : INotifyPropertyChanged
    {
        public UberViewModel() 
        {
        }
        public class VehicleLocations
        {
            public string Latitude { get; set; }
            public string Longitude { get; set; }
        }

        internal async Task<List<VehicleLocations>> LoadVehicles()
        {
            //Call the api to get the vehicles nearby

            //This are the hardcoded data
            List<VehicleLocations> vehicleLocations = new List<VehicleLocations>
            {
                new VehicleLocations{Latitude = "28.128888",Longitude="82.296891"},
                new VehicleLocations{Latitude = "28.130061",Longitude="82.297364"},
                new VehicleLocations{Latitude = "28.129550",Longitude="82.298887"},
                new VehicleLocations{Latitude = "28.127336",Longitude="82.292106"},

            };
            return vehicleLocations;
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        //private ObservableCollection<VehicleLocations> _mVehicleLocations;

        //public ObservableCollection<VehicleLocations> mVehicleLocations
        //{
        //    get
        //    {
        //        return _mVehicleLocations;
        //    }
        //    set
        //    {
        //        _mVehicleLocations = value;
        //        OnPropertyChanged();
        //    }
        //}
        //public UberViewModel() 
        //{
        //    LoadVehicles();
        //}

        //internal void LoadVehicles()
        //{
        //    mVehicleLocations = new ObservableCollection<VehicleLocations>();
        //    mVehicleLocations.Add(new VehicleLocations
        //    {
        //        Latitude = "28.128888",
        //        Longitude = "82.296891"
        //    });

        //    mVehicleLocations.Add(new VehicleLocations
        //    {
        //        Latitude = "28.130061",
        //        Longitude = "82.297364"
        //    });

        //    mVehicleLocations.Add(new VehicleLocations
        //    {
        //        Latitude = "28.129550",
        //        Longitude = "82.298887"
        //    });

        //    mVehicleLocations.Add(new VehicleLocations
        //    {
        //        Latitude = "28.127336",
        //        Longitude = "82.292106"
        //    });
        //}
    }
}
