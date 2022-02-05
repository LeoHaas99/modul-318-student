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
                    labelConnection.Text = "Verbindungen von " + fromStation + " nach " + toStation + " am " + Convert.ToDateTime(date).ToString("D") + ", " + Convert.ToDateTime(time).ToString("HH:mm");
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
                    labelStationboard.Text = "Aktuelle Anzeigetafel von " + station;
                    if (stationboard.Entries.Count > 0)
                    {
                        foreach (StationBoard connection in stationboard.Entries)
                        {
                            string category = connection.Category.ToString();
                            string number = connection.Number.ToString();
                            string platform = connection.Stop.Platform.ToString();
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
    }
}