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
            int i = 1;

            //Fill up Combobox With Values depending on the race
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


            //Set Index to 0 so the Enable FUnction wont try to use empty Values
        }            
    }
}
