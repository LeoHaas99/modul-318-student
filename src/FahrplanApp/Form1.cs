using SwissTransport.Core;
using SwissTransport.Models;

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
                    foreach(Station station in stations.StationList)
                    {
                        lbFrom.Items.Add(station.Name);
                    }
                    if(lbFrom.Items.Count > 0)
                    {
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
                    foreach (Station station in stations.StationList)
                    {
                        lbTo.Items.Add(station.Name);
                    }
                    if (lbTo.Items.Count > 0)
                    {
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
                    foreach (Station station in stations.StationList)
                    {
                        lbStationboard.Items.Add(station.Name);
                    }
                    if (lbStationboard.Items.Count > 0)
                    {
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
    }
}