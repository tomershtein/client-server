using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Sockets;
using System.Net;
using Renci.SshNet;
using Renci.SshNet.Sftp;


namespace linux_SSH_connection
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            IPTextBox.Text = "127.0.0.1";
            PortTextBox.Text = "7000";
            label5.Text = "Not Connected";
            FilenameComboBox.Text = "Not Selected";
            Sampel_RateComboBox.Text = "Not Selected";
            Center_FrequencyComboBox.Text = "Not Selected";
            PowerComboBox.Text = "Not Selected";
            PortComboBox.Text = "Not Selected";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SshClient client = new SshClient(IPTextBox.Text, PortTextBox.Text);
            client.Connect();
            Consoletext.AppendText("Connected" + "\n");
            string ch = Consoletext.Text;
            Byte[] message = Encoding.Unicode.GetBytes(ch);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Consoletext.AppendText("curl -XPOST -H " + "Content - Type: application / json" + "127.0.0.1:8080/api/tx_on_external_file -d " + ("\n" + FilenameComboBox.Text ) + (Sampel_RateComboBox.Text )) ;
            string ch = Consoletext.Text;

        }

    }
}
