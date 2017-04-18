/*
    Mcreator
    Copyright (C) 2016  Fabian Dörr <faflfama@outlook.com>

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */
using System;
using System.Windows.Forms;

namespace mcreator
{
    public partial class FrmLevelUp : Form
    {
        public FrmLevelUp()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            lbDiceValues.Items.Clear();
        }

        private void btnDiceValue_Click(object sender, EventArgs e)
        {
            int ergebnis = 0;
            if (maskedTextBox1.Text != "")
            {
                lbDiceValues.Items.Add(maskedTextBox1.Text);
                for (int i = 0; i < lbDiceValues.Items.Count; i++)
                {
                    ergebnis = ergebnis + Convert.ToInt32(lbDiceValues.Items[i].ToString());
                    textBox1.Text = Convert.ToString(ergebnis);
                }
            }         
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
          lbDiceValues.Items.Remove(lbDiceValues.SelectedItem);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lbDiceValues.Items.Clear();
        }

        private void btnCalculateAP_Click(object sender, EventArgs e)
        {
            string levelCurrent = "";
            string levelWanted = "";
            string levelKey = "";

            levelCurrent = comboBox3.SelectedItem.ToString();
            levelWanted = comboBox4.SelectedItem.ToString();
            levelKey = levelCurrent + levelWanted;

            switch(levelKey)
            {
                case "01":
                    {
                        break;  
                    }
                default:
                    {
                        break;
                    }
            }
               
        }
    }
}
