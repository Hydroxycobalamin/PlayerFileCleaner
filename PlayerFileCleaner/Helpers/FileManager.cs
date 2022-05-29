using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerFileCleaner.Helpers {
    internal class FileManager {
        /// <summary>
        /// Loads a json file.
        /// </summary>
        /// <returns> Dict -> string: string </returns>
        public static Dictionary<string, string> LoadFile(string filePath) {
            var values = new Dictionary<string, string>();
            if (!File.Exists(filePath)) {
                Logging.Write("Error loading file: " + filePath + "\nFile does not exist.");
                MessageBox.Show("File does not exist: " + filePath, "PlayerFileCleaner");
                return values;
            }
            try {
                values = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(filePath));
            } catch (Exception e) {
                Logging.Write("Error loading file: " + filePath + "\nFile structure is not valid", e);
                MessageBox.Show("File structure invalid: " + filePath, "PlayerFileCleaner");
                values = new Dictionary<string, string>();
            }
            if (values == null) {
                Logging.Write("Error loading file: " + filePath + "\nFile structure is not valid");
                MessageBox.Show("File structure invalid: " + filePath, "PlayerFileCleaner");
                values = new Dictionary<string, string>();
                return values;
            }
            return values;
        }

        /// <summary>
        /// Opens the file explorer and returns the file path of the selected file.
        /// </summary>
        /// <returns>string</returns>
        public static string LoadFileName() {
            string filePath = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON (*.json)|*.json";
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                if (openFileDialog.OpenFile() != null) {
                    filePath = openFileDialog.FileName;
                }
            }
            return filePath;
        }
        public static string LoadDirectoryName() {
            string directoryPath = "";
            using (var fbd = new FolderBrowserDialog()) {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath)) {
                    directoryPath = fbd.SelectedPath;
                }

            }
            return directoryPath;
        }
        public static string[] ListFiles(string path) {
            string[] files= Array.Empty<string>();
            if (Directory.Exists(path)) {
                files = Directory.GetFiles(path);
            }
            return files;
        }
        public static void MoveFile(string source, string destination, string fileName) {
            if (!(Directory.Exists(destination))) {
                Directory.CreateDirectory(destination);
            }
            if ((File.Exists(destination + fileName))) {
                return;
            }
            File.Move(source, destination + fileName);
            Logging.Write("move", destination + fileName, source);
        }
        public static void CopyFile(string source, string destination, string fileName) {
            if (!(Directory.Exists(destination))) {
                Directory.CreateDirectory(destination);
            }
            if ((File.Exists(destination + fileName))) {
                return;
            }
            File.Copy(source, destination + fileName);
            Logging.Write("copy", destination + fileName, source);
        }
    }
}