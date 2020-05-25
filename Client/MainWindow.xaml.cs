using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Data;
using Client.ViewModel;

namespace Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      
        
        public MainWindow()
        {

            InitializeComponent();
            
            //Connect("192.168.56.1");
        }

        #region Client

        public const int BUFFER = 1024 * 1024 * 10;
        Socket client;
        IPEndPoint ipe;

        //Hàm kết nối
        void Connect(string IP)
        {
            ipe = new IPEndPoint(IPAddress.Parse(IP), 9999);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            try
            {
                client.Connect(ipe);

            }
            catch
            {
                MessageBox.Show("Không thể kết nối đến server.");
                return;
            }

            Thread threadListen = new Thread(Receive);
            threadListen.IsBackground = true;
            threadListen.Start();
        }
       

        //Hàm gửi dữ liệu
        void Send(object obj)
        {
            client.Send(SerializeData(obj));
        }

        //Mã hóa dữ liệu
        public byte[] SerializeData(Object o)
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf1 = new BinaryFormatter();
            bf1.Serialize(ms, o);
            return ms.ToArray();
        }


        //Thực hiện nhận dữ liệu
        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[BUFFER];

                    client.Receive(data);

                   
                 

                }
            }
            catch
            {
                client.Close();
            }
        }
        
        //Giã mã dữ liệu
        public object DeserializeData(byte[] theByteArray)
        {
            MemoryStream ms = new MemoryStream(theByteArray);
            BinaryFormatter bf1 = new BinaryFormatter();
            ms.Position = 0;
            return bf1.Deserialize(ms);
        }

        #endregion

      

        private void BtnHideTab_Click(object sender, RoutedEventArgs e)
        {
            tabTinhNang.Visibility = Visibility.Collapsed;
            btnShowTab.Visibility = Visibility.Visible;
        }

        private void BtnShowTab_Click(object sender, RoutedEventArgs e)
        {
            tabTinhNang.Visibility = Visibility.Visible;
            btnShowTab.Visibility = Visibility.Collapsed;
        }

    

        private void TreeView_Expanded(object sender, RoutedEventArgs e)
        {
            
        }

        private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            TreeView a = sender as TreeView;
             TreeViewItem treeViewItem = e.NewValue as TreeViewItem;
            if ((a.SelectedItem as TreeViewItem).Header.ToString() == "Tìm kiếm sách")
                userTimKiemSach.Visibility = Visibility.Visible;
            else
                userTimKiemSach.Visibility = Visibility.Collapsed;
               
        }

        private void TxtTimmKiem_Tab_TextChanged(object sender, TextChangedEventArgs e)
        {
            

        }

        void TimKiemTreeView(TreeViewItem treeViewItem)
        {
            for(int i=0;i<treeViewItem.Items.Count;i++)
            {
                //if(treeViewItem.Items[i])
            }
        }
    }
}
