using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Client.Design;
namespace Client.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public bool Isloaded = false;
        public ICommand LoadedWindowCommand { get; set; }

        //mọi thứ xử lý sẽ nằm trong này
        public MainViewModel()
        {
            //LoadedWindowCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            //{
            //    Isloaded = true;

            //}
            //  );

            //WD_LoginWindow loginWindow = new WD_LoginWindow() { Height = 300, Width=450};
            //loginWindow.ShowDialog();

            
            
        }
    }
}
