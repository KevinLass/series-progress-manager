using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesProgressManager.Helper {
    public class ProcessHelper {
        public static void StartProcess(string filename, string videoPath) {
            Process p = new Process();
            p.StartInfo.FileName = filename;
            p.StartInfo.Arguments = $"\"{videoPath}\"";
            p.Start();
        }
    }
}
