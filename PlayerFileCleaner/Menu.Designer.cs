namespace PlayerFileCleaner {
    partial class Menu {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.BtnStartCleaning = new System.Windows.Forms.Button();
            this.CbGeyser = new System.Windows.Forms.CheckBox();
            this.TbWorldPath = new System.Windows.Forms.TextBox();
            this.tbJsonPath = new System.Windows.Forms.TextBox();
            this.LbPathJson = new System.Windows.Forms.Label();
            this.btnSelectJSON = new System.Windows.Forms.Button();
            this.LbPathOutput = new System.Windows.Forms.Label();
            this.LbPathWorld = new System.Windows.Forms.Label();
            this.BtnSelectWorld = new System.Windows.Forms.Button();
            this.TbOutputPath = new System.Windows.Forms.TextBox();
            this.BtnSelectOutputFolder = new System.Windows.Forms.Button();
            this.LbOptions = new System.Windows.Forms.Label();
            this.LbVersion = new System.Windows.Forms.Label();
            this.LlAuthorName = new System.Windows.Forms.LinkLabel();
            this.LbAuthor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnStartCleaning
            // 
            this.BtnStartCleaning.Enabled = false;
            this.BtnStartCleaning.Location = new System.Drawing.Point(27, 12);
            this.BtnStartCleaning.Name = "BtnStartCleaning";
            this.BtnStartCleaning.Size = new System.Drawing.Size(149, 65);
            this.BtnStartCleaning.TabIndex = 5;
            this.BtnStartCleaning.Text = "Start";
            this.BtnStartCleaning.UseVisualStyleBackColor = true;
            this.BtnStartCleaning.Click += new System.EventHandler(this.BtnStartCleaning_Click);
            // 
            // CbGeyser
            // 
            this.CbGeyser.AutoSize = true;
            this.CbGeyser.Location = new System.Drawing.Point(202, 36);
            this.CbGeyser.Name = "CbGeyser";
            this.CbGeyser.Size = new System.Drawing.Size(115, 19);
            this.CbGeyser.TabIndex = 6;
            this.CbGeyser.Text = "Clean Geyser(V0)";
            this.CbGeyser.UseVisualStyleBackColor = true;
            // 
            // TbWorldPath
            // 
            this.TbWorldPath.Enabled = false;
            this.TbWorldPath.Location = new System.Drawing.Point(367, 84);
            this.TbWorldPath.Name = "TbWorldPath";
            this.TbWorldPath.Size = new System.Drawing.Size(545, 23);
            this.TbWorldPath.TabIndex = 7;
            this.TbWorldPath.TextChanged += new System.EventHandler(this.tbJsonPath_TextChanged);
            // 
            // tbJsonPath
            // 
            this.tbJsonPath.Enabled = false;
            this.tbJsonPath.Location = new System.Drawing.Point(367, 12);
            this.tbJsonPath.Name = "tbJsonPath";
            this.tbJsonPath.Size = new System.Drawing.Size(545, 23);
            this.tbJsonPath.TabIndex = 2;
            this.tbJsonPath.TextChanged += new System.EventHandler(this.tbJsonPath_TextChanged);
            // 
            // LbPathJson
            // 
            this.LbPathJson.AutoSize = true;
            this.LbPathJson.Location = new System.Drawing.Point(685, 45);
            this.LbPathJson.Name = "LbPathJson";
            this.LbPathJson.Size = new System.Drawing.Size(131, 15);
            this.LbPathJson.TabIndex = 3;
            this.LbPathJson.Text = "player_names.json path";
            // 
            // btnSelectJSON
            // 
            this.btnSelectJSON.Location = new System.Drawing.Point(822, 41);
            this.btnSelectJSON.Name = "btnSelectJSON";
            this.btnSelectJSON.Size = new System.Drawing.Size(90, 23);
            this.btnSelectJSON.TabIndex = 4;
            this.btnSelectJSON.Text = "select File";
            this.btnSelectJSON.UseVisualStyleBackColor = true;
            this.btnSelectJSON.Click += new System.EventHandler(this.btnSelectJSON_Click);
            // 
            // LbPathOutput
            // 
            this.LbPathOutput.AutoSize = true;
            this.LbPathOutput.Location = new System.Drawing.Point(771, 191);
            this.LbPathOutput.Name = "LbPathOutput";
            this.LbPathOutput.Size = new System.Drawing.Size(45, 15);
            this.LbPathOutput.TabIndex = 12;
            this.LbPathOutput.Text = "Output";
            // 
            // LbPathWorld
            // 
            this.LbPathWorld.AutoSize = true;
            this.LbPathWorld.Location = new System.Drawing.Point(777, 120);
            this.LbPathWorld.Name = "LbPathWorld";
            this.LbPathWorld.Size = new System.Drawing.Size(39, 15);
            this.LbPathWorld.TabIndex = 8;
            this.LbPathWorld.Text = "World";
            // 
            // BtnSelectWorld
            // 
            this.BtnSelectWorld.Location = new System.Drawing.Point(822, 116);
            this.BtnSelectWorld.Name = "BtnSelectWorld";
            this.BtnSelectWorld.Size = new System.Drawing.Size(90, 23);
            this.BtnSelectWorld.TabIndex = 9;
            this.BtnSelectWorld.Text = "select Folder";
            this.BtnSelectWorld.UseVisualStyleBackColor = true;
            this.BtnSelectWorld.Click += new System.EventHandler(this.BtnSelectWorld_Click);
            // 
            // TbOutputPath
            // 
            this.TbOutputPath.Enabled = false;
            this.TbOutputPath.Location = new System.Drawing.Point(367, 158);
            this.TbOutputPath.Name = "TbOutputPath";
            this.TbOutputPath.Size = new System.Drawing.Size(545, 23);
            this.TbOutputPath.TabIndex = 10;
            this.TbOutputPath.TextChanged += new System.EventHandler(this.tbJsonPath_TextChanged);
            // 
            // BtnSelectOutputFolder
            // 
            this.BtnSelectOutputFolder.Location = new System.Drawing.Point(822, 187);
            this.BtnSelectOutputFolder.Name = "BtnSelectOutputFolder";
            this.BtnSelectOutputFolder.Size = new System.Drawing.Size(90, 23);
            this.BtnSelectOutputFolder.TabIndex = 11;
            this.BtnSelectOutputFolder.Text = "select Folder";
            this.BtnSelectOutputFolder.UseVisualStyleBackColor = true;
            this.BtnSelectOutputFolder.Click += new System.EventHandler(this.BtnSelectOutputFolder_Click);
            // 
            // LbOptions
            // 
            this.LbOptions.AutoSize = true;
            this.LbOptions.Location = new System.Drawing.Point(202, 12);
            this.LbOptions.Name = "LbOptions";
            this.LbOptions.Size = new System.Drawing.Size(49, 15);
            this.LbOptions.TabIndex = 13;
            this.LbOptions.Text = "Options";
            // 
            // LbVersion
            // 
            this.LbVersion.AutoSize = true;
            this.LbVersion.Location = new System.Drawing.Point(367, 217);
            this.LbVersion.Name = "LbVersion";
            this.LbVersion.Size = new System.Drawing.Size(51, 15);
            this.LbVersion.TabIndex = 14;
            this.LbVersion.Text = "Version: ";
            // 
            // LlAuthorName
            // 
            this.LlAuthorName.AutoSize = true;
            this.LlAuthorName.Location = new System.Drawing.Point(80, 217);
            this.LlAuthorName.Name = "LlAuthorName";
            this.LlAuthorName.Size = new System.Drawing.Size(108, 15);
            this.LlAuthorName.TabIndex = 15;
            this.LlAuthorName.TabStop = true;
            this.LlAuthorName.Text = "Hydroxycobalamin";
            this.LlAuthorName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlAuthor_LinkClicked);
            // 
            // LbAuthor
            // 
            this.LbAuthor.AutoSize = true;
            this.LbAuthor.Location = new System.Drawing.Point(27, 217);
            this.LbAuthor.Name = "LbAuthor";
            this.LbAuthor.Size = new System.Drawing.Size(47, 15);
            this.LbAuthor.TabIndex = 16;
            this.LbAuthor.Text = "Author:";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(924, 241);
            this.Controls.Add(this.LbAuthor);
            this.Controls.Add(this.LlAuthorName);
            this.Controls.Add(this.LbVersion);
            this.Controls.Add(this.LbOptions);
            this.Controls.Add(this.LbPathOutput);
            this.Controls.Add(this.BtnSelectOutputFolder);
            this.Controls.Add(this.TbOutputPath);
            this.Controls.Add(this.BtnSelectWorld);
            this.Controls.Add(this.LbPathWorld);
            this.Controls.Add(this.TbWorldPath);
            this.Controls.Add(this.CbGeyser);
            this.Controls.Add(this.BtnStartCleaning);
            this.Controls.Add(this.btnSelectJSON);
            this.Controls.Add(this.LbPathJson);
            this.Controls.Add(this.tbJsonPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(940, 280);
            this.Name = "Menu";
            this.Text = "Player File Cleaner";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button BtnStartCleaning;
        private CheckBox CbGeyser;
        private TextBox TbWorldPath;
        private TextBox tbJsonPath;
        private Label LbPathJson;
        private Button btnSelectJSON;
        private Label LbPathOutput;
        private Label LbPathWorld;
        private Button BtnSelectWorld;
        private TextBox TbOutputPath;
        private Button BtnSelectOutputFolder;
        private Label LbOptions;
        private Label LbVersion;
        private LinkLabel LlAuthorName;
        private Label LbAuthor;
    }
}