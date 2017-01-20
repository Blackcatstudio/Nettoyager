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

namespace MetroWPF.Pages
{
    /// <summary>
    /// Scanning.xaml 的交互逻辑
    /// </summary>
    public partial class Scanning : Page
    {
        public Scanning(int clrMode,string pathOfDotMC)
        {
            InitializeComponent();
            scanAction(pathOfDotMC);
        }

        void scanAction(string dotMCPath)
        {
            addLogLine("在" + dotMCPath + "中寻找垃圾：");

        }

        void completeScan()
        {

        }

        void addLogLine(string adding, bool newLine = true)
        {
            if (newLine)
                scanLogs.Text += "\n" + adding;
            else
                scanLogs.Text += "\n" + adding;
        }
    }
}
