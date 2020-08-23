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
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Server_Client
{
  
    public partial class Form2 : Form
    {
        private byte[] buffer = new byte[1024];
        public List<SocketT2h> ClientSocket { get; set; }
        private Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        public Form2()
        {
            InitializeComponent();

            PortTextBox.Text = "7000";
            IPAddress[] getLocalIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in getLocalIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    ServerIPTextBox.Text = address.ToString();
                }
            }
            CheckForIllegalCrossThreadCalls = false;
            ClientSocket = new List<SocketT2h>();
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

        private void StaerServerButton_Click(object sender, EventArgs e)
        {
            LoTextBox.Text = "Waiting for connection...";
            serverSocket.Bind(new IPEndPoint(IPAddress.Any, int.Parse(PortTextBox.Text)));
            serverSocket.Listen(1);
            serverSocket.BeginAccept(new AsyncCallback(AppceptCallback), null);
        }

       
        private void AppceptCallback(IAsyncResult ar)
        {
            Socket socket = serverSocket.EndAccept(ar);
            ClientSocket.Add(new SocketT2h(socket));
            listBox1.Items.Add(socket.RemoteEndPoint.ToString());
            ChatTextBox.Text = "Clients connedced to this server: " + ClientSocket.Count.ToString();
            string clientIPAddress = ("New IP Address is Connected: ") + (IPAddress.Parse(((IPEndPoint)socket.RemoteEndPoint).Address.ToString())) + ("\r\n");
            ChatTextBox.AppendText(clientIPAddress);
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
                catch (Exception)
                {
                    for (int i = 0; i < ClientSocket.Count; i++)
                    {
                        if (ClientSocket[i].SocketClient.RemoteEndPoint.ToString().Equals(socket.RemoteEndPoint.ToString()))
                        {
                            ClientSocket.RemoveAt(i);
                            ChatTextBox.Text = "Clients connected to this server: " + ClientSocket.Count.ToString();
                        }
                    }
                    return;
                }
                if (received != 0)
                {
                    byte[] dataBuf = new byte[received];
                    Array.Copy(buffer, dataBuf, received);
                    string text = Encoding.ASCII.GetString(dataBuf);
                    ChatTextBox.AppendText("Client: " + text + "\r\n");
                    string repomse = string.Empty;
                    if (text.Contains("@@"))
                    {
                        for (int i = 0; i < listBox1.Items.Count; i++)
                        {
                            if (socket.RemoteEndPoint.ToString().Equals(ClientSocket[i].SocketClient.RemoteEndPoint.ToString()))
                            {
                                listBox1.Items.RemoveAt(i);
                                listBox1.Items.Insert(i, text.Substring(1, text.Length - 1));
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

        private void SendButton_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < ClientSocket.Count; j++)
            {
                {
                    Sendata(ClientSocket[j].SocketClient, SendTextBox.Text);
                }
            }
            ChatTextBox.AppendText("Server: " + SendTextBox.Text + "\r\n");
            SendTextBox.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SendTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendButton_Click(sender, e);
            }
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
           
        }

        private void ShutDownBtuu_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void CliearButton_Click(object sender, EventArgs e)
        {
            ChatTextBox.Clear();
        }
    }
}
