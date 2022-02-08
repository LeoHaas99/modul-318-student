namespace SwissTransport
{
    using FluentAssertions;
    using SwissTransport.Core;
    using SwissTransport.Models;
    using Xunit;

    public class TransportTest
    {
        private readonly ITransport testee;

        public TransportTest()
        {
            this.testee = new Transport();
        }

        [Fact]
        public void LocationsTest()
        {
            Stations stations = this.testee.GetStations("Sursee,");

            stations.StationList.Should().HaveCount(10);
        }

        [Fact]
        public void LocationsCloseByTest()
        {
            Stations stations = this.testee.GetStationsCloseBy("47.243", "7.971");
            stations.StationList.Should().HaveCount(10);
        }

        [Fact]
        public void StationBoardTest()
        {
            StationBoardRoot stationBoard = this.testee.GetStationBoard("Sursee");

            stationBoard.Should().NotBeNull();
        }

        [Fact]
        public void ConnectionsTest()
        {
            Connections connections = this.testee.GetConnections("Sursee", "Luzern", "2022-02-08", "09:20");

            connections.Should().NotBeNull();
        }

        [Fact]
        public void ConnectionsLimitTest()
        {
            Connections connections = this.testee.GetConnections("Berg", "Weinfelden", "2022-02-09", "23:59");
            connections.ConnectionList.Should().HaveCount(10);
        }
    }
}