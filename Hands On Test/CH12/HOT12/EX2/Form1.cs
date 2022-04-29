using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX2
{
    public partial class Form1 : Form
    {
        List<Computer> computer = new List<Computer>()
        {
            new Computer("My-Desktop", "127.0.0.1"),
            new Computer("google-public-dns", "8.8.8.8"),
            new Computer("ranken.edu", "47.44.246.80")
        };

        string[] services = new string[8];
        [
            "20: FTP_DATA";
            "21: FTP_CONTROL";
            "23: TELNET";
            "53: DNS";
            "80: HTTP";
            "123: NTP";
            "389: LDAP";
            "443: HTTPS";
         ]

        public Form1() => InitializeComponent();

        private void btnScan_Click(object sender, EventArgs e)
        {
            string inputAddress = txtIpAddress.Text;
            ScanIpAddress(inputAddress);
            ShowComputer();
        }
        public string ScanIpAddress(string ipAddress)
        {

            for (int i = 0; i < computer.Count; i++)
            {
                if (computer[i].IpAddress == ipAddress)
                {
                    ShowComputer(computer[i]);
                }
                else
                {
                    ShowComputer();
                }
            }
        }
        public Computer ShowComputer(Computer computer)
        {
            if (computer == null)
            {
                lblComputerName.Text = "REQUEST TIMED OUT";
                lblIpAddress.Text = "";
                lblServiceOut.Text = "NONE";
            }
            else if (computer.Count == computer[i])
            {
                lblComputerName.Text = computer[i].Name;
                lblIpAddress.Text = computer.IpAddress;
                lblServiceOut.Text = String.Format("{0}", services.Length);
            }
            else if (computer.Count == computer[i])
            {
                lblComputerName.Text = computer.Name;
                lblIpAddress.Text = computer.IpAddress;
                lblServiceOut.Text = String.Format("{0}", services[3]);
            }
            else if (computer.Count == computer[i])
            {
                lblComputerName.Text = computer.Name;
                lblIpAddress.Text = computer.IpAddress;
                lblServiceOut.Text = String.Format("{0}", services[3], services[5], services[8]);
            }
        }
    }
}
