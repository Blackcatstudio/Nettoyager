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
    /// MainFrm.xaml 的交互逻辑
    /// </summary>
    public partial class MainFrm : Page
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MainFrm());
        }

        private void tileScan_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Pages.Road());
        }
    }
}
