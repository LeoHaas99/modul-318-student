using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;

namespace FahrplanApp
{
    public class Location
    {
       public Location()
        {
            
        }
        public string Latitude { get; private set; }
        public string Longitude { get; private set; }

        public GeolocationAccessStatus Status { get; private set; }

        public async Task<bool> SetLocationAsync()
        {
            Geolocator locator = new Geolocator();
            Status = await Geolocator.RequestAccessAsync();
            switch (Status)
            {
                case GeolocationAccessStatus.Allowed:
                    Geoposition pos = await locator.GetGeopositionAsync();
                    Latitude = pos.Coordinate.Latitude.ToString();
                    Longitude = pos.Coordinate.Longitude.ToString();
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
