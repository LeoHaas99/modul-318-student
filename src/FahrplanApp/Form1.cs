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
                    labelConnection.Text = "Verbindungen von " + fromStation + " nach " + toStation;
                    if (connections.ConnectionList.Count > 0)
                    {
                        foreach(Connection connection in connections.ConnectionList)
                        {   
                            string dateOfDeparture = Convert.ToDateTime(connection.From.Departure).ToString("D");
                            string platform = connection.From.Platform.ToString();
                            string departure = Convert.ToDateTime(connection.From.Departure).ToString("HH:mm");
                            string arrival = Convert.ToDateTime(connection.To.Arrival).ToString("HH:mm");
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

                }
            }
            else
            {
                MessageBox.Show("Bitte füllen Sie alle Felder aus.");
            }
        }
    }
}