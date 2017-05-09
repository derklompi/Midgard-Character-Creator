using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace mcreator.Classes
{
    class ComboBoxValue
    {
        public void SetComboBoxValue()
        {
            FrmCreateCharacter frmCC = Application.OpenForms[1] as FrmCreateCharacter;
          
            frmCC.cbBodySizeA.Items.Clear();

            switch (frmCC.Text)
            {
                case "MCreator - Zwerg":
                    frmCC.cbBodySizeA.Items.Add(0);
                    frmCC.cbBodySizeA.Items.Add(1);
                    frmCC.cbBodySizeA.Items.Add(2);
                    frmCC.cbBodySizeA.Items.Add(3);
                    frmCC.cbBodySizeA.Items.Add(4);
                    frmCC.cbBodySizeA.Items.Add(5);
                    frmCC.cbBodySizeA.Items.Add(6);
                    break;
                case "MCreator - Elf":
                    frmCC.cbBodySizeA.Items.Add(0);
                    frmCC.cbBodySizeA.Items.Add(1);
                    frmCC.cbBodySizeA.Items.Add(2);
                    frmCC.cbBodySizeA.Items.Add(3);
                    frmCC.cbBodySizeA.Items.Add(4);
                    frmCC.cbBodySizeA.Items.Add(5);
                    frmCC.cbBodySizeA.Items.Add(6);
                    break;
                case "MCreator - Gnom":
                    frmCC.cbBodySizeA.Items.Add(0);
                    frmCC.cbBodySizeA.Items.Add(1);
                    frmCC.cbBodySizeA.Items.Add(2);
                    frmCC.cbBodySizeA.Items.Add(3);
                    frmCC.cbBodySizeA.Items.Add(4);
                    frmCC.cbBodySizeA.Items.Add(5);
                    frmCC.cbBodySizeA.Items.Add(6);
                    break;
                case "MCreator - Halbling":
                    frmCC.cbBodySizeA.Items.Add(0);
                    frmCC.cbBodySizeA.Items.Add(1);
                    frmCC.cbBodySizeA.Items.Add(2);
                    frmCC.cbBodySizeA.Items.Add(3);
                    frmCC.cbBodySizeA.Items.Add(4);
                    frmCC.cbBodySizeA.Items.Add(5);
                    frmCC.cbBodySizeA.Items.Add(6);
                    break;
                case "MCreator - Mensch":
                    frmCC.cbBodySizeA.Items.Add(0);
                    frmCC.cbBodySizeA.Items.Add(1);
                    frmCC.cbBodySizeA.Items.Add(2);
                    frmCC.cbBodySizeA.Items.Add(3);
                    frmCC.cbBodySizeA.Items.Add(4);
                    frmCC.cbBodySizeA.Items.Add(5);
                    frmCC.cbBodySizeA.Items.Add(6);
                    frmCC.cbBodySizeA.Items.Add(7);
                    frmCC.cbBodySizeA.Items.Add(8);
                    frmCC.cbBodySizeA.Items.Add(9);
                    frmCC.cbBodySizeA.Items.Add(10);
                    frmCC.cbBodySizeA.Items.Add(11);
                    frmCC.cbBodySizeA.Items.Add(12);
                    frmCC.cbBodySizeA.Items.Add(13);
                    frmCC.cbBodySizeA.Items.Add(14);
                    frmCC.cbBodySizeA.Items.Add(15);
                    frmCC.cbBodySizeA.Items.Add(16);
                    frmCC.cbBodySizeA.Items.Add(17);
                    frmCC.cbBodySizeA.Items.Add(18);
                    frmCC.cbBodySizeA.Items.Add(19);
                    frmCC.cbBodySizeA.Items.Add(20);
                    break;
                default:
                    MessageBox.Show("fail");
                    break;
            }

            frmCC.cbBodySizeA.SelectedIndex = 0;
        }            
    }
}
