using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;

namespace FahrplanApp
{
    internal class Location
    {
       public Location()
        {

        }
        public string latitude { get; private set; }
        public string longitude { get; private set; }

        public async Task<bool> SetLocationAsync()
        {
            Geolocator locator = new Geolocator();
            var status = await Geolocator.RequestAccessAsync();
            switch (status)
            {
                case GeolocationAccessStatus.Allowed:
                    Geoposition pos = await locator.GetGeopositionAsync();
                    latitude = pos.Coordinate.Latitude.ToString();
                    longitude = pos.Coordinate.Longitude.ToString();
                    return true;

                case GeolocationAccessStatus.Denied:
                    MessageBox.Show("Keinen Zugriff auf die Position.");
                    return false;

                case GeolocationAccessStatus.Unspecified:
                    MessageBox.Show("Es ist ein Fehler aufgetreten");
                    return false;
            }
            return false;
            
        }
    }
}
