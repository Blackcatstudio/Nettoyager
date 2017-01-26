using System;
using System.IO;
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
using System.Runtime.InteropServices;



namespace MetroWPF.Pages
{
    /// <summary>
    /// Scanning.xaml 的交互逻辑
    /// </summary>
    public partial class Scanning : Page
    {
        double totalRubbish = 0L;

        string[] paths = new string[] { "\\logs\\" , "\\crash-reports\\"  , "\\asm\\" , "\\AMD\\" , "\\NVIDIA\\" };
        string[] alts = new string[] { "日志文件 logs：", "崩溃报告 crash-reports：", "Forge产生的文件 asm：", "AMD渲染缓存 AMD：", "NVIDIA渲染缓存 NVIDIA：" };

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        static extern bool GetDiskFreeSpace([MarshalAs(UnmanagedType.LPTStr)]string rootPathName, ref int sectorsPerCluster, ref int bytesPerSector, ref int numberOfFreeClusters, ref int totalNumbeOfClusters);

        public Scanning(int clrMode, string pathOfDotMC)
        {
            InitializeComponent();
            scanAction(pathOfDotMC);
        }
        void scanAction(string dotMCPath)
        {
            DirectoryInfo dirControl = new DirectoryInfo(dotMCPath);
            addLogLine("在" + dotMCPath + "中寻找垃圾：");
            for (int i = 0; i < paths.Length; i++)
            {
                addLogLine(alts[i] + ((float)dirSize(dotMCPath + paths[i]) / (1024f * 1024f)).ToString() + "MB");
                scanProgress.Value = 100f * ((float)(i+1) / (float)paths.Length);
            }
            addLogLine("总计大小：" + (totalRubbish/(1024f*1024f)).ToString()+"MB");
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

        long dirSize(string dirPath)
        {
            long totalSize = 0;
            DriveInfo drive = new DriveInfo(dirPath[0].ToString());
            DirectoryInfo locdir = new DirectoryInfo(dirPath);//set path

            if (!locdir.Exists) return 0L;

            FileInfo[] filesinside = locdir.GetFiles();//find files in the directory
            DirectoryInfo[] dirsinside = locdir.GetDirectories();//find dirs in the dirctory

            for (int j = 0; j < dirsinside.Length; j++)
                totalSize += dirSize(dirsinside[j].FullName);//get the size of all the dirs inside

            for (int k = 0; k < filesinside.Length; k++)
            {
                long lengthOfFile = filesinside[k].Length;//get the length of file
                long cluster = GetClusterSize(locdir);
                if(lengthOfFile % cluster != 0)
                    totalSize += cluster + (lengthOfFile - (lengthOfFile % cluster));
            }
            totalRubbish += totalSize;
            return totalSize;
        }




        //From Internet
        public static long GetClusterSize(DirectoryInfo dir)
        {
            long clusterSize = 0;

            DiskInfo diskInfo = new DiskInfo();
            diskInfo = GetDiskInfo(dir.Root.FullName);

            clusterSize = (diskInfo.BytesPerSector * diskInfo.SectorsPerCluster);
            return clusterSize;
        }

        public static DiskInfo GetDiskInfo(string rootPathName)
        {
            DiskInfo diskInfo = new DiskInfo();
            int sectorsPerCluster = 0, bytesPerSector = 0, numberOfFreeClusters = 0, totalNumberOfClusters = 0;
            GetDiskFreeSpace(rootPathName, ref sectorsPerCluster, ref bytesPerSector, ref numberOfFreeClusters, ref totalNumberOfClusters);

            //每簇的扇区数
            diskInfo.SectorsPerCluster = sectorsPerCluster;
            //每扇区字节
            diskInfo.BytesPerSector = bytesPerSector;

            return diskInfo;
        }

        public struct DiskInfo
        {
            public string RootPathName;

            public int SectorsPerCluster;

            public int BytesPerSector;
            public int NumberOfFreeClusters;
            public int TotalNumberOfClusters;
        }

        public static long GetClusterSize(FileInfo file)
        {
            long clusterSize = 0;
            DiskInfo diskInfo = new DiskInfo();
            diskInfo = GetDiskInfo(file.Directory.Root.FullName);
            clusterSize = (diskInfo.BytesPerSector * diskInfo.SectorsPerCluster);
            return clusterSize;
        }
        //End:From Internet
    }
}
