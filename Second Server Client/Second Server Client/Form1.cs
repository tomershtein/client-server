using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Second_Server_Client
{

    public partial class Form1 : Form
    {
        private byte[] buffer = new byte[1024];
        public List<SocketT2h> ClientSocket { get; set; }
        List<string> _names = new List<string>();
        private Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        public Form1()
        {
            InitializeComponent();
            PortTextBox.Text = "7000";
            IPAddress[] getLocalIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in getLocalIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    IPTextBox.Text = address.ToString();
                }
            }
            CheckForIllegalCrossThreadCalls = false;
            ClientSocket = new List<SocketT2h>();
        }

        private void Startbutton_Click(object sender, EventArgs e)
        {
            StartServer();
        }
        public class SocketT2h
        {
            public Socket SocketClient { get; set; }
            public string ClientName { get; set; }
            public SocketT2h(Socket socket)
            {
                this.SocketClient = socket;
            }
        }

        private void StartServer()
        {
            textBox3.Text = "Waiting for connection...";
            serverSocket.Bind(new IPEndPoint(IPAddress.Any, int.Parse(PortTextBox.Text)));
            serverSocket.Listen(1);
            serverSocket.BeginAccept(new AsyncCallback(AppceptCallback), null);
        }

        private void AppceptCallback(IAsyncResult ar)
        {
            Socket socket = serverSocket.EndAccept(ar);
            ClientSocket.Add(new SocketT2h(socket));
            listBox.Items.Add(socket.RemoteEndPoint.ToString());
            textBox3.Text = "Connection";
            string clientIPAddress = ("New IP Address is Connected: ") + (IPAddress.Parse(((IPEndPoint)socket.RemoteEndPoint).Address.ToString())) + ("\r\n");
            textBox1.AppendText(clientIPAddress);
            socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);
            serverSocket.BeginAccept(new AsyncCallback(AppceptCallback), null);
        }

        private void ReceiveCallback(IAsyncResult ar)
        {
            Socket socket = (Socket)ar.AsyncState;
            if (socket.Connected)
            {
                int received;
                try
                {
                    received = socket.EndReceive(ar);
                }
                catch(Exception)
                {
                    for(int i = 0; i < ClientSocket.Count; i++)
                    {
                        if (ClientSocket[i].SocketClient.RemoteEndPoint.ToString().Equals(socket.RemoteEndPoint))
                        {
                            ClientSocket.RemoveAt(i);
                        }
                    }
                    return;
                }
                if (received != 0)
                {
                    byte[] dataBuf = new byte[received];
                    Array.Copy(buffer, dataBuf, received);
                    string text = Encoding.ASCII.GetString(dataBuf);
                    textBox1.AppendText(socket.RemoteEndPoint + " Client: " + text + "\r\n");
                        string repomse = string.Empty;
                    if (text.Contains("@@"))
                    {
                        for (int i = 0; i < listBox.Items.Count; i++)
                        {
                            if (socket.RemoteEndPoint.ToString().Equals(ClientSocket[i].SocketClient.RemoteEndPoint.ToString()))
                            {
                                listBox.Items.RemoveAt(i);
                                listBox.Items.Insert(i, text.Substring(1, text.Length - 1));
                                ClientSocket[i].ClientName = text;
                                socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);
                                return;
                            }
                        }
                    }
                }
                socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);
            }
           
        }

        void Sendata(Socket socket, string noidung)
        {
            byte[] data = Encoding.ASCII.GetBytes(noidung);
            socket.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(SendCallback), socket);
            serverSocket.BeginAccept(new AsyncCallback(AppceptCallback), null);
        }

        private void SendCallback(IAsyncResult AR)
        {
            Socket socket = (Socket)AR.AsyncState;
            socket.EndSend(AR);
        }

        private void Sendbutton_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < ClientSocket.Count; j++)
            {
                {
                    Sendata(ClientSocket[j].SocketClient, textBox2.Text);
                }
            }
            textBox1.AppendText("Server: " + textBox2.Text + "\r\n");
            textBox2.Text = "";
        }

        private void textBox2_KeyDown(object sender, EventArgs e)
        {
            if (e.KeyCode == Keys.Enter)     
            {
                Sendbutton_Click(sender, e);   
            }

        }

        private void Stopbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
