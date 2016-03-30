namespace MidgardCreator
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnCreateHuman = new System.Windows.Forms.Button();
            this.btnCreateElf = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCreateHalfling = new System.Windows.Forms.Button();
            this.btnCreateDwarf = new System.Windows.Forms.Button();
            this.btnCreateGnome = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.menuSettingsDE = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLanguageDE = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLanguageDEGerman = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLanguageDEEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettingsEN = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLanguageEN = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLanguageENGerman = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLanguageENEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateHuman
            // 
            resources.ApplyResources(this.btnCreateHuman, "btnCreateHuman");
            this.btnCreateHuman.Name = "btnCreateHuman";
            this.btnCreateHuman.UseVisualStyleBackColor = true;
            this.btnCreateHuman.Click += new System.EventHandler(this.btnCreateHuman_Click);
            // 
            // btnCreateElf
            // 
            resources.ApplyResources(this.btnCreateElf, "btnCreateElf");
            this.btnCreateElf.Name = "btnCreateElf";
            this.btnCreateElf.UseVisualStyleBackColor = true;
            this.btnCreateElf.Click += new System.EventHandler(this.btnCreateElf_Click);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCreateHalfling
            // 
            resources.ApplyResources(this.btnCreateHalfling, "btnCreateHalfling");
            this.btnCreateHalfling.Name = "btnCreateHalfling";
            this.btnCreateHalfling.UseVisualStyleBackColor = true;
            this.btnCreateHalfling.Click += new System.EventHandler(this.btnCreateHalfling_Click);
            // 
            // btnCreateDwarf
            // 
            resources.ApplyResources(this.btnCreateDwarf, "btnCreateDwarf");
            this.btnCreateDwarf.Name = "btnCreateDwarf";
            this.btnCreateDwarf.UseVisualStyleBackColor = true;
            this.btnCreateDwarf.Click += new System.EventHandler(this.btnCreateDwarf_Click);
            // 
            // btnCreateGnome
            // 
            resources.ApplyResources(this.btnCreateGnome, "btnCreateGnome");
            this.btnCreateGnome.Name = "btnCreateGnome";
            this.btnCreateGnome.UseVisualStyleBackColor = true;
            this.btnCreateGnome.Click += new System.EventHandler(this.btnCreateGnome_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSettingsDE,
            this.menuSettingsEN});
            resources.ApplyResources(this.MainMenu, "MainMenu");
            this.MainMenu.Name = "MainMenu";
            // 
            // menuSettingsDE
            // 
            this.menuSettingsDE.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLanguageDE});
            this.menuSettingsDE.Name = "menuSettingsDE";
            resources.ApplyResources(this.menuSettingsDE, "menuSettingsDE");
            // 
            // menuLanguageDE
            // 
            this.menuLanguageDE.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLanguageDEGerman,
            this.menuLanguageDEEnglish});
            this.menuLanguageDE.Name = "menuLanguageDE";
            resources.ApplyResources(this.menuLanguageDE, "menuLanguageDE");
            // 
            // menuLanguageDEGerman
            // 
            this.menuLanguageDEGerman.Name = "menuLanguageDEGerman";
            resources.ApplyResources(this.menuLanguageDEGerman, "menuLanguageDEGerman");
            this.menuLanguageDEGerman.Click += new System.EventHandler(this.menuLanguageGerman_Click);
            // 
            // menuLanguageDEEnglish
            // 
            this.menuLanguageDEEnglish.Name = "menuLanguageDEEnglish";
            resources.ApplyResources(this.menuLanguageDEEnglish, "menuLanguageDEEnglish");
            this.menuLanguageDEEnglish.Click += new System.EventHandler(this.menuLanguageEnglish_Click);
            // 
            // menuSettingsEN
            // 
            this.menuSettingsEN.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLanguageEN});
            this.menuSettingsEN.Name = "menuSettingsEN";
            resources.ApplyResources(this.menuSettingsEN, "menuSettingsEN");
            // 
            // menuLanguageEN
            // 
            this.menuLanguageEN.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLanguageENGerman,
            this.menuLanguageENEnglish});
            this.menuLanguageEN.Name = "menuLanguageEN";
            resources.ApplyResources(this.menuLanguageEN, "menuLanguageEN");
            // 
            // menuLanguageENGerman
            // 
            this.menuLanguageENGerman.Name = "menuLanguageENGerman";
            resources.ApplyResources(this.menuLanguageENGerman, "menuLanguageENGerman");
            this.menuLanguageENGerman.Click += new System.EventHandler(this.menuLanguageENGerman_Click);
            // 
            // menuLanguageENEnglish
            // 
            this.menuLanguageENEnglish.Name = "menuLanguageENEnglish";
            resources.ApplyResources(this.menuLanguageENEnglish, "menuLanguageENEnglish");
            this.menuLanguageENEnglish.Click += new System.EventHandler(this.menuLanguageENEnglish_Click);
            // 
            // FrmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.btnCreateGnome);
            this.Controls.Add(this.btnCreateDwarf);
            this.Controls.Add(this.btnCreateHalfling);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCreateElf);
            this.Controls.Add(this.btnCreateHuman);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateHuman;
        private System.Windows.Forms.Button btnCreateElf;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCreateHalfling;
        private System.Windows.Forms.Button btnCreateDwarf;
        private System.Windows.Forms.Button btnCreateGnome;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem menuSettingsDE;
        private System.Windows.Forms.ToolStripMenuItem menuLanguageDE;
        private System.Windows.Forms.ToolStripMenuItem menuLanguageDEGerman;
        private System.Windows.Forms.ToolStripMenuItem menuLanguageDEEnglish;
        private System.Windows.Forms.ToolStripMenuItem menuSettingsEN;
        private System.Windows.Forms.ToolStripMenuItem menuLanguageEN;
        private System.Windows.Forms.ToolStripMenuItem menuLanguageENGerman;
        private System.Windows.Forms.ToolStripMenuItem menuLanguageENEnglish;
    }
}