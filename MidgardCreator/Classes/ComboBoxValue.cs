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

            frmCC.cbBodySizeA.SelectedIndex = 0;
            frmCC.cbBodySizeB.SelectedIndex = 0;
        }            
    }
}
