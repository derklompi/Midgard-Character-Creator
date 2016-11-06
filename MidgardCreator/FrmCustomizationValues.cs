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
    public partial class FrmCustomizationValues : Form
    {
        public FrmCustomizationValues()
        {
            InitializeComponent();
            
        }

        private void cbStartWeapons_SelectedIndexChanged(object sender, EventArgs e)
        {
            int weaponValue = Convert.ToInt32(cbStartWeapons.SelectedItem.ToString());
            if (weaponValue <= 10)
            {
                txtStartWeaponsA.Text = "3E";
                txtStartWeaponsB.Text = "2E";
                txtStartWeaponsC.Text = "1E";
                txtStartWeaponsD.Text = "2E";
            }
            if (weaponValue <= 20 && weaponValue > 10)
            {
                txtStartWeaponsA.Text = "3E, 1A";
                txtStartWeaponsB.Text = "1E, 1A";
                txtStartWeaponsC.Text = "1A";
                txtStartWeaponsD.Text = "1E, 1A";
            }
            if (weaponValue <= 30 && weaponValue > 20)
            {
                txtStartWeaponsA.Text = "2E, 2A";
                txtStartWeaponsB.Text = "2E, 1A";
                txtStartWeaponsC.Text = "2E";
                txtStartWeaponsD.Text = "3E";
            }
            if (weaponValue <= 60 && weaponValue > 30)
            {
                txtStartWeaponsA.Text = "3E, 2A";
                txtStartWeaponsB.Text = "3E, 1A";
                txtStartWeaponsC.Text = "1E, 1A";
                txtStartWeaponsD.Text = "2E, 1A";
            }
            if (weaponValue <= 80 && weaponValue > 60)
            {
                txtStartWeaponsA.Text = "2E, 3A";
                txtStartWeaponsB.Text = "2E, 2A";
                txtStartWeaponsC.Text = "1E, 1A";
                txtStartWeaponsD.Text = "1E, 2A";
            }
            if (weaponValue <= 95 && weaponValue > 80)
            {
                txtStartWeaponsA.Text = "5A";
                txtStartWeaponsB.Text = "4A";
                txtStartWeaponsC.Text = "2A";
                txtStartWeaponsD.Text = "3A";

            }
            if (weaponValue <= 100 && weaponValue > 95)
            {
                txtStartWeaponsA.Text = "1E*, 4A";
                txtStartWeaponsB.Text = "1E*, 3A";
                txtStartWeaponsC.Text = "1E*, 1A";
                txtStartWeaponsD.Text = "1E*, 2A";
            }
        }

        private void cbStartArmor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int armorValue = Convert.ToInt32(cbStartArmor.SelectedItem.ToString());
            if (armorValue <= 10)
            {
                txtStartArmorA.Text = "OR";
                txtStartArmorB.Text = "OR";
                txtStartArmorC.Text = "OR";
                txtStartArmorD.Text = "OR";
            }
            if (armorValue <= 20 && armorValue > 10)
            {
                txtStartArmorA.Text = "TR";
                txtStartArmorB.Text = "TR";
                txtStartArmorC.Text = "OR";
                txtStartArmorD.Text = "TR";
            }
            if (armorValue <= 30 && armorValue > 20)
            {
                txtStartArmorA.Text = "LR";
                txtStartArmorB.Text = "LR";
                txtStartArmorC.Text = "OR";
                txtStartArmorD.Text = "TR";
            }
            if (armorValue <= 60 && armorValue > 30)
            {
                txtStartArmorA.Text = "KR";
                txtStartArmorB.Text = "LR";
                txtStartArmorC.Text = "TR";
                txtStartArmorD.Text = "LR";
            }
            if (armorValue <= 80 && armorValue > 60)
            {
                txtStartArmorA.Text = "KR";
                txtStartArmorB.Text = "KR";
                txtStartArmorC.Text = "TR";
                txtStartArmorD.Text = "LR";
            }
            if (armorValue <= 95 && armorValue > 80)
            {
                txtStartArmorA.Text = "KR";
                txtStartArmorB.Text = "KR";
                txtStartArmorC.Text = "LR";
                txtStartArmorD.Text = "LR";

            }
            if (armorValue <= 100 && armorValue > 95)
            {
                txtStartArmorA.Text = "PR";
                txtStartArmorB.Text = "KR";
                txtStartArmorC.Text = "LR";
                txtStartArmorD.Text = "LR";
            }
        }
      
        private void btnReset_Click(object sender, EventArgs e)
        {
            cbStartArmor.Items.Clear();
        }

        private void cbStartMoneyA_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbStartMoneyB.Enabled = true;
        }

        private void cbStartMoneyB_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbStartMoneyC.Enabled = true;
        }

        private void cbStartMoneyC_SelectedIndexChanged(object sender, EventArgs e)
        {
            int startMoneyCalcA = 0;
            int startMoneyCalcB = 0;
            int startMoneyCalcC = 0;

            startMoneyCalcA = Convert.ToInt32(cbStartMoneyA.SelectedItem.ToString());
            startMoneyCalcB = Convert.ToInt32(cbStartMoneyB.SelectedItem.ToString());
            startMoneyCalcC = Convert.ToInt32(cbStartMoneyC.SelectedItem.ToString());

            if(txtSocialRank.Text == "Volk" || txtSocialRank.Text == "Mittelschicht")
            {
                txtMoneyA.Text = Convert.ToString(startMoneyCalcA + startMoneyCalcB + startMoneyCalcC - 3);
                txtMoneyB.Text = Convert.ToString(startMoneyCalcA + startMoneyCalcB + startMoneyCalcC);
                txtMoneyC.Text = Convert.ToString(startMoneyCalcA + startMoneyCalcB + startMoneyCalcC + 6);
                txtMoneyD.Text = Convert.ToString(startMoneyCalcA + startMoneyCalcB + startMoneyCalcC + 3);
            }

            if (txtSocialRank.Text == "Unfrei")
            {
                txtMoneyA.Text = Convert.ToString((startMoneyCalcA + startMoneyCalcB + startMoneyCalcC - 3)/2);
                txtMoneyB.Text = Convert.ToString((startMoneyCalcA + startMoneyCalcB + startMoneyCalcC)/2);
                txtMoneyC.Text = Convert.ToString((startMoneyCalcA + startMoneyCalcB + startMoneyCalcC + 6)/2);
                txtMoneyD.Text = Convert.ToString((startMoneyCalcA + startMoneyCalcB + startMoneyCalcC + 3)/2);
            }

            if (txtSocialRank.Text == "Adel")
            {
                txtMoneyA.Text = Convert.ToString((startMoneyCalcA + startMoneyCalcB + startMoneyCalcC - 3)*2);
                txtMoneyB.Text = Convert.ToString((startMoneyCalcA + startMoneyCalcB + startMoneyCalcC)*2);
                txtMoneyC.Text = Convert.ToString((startMoneyCalcA + startMoneyCalcB + startMoneyCalcC + 6)*2);
                txtMoneyD.Text = Convert.ToString((startMoneyCalcA + startMoneyCalcB + startMoneyCalcC + 3)*2);
            }
            else
            {
                txtMoneyA.Text = Convert.ToString(startMoneyCalcA + startMoneyCalcB + startMoneyCalcC - 3);
                txtMoneyB.Text = Convert.ToString(startMoneyCalcA + startMoneyCalcB + startMoneyCalcC);
                txtMoneyC.Text = Convert.ToString(startMoneyCalcA + startMoneyCalcB + startMoneyCalcC + 6);
                txtMoneyD.Text = Convert.ToString(startMoneyCalcA + startMoneyCalcB + startMoneyCalcC + 3);
            }
        }

        private void cbSocialRank_SelectedIndexChanged(object sender, EventArgs e)
        {
            int socialRankValue = Convert.ToInt32(cbSocialRank.SelectedItem.ToString());
            if (socialRankValue <= 10)
            {
                txtSocialRank.Text = "Unfrei";
            }
            if (socialRankValue <= 50 && socialRankValue > 10)
            {
                txtSocialRank.Text = "Volk";
            }
            if (socialRankValue <= 90 && socialRankValue > 50)
            {
                txtSocialRank.Text = "Mittelschicht";
            }
            if (socialRankValue <= 100 && socialRankValue > 90)
            {
                txtSocialRank.Text = "Adel";
            }
        }
    }
}
