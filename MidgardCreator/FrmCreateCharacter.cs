using System;
using System.Windows.Forms;
using mcreator.Classes;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace mcreator
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

        private void FrmCreateCharacter_Load(object sender, EventArgs e)
        {
            // Customizing the form for the different races
            if (this.Text == "Midgard Creator - Gnom")
            {
                mtxtHanded.Enabled = false;
                btnHanded.Enabled = false;
                txtBodySizeB.Visible = false;
                lblBodySizeB.Visible = false;
                txtBodyWeightB.Visible = false;
                lblBodyWeightB.Visible = false;

                lblDice20A.Text = "1W6";
                lblDice20B.Text = "1W6";
                lblBodySizeA.Text = "cm";
                lblBodySizeB.Text = "kg";

                txtHanded.Text = "Beidhändig";
            }
            if (this.Text == "Midgard Creator - Elf")
            {
                txtBodySizeB.Visible = false;
                lblBodySizeB.Visible = false;
                txtBodyWeightB.Visible = false;
                lblBodyWeightB.Visible = false;

                lblDice20A.Text = "1W6";
                lblDice20B.Text = "1W6";
                lblBodySizeA.Text = "cm";
                lblBodySizeB.Text = "kg";
            }
            if (this.Text == "Midgard Creator - Zwerg")
            {
                txtBodySizeB.Visible = false;
                lblBodySizeB.Visible = false;
                txtBodyWeightB.Visible = false;
                lblBodyWeightB.Visible = false;

                lblDice20A.Text = "1W6";
                lblDice20B.Text = "1W6";
                lblBodySizeA.Text = "cm";
                lblBodySizeB.Text = "kg";
            }
            if (this.Text == "Midgard Creator - Halbling")
            {
                txtBodySizeB.Visible = false;
                lblBodySizeB.Visible = false;
                txtBodyWeightB.Visible = false;
                lblBodyWeightB.Visible = false;

                lblDice20A.Text = "1W6";
                lblDice20B.Text = "1W6";
                lblBodySizeA.Text = "cm";
                lblBodySizeB.Text = "kg";
            }
            if (this.Text == "Midgard Creator - Mensch")
            {
                txtBodySizeB.Visible = true;
                lblBodySizeB.Visible = true;
                txtBodyWeightB.Visible = true;
                lblBodyWeightB.Visible = true;

                lblDice20A.Text = "1W20";
                lblDice20B.Text = "1W20";
                lblBodySizeA.Text = "cm (Mann)";
                lblBodySizeB.Text = "kg (Mann)";
            }
        }

        private void btnGetRandomCharacter_Click(object sender, EventArgs e)
        {
            // Reset the check value for the following cycle
            bool statPointCheck = false;

            while (statPointCheck == false)
            {
                Random Rnd = new Random();

                int strength = Rnd.Next(1, 101);
                int dexterity = Rnd.Next(1, 101);
                int agility = Rnd.Next(1, 101);
                int constitution = Rnd.Next(1, 101);
                int magicTalent = Rnd.Next(1, 101);
                int intelligence = Rnd.Next(1, 101);

                int gesamt = strength + dexterity + agility + constitution + magicTalent + intelligence;

                if (gesamt >= 350)
                {
                    // Setting the check value to true, so that the cycle gets terminated
                    statPointCheck = true;

                    // Seetting the check field for the timer 
                    txtStats.Text = "true";

                    // Randomizing the dice values
                    mtxtStrength.Text       = Convert.ToString(strength);
                    mtxtDexterity.Text      = Convert.ToString(dexterity);
                    mtxtAgility.Text        = Convert.ToString(agility);
                    mtxtConstitution.Text   = Convert.ToString(constitution);
                    mtxtMagicalTalent.Text  = Convert.ToString(magicTalent);
                    mtxtIntelligence.Text   = Convert.ToString(intelligence);

                    mtxtBodySizeA.Text      = Convert.ToString(Rnd.Next(1, 21));
                    mtxtBodySizeB.Text      = Convert.ToString(Rnd.Next(1, 21));
                    
                    mtxtBodyWeightA.Text    = Convert.ToString(Rnd.Next(1, 7));
                    mtxtBodyWeightB.Text    = Convert.ToString(Rnd.Next(1, 7));
                    mtxtBodyWeightC.Text    = Convert.ToString(Rnd.Next(1, 7));
                    mtxtBodyWeightD.Text    = Convert.ToString(Rnd.Next(1, 7));

                    mtxtAppearance.Text     = Convert.ToString(Rnd.Next(1, 101));
                    mtxtCharisma.Text       = Convert.ToString(Rnd.Next(1, 101));
                    mtxtWillpower.Text      = Convert.ToString(Rnd.Next(1, 101));
                    mtxtSelfControl.Text    = Convert.ToString(Rnd.Next(1, 100));
                    mtxtHanded.Text         = Convert.ToString(Rnd.Next(1, 21));

                    mtxtAdventurePointsA.Text   = Convert.ToString(Rnd.Next(1, 7));
                    mtxtAdventurePointsB.Text   = Convert.ToString(Rnd.Next(1, 7));
                    mtxtAdventurePointsC.Text   = Convert.ToString(Rnd.Next(1, 7));
                    mtxtLifePoints.Text         = Convert.ToString(Rnd.Next(1, 7));

                    mtxtInbornBuff.Text = Convert.ToString(Rnd.Next(1, 101));

                    CombatBuffs cb = new CombatBuffs();

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

                    txtAttackBuff.Text  = Convert.ToString(cb.AttackBuff(dexterity));
                    txtDefenseBuff.Text = Convert.ToString(cb.DefenseBuff(agility));
                    txtMagicBuff.Text   = Convert.ToString(cb.MagicBuff(magicTalent));

                    txtRumble.Text      = Convert.ToString(((strength + agility) / 20) + Convert.ToInt32(txtAttackBuff.Text));
                    txtDefense.Text     = Convert.ToString(11 + Convert.ToInt32(txtDefenseBuff.Text));
                    txtDefense0.Text    = Convert.ToString(10 + Convert.ToInt32(txtDefenseBuff.Text));
                    txtDoMagic.Text     = Convert.ToString(10 + Convert.ToInt32(txtMagicBuff.Text));
                    txtDoMagic0.Text    = Convert.ToString(2 + Convert.ToInt32(txtMagicBuff.Text));



                    txtBodySizeA.Text    = Convert.ToString(Convert.ToInt32(mtxtBodySizeA.Text) + Convert.ToInt32(mtxtBodySizeB.Text) + (Convert.ToInt32(mtxtStrength.Text) / 10) + 150);
                    txtBodySizeB.Text  = Convert.ToString(Convert.ToInt32(mtxtBodySizeA.Text) + Convert.ToInt32(mtxtBodySizeB.Text) + (Convert.ToInt32(mtxtStrength.Text) / 10) + 140);

                    txtBodyWeightA.Text      = Convert.ToString(Convert.ToInt32(mtxtBodyWeightA.Text) + Convert.ToInt32(mtxtBodyWeightB.Text) + Convert.ToInt32(mtxtBodyWeightC.Text) + Convert.ToInt32(mtxtBodyWeightD.Text) + (Convert.ToInt32(mtxtStrength.Text) / 10) + Convert.ToInt32(txtBodySizeA.Text) - 120);
                    txtBodyWeightB.Text    = Convert.ToString((Convert.ToInt32(mtxtBodyWeightA.Text) + Convert.ToInt32(mtxtBodyWeightB.Text) + Convert.ToInt32(mtxtBodyWeightC.Text) + Convert.ToInt32(mtxtBodyWeightD.Text) - 4) + (Convert.ToInt32(mtxtStrength.Text) / 10) + Convert.ToInt32(txtBodySizeB.Text) - 120);

                    Soul s = new Soul();

                    txtCharisma.Text        = Convert.ToString(s.Charisma(mtxtCharisma.Text, mtxtIntelligence.Text, mtxtAppearance.Text));
                    txtWillpower.Text       = Convert.ToString(s.Willpower(mtxtWillpower.Text, mtxtConstitution.Text, mtxtIntelligence.Text));
                    txtSelfControlA.Text    = Convert.ToString(s.SelfControlA(mtxtSelfControl.Text, mtxtIntelligence.Text, txtWillpower.Text));
                    txtSelfControlB.Text    = Convert.ToString(s.SelfControlB(mtxtSelfControl.Text, mtxtIntelligence.Text, txtWillpower.Text));
                    txtSelfControlC.Text    = Convert.ToString(s.SelfControlC(mtxtSelfControl.Text, mtxtIntelligence.Text, txtWillpower.Text));
                    txtHanded.Text          = s.Handed(mtxtHanded.Text);


                    AdventureLifePoints alp = new AdventureLifePoints();

                    txtAdventurePointsA.Text    = Convert.ToString(alp.adventurePointsA(mtxtAdventurePointsA.Text, txtStaminaBuff.Text, this.Text));
                    txtAdventurePointsB.Text    = Convert.ToString(alp.adventurePointsB(mtxtAdventurePointsB.Text, txtStaminaBuff.Text, this.Text));
                    txtAdventurePointsC.Text    = Convert.ToString(alp.adventurePointsC(mtxtAdventurePointsC.Text, txtStaminaBuff.Text, this.Text));
                    txtLifePoints.Text          = Convert.ToString(alp.lifePoints(mtxtConstitution.Text, mtxtLifePoints.Text, this.Text));


                    InbornBuff ib = new InbornBuff();
                    txtInbornBuff.Text = ib.Inborn(Convert.ToInt32(mtxtInbornBuff.Text), Convert.ToInt32(txtWillpower.Text));

                    Resistance r = new Resistance();

                    int mtBuffGhost_Body_MagicValue = 0;
                    int intBuffGhostMagicValue      = 0;
                    int CoBuffBodyMagicValue        = 0;

                    // Buff MagicTalent Ghost&Body
                    mtBuffGhost_Body_MagicValue = r.MagicTalentGhostBody(magicTalent);

                    // Buff Intelligence Ghost
                    intBuffGhostMagicValue = r.IntelligenceGhost(intelligence);

                    // Buff Constitution Body
                    CoBuffBodyMagicValue = r.ConstitutionBody(constitution);

                    // Values GhostMagic
                    txtGhostMagicFighter.Text   = Convert.ToString(14 + r.GhostMagic(mtBuffGhost_Body_MagicValue, intBuffGhostMagicValue));
                    txtGhostMagicMagician.Text  = Convert.ToString(17 + r.GhostMagic(mtBuffGhost_Body_MagicValue, intBuffGhostMagicValue));
                    txtGhostMagicNormal.Text    = Convert.ToString(14 + r.GhostMagic(mtBuffGhost_Body_MagicValue, intBuffGhostMagicValue));

                    // Values BodyMagic
                    txtBodyMagicFighter.Text    = Convert.ToString(16 + r.BodyMagic(mtBuffGhost_Body_MagicValue, CoBuffBodyMagicValue));
                    txtBodyMagicMagician.Text   = Convert.ToString(17 + r.BodyMagic(mtBuffGhost_Body_MagicValue, CoBuffBodyMagicValue));
                    txtBodyMagicNormal.Text     = Convert.ToString(14 + r.BodyMagic(mtBuffGhost_Body_MagicValue, CoBuffBodyMagicValue));

                    // Values AreaMagic
                    txtAreaMagicFighter.Text    = Convert.ToString(10 + r.AgilityArea(agility));
                    txtAreaMagicMagician.Text   = Convert.ToString(13 + r.AgilityArea(agility));
                    txtAreaMagicNormal.Text     = Convert.ToString(10 + r.AgilityArea(agility));
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(TextBox)) c.Text = "";
                if (c.GetType() == typeof(MaskedTextBox)) c.Text = "";
                string user_path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                txtExportPath.Text = "" + user_path + "";
            }

        }

        private void btnBodySize_Click(object sender, EventArgs e)
        {
            txtBodySizeA.Text = Convert.ToString(Convert.ToInt32(mtxtBodySizeA.Text) + Convert.ToInt32(mtxtBodySizeB.Text) + (Convert.ToInt32(mtxtStrength.Text) / 10) + 150);
            txtBodySizeB.Text = Convert.ToString(Convert.ToInt32(mtxtBodySizeA.Text) + Convert.ToInt32(mtxtBodySizeB.Text) + (Convert.ToInt32(mtxtStrength.Text) / 10) + 140);
        }

        private void btnBodyWeight_Click(object sender, EventArgs e)
        {
            txtBodyWeightA.Text = Convert.ToString(Convert.ToInt32(mtxtBodyWeightA.Text) + Convert.ToInt32(mtxtBodyWeightB.Text) + Convert.ToInt32(mtxtBodyWeightC.Text) + Convert.ToInt32(mtxtBodyWeightD.Text) + (Convert.ToInt32(mtxtStrength.Text) / 10) + Convert.ToInt32(txtBodySizeA.Text) - 120);
            txtBodyWeightB.Text = Convert.ToString((Convert.ToInt32(mtxtBodyWeightA.Text) + Convert.ToInt32(mtxtBodyWeightB.Text) + Convert.ToInt32(mtxtBodyWeightC.Text) + Convert.ToInt32(mtxtBodyWeightD.Text) - 4) + (Convert.ToInt32(mtxtStrength.Text) / 10) + Convert.ToInt32(txtBodySizeB.Text) - 120);
        }

        private void btnCharisma_Click(object sender, EventArgs e)
        {
            Soul s = new Soul();

            txtCharisma.Text = Convert.ToString(s.Charisma(mtxtCharisma.Text, mtxtIntelligence.Text, mtxtAppearance.Text));
        }

        private void btnWillpower_Click(object sender, EventArgs e)
        {
            Soul s = new Soul();
            txtWillpower.Text = Convert.ToString(s.Willpower(mtxtWillpower.Text, mtxtConstitution.Text, mtxtIntelligence.Text));
        }

        private void btnSelfControl_Click(object sender, EventArgs e)
        {
            Soul s = new Soul();

            txtSelfControlA.Text = Convert.ToString(s.SelfControlA(mtxtSelfControl.Text, mtxtIntelligence.Text, txtWillpower.Text));
            txtSelfControlB.Text = Convert.ToString(s.SelfControlB(mtxtSelfControl.Text, mtxtIntelligence.Text, txtWillpower.Text));
            txtSelfControlC.Text = Convert.ToString(s.SelfControlC(mtxtSelfControl.Text, mtxtIntelligence.Text, txtWillpower.Text));
        }

        private void btnInbornBuff_Click(object sender, EventArgs e)
        {
            InbornBuff ib = new InbornBuff();
            txtInbornBuff.Text = ib.Inborn(Convert.ToInt32(mtxtInbornBuff.Text), Convert.ToInt32(txtWillpower.Text));
        }

        private void btnHanded_Click(object sender, EventArgs e)
        {
            Soul s = new Soul();
            txtHanded.Text = s.Handed(mtxtHanded.Text);
        }

        private void btnAdventurePointsA_Click(object sender, EventArgs e)
        {
            AdventureLifePoints alp = new AdventureLifePoints();
            txtAdventurePointsA.Text = Convert.ToString(alp.adventurePointsA(mtxtAdventurePointsA.Text, txtStaminaBuff.Text, this.Text));
        }

        private void btnAdventurePointsB_Click(object sender, EventArgs e)
        {
            AdventureLifePoints alp = new AdventureLifePoints();
            txtAdventurePointsB.Text = Convert.ToString(alp.adventurePointsB(mtxtAdventurePointsB.Text, txtStaminaBuff.Text, this.Text));
        }

        private void btnAdventurePointsC_Click(object sender, EventArgs e)
        {
            AdventureLifePoints alp = new AdventureLifePoints();
            txtAdventurePointsC.Text = Convert.ToString(alp.adventurePointsC(mtxtAdventurePointsC.Text, txtStaminaBuff.Text, this.Text));
        }

        private void btnLifePoints_Click(object sender, EventArgs e)
        {
            AdventureLifePoints alp = new AdventureLifePoints();
            txtLifePoints.Text = Convert.ToString(alp.lifePoints(mtxtConstitution.Text, mtxtLifePoints.Text, this.Text));
        }

        private void Enable_Timer_Tick(object sender, EventArgs e)
        {
            #region Stats    
            if (mtxtStrength.Text != "" && Convert.ToInt32(mtxtStrength.Text) <= 100 && mtxtDexterity.Text != "" && Convert.ToInt32(mtxtDexterity.Text) <= 100 && mtxtAgility.Text != "" && Convert.ToInt32(mtxtAgility.Text) <= 100 && mtxtConstitution.Text != "" && Convert.ToInt32(mtxtConstitution.Text) <= 100 && mtxtIntelligence.Text != "" && Convert.ToInt32(mtxtIntelligence.Text) <= 100 && mtxtMagicalTalent.Text != "" && Convert.ToInt32(mtxtMagicalTalent.Text) <= 100)
            {
                int TotalAmount_Stat = 0;

                int strength = Convert.ToInt32(mtxtStrength.Text);
                int dexterity = Convert.ToInt32(mtxtDexterity.Text);
                int agility = Convert.ToInt32(mtxtAgility.Text);
                int constitution = Convert.ToInt32(mtxtConstitution.Text);
                int intelligence = Convert.ToInt32(mtxtIntelligence.Text);
                int magicTalent = Convert.ToInt32(mtxtMagicalTalent.Text);

                TotalAmount_Stat = strength + dexterity + agility + constitution + intelligence + magicTalent;

                if (TotalAmount_Stat < 350)
                {
                    lblStatCheck.Text = "Summe < 350";
                    lblStatCheck.ForeColor = System.Drawing.Color.Red;
                    txtStats.Text = "false";

                    // If Stat Sum is to low, values get reset
                    txtDamageBuff.Text = "";
                    txtStaminaBuff.Text = "";
                    txtAttackBuff.Text = "";
                    txtDefenseBuff.Text = "";
                    txtMagicBuff.Text = "";

                    txtRumble.Text = "";
                    txtDefense.Text = "";
                    txtDefense0.Text = "";
                    txtDoMagic.Text = "";
                    txtDoMagic0.Text = "";

                    txtGhostMagicFighter.Text = "";
                    txtGhostMagicMagician.Text = "";
                    txtGhostMagicNormal.Text = "";
                    txtBodyMagicFighter.Text = "";
                    txtBodyMagicMagician.Text = "";
                    txtBodyMagicNormal.Text = "";
                    txtAreaMagicFighter.Text = "";
                    txtAreaMagicMagician.Text = "";
                    txtAreaMagicNormal.Text = "";

                }

                if (TotalAmount_Stat >= 350)
                {
                    lblStatCheck.Text = "Summe OK";
                    lblStatCheck.ForeColor = System.Drawing.Color.Green;
                    txtStats.Text = "false";

                    CombatBuffs cb = new CombatBuffs();

                    int DamageBuff = 0;
                    int DefenseBuff = 0;

                    DamageBuff = (Convert.ToInt32(mtxtStrength.Text) / 20) + (Convert.ToInt32(mtxtDexterity.Text) / 30) - 3;
                    DefenseBuff = (Convert.ToInt32(mtxtConstitution.Text) / 10) + (Convert.ToInt32(mtxtStrength.Text) / 20) - 7;

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

                    txtAttackBuff.Text = Convert.ToString(cb.AttackBuff(dexterity));
                    txtDefenseBuff.Text = Convert.ToString(cb.DefenseBuff(agility));
                    txtMagicBuff.Text = Convert.ToString(cb.MagicBuff(magicTalent));

                    txtRumble.Text = Convert.ToString(((strength + agility) / 20) + Convert.ToInt32(txtAttackBuff.Text));
                    txtDefense.Text = Convert.ToString(11 + Convert.ToInt32(txtDefenseBuff.Text));
                    txtDefense0.Text = Convert.ToString(10 + Convert.ToInt32(txtDefenseBuff.Text));
                    txtDoMagic.Text = Convert.ToString(10 + Convert.ToInt32(txtMagicBuff.Text));
                    txtDoMagic0.Text = Convert.ToString(2 + Convert.ToInt32(txtMagicBuff.Text));

                    Resistance r = new Resistance();

                    int mtBuffGhost_Body_MagicValue = 0;
                    int intBuffGhostMagicValue = 0;
                    int CoBuffBodyMagicValue = 0;

                    //Buff MagicTalent Ghost&Body
                    mtBuffGhost_Body_MagicValue = r.MagicTalentGhostBody(magicTalent);

                    //Buff Intelligence Ghost
                    intBuffGhostMagicValue = r.IntelligenceGhost(intelligence);

                    //Buff Constitution Body
                    CoBuffBodyMagicValue = r.ConstitutionBody(constitution);

                    //Values GhostMagic
                    txtGhostMagicFighter.Text = Convert.ToString(14 + r.GhostMagic(mtBuffGhost_Body_MagicValue, intBuffGhostMagicValue));
                    txtGhostMagicMagician.Text = Convert.ToString(17 + r.GhostMagic(mtBuffGhost_Body_MagicValue, intBuffGhostMagicValue));
                    txtGhostMagicNormal.Text = Convert.ToString(14 + r.GhostMagic(mtBuffGhost_Body_MagicValue, intBuffGhostMagicValue));

                    //Values BodyMagic
                    txtBodyMagicFighter.Text = Convert.ToString(16 + r.BodyMagic(mtBuffGhost_Body_MagicValue, CoBuffBodyMagicValue));
                    txtBodyMagicMagician.Text = Convert.ToString(17 + r.BodyMagic(mtBuffGhost_Body_MagicValue, CoBuffBodyMagicValue));
                    txtBodyMagicNormal.Text = Convert.ToString(14 + r.BodyMagic(mtBuffGhost_Body_MagicValue, CoBuffBodyMagicValue));

                    //Values AreaMagic
                    txtAreaMagicFighter.Text = Convert.ToString(10 + r.AgilityArea(agility));
                    txtAreaMagicMagician.Text = Convert.ToString(13 + r.AgilityArea(agility));
                    txtAreaMagicNormal.Text = Convert.ToString(10 + r.AgilityArea(agility));
                }
            }
            else
            {
                lblStatCheck.Text = "Summe < 350";
                lblStatCheck.ForeColor = System.Drawing.Color.Red;
                txtStats.Text = "false";

                // If Stat Sum is to low, values get reset
                txtDamageBuff.Text = "";
                txtStaminaBuff.Text = "";
                txtAttackBuff.Text = "";
                txtDefenseBuff.Text = "";
                txtMagicBuff.Text = "";

                txtRumble.Text = "";
                txtDefense.Text = "";
                txtDefense0.Text = "";
                txtDoMagic.Text = "";
                txtDoMagic0.Text = "";

                txtGhostMagicFighter.Text = "";
                txtGhostMagicMagician.Text = "";
                txtGhostMagicNormal.Text = "";
                txtBodyMagicFighter.Text = "";
                txtBodyMagicMagician.Text = "";
                txtBodyMagicNormal.Text = "";
                txtAreaMagicFighter.Text = "";
                txtAreaMagicMagician.Text = "";
                txtAreaMagicNormal.Text = "";
            }

            #endregion
            TimerCheck t = new TimerCheck();
            //BodySize
            btnBodySize.Enabled = true;
                //t.BodySizeCheck(mtxtBodySizeA.Text, mtxtBodySizeB.Text, txtStats.Text, this.Text);

            //BodyWeight
            btnBodyWeight.Enabled = t.BodyWeightCheck(mtxtBodyWeightA.Text, mtxtBodyWeightB.Text, mtxtBodyWeightC.Text, mtxtBodyWeightD.Text, txtStats.Text, txtBodySizeA.Text);

            //Charisma
            btnCharisma.Enabled = t.CharismaCheck(mtxtAppearance.Text, txtStats.Text, mtxtCharisma.Text);

            //Willpower
            btnWillpower.Enabled = t.WillpowerCheck(mtxtWillpower.Text, txtStats.Text);

            //SelfControl
            btnSelfControl.Enabled = t.SelfControlCheck(mtxtSelfControl.Text, txtStats.Text, txtWillpower.Text);

            //Handed
            btnHanded.Enabled = t.HandedCheck(mtxtHanded.Text, txtStats.Text);

            //AP
            btnAdventurePointsA.Enabled = t.AdventurePointsACheck(mtxtAdventurePointsA.Text, txtStaminaBuff.Text);
            btnAdventurePointsB.Enabled = t.AdventurePointsBCheck(mtxtAdventurePointsB.Text, txtStaminaBuff.Text);
            btnAdventurePointsC.Enabled = t.AdventurePointsCCheck(mtxtAdventurePointsC.Text, txtStaminaBuff.Text);

            //LP
            btnLifePoints.Enabled = t.LifePointsCheck(mtxtLifePoints.Text, txtStats.Text);

            //InbornBuff
            btnInbornBuff.Enabled = t.InbornBuffCheck(mtxtInbornBuff.Text);
            
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if(txtCharacterName.Text !="")
            {
                string saveplace;
                string date;

                string dummyA = "", dummyB = "";
                DateTime currentDate = DateTime.Now;
                date = currentDate.ToString("dd-MM-yyy");
                saveplace = @"" + txtExportPath.Text + "\\" + txtCharacterName.Text + "-MidgardCreator_" + date + ".txt";

                Export exp = new Export(this.Text, saveplace, txtCharacterName.Text, date, mtxtStrength.Text, mtxtDexterity.Text, mtxtAgility.Text, mtxtConstitution.Text, mtxtIntelligence.Text,
                    mtxtMagicalTalent.Text, dummyA, dummyB, mtxtAppearance.Text, txtCharisma.Text, txtWillpower.Text, txtSelfControlA.Text, txtSelfControlB.Text,
                    txtSelfControlC.Text, txtInbornBuff.Text, txtDamageBuff.Text, txtStaminaBuff.Text, txtAttackBuff.Text, txtDefenseBuff.Text, txtMagicBuff.Text, txtRumble.Text,
                    txtDefense.Text, txtDefense0.Text, txtDoMagic.Text, txtDoMagic0.Text, txtGhostMagicFighter.Text, txtGhostMagicMagician.Text, txtGhostMagicNormal.Text,
                    txtBodyMagicFighter.Text, txtBodyMagicMagician.Text, txtBodyMagicNormal.Text, txtAreaMagicFighter.Text, txtAreaMagicMagician.Text, txtAreaMagicNormal.Text,
                    txtAdventurePointsA.Text, txtAdventurePointsB.Text, txtAdventurePointsC.Text, txtLifePoints.Text, mtxtBodySizeA.Text, mtxtBodySizeB.Text, mtxtBodyWeightA.Text,
                    mtxtBodyWeightB.Text, mtxtBodyWeightC.Text, mtxtBodyWeightD.Text, mtxtAppearance.Text, mtxtCharisma.Text, mtxtWillpower.Text, mtxtSelfControl.Text, mtxtInbornBuff.Text,
                    mtxtHanded.Text, mtxtAdventurePointsA.Text, mtxtAdventurePointsB.Text, mtxtAdventurePointsC.Text, mtxtLifePoints.Text, txtBodySizeA.Text, txtBodySizeB.Text,
                    txtBodyWeightA.Text, txtBodyWeightB.Text);
                Process.Start("explorer.exe", txtExportPath.Text);
                
            }
            else
            {
                MessageBox.Show("Bitte einen Charakternamen eingeben!", "Fehler");
                
            }
            
        }

        private void txtSavepathExport_Click(object sender, EventArgs e)
        {
            if (browserExportDialog.ShowDialog(this) == DialogResult.OK)
                txtExportPath.Text = browserExportDialog.SelectedPath;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {

            List<String> lines = new List<String>();
            using (StreamReader sr = new StreamReader(txtImportFile.Text, Encoding.Default))
            {
                while (sr.Peek() != -1)
                    lines.Add(sr.ReadLine());
            }




            mtxtStrength.Text = lines[53];
            mtxtDexterity.Text = lines[55];
            mtxtAgility.Text = lines[57];
            mtxtConstitution.Text = lines[59];
            mtxtIntelligence.Text = lines[61];
            mtxtMagicalTalent.Text = lines[63];

            mtxtBodySizeA.Text = lines[65];
            mtxtBodySizeB.Text = lines[67];

            mtxtBodyWeightA.Text = lines[69];
            mtxtBodyWeightB.Text = lines[71];
            mtxtBodyWeightC.Text = lines[73];
            mtxtBodyWeightD.Text = lines[75];

            mtxtAppearance.Text = lines[78];
            mtxtCharisma.Text = lines[80];
            mtxtWillpower.Text = lines[82];
            mtxtSelfControl.Text = lines[84];

            mtxtInbornBuff.Text = lines[86];
            mtxtHanded.Text = lines[88];

            mtxtAdventurePointsA.Text = lines[90];
            mtxtAdventurePointsB.Text = lines[92];
            mtxtAdventurePointsC.Text = lines[94];
            mtxtLifePoints.Text = lines[96];

            //txtCharacterName.Text = lines[];

            // Enabling the form
            int strength = Convert.ToInt32(mtxtStrength.Text);
            int dexterity = Convert.ToInt32(mtxtDexterity.Text);
            int agility = Convert.ToInt32(mtxtAgility.Text);
            int constitution = Convert.ToInt32(mtxtConstitution.Text);
            int intelligence = Convert.ToInt32(mtxtIntelligence.Text);
            int magicTalent = Convert.ToInt32(mtxtMagicalTalent.Text);

            txtStats.Text = "true";
            
            CombatBuffs cb = new CombatBuffs();

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

            txtAttackBuff.Text      = Convert.ToString(cb.AttackBuff(dexterity));
            txtDefenseBuff.Text     = Convert.ToString(cb.DefenseBuff(agility));
            txtMagicBuff.Text       = Convert.ToString(cb.MagicBuff(magicTalent));

            txtRumble.Text          = Convert.ToString(((strength + agility) / 20) + cb.AttackBuff(dexterity));
            txtDefense.Text         = Convert.ToString(11 + cb.DefenseBuff(agility));
            txtDefense0.Text        = Convert.ToString(10 + cb.DefenseBuff(agility));
            txtDoMagic.Text         = Convert.ToString(10 + cb.MagicBuff(magicTalent));
            txtDoMagic0.Text        = Convert.ToString(2  + cb.MagicBuff(magicTalent));


            Resistance r = new Resistance();

            int mtBuffGhost_Body_MagicValue = 0;
            int intBuffGhostMagicValue      = 0;
            int CoBuffBodyMagicValue        = 0;

            //Buff MagicTalent Ghost&Body
            mtBuffGhost_Body_MagicValue = r.MagicTalentGhostBody(magicTalent);

            //Buff Intelligence Ghost
            intBuffGhostMagicValue      = r.IntelligenceGhost(intelligence);

            //Buff Constitution Body
            CoBuffBodyMagicValue        = r.ConstitutionBody(constitution);

            //Values GhostMagic
            txtGhostMagicFighter.Text   = Convert.ToString(14 + r.GhostMagic(mtBuffGhost_Body_MagicValue, intBuffGhostMagicValue));
            txtGhostMagicMagician.Text  = Convert.ToString(17 + r.GhostMagic(mtBuffGhost_Body_MagicValue, intBuffGhostMagicValue));
            txtGhostMagicNormal.Text    = Convert.ToString(14 + r.GhostMagic(mtBuffGhost_Body_MagicValue, intBuffGhostMagicValue));

            //Values BodyMagic
            txtBodyMagicFighter.Text    = Convert.ToString(16 + r.BodyMagic(mtBuffGhost_Body_MagicValue, CoBuffBodyMagicValue));
            txtBodyMagicMagician.Text   = Convert.ToString(17 + r.BodyMagic(mtBuffGhost_Body_MagicValue, CoBuffBodyMagicValue));
            txtBodyMagicNormal.Text     = Convert.ToString(14 + r.BodyMagic(mtBuffGhost_Body_MagicValue, CoBuffBodyMagicValue));

            //Values AreaMagic
            txtAreaMagicFighter.Text    = Convert.ToString(10 + r.AgilityArea(agility));
            txtAreaMagicMagician.Text   = Convert.ToString(13 + r.AgilityArea(agility));
            txtAreaMagicNormal.Text     = Convert.ToString(10 + r.AgilityArea(agility));

        }


        private void txtImportFile_Click(object sender, EventArgs e)
        {
            string file;

            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                file = openFileDialog1.FileName;
                
                txtImportFile.Text = file;
            }         
        }

        
    }
}
