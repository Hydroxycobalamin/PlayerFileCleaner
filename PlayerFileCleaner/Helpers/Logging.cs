using System.Diagnostics;
using System.Reflection;

namespace PlayerFileCleaner.Helpers {
    enum Action {
        Deleted = 0,
        Moved = 1,
        Copied = 2
    }
    /// <summary>
    /// Class for logging
    /// </summary>
    public static class Logging {

        private static int fLogLevel = 0;
        private static string fFileName = "";
        /// <summary>
        /// Initialize
        /// </summary>
        /// <param name="fileName">Filename of the log file</param>
        /// <param name="logLevel">Log-Level</param>
        public static void Init(string fileName, int logLevel) {
            fFileName = fileName;
            fLogLevel = logLevel;
            string str = "Start Application, ";
            var version = Assembly.GetExecutingAssembly().GetName().Version;
            str += "Version " + version + ", ";
            str += "Loglevel " + fLogLevel;
            Write("=========================================================================");
            Write(str);
        }

        /// <summary>
        /// Writes a simple string to the logfile
        /// </summary>
        /// <param name="str">Logentry</param>
        public static void Write(string str) {
            try {
                Debug.WriteLine("(!) Logging: " + str);
                FileInfo fi = new FileInfo(fFileName);
                if (fi.Exists && (fi.Length > 1000000)) {
                    string fileNameWithOutExt = Path.GetFileNameWithoutExtension(fFileName);
                    string[] fileNames = Directory.GetFiles(fi.Directory.FullName, fileNameWithOutExt + "_log.*");
                    int newCount = 1;
                    if (fileNames.Length > 0) {
                        string ext = new FileInfo(fileNames[fileNames.Length - 1]).Extension;
                        newCount = Convert.ToInt32(ext.Substring(1)) + 1;
                    }
                    File.Copy(fFileName, fi.Directory.FullName + "\\" + fileNameWithOutExt + "_log." + newCount.ToString("000"));
                    File.Delete(fFileName);
                }
                using StreamWriter sw = File.AppendText(fFileName);
                string[] lines = str.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                if (lines.Length > 0) {
                    sw.WriteLine($"{DateTime.Now:yyyy.MM.dd HH:mm:ss}: {lines[0]}");
                    for (int i = 1; i < lines.Length; i++) {
                        sw.WriteLine("                     {0}", lines[i]);
                    }
                }
                sw.Flush();
            } catch {
            }
        }

        /// <summary>
        /// Writes a logentry with a exception.
        /// If loglevel >1 the whole Exception-Stack will be written down.
        /// </summary>
        /// <param name="message">Log-Eintrag</param>
        /// <param name="e">Exception</param>
        public static void Write(string message, Exception e) {
            if (fLogLevel < 2) {
                message += " " + e.ToString();
            } else {
                message += " " + e.Message + e.StackTrace;
            }
            Write(message);
        }

        public static void Write(short action, string destination, string source) {
            var str = $"[{(Action)action}] File \nfrom {source}\nto {destination}";
            Write(str);
        }

    }
}