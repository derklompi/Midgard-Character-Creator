using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
