using System;
using System.Windows.Forms;
using System.Threading;


namespace MidgardCreator
{
    public partial class FrmMain : Form
    {
        
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnCreateHuman_Click(object sender, EventArgs e)
        {
            
            if (Convert.ToString(Thread.CurrentThread.CurrentUICulture) == "de-DE")
            {
                Hide();
                FrmCreateHuman createHuman= new FrmCreateHuman();
                createHuman.Text = "Midgard Creator - Mensch";
                createHuman.ShowDialog();
                createHuman = null;
                Show();
            }
            if (Convert.ToString(Thread.CurrentThread.CurrentUICulture) == "en-EN")
            {
                Hide();
                FrmCreateHuman createHuman = new FrmCreateHuman();
                createHuman.Text = "Midgard Creator - Human";
                createHuman.ShowDialog();
                createHuman = null;
                Show();
            }
            
        }

        private void btnCreateElf_Click(object sender, EventArgs e)
        {
            Hide();
            FrmCreateAlien createAlien = new FrmCreateAlien();
            createAlien.Text = "Midgard Creator - Elf";
            createAlien.ShowDialog();
            createAlien = null;         
            Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateHalfling_Click(object sender, EventArgs e)
        {
            
            if (Convert.ToString(Thread.CurrentThread.CurrentUICulture) == "de-DE")
            {
                Hide();
                FrmCreateAlien createAlien = new FrmCreateAlien();
                createAlien.Text = "Midgard Creator - Halbling";
                createAlien.ShowDialog();
                createAlien = null;
                Show();
            }
            if (Convert.ToString(Thread.CurrentThread.CurrentUICulture) == "en-EN")
            {
                Hide();
                FrmCreateAlien createAlien = new FrmCreateAlien();
                createAlien.Text = "Midgard Creator - Halfling";
                createAlien.ShowDialog();
                createAlien = null;
                Show();
            }
            
        }

        private void btnCreateDwarf_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(Thread.CurrentThread.CurrentUICulture) == "de-DE")
            {
                Hide();
                FrmCreateAlien createAlien = new FrmCreateAlien();
                createAlien.Text = "Midgard Creator - Zwerg";
                createAlien.ShowDialog();
                createAlien = null;
                Show();
            }
            if (Convert.ToString(Thread.CurrentThread.CurrentUICulture) == "en-EN")
            {
                Hide();
                FrmCreateAlien createAlien = new FrmCreateAlien();
                createAlien.Text = "Midgard Creator - Dwarf";
                createAlien.ShowDialog();
                createAlien = null;
                Show();
            }
            
        }

        private void btnCreateGnome_Click(object sender, EventArgs e)
        {
            
            if (Convert.ToString(Thread.CurrentThread.CurrentUICulture) == "de-DE")
            {
                Hide();
                FrmCreateAlien createAlien = new FrmCreateAlien();
                createAlien.Text = "Midgard Creator - Gnom";
                createAlien.ShowDialog();
                createAlien = null;
                Show();
            }
            if (Convert.ToString(Thread.CurrentThread.CurrentUICulture) == "en-EN")
            {
                Hide();
                FrmCreateAlien createAlien = new FrmCreateAlien();
                createAlien.Text = "Midgard Creator - Gnome";
                createAlien.ShowDialog();
                createAlien = null;
                Show();
            }
        }

    }
}
