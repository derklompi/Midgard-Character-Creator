/*
    Mcreator
    Copyright (C) 2016  Fabian D�rr <faflfama@outlook.com>

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
    public partial class FrmMain : Form
    {
        
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnCreateHuman_Click(object sender, EventArgs e)
        {    
            //Convert.ToString(Thread.CurrentThread.CurrentUICulture) == "de-DE"
            Hide();
            FrmCreateCharacter createHuman = new FrmCreateCharacter();
            createHuman.Text = "MCreator - Mensch";
            createHuman.ShowDialog();
            createHuman = null;
                
            Show();  
        }

        private void btnCreateElf_Click(object sender, EventArgs e)
        {
            Hide();
            FrmCreateCharacter createElf = new FrmCreateCharacter();
            createElf.Text = "MCreator - Elf";
            createElf.ShowDialog();
            createElf = null;         
            Show();
        }

        private void btnCreateHalfling_Click(object sender, EventArgs e)
        {
            Hide();
            FrmCreateCharacter createHalfling = new FrmCreateCharacter();
            createHalfling.Text = "MCreator - Halbling";
            createHalfling.ShowDialog();
            createHalfling = null;
            Show();          
        }

        private void btnCreateDwarf_Click(object sender, EventArgs e)
        {
            Hide();
            FrmCreateCharacter createDwarf = new FrmCreateCharacter();
            createDwarf.Text = "MCreator - Zwerg";
            createDwarf.ShowDialog();
            createDwarf = null;
            Show();
        }

        private void btnCreateGnome_Click(object sender, EventArgs e)
        {
            Hide();
            FrmCreateCharacter createGnome = new FrmCreateCharacter();
            createGnome.Text = "MCreator - Gnom";
            createGnome.ShowDialog();
            createGnome = null;
            Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEXP_Click(object sender, EventArgs e)
        {
            Hide();
            FrmLevelUp levelUp = new FrmLevelUp();
            levelUp.Text = "MCreator - Level Up";
            levelUp.ShowDialog();
            levelUp = null;
            Show();
        }

        private void btnCustomizationValues_Click(object sender, EventArgs e)
        {
            Hide();
            FrmCustomizationValues customizationValues = new FrmCustomizationValues();
            customizationValues.Text = "MCreator - Customization Values";
            customizationValues.ShowDialog();
            customizationValues = null;
            Show();
        }
    }
}
