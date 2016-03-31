using System;
using System.Globalization;
using System.Windows.Forms;
using System.Threading;


namespace MidgardCreator
{
    public partial class FrmMain : Form
    {
        
        public FrmMain()
        {
            InitializeComponent();
            if(Convert.ToString(Thread.CurrentThread.CurrentUICulture) != "de-DE")
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-EN");
            }
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

        private void menuLanguageGerman_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("de-DE");

            //Menü-Punkte
            menuSettingsDE.Text = "Einstellungen";
            menuLanguageDE.Text = "Sprache";
            menuLanguageDEEnglish.Text = "Englisch";
            menuLanguageDEGerman.Text = "Deutsch";
            //Fomular-Buttons
            btnCreateDwarf.Text = "Zwerg";
            btnCreateElf.Text = "Elf";
            btnCreateGnome.Text = "Gnom";
            btnCreateHalfling.Text = "Halbling";
            btnCreateHuman.Text = "Mensch";
        }

        private void menuLanguageEnglish_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-EN");
            //Menü-Punkte
            menuSettingsDE.Text = "Settings";
            menuLanguageDE.Text = "Language";
            menuLanguageDEEnglish.Text = "English";
            menuLanguageDEGerman.Text = "German";
            //Fomular-Buttons
            btnCreateDwarf.Text = "Dwarf";
            btnCreateElf.Text = "Elf";
            btnCreateGnome.Text = "Gnome";
            btnCreateHalfling.Text = "Halfling";
            btnCreateHuman.Text = "Human";
        }

        private void menuLanguageENGerman_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("de-DE");
            //Menü-Punkte
            menuSettingsEN.Text = "Einstellungen";
            menuLanguageEN.Text = "Sprache";
            menuLanguageENEnglish.Text = "English";
            menuLanguageENGerman.Text = "Deutsch";
            //Fomular-Buttons
            btnCreateDwarf.Text = "Zwerg";
            btnCreateElf.Text = "Elf";
            btnCreateGnome.Text = "Gnom";
            btnCreateHalfling.Text = "Halbling";
            btnCreateHuman.Text = "Mensch";
        }

        private void menuLanguageENEnglish_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-EN");
            //Menü-Punkte
            menuSettingsEN.Text = "Settings";
            menuLanguageEN.Text = "Language";
            menuLanguageENEnglish.Text = "English";
            menuLanguageENGerman.Text = "German";
            //Fomular-Buttons
            btnCreateDwarf.Text = "Dwarf";
            btnCreateElf.Text = "Elf";
            btnCreateGnome.Text = "Gnome";
            btnCreateHalfling.Text = "Halfling";
            btnCreateHuman.Text = "Human";
        }
    }
}
