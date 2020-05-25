using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;

namespace Server
{
    public partial class Server : Form
    {
       
        public const int BUFFER = 1024 * 1024 * 10;
        public Server()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;

            txtIP.Text = GetIPv4();
            
        }

        #region GetIP
        public string GetLocalIPv4(NetworkInterfaceType _type)
        {
            string output = "";
            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (item.NetworkInterfaceType == _type && item.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            output = ip.Address.ToString();
                        }
                    }
                }
            }
            return output;
        }
        public string GetIPv4()
        {

            string ipLocal = GetLocalIPv4(System.Net.NetworkInformation.NetworkInterfaceType.Wireless80211);
            if (string.IsNullOrEmpty(ipLocal))
            {
                ipLocal = GetLocalIPv4(System.Net.NetworkInformation.NetworkInterfaceType.Ethernet);
            }
            return ipLocal;
        }
        #endregion

        #region Server
        List<Socket> listClient;
        IPEndPoint ipe;
        Socket server;
        void CreateServer()
        {
            listClient = new List<Socket>();
            ipe = new IPEndPoint(IPAddress.Any, int.Parse(txtPort.Value.ToString()));
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            server.Bind(ipe);

            Thread Listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(100);
                        Socket client = server.Accept();
                        listClient.Add(client);

                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                catch
                {
                    ipe = new IPEndPoint(IPAddress.Any, 9999);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
            });
            Listen.IsBackground = true;
            Listen.Start();

        }
        #endregion

        //Sửa hàm receive để có full tính năng
        #region Send Receive
        void Send(object obj, Socket client)
        {
            client.Send(SerializeData(obj));
        }
        public byte[] SerializeData(Object o)
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf1 = new BinaryFormatter();
            bf1.Serialize(ms, o);
            return ms.ToArray();
        }
        void Receive(object obj)
        {
            Socket client = obj as Socket;

            #region Hiển thị
            txtTrangThai.AppendText(client.RemoteEndPoint.ToString() + " đã kết nối vào hệ thống lúc " + DateTime.Now + "..... \n");

            string[] arr = new string[2];
            ListViewItem itm;
            //thêm Item vào ListView
            arr[0] = client.RemoteEndPoint.ToString();
            arr[1] = "Khách";
            itm = new ListViewItem(arr);
            ListView.Items.Add(itm);

            labTongKetNoi.Text = "Tổng kết nối: " + ListView.Items.Count.ToString();
            #endregion

            #region Xử lý dữ liệu
            try
            {
                while (true)
                {
                    byte[] data = new byte[BUFFER];
                    client.Receive(data);
                   
                    Data.SocketData socketData = (Data.SocketData)DeserializeData(data);
                    txtTrangThai.AppendText(socketData.Ojb.ToString());


                    //switch (socketData.Command)
                    //{
                    //    case (int)Data.SocketCommand.Exit:
                    //        try
                    //        {
                    //            txtTrangThai.AppendText(client.RemoteEndPoint.ToString() + " đã ngắt kết nối lúc"+ DateTime.Now + ".....\n");
                    //            listClient.Remove(client);
                    //            client.Close();
                    //            ListView.Items.Remove(itm);
                    //            labTongKetNoi.Text = "Tổng kết nối: " + ListView.Items.Count.ToString();
                    //            ListView.Invalidate();


                    //        }
                    //        catch
                    //        {
                    //            ipe = new IPEndPoint(IPAddress.Any, 9999);
                    //            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                    //        }
                    //        break;
                    //    case (int)Data.SocketCommand.Sql:
                    //        txtTrangThai.AppendText((string)socketData.Ojb+"\n");
                    //        break;
                    //}
                }
            }
            catch
            {
                listClient.Remove(client);
                client.Close();
            }
            #endregion
        }
        public object DeserializeData(byte[] theByteArray)
        {
            MemoryStream ms = new MemoryStream(theByteArray);
            BinaryFormatter bf1 = new BinaryFormatter();
            ms.Position = 0;
            return bf1.Deserialize(ms);
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            //txtShowMess.Text += txtSend.Text + "\n";
            foreach (Socket item in listClient)
            {
                //Send(txtSend.Text, item);
            }

        }
        #endregion


        private void btnCreaterServer_Click(object sender, EventArgs e)
        {
            if (btnCreaterServer.Text == "Bắt đầu")
            {
                CreateServer();
                btnCreaterServer.Enabled = false;
                txtPort.Enabled = false;
                btnCreaterServer.Text = "Đang kết nối....";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i=0;i<listClient.Count;i++)
            {
                Send("Khang", listClient[i]);
            }
        }
    }


}

