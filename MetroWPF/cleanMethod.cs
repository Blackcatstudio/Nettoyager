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
                      _crashreportDir = "\\crash-reports\\",
                      _reports = "\\reports\\",
                      _asm = "\\asm\\",
                      _amd = "\\AMD\\",
                      _NVIDIA = "\\NVIDIA\\";
    }

    class deepCleanFiles
    {
        public string _s_assets = "\\assets\\",
                      _s_libraries = "\\libraries\\",
                      _s_mods = "\\mods\\",
                      _s_native = "\\Native\\",
                      _s_natives = "\\natives\\",
                      _s_flan = "\\Flan\\",
                      _s_shader = "\\shaders\\",
                      _s_versions = "\\versions\\";//folders saved
        public string _s_launcherJar = "\\launcher.jar",
                      _s_serverdata = "\\server.dat",
                      _s_options = "\\options.txt",
                      _s_launcherProf = "\\launcher_profiles.json";//files saved
    }
}
