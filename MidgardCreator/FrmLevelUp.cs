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

            if (maskedTextBox1.Text != "")
            {
                lbDiceValues.Items.Add(maskedTextBox1.Text);

            }
            string valueNumberCheck = "";
            valueNumberCheck = cbCurrentLevel.SelectedItem.ToString();

            switch (valueNumberCheck)
            {

                case "0":
                    {
                        if (lbDiceValues.Items.Count == 1)
                        {
                            btnCalculateAP.Enabled = true;
                        }
                        else
                        {
                            btnCalculateAP.Enabled = false;
                        }
                        break;
                    }
                case "1":
                    {
                        if (lbDiceValues.Items.Count == 2)
                        {
                            btnCalculateAP.Enabled = true;
                        }
                        else
                        {
                            btnCalculateAP.Enabled = false;
                        }
                        break;
                    }
                case "2":
                    {
                        if (lbDiceValues.Items.Count == 3)
                        {
                            btnCalculateAP.Enabled = true;
                        }
                        else
                        {
                            btnCalculateAP.Enabled = false;
                        }
                        break;
                    }
                case "3":
                    {
                        if (lbDiceValues.Items.Count == 4)
                        {
                            btnCalculateAP.Enabled = true;
                        }
                        else
                        {
                            btnCalculateAP.Enabled = false;
                        }
                        break;
                    }
                case "4":
                    {
                        if (lbDiceValues.Items.Count == 5)
                        {
                            btnCalculateAP.Enabled = true;
                        }
                        else
                        {
                            btnCalculateAP.Enabled = false;
                        }
                        break;
                    }
                case "5":
                    {
                        if (lbDiceValues.Items.Count == 6)
                        {
                            btnCalculateAP.Enabled = true;
                        }
                        else
                        {
                            btnCalculateAP.Enabled = false;
                        }
                        break;
                    }
                case "6":
                    {
                        if (lbDiceValues.Items.Count == 7)
                        {
                            btnCalculateAP.Enabled = true;
                        }
                        else
                        {
                            btnCalculateAP.Enabled = false;
                        }
                        break;
                    }
                case "7":
                    {
                        if (lbDiceValues.Items.Count == 8)
                        {
                            btnCalculateAP.Enabled = true;
                        }
                        else
                        {
                            btnCalculateAP.Enabled = false;
                        }
                        break;
                    }
                case "8":
                    {
                        if (lbDiceValues.Items.Count == 9)
                        {
                            btnCalculateAP.Enabled = true;
                        }
                        else
                        {
                            btnCalculateAP.Enabled = false;
                        }
                        break;
                    }
                case "9":
                    {
                        if (lbDiceValues.Items.Count == 10)
                        {
                            btnCalculateAP.Enabled = true;
                        }
                        else
                        {
                            btnCalculateAP.Enabled = false;
                        }
                        break;
                    }
                case "10":
                    {
                        if (lbDiceValues.Items.Count == 11)
                        {
                            btnCalculateAP.Enabled = true;
                        }
                        else
                        {
                            btnCalculateAP.Enabled = false;
                        }
                        break;
                    }
                case "11":
                    {
                        if (lbDiceValues.Items.Count == 12)
                        {
                            btnCalculateAP.Enabled = true;
                        }
                        else
                        {
                            btnCalculateAP.Enabled = false;
                        }
                        break;
                    }
                case "12":
                    {
                        if (lbDiceValues.Items.Count == 13)
                        {
                            btnCalculateAP.Enabled = true;
                        }
                        else
                        {
                            btnCalculateAP.Enabled = false;
                        }
                        break;
                    }
                case "13":
                    {
                        if (lbDiceValues.Items.Count == 14)
                        {
                            btnCalculateAP.Enabled = true;
                        }
                        else
                        {
                            btnCalculateAP.Enabled = false;
                        }
                        break;
                    }
                case "14":
                    {
                        if (lbDiceValues.Items.Count == 15)
                        {
                            btnCalculateAP.Enabled = true;
                        }
                        else
                        {
                            btnCalculateAP.Enabled = false;
                        }
                        break;
                    }
                default:
                    {
                        break;
                    }
            }




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
            string valueNumberCheck = "";
            valueNumberCheck = cbCurrentLevel.SelectedItem.ToString();

            switch (valueNumberCheck)
            {

                case "0":
                    {
                        if (lbDiceValues.Items.Count == 1)
                        {
                            btnCalculateAP.Enabled = true;
                        }
                        else
                        {
                            btnCalculateAP.Enabled = false;
                        }
                        break;
                    }
                case "1":
                    {
                        if (lbDiceValues.Items.Count == 2)
                        {
                            btnCalculateAP.Enabled = true;
                        }
                        else
                        {
                            btnCalculateAP.Enabled = false;
                        }
                        break;
                    }
                case "2":
                    {
                        if (lbDiceValues.Items.Count == 3)
                        {
                            btnCalculateAP.Enabled = true;
                        }
                        else
                        {
                            btnCalculateAP.Enabled = false;
                        }
                        break;
                    }
                case "3":
                    {
                        if (lbDiceValues.Items.Count == 4)
                        {
                            btnCalculateAP.Enabled = true;
                        }
                        else
                        {
                            btnCalculateAP.Enabled = false;
                        }
                        break;
                    }
                case "4":
                    {
                        if (lbDiceValues.Items.Count == 5)
                        {
                            btnCalculateAP.Enabled = true;
                        }
                        else
                        {
                            btnCalculateAP.Enabled = false;
                        }
                        break;
                    }
                case "5":
                    {
                        if (lbDiceValues.Items.Count == 6)
                        {
                            btnCalculateAP.Enabled = true;
                        }
                        else
                        {
                            btnCalculateAP.Enabled = false;
                        }
                        break;
                    }
                case "6":
                    {
                        if (lbDiceValues.Items.Count == 7)
                        {
                            btnCalculateAP.Enabled = true;
                        }
                        else
                        {
                            btnCalculateAP.Enabled = false;
                        }
                        break;
                    }
                case "7":
                    {
                        if (lbDiceValues.Items.Count == 8)
                        {
                            btnCalculateAP.Enabled = true;
                        }
                        else
                        {
                            btnCalculateAP.Enabled = false;
                        }
                        break;
                    }
                case "8":
                    {
                        if (lbDiceValues.Items.Count == 9)
                        {
                            btnCalculateAP.Enabled = true;
                        }
                        else
                        {
                            btnCalculateAP.Enabled = false;
                        }
                        break;
                    }
                case "9":
                    {
                        if (lbDiceValues.Items.Count == 10)
                        {
                            btnCalculateAP.Enabled = true;
                        }
                        else
                        {
                            btnCalculateAP.Enabled = false;
                        }
                        break;
                    }
                case "10":
                    {
                        if (lbDiceValues.Items.Count == 11)
                        {
                            btnCalculateAP.Enabled = true;
                        }
                        else
                        {
                            btnCalculateAP.Enabled = false;
                        }
                        break;
                    }
                case "11":
                    {
                        if (lbDiceValues.Items.Count == 12)
                        {
                            btnCalculateAP.Enabled = true;
                        }
                        else
                        {
                            btnCalculateAP.Enabled = false;
                        }
                        break;
                    }
                case "12":
                    {
                        if (lbDiceValues.Items.Count == 13)
                        {
                            btnCalculateAP.Enabled = true;
                        }
                        else
                        {
                            btnCalculateAP.Enabled = false;
                        }
                        break;
                    }
                case "13":
                    {
                        if (lbDiceValues.Items.Count == 14)
                        {
                            btnCalculateAP.Enabled = true;
                        }
                        else
                        {
                            btnCalculateAP.Enabled = false;
                        }
                        break;
                    }
                case "14":
                    {
                        if (lbDiceValues.Items.Count == 15)
                        {
                            btnCalculateAP.Enabled = true;
                        }
                        else
                        {
                            btnCalculateAP.Enabled = false;
                        }
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lbDiceValues.Items.Clear();
        }

        private void btnCalculateAP_Click(object sender, EventArgs e)
        {
            if(lbDiceValues.Items.Count >= 1)
            {
                string levelKey = "";

                levelKey = cbCurrentLevel.SelectedItem.ToString();

                int diceValue = 0;
                int apValue = 0;

                string claass = cbClass.SelectedItem.ToString();

                switch (levelKey)
                {

                    case "0":
                        {
                            for (int i = 0; i < 1; i++)
                            {
                                diceValue = diceValue + Convert.ToInt32(lbDiceValues.Items[i].ToString());
                                if (i == 0)
                                {
                                    if(claass == "Barbar" || claass == "Krieger" || claass == "Söldner" || claass == "Kundschafter" || claass == "Waldläufer")
                                    {
                                        apValue = diceValue + 4;
                                        textBox1.Text = Convert.ToString(apValue);
                                        textBox2.Text = Convert.ToString(apValue * 20);
                                    }

                                    if (claass == "anderer Kämpfer" || claass == "Schamane")
                                    {
                                        apValue = diceValue + 3;
                                        textBox1.Text = Convert.ToString(apValue);
                                        textBox2.Text = Convert.ToString(apValue * 20);
                                    }

                                    if (claass == "anderer Zauberer")
                                    {
                                        apValue = diceValue + 2;
                                        textBox1.Text = Convert.ToString(apValue);
                                        textBox2.Text = Convert.ToString(apValue * 20);
                                    }

                                }

                            }
                            break;
                        }
                    case "1":
                        {
                            for (int i = 0; i < 2; i++)
                            {

                                diceValue = diceValue + Convert.ToInt32(lbDiceValues.Items[i].ToString());
                                if (i == 1)
                                {
                                    if (claass == "Barbar" || claass == "Krieger" || claass == "Söldner" || claass == "Kundschafter" || claass == "Waldläufer")
                                    {
                                        apValue = diceValue + 6;
                                        textBox1.Text = Convert.ToString(apValue);
                                        textBox2.Text = Convert.ToString(apValue * 20);
                                    }

                                    if (claass == "anderer Kämpfer" || claass == "Schamane")
                                    {
                                        apValue = diceValue + 4;
                                        textBox1.Text = Convert.ToString(apValue);
                                        textBox2.Text = Convert.ToString(apValue * 20);
                                    }

                                    if (claass == "anderer Zauberer")
                                    {
                                        apValue = diceValue + 2;
                                        textBox1.Text = Convert.ToString(apValue);
                                        textBox2.Text = Convert.ToString(apValue * 20);
                                    }
                                }
                            }
                            break;
                        }
                    case "2":
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                diceValue = diceValue + Convert.ToInt32(lbDiceValues.Items[i].ToString());
                                if (i == 2)
                                {
                                    if (claass == "Barbar" || claass == "Krieger" || claass == "Söldner" || claass == "Kundschafter" || claass == "Waldläufer")
                                    {
                                        apValue = diceValue + 9;
                                        textBox1.Text = Convert.ToString(apValue);
                                        textBox2.Text = Convert.ToString(apValue * 20);
                                    }

                                    if (claass == "anderer Kämpfer" || claass == "Schamane")
                                    {
                                        apValue = diceValue + 6;
                                        textBox1.Text = Convert.ToString(apValue);
                                        textBox2.Text = Convert.ToString(apValue * 20);
                                    }

                                    if (claass == "anderer Zauberer")
                                    {
                                        apValue = diceValue + 3;
                                        textBox1.Text = Convert.ToString(apValue);
                                        textBox2.Text = Convert.ToString(apValue * 20);
                                    }
                                }
                            }
                            break;
                        }
                    case "3":
                        {
                            for (int i = 0; i < 4; i++)
                            {
                                diceValue = diceValue + Convert.ToInt32(lbDiceValues.Items[i].ToString());
                                if (i == 3)
                                {
                                    if (claass == "Barbar" || claass == "Krieger" || claass == "Söldner" || claass == "Kundschafter" || claass == "Waldläufer")
                                    {
                                        apValue = diceValue + 12;
                                        textBox1.Text = Convert.ToString(apValue);
                                        textBox2.Text = Convert.ToString(apValue * 40);
                                    }

                                    if (claass == "anderer Kämpfer" || claass == "Schamane")
                                    {
                                        apValue = diceValue + 8;
                                        textBox1.Text = Convert.ToString(apValue);
                                        textBox2.Text = Convert.ToString(apValue * 40);
                                    }

                                    if (claass == "anderer Zauberer")
                                    {
                                        apValue = diceValue + 4;
                                        textBox1.Text = Convert.ToString(apValue);
                                        textBox2.Text = Convert.ToString(apValue * 40);
                                    }
                                }
                            }
                            break;
                        }
                    case "4":
                        {
                            for (int i = 0; i < 5; i++)
                            {
                                diceValue = diceValue + Convert.ToInt32(lbDiceValues.Items[i].ToString());
                                if (i == 4)
                                {
                                    if (claass == "Barbar" || claass == "Krieger" || claass == "Söldner" || claass == "Kundschafter" || claass == "Waldläufer")
                                    {
                                        apValue = diceValue + 15;
                                        textBox1.Text = Convert.ToString(apValue);
                                        textBox2.Text = Convert.ToString(apValue * 70);
                                    }

                                    if (claass == "anderer Kämpfer" || claass == "Schamane")
                                    {
                                        apValue = diceValue + 10;
                                        textBox1.Text = Convert.ToString(apValue);
                                        textBox2.Text = Convert.ToString(apValue * 70);
                                    }

                                    if (claass == "anderer Zauberer")
                                    {
                                        apValue = diceValue + 5;
                                        textBox1.Text = Convert.ToString(apValue);
                                        textBox2.Text = Convert.ToString(apValue * 70);
                                    }
                                }
                            }
                            break;
                        }
                    case "5":
                        {
                            for (int i = 0; i < 6; i++)
                            {
                                diceValue = diceValue + Convert.ToInt32(lbDiceValues.Items[i].ToString());
                                if (i == 5)
                                {
                                    if (claass == "Barbar" || claass == "Krieger" || claass == "Söldner" || claass == "Kundschafter" || claass == "Waldläufer")
                                    {
                                        apValue = diceValue + 18;
                                        textBox1.Text = Convert.ToString(apValue);
                                        textBox2.Text = Convert.ToString(apValue * 150);
                                    }

                                    if (claass == "anderer Kämpfer" || claass == "Schamane")
                                    {
                                        apValue = diceValue + 12;
                                        textBox1.Text = Convert.ToString(apValue);
                                        textBox2.Text = Convert.ToString(apValue * 150);
                                    }

                                    if (claass == "anderer Zauberer")
                                    {
                                        apValue = diceValue + 6;
                                        textBox1.Text = Convert.ToString(apValue);
                                        textBox2.Text = Convert.ToString(apValue * 150);
                                    }
                                }
                            }
                            break;
                        }
                    case "6":
                        {
                            for (int i = 0; i < 7; i++)
                            {
                                diceValue = diceValue + Convert.ToInt32(lbDiceValues.Items[i].ToString());
                                if (i == 6)
                                {
                                    if (claass == "Barbar" || claass == "Krieger" || claass == "Söldner" || claass == "Kundschafter" || claass == "Waldläufer")
                                    {
                                        apValue = diceValue + 21;
                                        textBox1.Text = Convert.ToString(apValue);
                                        textBox2.Text = Convert.ToString(apValue * 300);
                                    }

                                    if (claass == "anderer Kämpfer" || claass == "Schamane")
                                    {
                                        apValue = diceValue + 14;
                                        textBox1.Text = Convert.ToString(apValue);
                                        textBox2.Text = Convert.ToString(apValue * 300);
                                    }

                                    if (claass == "anderer Zauberer")
                                    {
                                        apValue = diceValue + 7;
                                        textBox1.Text = Convert.ToString(apValue);
                                        textBox2.Text = Convert.ToString(apValue * 300);
                                    }
                                }
                            }
                            break;
                        }
                    case "7":
                        {
                            for (int i = 0; i < 8; i++)
                            {
                                diceValue = diceValue + Convert.ToInt32(lbDiceValues.Items[i].ToString());
                                if (i == 7)
                                {
                                    if (claass == "Barbar" || claass == "Krieger" || claass == "Söldner" || claass == "Kundschafter" || claass == "Waldläufer")
                                    {
                                        apValue = diceValue + 24;
                                        textBox1.Text = Convert.ToString(apValue);
                                        textBox2.Text = Convert.ToString(apValue * 600);
                                    }

                                    if (claass == "anderer Kämpfer" || claass == "Schamane")
                                    {
                                        apValue = diceValue + 16;
                                        textBox1.Text = Convert.ToString(apValue);
                                        textBox2.Text = Convert.ToString(apValue * 600);
                                    }

                                    if (claass == "anderer Zauberer")
                                    {
                                        apValue = diceValue + 8;
                                        textBox1.Text = Convert.ToString(apValue);
                                        textBox2.Text = Convert.ToString(apValue * 600);
                                    }
                                }
                            }
                            break;
                        }
                    case "8":
                        {
                            for (int i = 0; i < 9; i++)
                            {
                                diceValue = diceValue + Convert.ToInt32(lbDiceValues.Items[i].ToString());
                                if (i == 8)
                                {
                                    if (claass == "Barbar" || claass == "Krieger" || claass == "Söldner" || claass == "Kundschafter" || claass == "Waldläufer")
                                    {
                                        apValue = diceValue + 27;
                                        textBox1.Text = Convert.ToString(apValue);
                                        textBox2.Text = Convert.ToString(apValue * 1200);
                                    }

                                    if (claass == "anderer Kämpfer" || claass == "Schamane")
                                    {
                                        apValue = diceValue + 18;
                                        textBox1.Text = Convert.ToString(apValue);
                                        textBox2.Text = Convert.ToString(apValue * 1200);
                                    }

                                    if (claass == "anderer Zauberer")
                                    {
                                        apValue = diceValue + 9;
                                        textBox1.Text = Convert.ToString(apValue);
                                        textBox2.Text = Convert.ToString(apValue * 1200);
                                    }
                                }
                            }
                            break;
                        }
                    case "9":
                        {
                            for (int i = 0; i < 10; i++)
                            {
                                diceValue = diceValue + Convert.ToInt32(lbDiceValues.Items[i].ToString());
                                if (i == 9)
                                {
                                    if (claass == "Barbar" || claass == "Krieger" || claass == "Söldner" || claass == "Kundschafter" || claass == "Waldläufer")
                                    {
                                        apValue = diceValue + 30;
                                        textBox1.Text = Convert.ToString(apValue);
                                        textBox2.Text = Convert.ToString(apValue * 1500);
                                    }

                                    if (claass == "anderer Kämpfer" || claass == "Schamane")
                                    {
                                        apValue = diceValue + 20;
                                        textBox1.Text = Convert.ToString(apValue);
                                        textBox2.Text = Convert.ToString(apValue * 1500);
                                    }

                                    if (claass == "anderer Zauberer")
                                    {
                                        apValue = diceValue + 10;
                                        textBox1.Text = Convert.ToString(apValue);
                                        textBox2.Text = Convert.ToString(apValue * 1500);
                                    }
                                }
                            }
                            break;
                        }
                    case "10":
                        {
                            for (int i = 0; i < 11; i++)
                            {
                                diceValue = diceValue + Convert.ToInt32(lbDiceValues.Items[i].ToString());
                                if (i == 10)
                                {
                                    if (claass == "Barbar" || claass == "Krieger" || claass == "Söldner" || claass == "Kundschafter" || claass == "Waldläufer")
                                    {
                                        apValue = diceValue + 30;
                                        textBox1.Text = Convert.ToString(apValue);
                                        textBox2.Text = Convert.ToString(apValue * 2000);
                                    }

                                    if (claass == "anderer Kämpfer" || claass == "Schamane")
                                    {
                                        apValue = diceValue + 20;
                                        textBox1.Text = Convert.ToString(apValue);
                                        textBox2.Text = Convert.ToString(apValue * 2000);
                                    }

                                    if (claass == "anderer Zauberer")
                                    {
                                        apValue = diceValue + 10;
                                        textBox1.Text = Convert.ToString(apValue);
                                        textBox2.Text = Convert.ToString(apValue * 2000);
                                    }
                                }
                            }
                            break;
                        }
                    case "11":
                        {
                            for (int i = 0; i < 12; i++)
                            {
                                diceValue = diceValue + Convert.ToInt32(lbDiceValues.Items[i].ToString());
                                if (i == 11)
                                {
                                    if (claass == "Barbar" || claass == "Krieger" || claass == "Söldner" || claass == "Kundschafter" || claass == "Waldläufer")
                                    {
                                        apValue = diceValue + 30;
                                        textBox1.Text = Convert.ToString(apValue);
                                        textBox2.Text = Convert.ToString(apValue * 2000);
                                    }

                                    if (claass == "anderer Kämpfer" || claass == "Schamane")
                                    {
                                        apValue = diceValue + 20;
                                        textBox1.Text = Convert.ToString(apValue);
                                        textBox2.Text = Convert.ToString(apValue * 2000);
                                    }

                                    if (claass == "anderer Zauberer")
                                    {
                                        apValue = diceValue + 10;
                                        textBox1.Text = Convert.ToString(apValue);
                                        textBox2.Text = Convert.ToString(apValue * 2000);
                                    }
                                }
                            }
                            break;
                        }
                    case "12":
                        {
                            for (int i = 0; i < 13; i++)
                            {
                                diceValue = diceValue + Convert.ToInt32(lbDiceValues.Items[i].ToString());
                                if (i == 12)
                                {
                                    if (claass == "Barbar" || claass == "Krieger" || claass == "Söldner" || claass == "Kundschafter" || claass == "Waldläufer")
                                    {
                                        apValue = diceValue + 30;
                                        textBox1.Text = Convert.ToString(apValue);
                                        textBox2.Text = Convert.ToString(apValue * 2000);
                                    }

                                    if (claass == "anderer Kämpfer" || claass == "Schamane")
                                    {
                                        apValue = diceValue + 20;
                                        textBox1.Text = Convert.ToString(apValue);
                                        textBox2.Text = Convert.ToString(apValue * 2000);
                                    }

                                    if (claass == "anderer Zauberer")
                                    {
                                        apValue = diceValue + 10;
                                        textBox1.Text = Convert.ToString(apValue);
                                        textBox2.Text = Convert.ToString(apValue * 2000);
                                    }
                                }
                            }
                            break;
                        }
                    case "13":
                        {
                            for (int i = 0; i < 14; i++)
                            {
                                diceValue = diceValue + Convert.ToInt32(lbDiceValues.Items[i].ToString());
                                if (i == 13)
                                {
                                    if (claass == "Barbar" || claass == "Krieger" || claass == "Söldner" || claass == "Kundschafter" || claass == "Waldläufer")
                                    {
                                        apValue = diceValue + 30;
                                        textBox1.Text = Convert.ToString(apValue);
                                        textBox2.Text = Convert.ToString(apValue * 2000);
                                    }

                                    if (claass == "anderer Kämpfer" || claass == "Schamane")
                                    {
                                        apValue = diceValue + 20;
                                        textBox1.Text = Convert.ToString(apValue);
                                        textBox2.Text = Convert.ToString(apValue * 2000);
                                    }

                                    if (claass == "anderer Zauberer")
                                    {
                                        apValue = diceValue + 10;
                                        textBox1.Text = Convert.ToString(apValue);
                                        textBox2.Text = Convert.ToString(apValue * 2000);
                                    }
                                }
                            }
                            break;
                        }
                    case "14":
                        {
                            for (int i = 0; i < 15; i++)
                            {
                                diceValue = diceValue + Convert.ToInt32(lbDiceValues.Items[i].ToString());
                                if (i == 14)
                                {
                                    if (claass == "Barbar" || claass == "Krieger" || claass == "Söldner" || claass == "Kundschafter" || claass == "Waldläufer")
                                    {
                                        apValue = diceValue + 30;
                                        textBox1.Text = Convert.ToString(apValue);
                                        textBox2.Text = Convert.ToString(apValue * 2000);
                                    }

                                    if (claass == "anderer Kämpfer" || claass == "Schamane")
                                    {
                                        apValue = diceValue + 20;
                                        textBox1.Text = Convert.ToString(apValue);
                                        textBox2.Text = Convert.ToString(apValue * 2000);
                                    }

                                    if (claass == "anderer Zauberer")
                                    {
                                        apValue = diceValue + 10;
                                        textBox1.Text = Convert.ToString(apValue);
                                        textBox2.Text = Convert.ToString(apValue * 2000);
                                    }
                                }
                            }
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            
            }

        }

        private void cbCurrentLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDiceValue.Enabled = true;

            string levelKey = "";

            levelKey = cbCurrentLevel.SelectedItem.ToString();

            switch (levelKey)
            {
                case "0":
                    {
                        txtNeededThrows.Text = "1W6 würfeln";
                        break;
                    }
                case "1":
                    {
                        txtNeededThrows.Text = "2W6 würfeln";
                        break;
                    }
                case "2":
                    {
                        txtNeededThrows.Text = "3W6 würfeln";
                        break;
                    }
                case "3":
                    {
                        txtNeededThrows.Text = "4W6 würfeln";
                        break;
                    }
                case "4":
                    {
                        txtNeededThrows.Text = "5W6 würfeln";
                        break;
                    }
                case "5":
                    {
                        txtNeededThrows.Text = "6W6 würfeln";
                        break;
                    }
                case "6":
                    {
                        txtNeededThrows.Text = "7W6 würfeln";
                        break;
                    }
                case "7":
                    {
                        txtNeededThrows.Text = "8W6 würfeln";
                        break;
                    }
                case "8":
                    {
                        txtNeededThrows.Text = "9W6 würfeln";
                        break;
                    }
                case "9":
                    {
                        txtNeededThrows.Text = "10W6 würfeln";
                        break;
                    }
                case "10":
                    {
                        txtNeededThrows.Text = "11W6 würfeln";
                        break;
                    }
                case "11":
                    {
                        txtNeededThrows.Text = "12W6 würfeln";
                        break;
                    }
                case "12":
                    {
                        txtNeededThrows.Text = "13W6 würfeln";
                        break;
                    }
                case "13":
                    {
                        txtNeededThrows.Text = "14W6 würfeln";
                        break;
                    }
                case "14":
                    {
                        txtNeededThrows.Text = "15W6 würfeln";
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