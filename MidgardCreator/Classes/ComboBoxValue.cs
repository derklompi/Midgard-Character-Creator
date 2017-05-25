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

using System.Windows.Forms;

namespace mcreator.Classes
{
    class ComboBoxValue
    {
        public void SetComboBoxValue()
        {
            FrmCreateCharacter frmCC = Application.OpenForms[1] as FrmCreateCharacter;
          
            frmCC.cbBodySizeA.Items.Clear();
            int i = 0;

            switch (frmCC.Text)
            {
                case "MCreator - Zwerg":
                    while (i < 7)
                    {
                        frmCC.cbBodySizeA.Items.Add(i);                       
                        i++;
                    }
                    frmCC.cbBodySizeB.Items.Add(0);
                    break;
                case "MCreator - Elf":
                    while (i < 7)
                    {
                        frmCC.cbBodySizeA.Items.Add(i);
                        frmCC.cbBodySizeB.Items.Add(i);
                        i++;
                    }
                    break;
                case "MCreator - Gnom":
                    while (i < 7)
                    {
                        frmCC.cbBodySizeA.Items.Add(i);
                        i++;
                    }
                    frmCC.cbBodySizeB.Items.Add(0);
                    break;
                case "MCreator - Halbling":
                    while (i < 7)
                    {
                        frmCC.cbBodySizeA.Items.Add(i);
                        frmCC.cbBodySizeB.Items.Add(i);
                        i++;
                    }
                    break;
                case "MCreator - Mensch":
                    while (i < 21)
                    {
                        frmCC.cbBodySizeA.Items.Add(i);
                        frmCC.cbBodySizeB.Items.Add(i);
                        i++;
                    }
                    break;
                default:
                    MessageBox.Show("fail");
                    break;
            }

            /*
            int a = 0;
            while (a < 21)
            {
                frmCC.cbHanded.Items.Add(a);
                a++;
            }

            int b = 0;
            while (b < 101)
            {
                frmCC.cbAppearance.Items.Add(b);
                frmCC.cbCharisma.Items.Add(b);
                frmCC.cbWillpower.Items.Add(b);
                frmCC.cbSelfControl.Items.Add(b);
                frmCC.cbInbornBuff.Items.Add(b);
            }
            */
            frmCC.cbBodySizeA.SelectedIndex = 0;
            frmCC.cbBodySizeB.SelectedIndex = 0;
            frmCC.cbHanded.SelectedIndex = 0;
            frmCC.cbAppearance.SelectedIndex = 0;
            frmCC.cbCharisma.SelectedIndex = 0;
            frmCC.cbWillpower.SelectedIndex = 0;
            frmCC.cbSelfControl.SelectedIndex = 0;
            frmCC.cbInbornBuff.SelectedIndex = 0;
            frmCC.cbBodyWeightA.SelectedIndex = 0;
            frmCC.cbBodyWeightB.SelectedIndex = 0;
            frmCC.cbBodyWeightC.SelectedIndex = 0;
            frmCC.cbBodyWeightD.SelectedIndex = 0;
            frmCC.cbStrength.SelectedIndex = 0;
            frmCC.cbDexterity.SelectedIndex = 0;
            frmCC.cbAgility.SelectedIndex = 0;
            frmCC.cbConstitution.SelectedIndex = 0;
            frmCC.cbIntelligence.SelectedIndex = 0;
            frmCC.cbMagicalTalent.SelectedIndex = 0;
            frmCC.cbAdventurePointsA.SelectedIndex = 0;
            frmCC.cbAdventurePointsB.SelectedIndex = 0;
            frmCC.cbAdventurePointsC.SelectedIndex = 0;
            frmCC.cbLifePoints.SelectedIndex = 0;
        }            
    }
}
