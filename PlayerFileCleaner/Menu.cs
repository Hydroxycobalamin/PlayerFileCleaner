using PlayerFileCleaner.Helpers;
using System.Diagnostics;
using System.Reflection;

namespace PlayerFileCleaner {
    public partial class Menu : Form {
        public Menu() {
            InitializeComponent();

        }

        private void Menu_Load(object sender, EventArgs e) {
            LbVersion.Text = "Version: " + Assembly.GetExecutingAssembly().GetName().Version;
        }

        private void btnSelectJSON_Click(object sender, EventArgs e) {
            string filePath = FileManager.LoadFileName();
            tbJsonPath.Text = filePath;
        }

        private void BtnStartCleaning_Click(object sender, EventArgs e) {
            bool cleanGeyser = CbGeyser.Checked;
            string filePathJson = tbJsonPath.Text;
            if (filePathJson.Equals("") || filePathJson == null) {
                MessageBox.Show("You must select a player_names.json file.", "PlayerFileCleaner");
                return;
            }
            string outputPath = TbOutputPath.Text;
            if (outputPath.Equals("") || outputPath == null) {
                MessageBox.Show("You must select a path for the output.", "PlayerFileCleaner");
                return;
            }
            string filePathWorld = TbWorldPath.Text;
            if (filePathWorld.Equals("") || filePathWorld == null) {
                MessageBox.Show("You must select a world.", "PlayerFileCleaner");
                return;
            }
            string? worldName = Path.GetFileName(filePathWorld);
            if (worldName == null) {
                MessageBox.Show("World name could not be found. Please check the path.", "PlayerFileCleaner");
                return;
            }
            var playerNames = FileManager.LoadFile(filePathJson);
            if (playerNames.Count == 0) {
                MessageBox.Show("The player_names.json file is empty.", "PlayerFileCleaner");
                return;
            }
            string[] advancementsFiles = FileManager.ListFiles(filePathWorld + "\\advancements");
            string[] playerFiles = FileManager.ListFiles(filePathWorld + "\\playerdata");
            
            Cleaner cleaner = new();
            outputPath += "\\PlayerFileCleaner\\";
            Directory.CreateDirectory(outputPath);
            Logging.Init(outputPath + "\\Logs.log", 1);
            cleaner.InitializeCleanup(playerNames, advancementsFiles, playerFiles, outputPath, worldName, cleanGeyser);
        }

        private void tbJsonPath_TextChanged(object sender, EventArgs e) {
            if (tbJsonPath.Text != string.Empty && !tbJsonPath.Text.Equals("")
                && TbWorldPath.Text != string.Empty && !TbWorldPath.Text.Equals("")
                && TbOutputPath.Text != string.Empty && !TbOutputPath.Text.Equals("")) {
                BtnStartCleaning.Enabled = true;
            }
        }

        private void BtnSelectWorld_Click(object sender, EventArgs e) {
            var filePathWorld = FileManager.LoadDirectoryName();
            TbWorldPath.Text = filePathWorld;
        }

        private void BtnSelectOutputFolder_Click(object sender, EventArgs e) {
            var filePathOutput = FileManager.LoadDirectoryName();
            TbOutputPath.Text = filePathOutput;
        }

        private void LlAuthor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            try {
                VisitLink();
            } catch (Exception ex) {
                MessageBox.Show("Unable to open link that was clicked.\n" + ex.Message);
            }
        }
        private void VisitLink() {
            LlAuthorName.LinkVisited = true;
            ProcessStartInfo psInfo = new ProcessStartInfo {
                FileName = "https://github.com/hydroxycobalamin",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }
    }
}