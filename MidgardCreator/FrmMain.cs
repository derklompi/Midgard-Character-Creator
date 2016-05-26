using System;
using System.Windows.Forms;
using System.Threading;


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
            FrmCreateCharacter createHuman= new FrmCreateCharacter();
            createHuman.Text = "Midgard Creator - Mensch";
            createHuman.ShowDialog();
            createHuman = null;
            Show();
          
        }

        private void btnCreateElf_Click(object sender, EventArgs e)
        {
            Hide();
            FrmCreateCharacter createElf = new FrmCreateCharacter();
            createElf.Text = "Midgard Creator - Elf";
            createElf.ShowDialog();
            createElf = null;         
            Show();
        }

        private void btnCreateHalfling_Click(object sender, EventArgs e)
        {
            Hide();
            FrmCreateCharacter createHalfling = new FrmCreateCharacter();
            createHalfling.Text = "Midgard Creator - Halbling";
            createHalfling.ShowDialog();
            createHalfling = null;
            Show();          
        }

        private void btnCreateDwarf_Click(object sender, EventArgs e)
        {
            Hide();
            FrmCreateCharacter createDwarf = new FrmCreateCharacter();
            createDwarf.Text = "Midgard Creator - Zwerg";
            createDwarf.ShowDialog();
            createDwarf = null;
            Show();
        }

        private void btnCreateGnome_Click(object sender, EventArgs e)
        {
            Hide();
            FrmCreateCharacter createGnome = new FrmCreateCharacter();
            createGnome.Text = "Midgard Creator - Gnom";
            createGnome.ShowDialog();
            createGnome = null;
            Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
