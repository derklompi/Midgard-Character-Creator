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

namespace mcc
{
    public partial class FrmMain : Form
    {
        
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnCreateHuman_Click(object sender, EventArgs e)
        {    
            Hide();
            FrmCreateCharacter createHuman = new FrmCreateCharacter()
            {
                Text = "MCreator - Mensch"
            };
            createHuman.ShowDialog();                     
            Show();  
        }

        private void BtnCreateElf_Click(object sender, EventArgs e)
        {
            Hide();
            FrmCreateCharacter createElf = new FrmCreateCharacter()
            {
                Text = "MCreator - Elf"
            };
            createElf.ShowDialog();       
            Show();
        }

        private void BtnCreateHalfling_Click(object sender, EventArgs e)
        {
            Hide();
            FrmCreateCharacter createHalfling = new FrmCreateCharacter()
            {
                Text = "MCreator - Halbling"
            };
            createHalfling.ShowDialog();
            Show();          
        }

        private void BtnCreateDwarf_Click(object sender, EventArgs e)
        {
            Hide();
            FrmCreateCharacter createDwarf = new FrmCreateCharacter()
            {
                Text = "MCreator - Zwerg"
            };
            createDwarf.ShowDialog();
            Show();
        }

        private void BtnCreateGnome_Click(object sender, EventArgs e)
        {
            Hide();
            FrmCreateCharacter createGnome = new FrmCreateCharacter()
            {
                Text = "MCreator - Gnom"
            };
            createGnome.ShowDialog();
            Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEXP_Click(object sender, EventArgs e)
        {
            Hide();
            FrmLevelUp levelUp = new FrmLevelUp()
            {
                Text = "MCreator - Level Up"
            };
            levelUp.ShowDialog();
            Show();
        }

        private void BtnCustomizationValues_Click(object sender, EventArgs e)
        {
            Hide();
            FrmCustomization customizationValues = new FrmCustomization()
            {
                Text = "MCreator - Customization Values"
            };
            customizationValues.ShowDialog();
            Show();
        }
    }
}
