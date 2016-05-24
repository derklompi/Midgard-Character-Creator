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
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateHuman
            // 
            this.btnCreateHuman.Location = new System.Drawing.Point(12, 25);
            this.btnCreateHuman.Name = "btnCreateHuman";
            this.btnCreateHuman.Size = new System.Drawing.Size(200, 50);
            this.btnCreateHuman.TabIndex = 0;
            this.btnCreateHuman.Text = "Mensch";
            this.btnCreateHuman.UseVisualStyleBackColor = true;
            this.btnCreateHuman.Click += new System.EventHandler(this.btnCreateHuman_Click);
            // 
            // btnCreateElf
            // 
            this.btnCreateElf.Location = new System.Drawing.Point(12, 81);
            this.btnCreateElf.Name = "btnCreateElf";
            this.btnCreateElf.Size = new System.Drawing.Size(200, 50);
            this.btnCreateElf.TabIndex = 1;
            this.btnCreateElf.Text = "Elf";
            this.btnCreateElf.UseVisualStyleBackColor = true;
            this.btnCreateElf.Click += new System.EventHandler(this.btnCreateElf_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 305);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 50);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCreateHalfling
            // 
            this.btnCreateHalfling.Location = new System.Drawing.Point(12, 137);
            this.btnCreateHalfling.Name = "btnCreateHalfling";
            this.btnCreateHalfling.Size = new System.Drawing.Size(200, 50);
            this.btnCreateHalfling.TabIndex = 2;
            this.btnCreateHalfling.Text = "Halbling";
            this.btnCreateHalfling.UseVisualStyleBackColor = true;
            this.btnCreateHalfling.Click += new System.EventHandler(this.btnCreateHalfling_Click);
            // 
            // btnCreateDwarf
            // 
            this.btnCreateDwarf.Location = new System.Drawing.Point(12, 193);
            this.btnCreateDwarf.Name = "btnCreateDwarf";
            this.btnCreateDwarf.Size = new System.Drawing.Size(200, 50);
            this.btnCreateDwarf.TabIndex = 3;
            this.btnCreateDwarf.Text = "Zwerg";
            this.btnCreateDwarf.UseVisualStyleBackColor = true;
            this.btnCreateDwarf.Click += new System.EventHandler(this.btnCreateDwarf_Click);
            // 
            // btnCreateGnome
            // 
            this.btnCreateGnome.Location = new System.Drawing.Point(12, 249);
            this.btnCreateGnome.Name = "btnCreateGnome";
            this.btnCreateGnome.Size = new System.Drawing.Size(200, 50);
            this.btnCreateGnome.TabIndex = 4;
            this.btnCreateGnome.Text = "Gnom";
            this.btnCreateGnome.UseVisualStyleBackColor = true;
            this.btnCreateGnome.Click += new System.EventHandler(this.btnCreateGnome_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSettingsDE});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(224, 24);
            this.MainMenu.TabIndex = 6;
            this.MainMenu.Text = "menuStrip1";
            this.MainMenu.Visible = false;
            // 
            // menuSettingsDE
            // 
            this.menuSettingsDE.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLanguageDE});
            this.menuSettingsDE.Name = "menuSettingsDE";
            this.menuSettingsDE.Size = new System.Drawing.Size(90, 20);
            this.menuSettingsDE.Text = "Einstellungen";
            // 
            // menuLanguageDE
            // 
            this.menuLanguageDE.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLanguageDEGerman,
            this.menuLanguageDEEnglish});
            this.menuLanguageDE.Name = "menuLanguageDE";
            this.menuLanguageDE.Size = new System.Drawing.Size(152, 22);
            this.menuLanguageDE.Text = "Sprache";
            // 
            // menuLanguageDEGerman
            // 
            this.menuLanguageDEGerman.Name = "menuLanguageDEGerman";
            this.menuLanguageDEGerman.Size = new System.Drawing.Size(118, 22);
            this.menuLanguageDEGerman.Text = "Deutsch";
            this.menuLanguageDEGerman.Click += new System.EventHandler(this.menuLanguageGerman_Click);
            // 
            // menuLanguageDEEnglish
            // 
            this.menuLanguageDEEnglish.Name = "menuLanguageDEEnglish";
            this.menuLanguageDEEnglish.Size = new System.Drawing.Size(118, 22);
            this.menuLanguageDEEnglish.Text = "Englisch";
            this.menuLanguageDEEnglish.Click += new System.EventHandler(this.menuLanguageEnglish_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 362);
            this.ControlBox = false;
            this.Controls.Add(this.btnCreateGnome);
            this.Controls.Add(this.btnCreateDwarf);
            this.Controls.Add(this.btnCreateHalfling);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCreateElf);
            this.Controls.Add(this.btnCreateHuman);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.MaximumSize = new System.Drawing.Size(240, 400);
            this.MinimumSize = new System.Drawing.Size(240, 400);
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Midgard Creator";
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
    }
}