using SwissTransport.Core;
using SwissTransport.Models;
using Windows.Devices.Geolocation;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using System.Web;
using System.Net.Mail;

namespace FahrplanApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ITransport transport = new Transport();

        private void Form1_Load(object sender, EventArgs e)
        {
            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.CustomFormat = "HH:mm"; 
            timePicker.ShowUpDown = true;
            labelConnection.Text = "";
            labelStationboard.Text = "";
            lbFrom.Hide();
            lbTo.Hide();
            lbStationboard.Hide();
            lbPlace.Hide();
            gmap.Hide();
            btnCloseMap.Hide();
            labelPlace.Text = "";
        }

        

        private void btnConnections_Click(object sender, EventArgs e)
        {
           
            string fromStation = txtFrom.Text.Trim();
            string toStation = txtTo.Text.Trim();
            string date = datePicker.Value.ToString("yyyy-MM-dd");
            string time = timePicker.Value.ToString();
            if (fromStation != "" && toStation != "")
            {
                try
                {
                    Connections connections = transport.GetConnections(fromStation, toStation, date, time);
                    dgvConnections.Rows.Clear();
                    closeLists(sender, e);
                    labelConnection.Text = "Verbindungen \nvon " + fromStation + " nach " + toStation + " \nam " + Convert.ToDateTime(date).ToString("D") + ", " + Convert.ToDateTime(time).ToString("HH:mm");
                    if (connections.ConnectionList.Count > 0)
                    {
                        string tempDate = "";
                        foreach(Connection connection in connections.ConnectionList)
                        {   
                            string dateOfDeparture = Convert.ToDateTime(connection.From.Departure).ToString("D");
                            string platform = "";
                            if (connection.From.Platform != null)
                            {
                                platform = connection.From.Platform.ToString();
                            }
                            else
                            {
                                platform = "unbekannt";
                            }
                            string departure = Convert.ToDateTime(connection.From.Departure).ToString("HH:mm");
                            string arrival = Convert.ToDateTime(connection.To.Arrival).ToString("HH:mm");
                            if(tempDate == dateOfDeparture)
                            {
                                dateOfDeparture = "";
                            }
                            else
                            {
                                tempDate = dateOfDeparture;
                            }
                            
                            dgvConnections.Rows.Add(dateOfDeparture, platform, departure, arrival);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Für diese Stationen wurden keine Verbindungen gefunden. Überprüfen Sie Ihre Eingaben.");
                    }
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Es ist ein Fehler aufgetreten.\n" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Bitte füllen Sie alle Felder aus.");
            }
        }

        private void btnStationboard_Click(object sender, EventArgs e)
        {
            string station = txtStationboard.Text.Trim();
            if(station != "")
            {
                try
                {
                    StationBoardRoot stationboard = transport.GetStationBoard(station);
                    dgvStationboard.Rows.Clear();
                    closeLists(sender, e);
                    labelStationboard.Text = "Aktuelle Anzeigetafel von " + station;
                    if (stationboard.Entries.Count > 0)
                    {
                        foreach (StationBoard connection in stationboard.Entries)
                        {
                            string category = connection.Category.ToString();
                            string number = connection.Number.ToString();
                            string platform = "";
                            if (connection.Stop.Platform != null)
                            {
                                platform = connection.Stop.Platform.ToString();
                            }
                            else
                            {
                                platform = "unbekannt";
                            }
                            string endstation = connection.To.ToString();
                            string departure = connection.Stop.Departure.ToString("HH:mm");

                            dgvStationboard.Rows.Add(category + number, platform, endstation, departure);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Für diese Stationen wurden keine Verbindungen gefunden. Überprüfen Sie Ihre Eingaben.");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Es ist ein Fehler aufgetreten.\n" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Bitte füllen Sie das Stationsfeld aus.");
            }
        }

        private void txtFrom_TextChanged(object sender, EventArgs e)
        {
            if(txtFrom.Text.Length > 2)
            {
                string stationName = txtFrom.Text.Trim();
                try
                {
                    lbFrom.Items.Clear();
                    Stations stations = transport.GetStations(stationName);
                    if(stations.StationList.Count > 0)
                    {
                        foreach (Station station in stations.StationList)
                        {
                            lbFrom.Items.Add(station.Name);
                        }
                        lbFrom.Show();
                    }
                }
                catch
                {
                    lbFrom.Hide();
                }
            }
        }

        private void lbFrom_Leave(object sender, EventArgs e)
        {
            lbFrom.Hide();
        }

        private void txtFrom_Enter(object sender, EventArgs e)
        {
            lbTo.Hide();
            if(txtFrom.Text.Length > 2 && lbFrom.Items.Count > 0)
            {
                lbFrom.Show();
            }
        }

        private void txtTo_Enter(object sender, EventArgs e)
        {
            lbFrom.Hide();
            if (txtTo.Text.Length > 2 && lbTo.Items.Count > 0)
            {
                lbTo.Show();
            }
        }

        private void closeLists(object sender, EventArgs e)
        {
            lbFrom.Hide();
            lbTo.Hide();
            lbStationboard.Hide();
            lbPlace.Hide();
        }

        private void lbFrom_Click(object sender, EventArgs e)
        {
            txtFrom.Text = lbFrom.SelectedItem.ToString();
            lbFrom.Hide();
        }

        private void txtTo_TextChanged(object sender, EventArgs e)
        {
            if (txtTo.Text.Length > 2)
            {
                string stationName = txtTo.Text.Trim();
                try
                {
                    lbTo.Items.Clear();
                    Stations stations = transport.GetStations(stationName);
                    if(stations.StationList.Count > 0)
                    {
                        foreach (Station station in stations.StationList)
                        {
                            lbTo.Items.Add(station.Name);
                        }
                        lbTo.Show();
                    }
                }
                catch
                {
                    lbTo.Hide();
                }
            }
        }

        private void lbTo_Click(object sender, EventArgs e)
        {
            txtTo.Text = lbTo.SelectedItem.ToString();
            lbTo.Hide();
        }

        private void txtStationboard_TextChanged(object sender, EventArgs e)
        {
            if (txtStationboard.Text.Length > 2)
            {
                string stationName = txtStationboard.Text.Trim();
                try
                {
                    lbStationboard.Items.Clear();
                    Stations stations = transport.GetStations(stationName);
                    if (stations.StationList.Count > 0)
                    {
                        foreach (Station station in stations.StationList)
                        {
                            lbStationboard.Items.Add(station.Name);
                        }
                        lbStationboard.Show();
                    }
                }
                catch
                {
                    lbStationboard.Hide();
                }
            }
        }

        private void lbStationboard_Click(object sender, EventArgs e)
        {
            txtStationboard.Text = lbStationboard.SelectedItem.ToString();
            lbStationboard.Hide();
        }

        private async void btnCloseBy_Click(object sender, EventArgs e)
        {
            closeLists(sender, e);
            Location location = new Location();
            ;
            if (await location.SetLocationAsync())
            {
                string latitude = location.Latitude;
                string longitude = location.Longitude;
                try
                {
                    dgvMap.Rows.Clear();
                    Stations stations = transport.GetStationsCloseBy(latitude,longitude);
                    gmap.MapProvider = BingHybridMapProvider.Instance;
                    GMaps.Instance.Mode = AccessMode.ServerOnly;
                    gmap.ShowCenter = false;
                    gmap.Position = new GMap.NET.PointLatLng(Convert.ToDouble(latitude), Convert.ToDouble(longitude));
                    GMapOverlay markers = new GMapOverlay("markers");
                    GMapMarker marker = new GMarkerGoogle(
                        new PointLatLng(Convert.ToDouble(latitude), Convert.ToDouble(longitude)),
                        GMarkerGoogleType.blue_pushpin);
                    marker.ToolTipText = "Dein Standort";
                    markers.Markers.Add(marker);
                    foreach (Station station in stations.StationList)
                    {
                        if(station.Coordinate.XCoordinate != null && station.Coordinate.YCoordinate != null)
                        {
                            double latitudeStation = (double)station.Coordinate.XCoordinate;
                            double longitudeStation = (double)station.Coordinate.YCoordinate;
                            GMapMarker markerStation = new GMarkerGoogle(
                            new PointLatLng(Convert.ToDouble(latitudeStation), Convert.ToDouble(longitudeStation)),
                            GMarkerGoogleType.red_pushpin);
                            markerStation.ToolTipText = station.Name;
                            markers.Markers.Add(markerStation);
                        }
                    }
                    gmap.Overlays.Clear();
                    gmap.Overlays.Add(markers);
                    gmap.Show();
                    labelPlace.Text = "Stationen in der Nähe";
                }
                catch
                {
                    MessageBox.Show("Es ist ein Fehler aufgetreten");
                }
            }
            else
            {
                MessageBox.Show("Es ist ein Fehler aufgetreten. Die Position konnte nicht bestimmt werden");
            }
        }
        
        private void btnPlace_Click(object sender, EventArgs e)
        {
            gmap.Hide();
            closeLists(sender, e);
            string place = txtPlace.Text.Trim();
            try
            {
                dgvMap.Rows.Clear();
                labelPlace.Text = "Stationen mit dem Namen " + place;
                Stations stations = transport.GetStations(place);
                if(stations.StationList.Count > 0)
                {
                    foreach (Station station in stations.StationList)
                    {
                        dgvMap.Rows.Add(station.Name);
                    }
                }
                else
                {
                    MessageBox.Show("Es wurden keine Resultate gefunden.");
                }
            }
            catch
            {
                MessageBox.Show("Es ist ein Fehler aufgetreten.");
            }
        }

        private void dgvMap_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvMap.CurrentCell.RowIndex;
            int columnIndex = dgvMap.CurrentCell.ColumnIndex;
            string place = dgvMap.Rows[rowIndex].Cells[columnIndex].Value.ToString();
            labelPlace.Text = place + " auf der Karte";
            Stations stations = transport.GetStations(place);
            foreach (Station station in stations.StationList)
            {
                if(station.Coordinate.XCoordinate != null && station.Coordinate.YCoordinate != null)
                {
                    double latitudeStation = (double)station.Coordinate.XCoordinate;
                    double longitudeStation = (double)station.Coordinate.YCoordinate;
                    gmap.MapProvider = BingHybridMapProvider.Instance;
                    GMaps.Instance.Mode = AccessMode.ServerOnly;
                    gmap.ShowCenter = false;
                    gmap.Position = new GMap.NET.PointLatLng(Convert.ToDouble(latitudeStation), Convert.ToDouble(longitudeStation));
                    GMapOverlay markers = new GMapOverlay("markers");
                    GMapMarker markerStation = new GMarkerGoogle(
                    new PointLatLng(Convert.ToDouble(latitudeStation), Convert.ToDouble(longitudeStation)),
                    GMarkerGoogleType.red_pushpin);
                    markerStation.ToolTipText = station.Name;
                    markers.Markers.Add(markerStation);
                    gmap.Overlays.Clear();
                    gmap.Overlays.Add(markers);
                    btnCloseMap.Show();
                    gmap.Show();
                    break;
                }
                else
                {
                    MessageBox.Show("Dieser Eintrag kann nicht auf der Karte angezeigt werden");
                    break;
                }
            }
        }

        private void btnCloseMap_Click(object sender, EventArgs e)
        {
            gmap.Hide();
            btnCloseMap.Hide();
        }

        private void txtPlace_TextChanged(object sender, EventArgs e)
        {
            if (txtPlace.Text.Length > 2)
            {
                string stationName = txtPlace.Text.Trim();
                try
                {
                    lbPlace.Items.Clear();
                    Stations stations = transport.GetStations(stationName);
                    if (stations.StationList.Count > 0)
                    {
                        foreach (Station station in stations.StationList)
                        {
                            lbPlace.Items.Add(station.Name);
                        }
                        lbPlace.Show();
                    }
                }
                catch
                {
                    lbPlace.Hide();
                }
            }
        }

        private void lbPlace_Click(object sender, EventArgs e)
        {
            txtPlace.Text = lbPlace.SelectedItem.ToString();
            lbPlace.Hide();
        }

    }
}