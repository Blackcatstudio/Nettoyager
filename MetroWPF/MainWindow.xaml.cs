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
    public partial class MainWindow : NavigationWindow
    {
        /* 编码提醒 
           Frame的Navigate控制并不需要如此复杂的定义方式
           只需要一行代码即可解决
           请负责人注意
             */
        /* 已经改掉了 --2016/8/22 RL */

        public MainWindow()
        {
            InitializeComponent();
            GetNavigationService(this).Navigate(new MainFrm());
        }

        /*private void Start(object sender, RoutedEventArgs e)
        {
             ERIC对这句表示强烈吐槽 
        //this.ShowMessageAsync("无反应", "因为现在的Nettoyager只有UI");  注释了不就可以了，
                                                                       反正这是个废函数 --RL
        }*/
    }
}
