using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace Client.Design
{
    /// <summary>
    /// Interaction logic for userTimKiem.xaml
    /// </summary>
    public partial class UCTimKiem : UserControl
    {
        public UCTimKiem()
        {
            InitializeComponent();
            txtPage.Text = "Trang: " + sldPage.Value.ToString() + "/" + sldPage.Maximum.ToString();
            HienThiSach(1000);
            HienThiSachTrongTrang(1);
        }

       

        private void BtnChevronDoubleLeft_Click(object sender, RoutedEventArgs e)
        {
            sldPage.Value = sldPage.Minimum;
        }

        private void BtnChevronLeft_Click(object sender, RoutedEventArgs e)
        {
            sldPage.Value = sldPage.Value > sldPage.Minimum ? sldPage.Value - 1: sldPage.Value;
        }

        private void BtnChevronRight_Click(object sender, RoutedEventArgs e)
        {
            sldPage.Value = sldPage.Value < sldPage.Maximum ? sldPage.Value + 1 : sldPage.Value;
        }

        private void BtnChevronDoubleRight_Click(object sender, RoutedEventArgs e)
        {
            sldPage.Value = sldPage.Maximum;
        }
       

        private void SldPage_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            try
            {
                txtPage.Text = "Trang: " + sldPage.Value.ToString() + "/" + sldPage.Maximum.ToString();
                HienThiSachTrongTrang((int)sldPage.Value);
            }
            catch { }
        }
        void HienThiSach(int x)
        {
            sldPage.Maximum = x % 25 > 0 ? x / 25 + 1 : x / 25;
        }
        void HienThiSachTrongTrang(int soTrang)
        {
            pnlHienThiSach.Children.Clear();
            for (int i=(soTrang-1)*25+1;i<=soTrang*25;i++)
            {
                pnlHienThiSach.Children.Add(new UCSach(i) { Width=200, Height = 320});
            }
        }

        
    }
}
