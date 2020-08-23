using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ServerButton_Click(object sender, EventArgs e)
        {
            Form2 Server = new Form2();
            Server.Show();
            this.Hide();
        }

        private void ClientButton_Click(object sender, EventArgs e)
        {
            Form3 Client = new Form3();
            Client.Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
