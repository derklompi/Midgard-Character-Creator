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
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace mcreator.Classes
{
    class Export
    {
        public void export()
        {
            FrmCreateCharacter CharExport = Application.OpenForms[1] as FrmCreateCharacter;
            if (CharExport == null)
            {
                MessageBox.Show("Keine Hauptform vorhanden!");
                return;
            }
            
            //Get the current date
            string date = "";
            DateTime currentDate = DateTime.Now;
            date = currentDate.ToString("dd-MM-yyy");

            //Get the ExportPlace/Path and the filename
            string exportPlace = "";
            string exportPath = "";
            string characterName = "";
            exportPath = CharExport.txtExportPath.Text;
            characterName = CharExport.txtCharacterName.Text;
            exportPlace = @"" + exportPath + "\\" + characterName + "-MCreator_" + date + ".txt";

            string formTitle = "";
            formTitle = CharExport.Text;
                               
            string cbStrength        = CharExport.cbStrength.SelectedItem.ToString();
            string cbDexterity       = CharExport.cbDexterity.SelectedItem.ToString();
            string cbAgility         = CharExport.cbAgility.SelectedItem.ToString();
            string cbConstitution    = CharExport.cbConstitution.SelectedItem.ToString();
            string cbIntelligence    = CharExport.cbIntelligence.SelectedItem.ToString();
            string cbMagicalTalent   = CharExport.cbMagicalTalent.SelectedItem.ToString();
            string cbAppearance      = CharExport.cbAppearance.SelectedItem.ToString();

            string txtCharisma         = CharExport.txtCharisma.Text;
            string txtWillpower        = CharExport.txtWillpower.Text;
            string txtSelfControlA     = CharExport.txtSelfControlA.Text;
            string txtSelfControlB     = CharExport.txtSelfControlB.Text;
            string txtSelfControlC     = CharExport.txtSelfControlC.Text;
            string cbCharisma        = CharExport.cbCharisma.SelectedItem.ToString();
            string cbWillpower       = CharExport.cbWillpower.SelectedItem.ToString();
            string cbSelfControl     = CharExport.cbSelfControl.SelectedItem.ToString();
            string cbInbornBuff      = CharExport.cbInbornBuff.SelectedItem.ToString();
            string cbHanded          = CharExport.cbHanded.SelectedItem.ToString();

            string txtInbornBuff    = CharExport.txtInbornBuff.Text;
            string txtHanded        = CharExport.txtHanded.Text;

            string txtDamageBuff       = CharExport.txtDamageBuff.Text;
            string txtStaminaBuff      = CharExport.txtStaminaBuff.Text;
            string txtAttackBuff       = CharExport.txtAttackBuff.Text;
            string txtDefenseBuff      = CharExport.txtDefenseBuff.Text;
            string txtMagicBuff        = CharExport.txtMagicBuff.Text;
            string txtRumble           = CharExport.txtRumble.Text;
            string txtDefense          = CharExport.txtDefense.Text;
            string txtDefense0         = CharExport.txtDefense0.Text;
            string txtDoMagic          = CharExport.txtDoMagic.Text;
            string txtDoMagic0         = CharExport.txtDoMagic0.Text;

            string txtGhostMagicFighter    = CharExport.txtGhostMagicFighter.Text;
            string txtGhostMagicMagician   = CharExport.txtGhostMagicMagician.Text;
            string txtGhostMagicNormal     = CharExport.txtGhostMagicNormal.Text;
            string txtBodyMagicFighter     = CharExport.txtBodyMagicFighter.Text;
            string txtBodyMagicMagician    = CharExport.txtBodyMagicMagician.Text;
            string txtBodyMagicNormal      = CharExport.txtBodyMagicNormal.Text;
            string txtAreaMagicFighter     = CharExport.txtAreaMagicFighter.Text;
            string txtAreaMagicMagician    = CharExport.txtAreaMagicMagician.Text;
            string txtAreaMagicNormal      = CharExport.txtAreaMagicNormal.Text;

            string txtAdventurePointsA     = CharExport.txtAdventurePointsA.Text;
            string txtAdventurePointsB     = CharExport.txtAdventurePointsB.Text;
            string txtAdventurePointsC     = CharExport.txtAdventurePointsC.Text;
            string txtLifePoints           = CharExport.txtLifePoints.Text;
            string cbAdventurePointsA    = CharExport.cbAdventurePointsA.SelectedItem.ToString();
            string cbAdventurePointsB    = CharExport.cbAdventurePointsB.SelectedItem.ToString();
            string cbAdventurePointsC    = CharExport.cbAdventurePointsC.SelectedItem.ToString();
            string cbLifePoints          = CharExport.cbLifePoints.SelectedItem.ToString();

            string txtBodySizeA        = CharExport.txtBodySizeA.Text;
            string txtBodySizeB        = CharExport.txtBodySizeB.Text;
            string cbBodySizeA       = CharExport.cbBodySizeA.SelectedItem.ToString();
            string cbBodySizeB       = CharExport.cbBodySizeB.SelectedItem.ToString();

            string txtBodyWeightA      = CharExport.txtBodyWeightA.Text;
            string txtBodyWeightB      = CharExport.txtBodyWeightB.Text;
            string cbBodyWeightA     = CharExport.cbBodyWeightA.SelectedItem.ToString();
            string cbBodyWeightB     = CharExport.cbBodyWeightB.SelectedItem.ToString();
            string cbBodyWeightC     = CharExport.cbBodyWeightC.SelectedItem.ToString();
            string cbBodyWeightD     = CharExport.cbBodyWeightD.SelectedItem.ToString();
                       
            if (File.Exists(exportPlace) != true)
            {
                string charrclass = "";

                // Read the title to define the race
                switch (formTitle)
                {
                    case ("MCreator - Mensch"):
                        charrclass = "Mensch";
                        break;
                    case ("MCreator - Elf"):
                        charrclass = "Elf";
                        break;
                    case ("MCreator - Halbling"):
                        charrclass = "Halbling";
                        break;
                    case ("MCreator - Zwerg"):
                        charrclass = "Zwerg";
                        break;
                    case ("MCreator - Gnom"):
                        charrclass = "Gnom";
                        break;
                }

                // Writing the values in the text file
                using (StreamWriter file =
                new StreamWriter(exportPlace))
                {
                    file.WriteLine("Werte für " + characterName + " am " + currentDate);
                    file.WriteLine("Klasse: " + charrclass);
                    file.WriteLine("--------------------------------");

                    //Grundwerte
                    file.WriteLine("Grundwerte");
                    file.WriteLine("Stärke:             " + cbStrength);
                    file.WriteLine("Geschicklichkeit:   " + cbDexterity);
                    file.WriteLine("Gewandheit:         " + cbAgility);
                    file.WriteLine("Konsitution:        " + cbConstitution);
                    file.WriteLine("Intelligenz:        " + cbIntelligence);
                    file.WriteLine("Zaubertalent:       " + cbMagicalTalent);

                    // Since humans have both male and female they need the extra part
                    if (charrclass == "Mensch")
                    {
                        file.WriteLine("Größe (Mann):       " + txtBodySizeA + " cm");
                        file.WriteLine("Größe (Frau):       " + txtBodySizeB + " cm");
                        file.WriteLine("Gewicht (Mann):     " + txtBodyWeightA + " kg");
                        file.WriteLine("Gewicht (Frau):     " + txtBodyWeightB + " kg");
                    }
                    else
                    {
                        file.WriteLine("Größe:              " + txtBodySizeA + " cm");
                        file.WriteLine("Gewicht:            " + txtBodyWeightA + " kg");
                    }

                    file.WriteLine("");

                    //Charisma-Wesenswerte
                    file.WriteLine("Charisma-Wesenswerte");
                    file.WriteLine("Aussehen:                                           " + cbAppearance);
                    file.WriteLine("Persönliche Ausstrahlung:                           " + txtCharisma);
                    file.WriteLine("Willenskraft:                                       " + txtWillpower);
                    file.WriteLine("Selbstbeherrschung (allgemein):                     " + txtSelfControlA);
                    file.WriteLine("Selbstbeherrschung (Glücksritter/Spitzbuben):       " + txtSelfControlB);
                    file.WriteLine("Selbstbeherrschung (Assasine/Beschwörer/Druide):    " + txtSelfControlC);
                    file.WriteLine("Angeborene Fähigkeit:                               " + txtInbornBuff);
                    file.WriteLine("Angeborene Fähigkeit:                               " + txtHanded);

                    file.WriteLine("");

                    //Boni
                    file.WriteLine("Boni");
                    file.WriteLine("Schadensbonus:          " + txtDamageBuff);
                    file.WriteLine("Ausdauerbonus:          " + txtStaminaBuff);
                    file.WriteLine("Angriffsbonus:          " + txtAttackBuff);
                    file.WriteLine("Abwehrbonus:            " + txtDefenseBuff);
                    file.WriteLine("Zauberbonus:            " + txtMagicBuff);
                    file.WriteLine("Raufen:                 " + txtRumble);
                    file.WriteLine("Abwehr:                 " + txtDefense);
                    file.WriteLine("Abwehr (ungelernt):     " + txtDefense0);
                    file.WriteLine("Zaubern:                " + txtDoMagic);
                    file.WriteLine("Zaubern (ungelernt):    " + txtDoMagic0);

                    file.WriteLine("");

                    //Resistenzen
                    file.WriteLine("Resistenzen");
                    file.WriteLine("Geistesmagie (Kämpfer):     " + txtGhostMagicFighter);
                    file.WriteLine("Geistesmagie (Zauberer):    " + txtGhostMagicMagician);
                    file.WriteLine("Geistesmagie (Normal):      " + txtGhostMagicNormal);
                    file.WriteLine("Körpermagie (Kämpfer):      " + txtBodyMagicFighter);
                    file.WriteLine("Körpermagie (Zauberer):     " + txtBodyMagicMagician);
                    file.WriteLine("Körpermagie (Normal):       " + txtBodyMagicNormal);
                    file.WriteLine("Umgebungsmagie (Kämpfer):   " + txtAreaMagicFighter);
                    file.WriteLine("Umgebungsmagie (Zauberer):  " + txtAreaMagicMagician);
                    file.WriteLine("Umgebungsmagie (Normal):    " + txtAreaMagicNormal);

                    file.WriteLine("");

                    //AP+LP
                    file.WriteLine("Abenteuerpunkte (BarBar/Krieger/Söldner/WaLäu/KunScha):     " + txtAdventurePointsA);
                    file.WriteLine("Abenteuerpunkte (Andere Kämpfer/Schamane):                  " + txtAdventurePointsB);
                    file.WriteLine("Abenteuerpunkte (Anderer Zauberertyp):                      " + txtAdventurePointsC);

                    file.WriteLine("Lebenspunkte: " + txtLifePoints);

                    file.WriteLine("-----------------------------------------------------------------------------------");

                    //Würfelwerte
                    file.WriteLine("Würfelwerte");

                    file.WriteLine("Grundwerte");
                    file.WriteLine("Stärke (1W%):");
                    file.WriteLine(cbStrength);
                    file.WriteLine("Geschicklichkeit (1W%):");
                    file.WriteLine(cbDexterity);
                    file.WriteLine("Gewandheit (1W%):");
                    file.WriteLine(cbAgility);
                    file.WriteLine("Konstitution (1W%):");
                    file.WriteLine(cbConstitution);
                    file.WriteLine("Intelligenz (1W%):");
                    file.WriteLine(cbIntelligence);
                    file.WriteLine("Zaubertalent (1W%):");
                    file.WriteLine(cbMagicalTalent);
                    file.WriteLine("1. Größe (1W20/1W6):");
                    file.WriteLine(cbBodySizeA);
                    file.WriteLine("2. Größe (1W20/1W6):");
                    file.WriteLine(cbBodySizeB);
                    file.WriteLine("1. Gewicht (1W6):");
                    file.WriteLine(cbBodyWeightA);
                    file.WriteLine("2. Gewicht (1W6):");
                    file.WriteLine(cbBodyWeightB);
                    file.WriteLine("3. Gewicht (1W6):");
                    file.WriteLine(cbBodyWeightC);
                    file.WriteLine("4. Gewicht (1W6):");
                    file.WriteLine(cbBodyWeightD);

                    file.WriteLine("Charismawerte");
                    file.WriteLine("Aussehen (1W%):");
                    file.WriteLine(cbAppearance);
                    file.WriteLine("Persönliche Ausstrahlung (1W%):");
                    file.WriteLine(cbCharisma);
                    file.WriteLine("Willenskraft (1W%):");
                    file.WriteLine(cbWillpower);
                    file.WriteLine("Selbstbeherrschung (1W%):");
                    file.WriteLine(cbSelfControl);
                    file.WriteLine("Angeborene Fähigkeit (1W%):");
                    file.WriteLine(cbInbornBuff);
                    file.WriteLine("Händigkeit (1W20):");
                    file.WriteLine(cbHanded);

                    file.WriteLine("Abenteuerpunkte (1W6):");
                    file.WriteLine(cbAdventurePointsA);
                    file.WriteLine("Abenteuerpunkte (1W6):");
                    file.WriteLine(cbAdventurePointsB);
                    file.WriteLine("Abenteuerpunkte (1W6):");
                    file.WriteLine(cbAdventurePointsC);

                    file.WriteLine("Lebenspunkte (1W6):");
                    file.WriteLine(cbLifePoints);

                    file.WriteLine("Fenstertitel");
                    file.WriteLine(formTitle);

                    if (File.Exists(exportPlace))
                    {
                        MessageBox.Show("Datei wurde erstellt!");
                        // Setting the file attribute to read only to prevent changes (at least for inexperienced users)
                        System.IO.FileAttributes att = System.IO.File.GetAttributes(exportPlace);
                        System.IO.File.SetAttributes(exportPlace, att | System.IO.FileAttributes.ReadOnly);

                        // Taken from https://dotnet-snippets.de/snippet/explorer-starten-und-datei-selektieren/1200
                        Process process = new Process();
                        process.StartInfo.FileName = "explorer.exe";
                        process.StartInfo.Arguments = string.Format("/e,/select,\"{0}\"", exportPlace);
                        process.Start();
                    }
                    else
                    {
                        MessageBox.Show("Datei konnte nicht erstellt werden!");
                    }
                }                
            }
            else
            {
                MessageBox.Show("Datei schon vorhanden!");
            }      
        }     
    }
}