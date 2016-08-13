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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RunGame(object sender, RoutedEventArgs e)
        {
            
        }

        private void SkinSetting(object sender, RoutedEventArgs e)
        {
            this.ShowMessageAsync("NorthStar个性化设置打开失败!", "NorthStar个性化设置暂不开放~(我才不会说是程序猿懒得做呢!)");
        }
    }
}
