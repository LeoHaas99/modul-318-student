namespace SwissTransport.Core
{
    using System.Threading.Tasks;
    using SwissTransport.Models;

    public interface ITransport
    {
        Stations GetStations(string query);

        Stations GetStationsCloseBy(string latitude, string longitude);

        StationBoardRoot GetStationBoard(string station/*, string id*/);

        Connections GetConnections(string fromStation, string toStation, string date, string time);
    }
}