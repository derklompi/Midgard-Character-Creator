namespace mcreator
{
    partial class FrmLevelUp
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
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbRace = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCurrentLevel = new System.Windows.Forms.ComboBox();
            this.lbDiceValues = new System.Windows.Forms.ListBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.btnDiceValue = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculateAP = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNeededThrows = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbClass
            // 
            this.cbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Items.AddRange(new object[] {
            "Barbar",
            "Krieger",
            "Söldner",
            "Kundschafter",
            "Waldläufer",
            "Schamane",
            "anderer Kämpfer",
            "anderer Zauberer"});
            this.cbClass.Location = new System.Drawing.Point(53, 17);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(176, 21);
            this.cbClass.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(728, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbRace
            // 
            this.cbRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRace.FormattingEnabled = true;
            this.cbRace.Items.AddRange(new object[] {
            "Halbling",
            "Gnom",
            "Andere"});
            this.cbRace.Location = new System.Drawing.Point(53, 44);
            this.cbRace.Name = "cbRace";
            this.cbRace.Size = new System.Drawing.Size(176, 21);
            this.cbRace.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Klasse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rasse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Grad";
            // 
            // cbCurrentLevel
            // 
            this.cbCurrentLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurrentLevel.FormattingEnabled = true;
            this.cbCurrentLevel.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14"});
            this.cbCurrentLevel.Location = new System.Drawing.Point(53, 71);
            this.cbCurrentLevel.Name = "cbCurrentLevel";
            this.cbCurrentLevel.Size = new System.Drawing.Size(176, 21);
            this.cbCurrentLevel.TabIndex = 5;
            this.cbCurrentLevel.SelectedIndexChanged += new System.EventHandler(this.cbCurrentLevel_SelectedIndexChanged);
            // 
            // lbDiceValues
            // 
            this.lbDiceValues.FormattingEnabled = true;
            this.lbDiceValues.Location = new System.Drawing.Point(327, 40);
            this.lbDiceValues.Name = "lbDiceValues";
            this.lbDiceValues.Size = new System.Drawing.Size(42, 199);
            this.lbDiceValues.TabIndex = 9;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(264, 40);
            this.maskedTextBox1.Mask = "0";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(24, 20);
            this.maskedTextBox1.TabIndex = 10;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDiceValue
            // 
            this.btnDiceValue.Enabled = false;
            this.btnDiceValue.Location = new System.Drawing.Point(294, 38);
            this.btnDiceValue.Name = "btnDiceValue";
            this.btnDiceValue.Size = new System.Drawing.Size(27, 23);
            this.btnDiceValue.TabIndex = 11;
            this.btnDiceValue.Text = "->";
            this.btnDiceValue.UseVisualStyleBackColor = true;
            this.btnDiceValue.Click += new System.EventHandler(this.btnDiceValue_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(456, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(375, 67);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "löschen";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(375, 96);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculateAP
            // 
            this.btnCalculateAP.Enabled = false;
            this.btnCalculateAP.Location = new System.Drawing.Point(375, 38);
            this.btnCalculateAP.Name = "btnCalculateAP";
            this.btnCalculateAP.Size = new System.Drawing.Size(75, 23);
            this.btnCalculateAP.TabIndex = 15;
            this.btnCalculateAP.Text = "GO";
            this.btnCalculateAP.UseVisualStyleBackColor = true;
            this.btnCalculateAP.Click += new System.EventHandler(this.btnCalculateAP_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(456, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(562, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "AP Bonus";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(562, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "EP Bonus";
            // 
            // txtNeededThrows
            // 
            this.txtNeededThrows.Location = new System.Drawing.Point(53, 114);
            this.txtNeededThrows.Name = "txtNeededThrows";
            this.txtNeededThrows.ReadOnly = true;
            this.txtNeededThrows.Size = new System.Drawing.Size(176, 20);
            this.txtNeededThrows.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "1W6";
            // 
            // FrmLevelUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 488);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNeededThrows);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnCalculateAP);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDiceValue);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.lbDiceValues);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCurrentLevel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbRace);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cbClass);
            this.Name = "FrmLevelUp";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLevelUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cbRace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCurrentLevel;
        private System.Windows.Forms.ListBox lbDiceValues;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button btnDiceValue;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculateAP;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNeededThrows;
        private System.Windows.Forms.Label label4;
    }
}