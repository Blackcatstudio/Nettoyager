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
using static System.Windows.Navigation.NavigationService;
using System.Windows.Navigation;
using System.Windows.Shapes;

using MahApps.Metro.Controls;
using MahApps.Metro;
using MahApps.Metro.Controls.Dialogs;

namespace MetroWPF
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        /* 编码提醒 
           Frame的Navigate控制并不需要如此复杂的定义方式
           只需要一行代码即可解决
           请负责人注意
             */
/*我已经改了 --2016/8/22 RL*/
        public MainWindow()
        {
            InitializeComponent();
            

            //frameNavServ.Navigate(uriMainFrm);
            this.frame.Navigate(new MainFrm());
        }

        private void MetroWindow_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            frame.Height = this.Height;
            frame.Width = this.Width;
        }
    }
}
