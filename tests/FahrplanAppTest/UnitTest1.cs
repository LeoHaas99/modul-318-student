using NUnit.Framework;
using System.Threading.Tasks;
using FahrplanApp;
using Windows.Devices.Geolocation;

namespace FahrplanAppTest
{
    public class LocationTest
    {
        
        [Test]
        public async Task LocationTestAsync()
        {
            Location location = new Location();
            await location.SetLocationAsync();
            Assert.IsNotNull(location.Longitude);
            Assert.IsNotNull(location.Latitude);
        }

        [Test]
        public async Task LocationAccessTestAsync()
        {
            Location location = new Location();
            if (await location.SetLocationAsync()){
                Assert.AreEqual(location.Status, GeolocationAccessStatus.Allowed);
            }
        }
    }
}