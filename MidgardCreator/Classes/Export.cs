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
                               
            int mtxtStrength = Convert.ToInt32(CharExport.mtxtStrength.Text);
            int mtxtDexterity = Convert.ToInt32(CharExport.mtxtDexterity.Text);
            int mtxtAgility = Convert.ToInt32(CharExport.mtxtAgility.Text);
            int mtxtConstitution = Convert.ToInt32(CharExport.mtxtConstitution.Text);
            int mtxtIntelligence = Convert.ToInt32(CharExport.mtxtIntelligence.Text);
            int mtxtMagicalTalent = Convert.ToInt32(CharExport.mtxtMagicalTalent.Text);
            int mtxtAppearance = Convert.ToInt32(CharExport.mtxtAppearance.Text);

            int txtCharisma = Convert.ToInt32(CharExport.txtCharisma.Text);
            int txtWillpower = Convert.ToInt32(CharExport.txtWillpower.Text);
            int txtSelfControlA = Convert.ToInt32(CharExport.txtSelfControlA.Text);
            int txtSelfControlB = Convert.ToInt32(CharExport.txtSelfControlB.Text);
            int txtSelfControlC = Convert.ToInt32(CharExport.txtSelfControlC.Text);
            string txtInbornBuff = CharExport.txtInbornBuff.Text;
            string txtHanded = CharExport.txtHanded.Text;
            int mtxtCharisma = Convert.ToInt32(CharExport.mtxtCharisma.Text);
            int mtxtWillpower = Convert.ToInt32(CharExport.mtxtWillpower.Text);
            int mtxtSelfControl = Convert.ToInt32(CharExport.mtxtSelfControl.Text);
            int mtxtInbornBuff = Convert.ToInt32(CharExport.mtxtInbornBuff.Text);
            int mtxtHanded = Convert.ToInt32(CharExport.mtxtHanded.Text);

            int txtDamageBuff = Convert.ToInt32(CharExport.txtDamageBuff.Text);
            int txtStaminaBuff = Convert.ToInt32(CharExport.txtStaminaBuff.Text);
            int txtAttackBuff = Convert.ToInt32(CharExport.txtAttackBuff.Text);
            int txtDefenseBuff = Convert.ToInt32(CharExport.txtDefenseBuff.Text);
            int txtMagicBuff = Convert.ToInt32(CharExport.txtMagicBuff.Text);
            int txtRumble = Convert.ToInt32(CharExport.txtRumble.Text);
            int txtDefense = Convert.ToInt32(CharExport.txtDefense.Text);
            int txtDefense0 = Convert.ToInt32(CharExport.txtDefense0.Text);
            int txtDoMagic = Convert.ToInt32(CharExport.txtDoMagic.Text);
            int txtDoMagic0 = Convert.ToInt32(CharExport.txtDoMagic0.Text);
            int txtGhostMagicFighter = Convert.ToInt32(CharExport.txtGhostMagicFighter.Text);
            int txtGhostMagicMagician   = Convert.ToInt32(CharExport.txtGhostMagicMagician.Text);
            int txtGhostMagicNormal = Convert.ToInt32(CharExport.txtGhostMagicNormal.Text);
            int txtBodyMagicFighter = Convert.ToInt32(CharExport.txtBodyMagicFighter.Text);
            int txtBodyMagicMagician = Convert.ToInt32(CharExport.txtBodyMagicMagician.Text);
            int txtBodyMagicNormal = Convert.ToInt32(CharExport.txtBodyMagicNormal.Text);
            int txtAreaMagicFighter = Convert.ToInt32(CharExport.txtAreaMagicFighter.Text);
            int txtAreaMagicMagician = Convert.ToInt32(CharExport.txtAreaMagicMagician.Text);
            int txtAreaMagicNormal = Convert.ToInt32(CharExport.txtAreaMagicNormal.Text);

            int txtAdventurePointsA = Convert.ToInt32(CharExport.txtAdventurePointsA.Text);
            int txtAdventurePointsB = Convert.ToInt32(CharExport.txtAdventurePointsB.Text);
            int txtAdventurePointsC = Convert.ToInt32(CharExport.txtAdventurePointsC.Text);
            int txtLifePoints = Convert.ToInt32(CharExport.txtLifePoints.Text);
            int mtxtAdventurePointsA = Convert.ToInt32(CharExport.mtxtAdventurePointsA.Text);
            int mtxtAdventurePointsB = Convert.ToInt32(CharExport.mtxtAdventurePointsB.Text);
            int mtxtAdventurePointsC = Convert.ToInt32(CharExport.mtxtAdventurePointsC.Text);
            int mtxtLifePoints = Convert.ToInt32(CharExport.mtxtLifePoints.Text);

            int txtBodySizeA = Convert.ToInt32(CharExport.txtBodySizeA.Text);
            int txtBodySizeB = Convert.ToInt32(CharExport.txtBodySizeB.Text);
            int mtxtBodySizeA = Convert.ToInt32(CharExport.mtxtBodySizeA.Text);
            int mtxtBodySizeB = Convert.ToInt32(CharExport.mtxtBodySizeB.Text);
            
            int txtBodyWeightA = Convert.ToInt32(CharExport.txtBodyWeightA.Text);
            int txtBodyWeightB = Convert.ToInt32(CharExport.txtBodyWeightB.Text);
            int mtxtBodyWeightA = Convert.ToInt32(CharExport.mtxtBodyWeightA.Text);
            int mtxtBodyWeightB = Convert.ToInt32(CharExport.mtxtBodyWeightB.Text);
            int mtxtBodyWeightC = Convert.ToInt32(CharExport.mtxtBodyWeightC.Text);
            int mtxtBodyWeightD = Convert.ToInt32(CharExport.mtxtBodyWeightD.Text);
           
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
                    file.WriteLine("Stärke:             " + mtxtStrength);
                    file.WriteLine("Geschicklichkeit:   " + mtxtDexterity);
                    file.WriteLine("Gewandheit:         " + mtxtAgility);
                    file.WriteLine("Konsitution:        " + mtxtConstitution);
                    file.WriteLine("Intelligenz:        " + mtxtIntelligence);
                    file.WriteLine("Zaubertalent:       " + mtxtMagicalTalent);

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
                    file.WriteLine("Aussehen:                                           " + mtxtAppearance);
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
                    file.WriteLine(mtxtStrength);
                    file.WriteLine("Geschicklichkeit (1W%):");
                    file.WriteLine(mtxtDexterity);
                    file.WriteLine("Gewandheit (1W%):");
                    file.WriteLine(mtxtAgility);
                    file.WriteLine("Konsitution (1W%):");
                    file.WriteLine(mtxtConstitution);
                    file.WriteLine("Intelligenz (1W%):");
                    file.WriteLine(mtxtIntelligence);
                    file.WriteLine("Zaubertalent (1W%):");
                    file.WriteLine(mtxtMagicalTalent);
                    file.WriteLine("1. Größe (1W20/1W6):");
                    file.WriteLine(mtxtBodySizeA);
                    file.WriteLine("2. Größe (1W20/1W6):");
                    file.WriteLine(mtxtBodySizeB);
                    file.WriteLine("1. Gewicht (1W6):");
                    file.WriteLine(mtxtBodyWeightA);
                    file.WriteLine("2. Gewicht (1W6):");
                    file.WriteLine(mtxtBodyWeightB);
                    file.WriteLine("3. Gewicht (1W6):");
                    file.WriteLine(mtxtBodyWeightC);
                    file.WriteLine("4. Gewicht (1W6):");
                    file.WriteLine(mtxtBodyWeightD);

                    file.WriteLine("Charismawerte");
                    file.WriteLine("Aussehen (1W%):");
                    file.WriteLine(mtxtAppearance);
                    file.WriteLine("Persönliche Ausstrahlung (1W%):");
                    file.WriteLine(mtxtCharisma);
                    file.WriteLine("Willenskraft (1W%):");
                    file.WriteLine(mtxtWillpower);
                    file.WriteLine("Selbstbeherrschung (1W%):");
                    file.WriteLine(mtxtSelfControl);
                    file.WriteLine("Angeborene Fähigkeit (1W%):");
                    file.WriteLine(mtxtInbornBuff);
                    file.WriteLine("Händigkeit (1W20):");
                    file.WriteLine(mtxtHanded);

                    file.WriteLine("Abenteuerpunkte (1W6):");
                    file.WriteLine(mtxtAdventurePointsA);
                    file.WriteLine("Abenteuerpunkte (1W6):");
                    file.WriteLine(mtxtAdventurePointsB);
                    file.WriteLine("Abenteuerpunkte (1W6):");
                    file.WriteLine(mtxtAdventurePointsC);

                    file.WriteLine("Lebenspunkte (1W6):");
                    file.WriteLine(mtxtLifePoints);

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