using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;

namespace RocketPi
{
    public partial class RocketPi_Form : Form
    {
        public static SerialPort port;
        public IList<GPRMC> data;
        public static GMapOverlay markersOverlay;
        public static GMapOverlay polygonOverlay;
        public static StringBuilder builder;
        public RocketPi_Form()
        {
            InitializeComponent();
            markersOverlay = new GMapOverlay("markers");
            polygonOverlay = new GMapOverlay("polygon");

            consoleText.TabStop = false;
            consoleText.AppendText("Welcome to RocketPi!\n");

            port = new SerialPort();
            port.PortName = "N/A";
            port.BaudRate = 9600;
            port.Parity = Parity.None;
            port.StopBits = StopBits.One;
            port.DataBits = 8;
            //port.Handshake = Handshake.None;
            scanPort(); 
            
            port.DataReceived += (sender, args) => {
                if (consoleText.InvokeRequired)
                {
                    consoleText.Invoke(new MethodInvoker(() => {
                        string input = port.ReadExisting();
                        if (input.StartsWith("$GPRMC"))
                        {
                            try
                            {
                                string[] gprmcArgs = input.Split(',');
                                GPRMC entry = new GPRMC();
                                entry.status = gprmcArgs[2];
                                gpsValidityText.Text = entry.status;

                                entry.coordinates.Lat = Double.Parse(gprmcArgs[3]);
                                gpsLatText.Text = entry.coordinates.Lat.ToString();

                                entry.coordinates.Lng = Double.Parse(gprmcArgs[5]);
                                gpsLongText.Text = entry.coordinates.Lng.ToString();

                                entry.speed = float.Parse(gprmcArgs[7]);
                                entry.course = float.Parse(gprmcArgs[8]);

                                string day = gprmcArgs[9].Substring(0, 2);
                                string month = gprmcArgs[9].Substring(2, 2);
                                string year = gprmcArgs[9].Substring(4, 2);
                                string date = month + "/" + day + "/" + year;

                                string hour = gprmcArgs[1].Substring(0, 2);
                                string minute = gprmcArgs[1].Substring(2, 2);
                                string second = gprmcArgs[1].Substring(4, 2);
                                string time = hour + ":" + minute + ":" + second;
                                string datetime = date + " " + time;
                                gpsTimeStampText.Text = datetime;

                                entry.timestamp = Convert.ToDateTime(datetime);
                                data.Add(entry);
                                if (data.Count == 0)
                                {
                                    GMarkerGoogle marker = new GMarkerGoogle(entry.coordinates, GMarkerGoogleType.green);
                                    markersOverlay.Markers.Add(marker);
                                    gpsMap.Overlays.Add(markersOverlay);
                                }

                            }
                            catch(Exception ex)
                            {

                            }
                        }

                        consoleText.AppendText(port.ReadExisting().ToString());
                    }));
                }
                else
                {
                    consoleText.AppendText(port.ReadExisting().ToString());
                }
            };

            port.PinChanged += (sender, args) => {
                if (consoleText.InvokeRequired)
                {
                    consoleText.Invoke(new MethodInvoker(() => {
                        consoleText.AppendText("Changes detected. Port closed.\n");
                        port.Close();
                    }));
                }
                else
                {
                    consoleText.AppendText("Changes detected. Port closed.\n");
                    port.Close();
                }
            };

        }



        private void Console_Clear(object sender, MouseEventArgs e)
        {
            consoleText.Text = "";
        }

        private void settingsMenuOnClick(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            if (menuItem.GetCurrentParent() == null)
            {
                return;
            }

            if (!menuItem.Checked)
            {
                uncheckAllChildren(menuItem.GetCurrentParent());
                closePort();

                switch (menuItem.OwnerItem.Text)
                {
                case "Preset":
                        switch(menuItem.Text)
                        {
                            case "XBee":
                                port.BaudRate = 9600;
                                port.Parity = Parity.None;
                                port.StopBits = StopBits.One;
                                port.DataBits = 8;
                                port.Handshake = Handshake.None;
                                break;
                            case "Raspberry Pi":
                                port.BaudRate = 115200;
                                port.Parity = Parity.None;
                                port.StopBits = StopBits.One;
                                port.DataBits = 8;
                                port.Handshake = Handshake.XOnXOff;
                                break;
                        }
                        menuItem.Checked = true;
                        break;
                case "Port":
                        port.PortName = menuItem.Text;
                        currentPortText.Text = menuItem.Text;
                        break;
                default:

                        break;
                }
            }

            return;
        }

        private void writeToPortButton(object sender, MouseEventArgs e)
        {
            if (port.IsOpen)
            {
                port.Write(consoleInput.Text + "\r\n");
                consoleInput.Text = "";
            }
            else
            {
                consoleText.AppendText("Port is closed.\n");
            }
        }

        private void writeToPortTextbox(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(port.IsOpen)
                { 
                    port.Write(consoleInput.Text + "\r\n");
                    consoleInput.Text = "";
                }
                else
                {
                    consoleText.AppendText("Port is closed.\n");
                }
            }
        }

        private void uncheckAllChildren(ToolStrip parent)
        {
            foreach (ToolStripMenuItem item in parent.Items)
            {
                if (item != null && item.Checked)
                {
                    item.Checked = false;
                    return;
                }
            }
        }

        private void mainWindowLoad(object sender, EventArgs e)
        {
            gpsMap.MapProvider = GMap.NET.MapProviders.OpenStreetMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gpsMap.SetPositionByKeywords("Seattle, Washington");
        }

        private void portSwitch(object sender, EventArgs e)
        {
            if (!port.IsOpen)
            {
                try
                {
                    port.Open();
                    portStatusText.Text = "open";
                    portSwitchButton.Text = "Close";
                    consoleText.AppendText("Port is opened.\n");
                }
                catch (Exception ex)
                {
                    consoleText.AppendText("Failed to open port.\n");
                }
            }
            else
            {
                closePort();
            }
        }

        private void closePort()
        {
            port.Close();
            consoleText.AppendText("Port is closed.\n");
            portSwitchButton.Text = "Open";
        }


        private void scanPort()
        {
            closePort();
            consoleText.AppendText("Scanning port...\n");
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            if (ports.Length > 0)
            {
                foreach (String portName in ports)
                {
                    port.PortName = portName;
                    currentPortText.Text = portName;
                    consoleText.AppendText(portName + " found.\n");
                }
            }
            else
            {
                consoleText.AppendText("No port detected.\n");
            }
        }

        private void scanPort(object sender, MouseEventArgs e)
        {
            scanPort();
        }

        public class GPRMC
        {
            public string status = "V";
            public DateTime timestamp;
            public PointLatLng coordinates;
            public float speed;
            public float course;

            public GPRMC()
            {

            }
        }
    }
}
