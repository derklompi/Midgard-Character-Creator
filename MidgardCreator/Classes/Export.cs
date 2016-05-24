using System;
using System.IO;
using System.Windows.Forms;

namespace MidgardCreator.Classes
{
    class Export
    {
        public Export(string formTitle,string saveplace, string characterName, string currentDate, string mtxtStrength, 
            string mtxtDexterity, string mtxtAgility, string mtxtConstitution, string mtxtIntelligence, string mtxtMagicalTalent, 
            string txtBodySize, string txtBodyWeight, string txtAppearance, string txtCharisma, string txtWillpower, 
            string txtSelfControlA, string txtSelfControlB, string txtSelfControlC, string txtInbornBuff, string txtDamageBuff,
            string txtStaminaBuff, string txtAttackBuff, string txtDefenseBuff, string txtMagicBuff, string txtRumble, 
            string txtDefense, string txtDefense0, string txtDoMagic, string txtDoMagic0, string txtGhostMagicFighter, 
            string txtGhostMagicMagician, string txtGhostMagicNormal, string txtBodyMagicFighter, string txtBodyMagicMagician,
            string txtBodyMagicNormal, string txtAreaMagicFighter, string txtAreaMagicMagician, string txtAreaMagicNormal, 
            string txtAdventurePointsA, string txtAdventurePointsB, string txtAdventurePointsC, string txtLifePoints, 
            string mtxtBodySizeA, string mtxtBodySizeB, string mtxtBodyWeightA, string mtxtBodyWeightB, string mtxtBodyWeightC, 
            string mtxtBodyWeightD, string mtxtAppearance, string mtxtCharisma, string mtxtWillpower, string mtxtSelfControl,
            string mtxtInbornBuff, string mtxtHanded, string mtxtAdventurePointsA, string mtxtAdventurePointsB, 
            string mtxtAdventurePointsC, string mtxtLifePoints, string txtBodySizeMale, string txtBodySizeFemale,
            string txtBodyWeightMale, string txtBodyWeightFemale)
        {
            if (File.Exists(saveplace) != true)
            {
                string race = "";

                switch (formTitle)
                {
                    case ("Midgard Creator - Mensch"):
                        race = "Mensch";
                        break;
                    case ("Midgard Creator - Human"):
                        race = "Human";
                        break;
                    case ("Midgard Creator - Elf"):
                        race = "Elf";
                        break;
                    case ("Midgard Creator - Halbling"):
                        race = "Halbling";
                        break;
                    case ("Midgard Creator - Halfling"):
                        race = "Halfling";
                        break;
                    case ("Midgard Creator - Zwerg"):
                        race = "Zwerg";
                        break;
                    case ("Midgard Creator - Dwarf"):
                        race = "Dwarf";
                        break;
                    case ("Midgard Creator - Gnom"):
                        race = "Gnom";
                        break;
                    case ("Midgard Creator - Gnome"):
                        race = "Gnome";
                        break;
                }

                using (StreamWriter file =
                new StreamWriter(saveplace))
                {
                    file.WriteLine("Werte für " + characterName + " am " + currentDate);
                    file.WriteLine("Rasse: " + race);
                    file.WriteLine("--------------------------------");

                    //Grundwerte
                    file.WriteLine("Grundwerte");
                    file.WriteLine("Stärke:             " + mtxtStrength);
                    file.WriteLine("Geschicklichkeit:   " + mtxtDexterity);
                    file.WriteLine("Gewandheit:         " + mtxtAgility);
                    file.WriteLine("Konsitution:        " + mtxtConstitution);
                    file.WriteLine("Intelligenz:        " + mtxtIntelligence);
                    file.WriteLine("Zaubertalent:       " + mtxtMagicalTalent);

                    if (race == "Human" || race == "Mensch")
                    {
                        file.WriteLine("Größe (Mann):       " + txtBodySizeMale + " cm");
                        file.WriteLine("Größe (Frau):       " + txtBodySizeFemale + " cm");
                        file.WriteLine("Gewicht (Mann):     " + txtBodyWeightMale + " kg");
                        file.WriteLine("Gewicht (Frau):     " + txtBodyWeightFemale + " kg");
                    }
                    else
                    {
                        file.WriteLine("Größe:              " + txtBodySize + " cm");
                        file.WriteLine("Gewicht:            " + txtBodyWeight + " kg");
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

                    if (File.Exists(saveplace))
                    {
                        MessageBox.Show("Datei wurde erstellt!");
                    }
                    else
                    {
                        MessageBox.Show("Datei konnte nicht erstellt werden!");
                    }
                }
                System.IO.FileAttributes att = System.IO.File.GetAttributes(saveplace);
                System.IO.File.SetAttributes(saveplace, att | System.IO.FileAttributes.ReadOnly);
            }
            else
            {
                MessageBox.Show("Datei schon vorhanden!"); 
            }
            
        }               
    }
}
