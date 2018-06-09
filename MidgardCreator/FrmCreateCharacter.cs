/*
    Mcreator
    Copyright (C) 2017  Fabian Dörr <faflfama@outlook.com>

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
using mcc.Classes;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace mcc
{
    public partial class FrmCreateCharacter : Form
    {
        public FrmCreateCharacter()
        {
            InitializeComponent();

            // Get the user home path and set it as default
            string user_path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            txtExportPath.Text = "" + user_path + "";           
        }

        Character c = new Character();

        private void FrmCreateCharacter_Load(object sender, EventArgs e)
        {
            ComboBoxValue cbv = new ComboBoxValue();
            cbv.SetComboBoxValue();
            CalculationTimer.Enabled = true;
            EnableTimer.Enabled = true;

            // Customizing the form for the different races
            switch (this.Text)
            {               
                case "MCreator - Halbling":
                    // Hide not needed fields
                    // Handed
                    cbHanded.Visible        = false;
                    lblDice20C.Visible      = false;
                    // Bodysize
                    cbBodyWeightD.Visible   = false;
                    txtBodySizeB.Visible    = false;
                    lblBodySizeB.Visible    = false;
                    lblDice6F.Visible       = false;
                    //Bodyweight
                    txtBodyWeightB.Visible  = false;
                    lblBodyWeightB.Visible  = false;
                    // Change Text of labels
                    lblDice20A.Text         = "1W6";
                    lblDice20B.Text         = "1W6";
                    lblBodySizeA.Text       = "cm";
                    lblBodyWeightA.Text     = "kg";
                    // Change texts of textfields
                    // Handed
                    txtHanded.Text          = "Beidhändig";
                    //BodyWeight
                    cbBodyWeightD.SelectedIndex = 0;
                    break;
                case "MCreator - Elf":
                    // Hide not needed fields
                    // Bodysize               
                    txtBodySizeB.Visible    = false;
                    lblBodySizeB.Visible    = false;
                    //Bodyweight
                    txtBodyWeightB.Visible  = false;
                    lblBodyWeightB.Visible  = false;
                    // Change Text of labels
                    lblDice20A.Text         = "1W6";
                    lblDice20B.Text         = "1W6";
                    lblBodySizeA.Text       = "cm";
                    lblBodyWeightA.Text     = "kg";
                    break;
                case "MCreator - Zwerg":
                    // Hide not needed fields
                    // Bodysize               
                    txtBodySizeB.Visible    = false;
                    lblBodySizeB.Visible    = false;
                    lblDice20B.Visible      = false;
                    cbBodySizeB.Visible     = false;
                    //Bodyweight
                    txtBodyWeightB.Visible  = false;
                    lblBodyWeightB.Visible  = false;
                    // Change Text of labels
                    lblDice20A.Text         = "1W6";
                    lblDice20B.Text         = "1W6";
                    lblBodySizeA.Text       = "cm";
                    lblBodyWeightA.Text     = "kg";
                    // Change texts of textfields
                    //BodySize
                    cbBodySizeB.SelectedIndex = 0;
                    break;
                case "MCreator - Gnom":
                    // Hide not needed fields
                    // Bodysize                
                    txtBodySizeB.Visible    = false;
                    lblBodySizeB.Visible    = false;
                    lblDice20B.Visible      = false;
                    cbBodySizeB.Visible     = false;
                    //Bodyweight
                    cbBodyWeightD.Visible   = false;
                    txtBodyWeightB.Visible  = false;
                    lblBodyWeightB.Visible  = false;
                    lblDice6F.Visible       = false;
                    // Change Text of labels
                    lblDice20A.Text         = "1W6";
                    lblDice20B.Text         = "1W6";
                    lblBodySizeA.Text       = "cm";
                    lblBodyWeightA.Text     = "kg";
                    // Change texts of textfields
                    //BodySize
                    cbBodySizeB.SelectedIndex = 0;
                    //BodyWeight
                    cbBodyWeightD.SelectedIndex = 0;
                    break;
                case "MCreator - Mensch":
                    // UnHide not needed fields
                    // Bodysize 
                    txtBodySizeB.Visible    = true;
                    lblBodySizeB.Visible    = true;
                    txtBodyWeightB.Visible  = true;
                    lblBodyWeightB.Visible  = true;
                    // Change Text of labels
                    lblDice20A.Text         = "1W20";
                    lblDice20B.Text         = "1W20";
                    lblBodySizeA.Text       = "cm (Mann)";
                    lblBodyWeightA.Text     = "kg (Mann)";
                    break;
                default:
                    break;
            }          
        }
      
        private void BtnGetRandomCharacter_Click(object sender, EventArgs e)
        {
            // Reset the check value for the following cycle
            bool statPointCheck = false;

            while (statPointCheck == false)
            {
                //Get Random numbers between 0 and 99
                Random Rnd = new Random();

                int strength        = Rnd.Next(0, 100);
                int dexterity       = Rnd.Next(0, 100);
                int agility         = Rnd.Next(0, 100);
                int constitution    = Rnd.Next(0, 100);
                int magicTalent     = Rnd.Next(0, 100);
                int intelligence    = Rnd.Next(0, 100);

                //Check if StatSum is over 350
                int StatSum = strength + dexterity + agility + constitution + magicTalent + intelligence;

                if (StatSum >= 350)
                {
                    Character c = new Character();
                    // Setting the check value to true, so that the cycle gets terminated
                    statPointCheck = true;

                    // Seetting the check field for the timer 
                    rbStats.Checked = true;

                    // Set the text fields to the StatValues
                    cbStrength.SelectedIndex        = strength;
                    cbDexterity.SelectedIndex       = dexterity;
                    cbAgility.SelectedIndex         = agility;
                    cbConstitution.SelectedIndex    = constitution;
                    cbMagicalTalent.SelectedIndex   = magicTalent;
                    cbIntelligence.SelectedIndex    = intelligence;

                    //Get the BodySize for the different races
                    if (this.Text == "MCreator - Mensch")
                    {
                        cbBodySizeA.SelectedIndex = Rnd.Next(0, 20);
                        cbBodySizeB.SelectedIndex = Rnd.Next(0, 20);
                    }
                    else
                    {
                        if (this.Text == "MCreator - Zwerg" || this.Text == "MCreator - Gnom")
                        {
                            cbBodySizeA.SelectedIndex = Rnd.Next(0, 6);
                            cbBodySizeB.SelectedIndex = 0;
                        }
                        if (this.Text == "MCreator - Elf" || this.Text == "MCreator - Halbling")
                        {
                            cbBodySizeA.SelectedIndex = Rnd.Next(0, 6);
                            cbBodySizeB.SelectedIndex = Rnd.Next(0, 6);
                        }           
                    }

                    if (this.Text == "MCreator - Mensch")
                    {
                        cbBodyWeightA.SelectedIndex = Rnd.Next(0, 6);
                        cbBodyWeightB.SelectedIndex = Rnd.Next(0, 6);
                        cbBodyWeightC.SelectedIndex = Rnd.Next(0, 6);
                        cbBodyWeightD.SelectedIndex = Rnd.Next(0, 6);
                    }
                    else
                    {
                        if (this.Text == "MCreator - Zwerg" || this.Text == "MCreator - Elf")
                        {
                            cbBodyWeightA.SelectedIndex = Rnd.Next(0, 6);
                            cbBodyWeightB.SelectedIndex = Rnd.Next(0, 6);
                            cbBodyWeightC.SelectedIndex = Rnd.Next(0, 6);
                            cbBodyWeightD.SelectedIndex = Rnd.Next(0, 6);
                        }
                        if (this.Text == "MCreator - Gnom" || this.Text == "MCreator - Halbling")
                        {
                            cbBodyWeightA.SelectedIndex = Rnd.Next(0, 6);
                            cbBodyWeightB.SelectedIndex = Rnd.Next(0, 6);
                            cbBodyWeightC.SelectedIndex = Rnd.Next(0, 6);
                            cbBodyWeightD.SelectedIndex = 0;
                        }
                    }
                                       
                    cbAppearance.SelectedIndex      = Rnd.Next(0, 100);
                    cbCharisma.SelectedIndex        = Rnd.Next(0, 100);
                    cbWillpower.SelectedIndex       = Rnd.Next(0, 100);
                    cbSelfControl.SelectedIndex     = Rnd.Next(0, 100);
                    cbHanded.SelectedIndex          = Rnd.Next(0, 20);

                    cbAdventurePointsA.SelectedIndex    = Rnd.Next(0, 6);
                    cbAdventurePointsB.SelectedIndex    = Rnd.Next(0, 6);
                    cbAdventurePointsC.SelectedIndex    = Rnd.Next(0, 6);
                    cbLifePoints.SelectedIndex          = Rnd.Next(0, 6);

                    cbInbornBuff.SelectedIndex = Rnd.Next(0, 100);                

                    //Calculatin the Damage/DefenseBuff
                    int DamageBuff  = 0;
                    int DefenseBuff = 0;

                    DamageBuff  = (strength / 20) + (dexterity / 30) - 3;
                    DefenseBuff = (strength / 20) + (constitution / 10) - 7;

                    if (DamageBuff >= 0)
                    {
                        txtDamageBuff.Text = Convert.ToString(DamageBuff);
                    }
                    else
                    {
                        txtDamageBuff.Text = "0";
                    }

                    if (DefenseBuff >= 0)
                    {
                        txtStaminaBuff.Text = Convert.ToString(DefenseBuff);
                    }
                    else
                    {
                        txtStaminaBuff.Text = "0";
                    }

                    txtAttackBuff.Text  = Convert.ToString(c.AttackBuff(dexterity));
                    txtDefenseBuff.Text = Convert.ToString(c.DefenseBuff(agility));
                    txtMagicBuff.Text   = Convert.ToString(c.MagicBuff(magicTalent));

                    txtRumble.Text      = Convert.ToString(((strength + agility) / 20) + Convert.ToInt32(txtAttackBuff.Text));
                    txtDefense.Text     = Convert.ToString(11 + Convert.ToInt32(txtDefenseBuff.Text));
                    txtDefense0.Text    = Convert.ToString(10 + Convert.ToInt32(txtDefenseBuff.Text));
                    txtDoMagic.Text     = Convert.ToString(10 + Convert.ToInt32(txtMagicBuff.Text));
                    txtDoMagic0.Text    = Convert.ToString(2  + Convert.ToInt32(txtMagicBuff.Text));               

                    if (this.Text == "MCreator - Mensch")
                    {
                        txtBodySizeA.Text = Convert.ToString(c.BodySize(cbBodySizeA.SelectedItem.ToString(), cbBodySizeB.SelectedItem.ToString(), cbStrength.SelectedItem.ToString(), this.Text) + 150);
                        txtBodySizeB.Text = Convert.ToString(c.BodySize(cbBodySizeA.SelectedItem.ToString(), cbBodySizeB.SelectedItem.ToString(), cbStrength.SelectedItem.ToString(), this.Text) + 140);
                    }
                    else
                    {
                        txtBodySizeA.Text = Convert.ToString(c.BodySize(cbBodySizeA.SelectedItem.ToString(), cbBodySizeB.SelectedItem.ToString(), cbStrength.SelectedItem.ToString(), this.Text));
                    }

                    if (this.Text == "MCreator - Mensch")
                    {
                        txtBodyWeightA.Text = Convert.ToString(c.BodyWeight(cbBodyWeightA.SelectedItem.ToString(), cbBodyWeightB.SelectedItem.ToString(), cbBodyWeightC.SelectedItem.ToString(), cbBodyWeightD.SelectedItem.ToString(), cbStrength.SelectedItem.ToString(), txtBodySizeA.Text,this.Text));
                        txtBodyWeightB.Text = Convert.ToString(c.BodyWeight(cbBodyWeightA.SelectedItem.ToString(), cbBodyWeightB.SelectedItem.ToString(), cbBodyWeightC.SelectedItem.ToString(), cbBodyWeightD.SelectedItem.ToString(), cbStrength.SelectedItem.ToString(), txtBodySizeA.Text, this.Text) -4);
                    }
                    else
                    {
                        txtBodyWeightA.Text = Convert.ToString(c.BodyWeight(cbBodyWeightA.SelectedItem.ToString(), cbBodyWeightB.SelectedItem.ToString(), cbBodyWeightC.SelectedItem.ToString(), cbBodyWeightD.SelectedItem.ToString(), cbStrength.SelectedItem.ToString(), txtBodySizeA.Text, this.Text));
                    }

                    //Calling the CalculationFunctions    

                    txtCharisma.Text            = Convert.ToString(c.Charisma(cbCharisma.SelectedItem.ToString(), cbIntelligence.SelectedItem.ToString(), cbAppearance.SelectedItem.ToString()));
                    txtWillpower.Text           = Convert.ToString(c.Willpower(cbWillpower.SelectedItem.ToString(), cbIntelligence.SelectedItem.ToString(), cbConstitution.SelectedItem.ToString()));
                    txtSelfControlA.Text        = Convert.ToString(c.SelfControlA(cbSelfControl.SelectedItem.ToString(), txtWillpower.Text, cbIntelligence.SelectedItem.ToString()));
                    txtSelfControlB.Text        = Convert.ToString(c.SelfControlB(cbSelfControl.SelectedItem.ToString(), txtWillpower.Text, cbIntelligence.SelectedItem.ToString()));
                    txtSelfControlC.Text        = Convert.ToString(c.SelfControlC(cbSelfControl.SelectedItem.ToString(), txtWillpower.Text, cbIntelligence.SelectedItem.ToString()));
                    txtAdventurePointsA.Text    = Convert.ToString(c.AdventurePointsA(cbAdventurePointsA.SelectedItem.ToString(), txtStaminaBuff.Text, this.Text));
                    txtAdventurePointsB.Text    = Convert.ToString(c.AdventurePointsB(cbAdventurePointsB.SelectedItem.ToString(), txtStaminaBuff.Text, this.Text));
                    txtAdventurePointsC.Text    = Convert.ToString(c.AdventurePointsC(cbAdventurePointsC.SelectedItem.ToString(), txtStaminaBuff.Text, this.Text));
                    txtLifePoints.Text          = Convert.ToString(c.LifePoints(cbConstitution.SelectedItem.ToString(), cbLifePoints.SelectedItem.ToString(), this.Text));
                    txtInbornBuff.Text          = c.InbornBuff(cbInbornBuff.SelectedItem.ToString(), txtWillpower.Text);

                    if (this.Text == "MCreator - Halfling")
                    {
                        txtHanded.Text = "Beidhändig";
                    }
                    else
                    {
                        txtHanded.Text = c.Handed(cbHanded.SelectedItem.ToString());
                    }
                }
            }
        }

        //Reset Button to clear the form
        private void BtnReset_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                //taken from https://dotnet-snippets.de/snippet/alle-textboxen-in-einer-form-loeschen/156
                if (c.GetType() == typeof(TextBox)) c.Text = "";

                string user_path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                txtExportPath.Text = "" + user_path + "";
            }

            cbBodySizeA.SelectedIndex           = -1;
            cbBodySizeB.SelectedIndex           = -1;
            cbHanded.SelectedIndex              = -1;
            cbAppearance.SelectedIndex          = -1;
            cbCharisma.SelectedIndex            = -1;
            cbWillpower.SelectedIndex           = -1;
            cbSelfControl.SelectedIndex         = -1;
            cbInbornBuff.SelectedIndex          = -1;
            cbBodyWeightA.SelectedIndex         = -1;
            cbBodyWeightB.SelectedIndex         = -1;
            cbBodyWeightC.SelectedIndex         = -1;
            cbBodyWeightD.SelectedIndex         = -1;
            cbStrength.SelectedIndex            = -1;
            cbDexterity.SelectedIndex           = -1;
            cbAgility.SelectedIndex             = -1;
            cbConstitution.SelectedIndex        = -1;
            cbIntelligence.SelectedIndex        = -1;
            cbMagicalTalent.SelectedIndex       = -1;
            cbAdventurePointsA.SelectedIndex    = -1;
            cbAdventurePointsB.SelectedIndex    = -1;
            cbAdventurePointsC.SelectedIndex    = -1;
            cbLifePoints.SelectedIndex          = -1;

        }

        //Timer to enable the different Buttons
        private void Enable_Timer_Tick(object sender, EventArgs e)
        {
            if (cbStrength.SelectedItem != null && 
                cbDexterity.SelectedItem != null && 
                cbAgility.SelectedItem != null && 
                cbConstitution.SelectedItem != null && 
                cbIntelligence.SelectedItem != null && 
                cbMagicalTalent.SelectedItem != null)
            {
                int TotalAmount_Stat = 0;

                int strength        = Convert.ToInt32(cbStrength.SelectedItem.ToString());
                int dexterity       = Convert.ToInt32(cbDexterity.SelectedItem.ToString());
                int agility         = Convert.ToInt32(cbAgility.SelectedItem.ToString());
                int constitution    = Convert.ToInt32(cbConstitution.SelectedItem.ToString());
                int intelligence    = Convert.ToInt32(cbIntelligence.SelectedItem.ToString());
                int magicTalent     = Convert.ToInt32(cbMagicalTalent.SelectedItem.ToString());

                TotalAmount_Stat = strength + dexterity + agility + constitution + intelligence + magicTalent;

                if (TotalAmount_Stat < 350)
                {
                    lblStatCheck.Text = "Summe < 350";
                    lblStatCheck.ForeColor = System.Drawing.Color.Red;
                    rbStats.Checked = false;

                    // If Stat Sum is to low, values get reset
                    txtDamageBuff.Text  = "";
                    txtStaminaBuff.Text = "";
                    txtAttackBuff.Text  = "";
                    txtDefenseBuff.Text = "";
                    txtMagicBuff.Text   = "";

                    txtRumble.Text      = "";
                    txtDefense.Text     = "";
                    txtDefense0.Text    = "";
                    txtDoMagic.Text     = "";
                    txtDoMagic0.Text    = "";

                    txtGhostMagicFighter.Text   = "";
                    txtGhostMagicMagician.Text  = "";
                    txtGhostMagicNormal.Text    = "";
                    txtBodyMagicFighter.Text    = "";
                    txtBodyMagicMagician.Text   = "";
                    txtBodyMagicNormal.Text     = "";
                    txtAreaMagicFighter.Text    = "";
                    txtAreaMagicMagician.Text   = "";
                    txtAreaMagicNormal.Text     = "";

                    cbCharisma.Enabled    = false;
                    cbWillpower.Enabled   = false;
                    cbSelfControl.Enabled = false;

                    cbAdventurePointsA.Enabled = false;
                    cbAdventurePointsB.Enabled = false;
                    cbAdventurePointsC.Enabled = false;
                    cbLifePoints.Enabled = false;

                    cbBodySizeA.Enabled = false;
                    cbBodySizeB.Enabled = false;

                    cbBodyWeightA.Enabled = false;
                    cbBodyWeightB.Enabled = false;
                    cbBodyWeightC.Enabled = false;
                    cbBodyWeightD.Enabled = false;
                }

                if (TotalAmount_Stat >= 350)
                {
                    lblStatCheck.Text = "Summe OK";
                    lblStatCheck.ForeColor = System.Drawing.Color.Green;
                    rbStats.Checked = true;

                    int DamageBuff = 0;

                    int DefenseBuff = 0;

                    DamageBuff  = (Convert.ToInt32(cbStrength.SelectedItem.ToString()) / 20)        + (Convert.ToInt32(cbDexterity.SelectedItem.ToString()) / 30) - 3;
                    DefenseBuff = (Convert.ToInt32(cbConstitution.SelectedItem.ToString()) / 10)    + (Convert.ToInt32(cbStrength.SelectedItem.ToString()) / 20) - 7;

                    if (DamageBuff >= 0)
                    {
                        txtDamageBuff.Text = Convert.ToString(DamageBuff);
                    }
                    else
                    {
                        txtDamageBuff.Text = "0";
                    }

                    if (DefenseBuff >= 0)
                    {
                        txtStaminaBuff.Text = Convert.ToString(DefenseBuff);
                    }
                    else
                    {
                        txtStaminaBuff.Text = "0";
                    }

                    txtAttackBuff.Text  = Convert.ToString(c.AttackBuff(dexterity));
                    txtDefenseBuff.Text = Convert.ToString(c.DefenseBuff(agility));
                    txtMagicBuff.Text   = Convert.ToString(c.MagicBuff(magicTalent));

                    txtRumble.Text      = Convert.ToString(((strength + agility) / 20) + Convert.ToInt32(txtAttackBuff.Text));
                    txtDefense.Text     = Convert.ToString(11 + Convert.ToInt32(txtDefenseBuff.Text));
                    txtDefense0.Text    = Convert.ToString(10 + Convert.ToInt32(txtDefenseBuff.Text));
                    txtDoMagic.Text     = Convert.ToString(10 + Convert.ToInt32(txtMagicBuff.Text));
                    txtDoMagic0.Text    = Convert.ToString( 2 + Convert.ToInt32(txtMagicBuff.Text));

                    int mtBuffGhost_Body_MagicValue = 0;
                    int intBuffGhostMagicValue      = 0;
                    int CoBuffBodyMagicValue        = 0;

                    //Buff MagicTalent Ghost&Body
                    mtBuffGhost_Body_MagicValue = c.MagicTalentGhostBody(magicTalent);

                    //Buff Intelligence Ghost
                    intBuffGhostMagicValue = c.IntelligenceGhost(intelligence);

                    //Buff Constitution Body
                    CoBuffBodyMagicValue = c.ConstitutionBody(constitution);

                    //Values GhostMagic
                    txtGhostMagicFighter.Text   = Convert.ToString(14 + c.GhostMagic(mtBuffGhost_Body_MagicValue, intBuffGhostMagicValue));
                    txtGhostMagicMagician.Text  = Convert.ToString(17 + c.GhostMagic(mtBuffGhost_Body_MagicValue, intBuffGhostMagicValue));
                    txtGhostMagicNormal.Text    = Convert.ToString(14 + c.GhostMagic(mtBuffGhost_Body_MagicValue, intBuffGhostMagicValue));

                    //Values BodyMagic
                    txtBodyMagicFighter.Text    = Convert.ToString(16 + c.BodyMagic(mtBuffGhost_Body_MagicValue, CoBuffBodyMagicValue));
                    txtBodyMagicMagician.Text   = Convert.ToString(17 + c.BodyMagic(mtBuffGhost_Body_MagicValue, CoBuffBodyMagicValue));
                    txtBodyMagicNormal.Text     = Convert.ToString(14 + c.BodyMagic(mtBuffGhost_Body_MagicValue, CoBuffBodyMagicValue));

                    //Values AreaMagic
                    txtAreaMagicFighter.Text    = Convert.ToString(10 + c.AgilityArea(agility));
                    txtAreaMagicMagician.Text   = Convert.ToString(13 + c.AgilityArea(agility));
                    txtAreaMagicNormal.Text     = Convert.ToString(10 + c.AgilityArea(agility));

                    if (cbAppearance.SelectedItem != null)
                    {
                        cbCharisma.Enabled = true;
                    }

                    if(cbIntelligence.SelectedItem != null && cbConstitution.SelectedItem != null)
                    {
                        cbWillpower.Enabled = true;
                    }

                    if(txtWillpower.Text != "" && cbIntelligence.SelectedItem != null)
                    {
                        cbSelfControl.Enabled = true;
                    }                   

                    if(txtStaminaBuff.Text != "")
                    {
                        cbAdventurePointsA.Enabled = true;
                        cbAdventurePointsB.Enabled = true;
                        cbAdventurePointsC.Enabled = true;
                    }

                    if(cbConstitution.SelectedItem != null)
                    {
                        cbLifePoints.Enabled = true;
                    }

                    if (cbStrength.SelectedItem != null)
                    {
                        cbBodySizeA.Enabled = true;
                        cbBodySizeB.Enabled = true;
                    }

                    if (cbBodySizeA.SelectedItem != null && cbBodySizeB.SelectedItem != null && cbStrength.SelectedItem != null)
                    {
                        cbBodyWeightA.Enabled = true;
                        cbBodyWeightB.Enabled = true;
                        cbBodyWeightC.Enabled = true;
                        cbBodyWeightD.Enabled = true;
                    }
                }
            }
            else
            {
                lblStatCheck.Text = "Summe < 350";
                lblStatCheck.ForeColor = System.Drawing.Color.Red;
                rbStats.Checked = false;

                // If Stat Sum is to low, values get reset
                txtDamageBuff.Text  = "";
                txtStaminaBuff.Text = "";
                txtAttackBuff.Text  = "";
                txtDefenseBuff.Text = "";
                txtMagicBuff.Text   = "";

                txtRumble.Text      = "";
                txtDefense.Text     = "";
                txtDefense0.Text    = "";
                txtDoMagic.Text     = "";
                txtDoMagic0.Text    = "";

                txtGhostMagicFighter.Text   = "";
                txtGhostMagicMagician.Text  = "";
                txtGhostMagicNormal.Text    = "";
                txtBodyMagicFighter.Text    = "";
                txtBodyMagicMagician.Text   = "";
                txtBodyMagicNormal.Text     = "";
                txtAreaMagicFighter.Text    = "";
                txtAreaMagicMagician.Text   = "";
                txtAreaMagicNormal.Text     = "";

                cbCharisma.Enabled    = false;
                cbWillpower.Enabled   = false;
                cbSelfControl.Enabled = false;

                cbAdventurePointsA.Enabled = false;
                cbAdventurePointsB.Enabled = false;
                cbAdventurePointsC.Enabled = false;
                cbLifePoints.Enabled  = false;

                cbBodySizeA.Enabled = false;
                cbBodySizeB.Enabled = false;

                cbBodyWeightA.Enabled = false;
                cbBodyWeightB.Enabled = false;
                cbBodyWeightC.Enabled = false;
                cbBodyWeightD.Enabled = false;
            }            
        }

        //Export to a .txt file

        private void BtnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCharacterName.Text != "")
                {

                    //NonHumans dont have male/female so there isnt a second size
                    if (this.Text != "MCreator - Mensch")
                    {
                        txtBodySizeB.Text = "0";
                        txtBodyWeightB.Text = "0";
                    }

                    Export exp = new Export();
                    exp.export();
                }
                else
                {
                    MessageBox.Show("Bitte einen Charakternamen eingeben!", "Fehler", MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Bitte erst alle Werte eintragen", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        //Opens a Dialog to choose a folder
        private void TxtSavepathExport_Click(object sender, EventArgs e)
        {
            if (chooseExportFolder.ShowDialog(this) == DialogResult.OK)
                txtExportPath.Text = chooseExportFolder.SelectedPath;
        }

        //Imports the charactervalues from a previously exported character
        private void BtnImport_Click(object sender, EventArgs e)
        {
            if (txtImportFile.Text !="")
            {
                List<String> lines = new List<String>();
                using (StreamReader sr = new StreamReader(txtImportFile.Text, Encoding.Default))
                {
                    while (sr.Peek() != -1)
                        lines.Add(sr.ReadLine());
                }


                if (this.Text == lines[101])
                {
                    cbStrength.SelectedIndex = Convert.ToInt32(lines[56]) -1 ;
                    cbDexterity.SelectedIndex = Convert.ToInt32(lines[58]) -1;
                    cbAgility.SelectedIndex = Convert.ToInt32(lines[60]) -1;
                    cbConstitution.SelectedIndex = Convert.ToInt32(lines[62]) -1;
                    cbIntelligence.SelectedIndex = Convert.ToInt32(lines[64]) -1;
                    cbMagicalTalent.SelectedIndex = Convert.ToInt32(lines[66]) -1;

                    cbBodySizeA.SelectedIndex = Convert.ToInt32(lines[68]) -1;
                    cbBodySizeB.SelectedIndex = Convert.ToInt32(lines[70]) -1;

                    cbBodyWeightA.SelectedIndex = Convert.ToInt32(lines[72]) -1;
                    cbBodyWeightB.SelectedIndex = Convert.ToInt32(lines[74]) -1;
                    cbBodyWeightC.SelectedIndex = Convert.ToInt32(lines[76]) -1;
                    cbBodyWeightD.SelectedIndex = Convert.ToInt32(lines[78]) -1;

                    cbAppearance.SelectedIndex = Convert.ToInt32(lines[81]) -1;
                    cbCharisma.SelectedIndex = Convert.ToInt32(lines[83]) -1;
                    cbWillpower.SelectedIndex = Convert.ToInt32(lines[85]) -1;
                    cbSelfControl.SelectedIndex = Convert.ToInt32(lines[87]) -1;

                    cbInbornBuff.SelectedIndex = Convert.ToInt32(lines[89]) -1;
                    cbHanded.SelectedIndex = Convert.ToInt32(lines[91]) -1;

                    cbAdventurePointsA.SelectedIndex = Convert.ToInt32(lines[93]) -1;
                    cbAdventurePointsB.SelectedIndex = Convert.ToInt32(lines[95]) -1;
                    cbAdventurePointsC.SelectedIndex = Convert.ToInt32(lines[97]) -1;
                    cbLifePoints.SelectedIndex = Convert.ToInt32(lines[99]) -1;

                    //txtCharacterName.Text = lines[];

                    // Enabling the form
                    int strength = Convert.ToInt32(cbStrength.SelectedItem.ToString()) -1;
                    int dexterity = Convert.ToInt32(cbDexterity.SelectedItem.ToString()) -1;
                    int agility = Convert.ToInt32(cbAgility.SelectedItem.ToString()) -1;
                    int constitution = Convert.ToInt32(cbConstitution.SelectedItem.ToString()) -1;
                    int intelligence = Convert.ToInt32(cbConstitution.SelectedItem.ToString()) -1;
                    int magicTalent = Convert.ToInt32(cbMagicalTalent.SelectedItem.ToString()) -1;

                    rbStats.Checked = true;

                    int DamageBuff = 0;
                    int DefenseBuff = 0;

                    DamageBuff = (strength / 20) + (dexterity / 30) - 3;
                    DefenseBuff = (strength / 20) + (constitution / 10) - 7;

                    if (DamageBuff >= 0)
                    {
                        txtDamageBuff.Text = Convert.ToString(DamageBuff);
                    }
                    else
                    {
                        txtDamageBuff.Text = "0";
                    }

                    if (DefenseBuff >= 0)
                    {
                        txtStaminaBuff.Text = Convert.ToString(DefenseBuff);
                    }
                    else
                    {
                        txtStaminaBuff.Text = "0";
                    }

                    txtAttackBuff.Text = Convert.ToString(c.AttackBuff(dexterity));
                    txtDefenseBuff.Text = Convert.ToString(c.DefenseBuff(agility));
                    txtMagicBuff.Text = Convert.ToString(c.MagicBuff(magicTalent));

                    txtRumble.Text = Convert.ToString(((strength + agility) / 20) + c.AttackBuff(dexterity));
                    txtDefense.Text = Convert.ToString(11 + c.DefenseBuff(agility));
                    txtDefense0.Text = Convert.ToString(10 + c.DefenseBuff(agility));
                    txtDoMagic.Text = Convert.ToString(10 + c.MagicBuff(magicTalent));
                    txtDoMagic0.Text = Convert.ToString(2 + c.MagicBuff(magicTalent));

                    int mtBuffGhost_Body_MagicValue = 0;
                    int intBuffGhostMagicValue = 0;
                    int CoBuffBodyMagicValue = 0;

                    //Buff MagicTalent Ghost&Body
                    mtBuffGhost_Body_MagicValue = c.MagicTalentGhostBody(magicTalent);

                    //Buff Intelligence Ghost
                    intBuffGhostMagicValue = c.IntelligenceGhost(intelligence);

                    //Buff Constitution Body
                    CoBuffBodyMagicValue = c.ConstitutionBody(constitution);

                    //Values GhostMagic
                    txtGhostMagicFighter.Text = Convert.ToString(14 + c.GhostMagic(mtBuffGhost_Body_MagicValue, intBuffGhostMagicValue));
                    txtGhostMagicMagician.Text = Convert.ToString(17 + c.GhostMagic(mtBuffGhost_Body_MagicValue, intBuffGhostMagicValue));
                    txtGhostMagicNormal.Text = Convert.ToString(14 + c.GhostMagic(mtBuffGhost_Body_MagicValue, intBuffGhostMagicValue));

                    //Values BodyMagic
                    txtBodyMagicFighter.Text = Convert.ToString(16 + c.BodyMagic(mtBuffGhost_Body_MagicValue, CoBuffBodyMagicValue));
                    txtBodyMagicMagician.Text = Convert.ToString(17 + c.BodyMagic(mtBuffGhost_Body_MagicValue, CoBuffBodyMagicValue));
                    txtBodyMagicNormal.Text = Convert.ToString(14 + c.BodyMagic(mtBuffGhost_Body_MagicValue, CoBuffBodyMagicValue));

                    //Values AreaMagic
                    txtAreaMagicFighter.Text = Convert.ToString(10 + c.AgilityArea(agility));
                    txtAreaMagicMagician.Text = Convert.ToString(13 + c.AgilityArea(agility));
                    txtAreaMagicNormal.Text = Convert.ToString(10 + c.AgilityArea(agility));


                    


                }
                else
                {
                    MessageBox.Show("Importdatei passt nicht zur gewähten Rasse");
                }
                
            }
            
        }

        //Import button for a previously exported character
        private void TxtImportFile_Click(object sender, EventArgs e)
        {
            string file;

            if (chooseImportFile.ShowDialog(this) == DialogResult.OK)
            {
                file = chooseImportFile.FileName;
                
                txtImportFile.Text = file;
            }         
        }

        //Exit Button
        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Beim Beenden gehen alle Werte verloren", "Warnung", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                CalculationTimer.Enabled = false;
                EnableTimer.Enabled = false;
                this.Close();
            }
                
        }

        //Automatic Calculatin during runtime
        private void CalculationTimer_Tick(object sender, EventArgs e)
        {
            if (
                cbStrength.SelectedItem != null && 
                cbDexterity.SelectedItem != null && 
                cbAgility.SelectedItem != null && 
                cbConstitution.SelectedItem != null && 
                cbIntelligence.SelectedItem != null && 
                cbMagicalTalent.SelectedItem != null)
            {
                int TotalAmount_Stat = 0;

                int strength        = Convert.ToInt32(cbStrength.SelectedItem.ToString());
                int dexterity       = Convert.ToInt32(cbDexterity.SelectedItem.ToString());
                int agility         = Convert.ToInt32(cbAgility.SelectedItem.ToString());
                int constitution    = Convert.ToInt32(cbConstitution.SelectedItem.ToString());
                int intelligence    = Convert.ToInt32(cbIntelligence.SelectedItem.ToString());
                int magicTalent     = Convert.ToInt32(cbMagicalTalent.SelectedItem.ToString());

                TotalAmount_Stat = strength + dexterity + agility + constitution + intelligence + magicTalent;

                if (TotalAmount_Stat >= 350)
                {
                    int DamageBuff = 0;
                    int DefenseBuff = 0;

                    DamageBuff  = (Convert.ToInt32(cbStrength.SelectedItem.ToString()) / 20)        + (Convert.ToInt32(cbDexterity.SelectedItem.ToString()) / 30) - 3;
                    DefenseBuff = (Convert.ToInt32(cbConstitution.SelectedItem.ToString()) / 10)    + (Convert.ToInt32(cbStrength.SelectedItem.ToString()) / 20) - 7;

                    if (DamageBuff >= 0)
                    {
                        txtDamageBuff.Text = Convert.ToString(DamageBuff);
                    }
                    else
                    {
                        txtDamageBuff.Text = "0";
                    }

                    if (DefenseBuff >= 0)
                    {
                        txtStaminaBuff.Text = Convert.ToString(DefenseBuff);
                    }
                    else
                    {
                        txtStaminaBuff.Text = "0";
                    }

                    txtAttackBuff.Text  = Convert.ToString(c.AttackBuff(dexterity));
                    txtDefenseBuff.Text = Convert.ToString(c.DefenseBuff(agility));
                    txtMagicBuff.Text   = Convert.ToString(c.MagicBuff(magicTalent));

                    txtRumble.Text      = Convert.ToString(((strength + agility) / 20) + Convert.ToInt32(txtAttackBuff.Text));
                    txtDefense.Text     = Convert.ToString(11 + Convert.ToInt32(txtDefenseBuff.Text));
                    txtDefense0.Text    = Convert.ToString(10 + Convert.ToInt32(txtDefenseBuff.Text));
                    txtDoMagic.Text     = Convert.ToString(10 + Convert.ToInt32(txtMagicBuff.Text));
                    txtDoMagic0.Text    = Convert.ToString(2 + Convert.ToInt32(txtMagicBuff.Text));

                    int mtBuffGhost_Body_MagicValue = 0;
                    int intBuffGhostMagicValue = 0;
                    int CoBuffBodyMagicValue = 0;

                    //Buff MagicTalent Ghost&Body
                    mtBuffGhost_Body_MagicValue = c.MagicTalentGhostBody(magicTalent);

                    //Buff Intelligence Ghost
                    intBuffGhostMagicValue = c.IntelligenceGhost(intelligence);

                    //Buff Constitution Body
                    CoBuffBodyMagicValue = c.ConstitutionBody(constitution);

                    //Values GhostMagic
                    txtGhostMagicFighter.Text   = Convert.ToString(14 + c.GhostMagic(mtBuffGhost_Body_MagicValue, intBuffGhostMagicValue));
                    txtGhostMagicMagician.Text  = Convert.ToString(17 + c.GhostMagic(mtBuffGhost_Body_MagicValue, intBuffGhostMagicValue));
                    txtGhostMagicNormal.Text    = Convert.ToString(14 + c.GhostMagic(mtBuffGhost_Body_MagicValue, intBuffGhostMagicValue));

                    //Values BodyMagic
                    txtBodyMagicFighter.Text    = Convert.ToString(16 + c.BodyMagic(mtBuffGhost_Body_MagicValue, CoBuffBodyMagicValue));
                    txtBodyMagicMagician.Text   = Convert.ToString(17 + c.BodyMagic(mtBuffGhost_Body_MagicValue, CoBuffBodyMagicValue));
                    txtBodyMagicNormal.Text     = Convert.ToString(14 + c.BodyMagic(mtBuffGhost_Body_MagicValue, CoBuffBodyMagicValue));

                    //Values AreaMagic
                    txtAreaMagicFighter.Text    = Convert.ToString(10 + c.AgilityArea(agility));
                    txtAreaMagicMagician.Text   = Convert.ToString(13 + c.AgilityArea(agility));
                    txtAreaMagicNormal.Text     = Convert.ToString(10 + c.AgilityArea(agility));
                }
            }                                    
        }

        private void cbCharisma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCharisma.SelectedItem != null && cbIntelligence.SelectedItem != null && cbAppearance.SelectedItem != null)
            {
                txtCharisma.Text = Convert.ToString(c.Charisma(cbCharisma.SelectedItem.ToString(), cbIntelligence.SelectedItem.ToString(), cbAppearance.SelectedItem.ToString()));
            }
        }

        private void cbWillpower_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbWillpower.SelectedItem != null && cbIntelligence.SelectedItem != null && cbConstitution.SelectedItem != null)
            {
                txtWillpower.Text = Convert.ToString(c.Willpower(cbWillpower.SelectedItem.ToString(), cbIntelligence.SelectedItem.ToString(), cbConstitution.SelectedItem.ToString()));
            }
        }

        private void cbSelfControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSelfControl.SelectedItem != null && txtWillpower.Text != "" && cbIntelligence.SelectedItem != null)
            {
                txtSelfControlA.Text = Convert.ToString(c.SelfControlA(cbSelfControl.SelectedItem.ToString(), txtWillpower.Text, cbIntelligence.SelectedItem.ToString()));
                txtSelfControlB.Text = Convert.ToString(c.SelfControlB(cbSelfControl.SelectedItem.ToString(), txtWillpower.Text, cbIntelligence.SelectedItem.ToString()));
                txtSelfControlC.Text = Convert.ToString(c.SelfControlC(cbSelfControl.SelectedItem.ToString(), txtWillpower.Text, cbIntelligence.SelectedItem.ToString()));
            }
        }

        private void cbInbornBuff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbInbornBuff.SelectedItem != null && txtWillpower.Text != "")
            {
                txtInbornBuff.Text = c.InbornBuff(cbInbornBuff.SelectedItem.ToString(), txtWillpower.Text);
            }
            
        }

        private void cbHanded_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbHanded.SelectedItem != null)
            {
                txtHanded.Text = c.Handed(cbHanded.SelectedItem.ToString());
            }
            
        }

        private void cbAdventurePointsA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAdventurePointsA.SelectedItem != null && txtStaminaBuff.Text != "")
            {
                txtAdventurePointsA.Text = Convert.ToString(c.AdventurePointsA(cbAdventurePointsA.SelectedItem.ToString(), txtStaminaBuff.Text, this.Text));
            }
        }

        private void cbAdventurePointsB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAdventurePointsB.SelectedItem != null && txtStaminaBuff.Text != "")
            {
                txtAdventurePointsB.Text = Convert.ToString(c.AdventurePointsB(cbAdventurePointsB.SelectedItem.ToString(), txtStaminaBuff.Text, this.Text));
            }
        }

        private void cbAdventurePointsC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAdventurePointsC.SelectedItem != null && txtStaminaBuff.Text != "")
            {
                txtAdventurePointsC.Text = Convert.ToString(c.AdventurePointsC(cbAdventurePointsC.SelectedItem.ToString(), txtStaminaBuff.Text, this.Text));
            }
        }

        private void cbLifePoints_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLifePoints.SelectedItem != null && cbConstitution.SelectedItem != null)
            {
                txtLifePoints.Text = Convert.ToString(c.LifePoints(cbConstitution.SelectedItem.ToString(), cbLifePoints.SelectedItem.ToString(), this.Text));
            }
        }

        private void cbBodySizeA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBodySizeA.SelectedItem != null && cbBodySizeB.SelectedItem != null && cbStrength.SelectedItem != null)
            {
                if (this.Text == "MCreator - Mensch")
                {
                    txtBodySizeA.Text = Convert.ToString(c.BodySize(cbBodySizeA.SelectedItem.ToString(), cbBodySizeB.SelectedItem.ToString(), cbStrength.SelectedItem.ToString(), this.Text) + 150);
                    txtBodySizeB.Text = Convert.ToString(c.BodySize(cbBodySizeA.SelectedItem.ToString(), cbBodySizeB.SelectedItem.ToString(), cbStrength.SelectedItem.ToString(), this.Text) + 140);
                }
                else
                {
                    txtBodySizeA.Text = Convert.ToString(c.BodySize(cbBodySizeA.SelectedItem.ToString(), cbBodySizeB.SelectedItem.ToString(), cbStrength.SelectedItem.ToString(), this.Text));
                }
            }
            
        }

        private void cbBodySizeB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBodySizeA.SelectedItem != null && cbBodySizeB.SelectedItem != null && cbStrength.SelectedItem != null)
            {
                if (this.Text == "MCreator - Mensch")
                {
                    txtBodySizeA.Text = Convert.ToString(c.BodySize(cbBodySizeA.SelectedItem.ToString(), cbBodySizeB.SelectedItem.ToString(), cbStrength.SelectedItem.ToString(), this.Text) + 150);
                    txtBodySizeB.Text = Convert.ToString(c.BodySize(cbBodySizeA.SelectedItem.ToString(), cbBodySizeB.SelectedItem.ToString(), cbStrength.SelectedItem.ToString(), this.Text) + 140);
                }
                else
                {
                    txtBodySizeA.Text = Convert.ToString(c.BodySize(cbBodySizeA.SelectedItem.ToString(), cbBodySizeB.SelectedItem.ToString(), cbStrength.SelectedItem.ToString(), this.Text));
                }
            }
        }

        private void cbBodyWeightA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBodyWeightA.SelectedItem != null && cbBodyWeightB.SelectedItem != null && cbBodyWeightC.SelectedItem != null && cbBodyWeightD.SelectedItem != null && cbStrength.SelectedItem != null && txtBodySizeA.Text != "")
            {
                if (this.Text == "MCreator - Mensch")
                {
                    txtBodyWeightA.Text = Convert.ToString(c.BodyWeight(cbBodyWeightA.SelectedItem.ToString(), cbBodyWeightB.SelectedItem.ToString(), cbBodyWeightC.SelectedItem.ToString(), cbBodyWeightD.SelectedItem.ToString(), cbStrength.SelectedItem.ToString(), txtBodySizeA.Text, this.Text));
                    txtBodyWeightB.Text = Convert.ToString(c.BodyWeight(cbBodyWeightA.SelectedItem.ToString(), cbBodyWeightB.SelectedItem.ToString(), cbBodyWeightC.SelectedItem.ToString(), cbBodyWeightD.SelectedItem.ToString(), cbStrength.SelectedItem.ToString(), txtBodySizeA.Text, this.Text) - 4);
                }
                else
                {
                    txtBodyWeightA.Text = Convert.ToString(c.BodyWeight(cbBodyWeightA.SelectedItem.ToString(), cbBodyWeightB.SelectedItem.ToString(), cbBodyWeightC.SelectedItem.ToString(), cbBodyWeightD.SelectedItem.ToString(), cbStrength.SelectedItem.ToString(), txtBodySizeA.Text, this.Text));
                }
            }
        }

        private void cbBodyWeightB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBodyWeightA.SelectedItem != null && cbBodyWeightB.SelectedItem != null && cbBodyWeightC.SelectedItem != null && cbBodyWeightD.SelectedItem != null && cbStrength.SelectedItem != null && txtBodySizeA.Text != "")
            {
                if (this.Text == "MCreator - Mensch")
                {
                    txtBodyWeightA.Text = Convert.ToString(c.BodyWeight(cbBodyWeightA.SelectedItem.ToString(), cbBodyWeightB.SelectedItem.ToString(), cbBodyWeightC.SelectedItem.ToString(), cbBodyWeightD.SelectedItem.ToString(), cbStrength.SelectedItem.ToString(), txtBodySizeA.Text, this.Text));
                    txtBodyWeightB.Text = Convert.ToString(c.BodyWeight(cbBodyWeightA.SelectedItem.ToString(), cbBodyWeightB.SelectedItem.ToString(), cbBodyWeightC.SelectedItem.ToString(), cbBodyWeightD.SelectedItem.ToString(), cbStrength.SelectedItem.ToString(), txtBodySizeA.Text, this.Text) - 4);
                }
                else
                {
                    txtBodyWeightA.Text = Convert.ToString(c.BodyWeight(cbBodyWeightA.SelectedItem.ToString(), cbBodyWeightB.SelectedItem.ToString(), cbBodyWeightC.SelectedItem.ToString(), cbBodyWeightD.SelectedItem.ToString(), cbStrength.SelectedItem.ToString(), txtBodySizeA.Text, this.Text));
                }
            }
        }

        private void cbBodyWeightC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBodyWeightA.SelectedItem != null && cbBodyWeightB.SelectedItem != null && cbBodyWeightC.SelectedItem != null && cbBodyWeightD.SelectedItem != null && cbStrength.SelectedItem != null && txtBodySizeA.Text != "")
            {
                if (this.Text == "MCreator - Mensch")
                {
                    txtBodyWeightA.Text = Convert.ToString(c.BodyWeight(cbBodyWeightA.SelectedItem.ToString(), cbBodyWeightB.SelectedItem.ToString(), cbBodyWeightC.SelectedItem.ToString(), cbBodyWeightD.SelectedItem.ToString(), cbStrength.SelectedItem.ToString(), txtBodySizeA.Text, this.Text));
                    txtBodyWeightB.Text = Convert.ToString(c.BodyWeight(cbBodyWeightA.SelectedItem.ToString(), cbBodyWeightB.SelectedItem.ToString(), cbBodyWeightC.SelectedItem.ToString(), cbBodyWeightD.SelectedItem.ToString(), cbStrength.SelectedItem.ToString(), txtBodySizeA.Text, this.Text) - 4);
                }
                else
                {
                    txtBodyWeightA.Text = Convert.ToString(c.BodyWeight(cbBodyWeightA.SelectedItem.ToString(), cbBodyWeightB.SelectedItem.ToString(), cbBodyWeightC.SelectedItem.ToString(), cbBodyWeightD.SelectedItem.ToString(), cbStrength.SelectedItem.ToString(), txtBodySizeA.Text, this.Text));
                }
            }
        }

        private void cbBodyWeightD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBodyWeightA.SelectedItem != null && cbBodyWeightB.SelectedItem != null && cbBodyWeightC.SelectedItem != null && cbBodyWeightD.SelectedItem != null && cbStrength.SelectedItem != null && txtBodySizeA.Text != "")
            {
                if (this.Text == "MCreator - Mensch")
                {
                    txtBodyWeightA.Text = Convert.ToString(c.BodyWeight(cbBodyWeightA.SelectedItem.ToString(), cbBodyWeightB.SelectedItem.ToString(), cbBodyWeightC.SelectedItem.ToString(), cbBodyWeightD.SelectedItem.ToString(), cbStrength.SelectedItem.ToString(), txtBodySizeA.Text, this.Text));
                    txtBodyWeightB.Text = Convert.ToString(c.BodyWeight(cbBodyWeightA.SelectedItem.ToString(), cbBodyWeightB.SelectedItem.ToString(), cbBodyWeightC.SelectedItem.ToString(), cbBodyWeightD.SelectedItem.ToString(), cbStrength.SelectedItem.ToString(), txtBodySizeA.Text, this.Text) - 4);
                }
                else
                {
                    txtBodyWeightA.Text = Convert.ToString(c.BodyWeight(cbBodyWeightA.SelectedItem.ToString(), cbBodyWeightB.SelectedItem.ToString(), cbBodyWeightC.SelectedItem.ToString(), cbBodyWeightD.SelectedItem.ToString(), cbStrength.SelectedItem.ToString(), txtBodySizeA.Text, this.Text));
                }
            }
        }
    }
}
