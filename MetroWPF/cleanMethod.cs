using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroWPF
{

    class safeCleanFiles
    {
        //root dir is ".minecraft" folder
        public string _fmlLogs = "\\*.log",
                      _logsDir = "\\logs\\",
                      _crashreportDir = "\\crash-reports\\";
    }

    class deepCleanFiles
    {
        public string _s_assets = "\\assets\\",
                      _s_libraries = "\\libraries\\",
                      _s_mods = "\\mods\\",
                      _s_native = "\\Native\\",
                      _s_natives = "\\natives\\",
                      _s_versions = "\\versions\\"；
    }
}
