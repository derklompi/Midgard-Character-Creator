/*
    Mcreator
    Copyright (C) 2016  Fabian Dörr <faflfama@outlook.com>

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
using System.Windows.Forms;

namespace mcreator.Classes
{
    class Character
    {     
        // Calculate of the bodysize
        private int bodySize;
        public int BodySize(string mtxtBodySizeA, string mtxtBodySizeB, string mtxtStrength, string formTitle)
        {         
            // Convert to int for better usability
            int bodysizeA = Convert.ToInt32(mtxtBodySizeA);
            int bodysizeB = Convert.ToInt32(mtxtBodySizeB);

            int strength = Convert.ToInt32(mtxtStrength);

            //Calculation for dwarfs
            if (formTitle == "MCreator - Zwerg")
            {
                bodySize = bodysizeA + (strength / 10) + 130;
            }

            //Calculation for elfs
            if (formTitle == "MCreator - Elf")
            {
                bodySize = bodysizeA + bodysizeB + (strength / 10) + 160;
            }

            //Calculation for gnomes
            if (formTitle == "MCreator - Gnom")
            {
                bodySize = bodysizeA + (strength / 10) + 90;
            }

            //Calculation for halflings
            if (formTitle == "MCreator - Halbling")
            {
                bodySize = bodysizeA + bodysizeB + (strength / 10) + 100;
            }

            //Calculation for human
            if (formTitle == "MCreator - Mensch")
            {
                bodySize = bodysizeA + bodysizeB + (strength / 10);
            }
            return bodySize;
        }

        // Calculate of the bodyweight
        private int bodyWeight;
        public int BodyWeight(string mtxtBodyWeightA, string mtxtBodyWeightB, string mtxtBodyWeightC,
            string mtxtBodyWeightD, string mtxtStrength, string txtBodySize, string formTitle)
        {
            // Convert to int for better usability
            int bodyweightA = Convert.ToInt32(mtxtBodyWeightA);
            int bodyweightB = Convert.ToInt32(mtxtBodyWeightB);
            int bodyweightC = Convert.ToInt32(mtxtBodyWeightC);
            int bodyweightD = Convert.ToInt32(mtxtBodyWeightD);

            int strength = Convert.ToInt32(mtxtStrength);
            int bodysize = Convert.ToInt32(txtBodySize);

            //Calculation for dwarfs
            if (formTitle == "MCreator - Zwerg")
            {
                bodyWeight = bodyweightA + bodyweightB + bodyweightC + bodyweightD +
                    (strength / 10) + bodysize - 90;
            }

            //Calculation for elfs
            if (formTitle == "MCreator - Elf")
            {
                bodyWeight = bodyweightA + bodyweightB + bodyweightC + bodyweightD +
                    (strength / 10) + bodysize - 128;
            }

            //Calculation for gnomes
            if (formTitle == "MCreator - Gnom")
            {
                bodyWeight = bodyweightA + bodyweightB + bodyweightC +
                    (strength / 10) + bodysize - 90;
            }

            //Calculation for halflings
            if (formTitle == "MCreator - Halbling")
            {
                bodyWeight = bodyweightA + bodyweightB + bodyweightC +
                    (strength / 10) + bodysize - 87;
            }

            //Calculation for human
            if (formTitle == "MCreator - Mensch")
            {
                bodyWeight = bodyweightA + bodyweightB + bodyweightC + bodyweightD +
                    (strength / 10) + bodysize - 120;
            }

            return bodyWeight;
        }

        // Calculation of the attack buff
        private int attackBuffValue;
        public int AttackBuff(int dexterity)
        {

            if (0 <= dexterity && dexterity <= 5)
            {
                attackBuffValue = -2;
            }
            if (6 <= dexterity && dexterity <= 20)
            {
                attackBuffValue = -1;
            }
            if (21 <= dexterity && dexterity <= 80)
            {
                attackBuffValue = 0;
            }
            if (81 <= dexterity && dexterity <= 95)
            {
                attackBuffValue = +1;
            }
            if (96 <= dexterity && dexterity <= 100)
            {
                attackBuffValue = +2;
            }

            return attackBuffValue;
        }

        // Calculation of the defense buff
        private int defenseBufValue;
        public int DefenseBuff(int agility)
        {
            if (0 <= agility && agility <= 5)
            {
                defenseBufValue = -2;
            }
            if (6 <= agility && agility <= 20)
            {
                defenseBufValue = -1;
            }
            if (21 <= agility && agility <= 80)
            {
                defenseBufValue = 0;
            }
            if (81 <= agility && agility <= 95)
            {
                defenseBufValue = +1;
            }
            if (96 <= agility && agility <= 100)
            {
                defenseBufValue = +2;
            }

            return defenseBufValue;
        }

        // Calculation of the magic buff
        private int magicBuffValue;
        public int MagicBuff(int magicTalent)
        {
            if (0 <= magicTalent && magicTalent <= 5)
            {
                magicBuffValue = -3;
            }
            if (6 <= magicTalent && magicTalent <= 20)
            {
                magicBuffValue = -2;
            }
            if (21 <= magicTalent && magicTalent <= 40)
            {
                magicBuffValue = -1;
            }
            if (41 <= magicTalent && magicTalent <= 60)
            {
                magicBuffValue = 0;
            }
            if (61 <= magicTalent && magicTalent <= 80)
            {
                magicBuffValue = +1;
            }
            if (81 <= magicTalent && magicTalent <= 95)
            {
                magicBuffValue = +2;
            }
            if (96 <= magicTalent && magicTalent <= 99)
            {
                magicBuffValue = +3;
            }
            if (magicTalent == 100)
            {
                magicBuffValue = +4;
            }

            return magicBuffValue;
        }

        // Calculation for adventure points of barbarians, warriors. etc.
        public void AdventurePoints()
        {
            if (Application.OpenForms.Count > 1)
            {
                FrmCreateCharacter ce = Application.OpenForms[1] as FrmCreateCharacter;

                if (ce.mtxtAdventurePointsA.Text != "" && ce.mtxtAdventurePointsA.Text !="_" && ce.txtStaminaBuff.Text != "")
                {
                    int tempAdventurePointsAValue = 0;

                    tempAdventurePointsAValue = Convert.ToInt32(ce.mtxtAdventurePointsA.Text) + 4 + Convert.ToInt32(ce.txtStaminaBuff.Text);

                    if (tempAdventurePointsAValue >= 4)
                    {

                        // Calculations for dwarfs
                        /*
                        if (ce.Text == "MCreator - Zwerg")
                        {
                            //
                        }

                        // Calculations for elfs
                        if (ce.Text == "MCreator - Elf")
                        {
                            //
                        }

                        // Calculations for humans
                        if (ce.Text == "MCreator - Mensch")
                        {
                            //
                        }
                        */
                        // Calculations for gnomes
                        if (ce.Text == "MCreator - Gnom")
                        {
                            tempAdventurePointsAValue = tempAdventurePointsAValue - 2;
                        }

                        // Calculations for halflings
                        if (ce.Text == "MCreator - Halbling")
                        {
                            tempAdventurePointsAValue = tempAdventurePointsAValue - 1;
                        }

                        ce.txtAdventurePointsA.Text = Convert.ToString(tempAdventurePointsAValue);
                    }
                    else
                    {
                        ce.txtAdventurePointsA.Text = "4";
                    }

                }

                if (ce.mtxtAdventurePointsB.Text != "" && ce.mtxtAdventurePointsB.Text != "_" && ce.txtStaminaBuff.Text != "")
                {
                    int tempAdventurePointsBValue = 0;

                    tempAdventurePointsBValue = Convert.ToInt32(ce.mtxtAdventurePointsB.Text) + 3 + Convert.ToInt32(ce.txtStaminaBuff.Text);

                    if (tempAdventurePointsBValue >= 4)
                    {
                        // Calculations for dwarfs
                        /*
                        if (ce.Text == "MCreator - Zwerg")
                        {
                            //
                        }

                        // Calculations for elfs
                        if (ce.Text == "MCreator - Elf")
                        {
                            //
                        }

                        // Calculations for humans
                        if (ce.Text == "MCreator - Mensch")
                        {
                            //
                        }
                        */
                        // Calculations for gnomes
                        if (ce.Text == "MCreator - Gnom")
                        {
                            tempAdventurePointsBValue = tempAdventurePointsBValue - 2;
                        }

                        // Calculations for halflings
                        if (ce.Text == "MCreator - Halbling")
                        {
                            tempAdventurePointsBValue = tempAdventurePointsBValue - 1;
                        }

                        ce.txtAdventurePointsB.Text = Convert.ToString(tempAdventurePointsBValue);
                    }
                    else
                    {
                        ce.txtAdventurePointsB.Text = "4";
                    }
                }

                if (ce.mtxtAdventurePointsC.Text != "" && ce.mtxtAdventurePointsC.Text != "_" && ce.txtStaminaBuff.Text != "")
                {
                    int tempAdventurePointsCValue = 0;

                    tempAdventurePointsCValue = Convert.ToInt32(ce.mtxtAdventurePointsC.Text) + 2 + Convert.ToInt32(ce.txtStaminaBuff.Text);

                    if (tempAdventurePointsCValue >= 4)
                    {
                        // Calculations for dwarfs
                        /*
                        if (ce.Text == "MCreator - Zwerg")
                        {
                            //
                        }

                        // Calculations for elfs
                        if (ce.Text == "MCreator - Elf")
                        {
                            //
                        }

                        // Calculations for humans
                        if (ce.Text == "MCreator - Mensch")
                        {
                            //
                        }
                        */
                        // Calculations for gnomes
                        if (ce.Text == "MCreator - Gnom")
                        {
                            tempAdventurePointsCValue = tempAdventurePointsCValue - 2;
                        }

                        // Calculations for halflings
                        if (ce.Text == "MCreator - Halbling")
                        {
                            tempAdventurePointsCValue = tempAdventurePointsCValue - 1;
                        }

                        ce.txtAdventurePointsC.Text = Convert.ToString(tempAdventurePointsCValue);
                    }
                    else
                    {
                        ce.txtAdventurePointsC.Text = "4";
                    }
                }                
            }           
        }

        // Calculations of the lifepoints
        public void LifePoints()
        {
            if (Application.OpenForms.Count > 1)
            {
                FrmCreateCharacter ce = Application.OpenForms[1] as FrmCreateCharacter;
                if (true)
                {
                    if (ce.mtxtConstitution.Text !="" && ce.mtxtConstitution.Text !="___" && ce.mtxtLifePoints.Text !="" && ce.mtxtLifePoints.Text != "_")
                    {
                        // Convert the strings to Int
                        int constitution = Convert.ToInt32(ce.mtxtConstitution.Text);
                        int templifePoints = Convert.ToInt32(ce.mtxtLifePoints.Text);
                        int lifePoints = 0;
                        // Calculations for humans
                        if (ce.Text == "MCreator - Mensch")
                        {
                            lifePoints = (constitution / 10) + templifePoints + 5;
                        }

                        // Calculations for elfs
                        if (ce.Text == "MCreator - Elf")
                        {
                            lifePoints = (constitution / 10) + templifePoints + 4;
                        }

                        // Calculations for gnomes
                        if (ce.Text == "MCreator - Gnom")
                        {
                            lifePoints = (constitution / 10) + templifePoints - 1;
                        }

                        // Calculations for halflings
                        if (ce.Text == "MCreator - Halbling")
                        {
                            lifePoints = (constitution / 10) + templifePoints + 2;
                        }

                        // Calculations for dwarfs
                        if (ce.Text == "MCreator - Zwerg")
                        {
                            lifePoints = (constitution / 10) + templifePoints + 4;
                        }

                        ce.txtLifePoints.Text = Convert.ToString(lifePoints);
                    }
                    
                }
                
            }
            
        }

        public void InbornBuff()
        {
            if (Application.OpenForms.Count > 1)
            {
                FrmCreateCharacter ce = Application.OpenForms[1] as FrmCreateCharacter;

                if (ce.mtxtInbornBuff.Text != "" && ce.mtxtInbornBuff.Text != "___")
                {
                    int inbornBuff;
                    inbornBuff = Convert.ToInt32(ce.mtxtInbornBuff.Text);
                    if (1 <= inbornBuff && inbornBuff <= 2)
                    {
                        ce.txtInbornBuff.Text = "Kurzsichtigkeit (nur Sehen +4)";
                    }
                    if (3 <= inbornBuff && inbornBuff <= 4)
                    {
                        ce.txtInbornBuff.Text = "Schwerhörigkeit (nur Hören +4)";
                    }
                    if (5 <= inbornBuff && inbornBuff <= 6)
                    {
                        ce.txtInbornBuff.Text = "nur Riechen +4";
                    }
                    if (7 <= inbornBuff && inbornBuff <= 8)
                    {
                        ce.txtInbornBuff.Text = "nur Schmecken +4";
                    }
                    if (9 <= inbornBuff && inbornBuff <= 10)
                    {
                        ce.txtInbornBuff.Text = "nur Tasten +4";
                    }
                    if (11 <= inbornBuff && inbornBuff <= 20)
                    {
                        ce.txtInbornBuff.Text = "Sehen +10";
                    }
                    if (21 <= inbornBuff && inbornBuff <= 30)
                    {
                        ce.txtInbornBuff.Text = "Hören +10";
                    }
                    if (31 <= inbornBuff && inbornBuff <= 40)
                    {
                        ce.txtInbornBuff.Text = "Riechen +10";
                    }
                    if (41 <= inbornBuff && inbornBuff <= 50)
                    {
                        ce.txtInbornBuff.Text = "Schmecken +10";
                    }
                    if (51 <= inbornBuff && inbornBuff <= 60)
                    {
                        ce.txtInbornBuff.Text = "Tasten +10";
                    }
                    if (61 <= inbornBuff && inbornBuff <= 65)
                    {
                        ce.txtInbornBuff.Text = "Sechster Sinn +6";
                    }
                    if (66 <= inbornBuff && inbornBuff <= 70)
                    {
                        int berserk = 0;
                        berserk = 18 - (Convert.ToInt32(ce.txtWillpower.Text) / 5);
                        ce.txtInbornBuff.Text = "Berserkergang+ " + berserk;
                    }
                    if (71 <= inbornBuff && inbornBuff <= 75)
                    {
                        ce.txtInbornBuff.Text = "Gute Reflexe +9";
                    }
                    if (76 <= inbornBuff && inbornBuff <= 80)
                    {
                        ce.txtInbornBuff.Text = "Nachtsicht +8";
                    }
                    if (81 <= inbornBuff && inbornBuff <= 85)
                    {
                        ce.txtInbornBuff.Text = "Richtungssinn +12";
                    }
                    if (86 <= inbornBuff && inbornBuff <= 90)
                    {
                        ce.txtInbornBuff.Text = "Robustheit +9";
                    }
                    if (91 <= inbornBuff && inbornBuff <= 95)
                    {
                        ce.txtInbornBuff.Text = "Wachgabe +6";
                    }
                    if (96 <= inbornBuff && inbornBuff <= 99)
                    {
                        ce.txtInbornBuff.Text = "Einprägen +4";
                    }
                    if (inbornBuff == 100)
                    {
                        ce.txtInbornBuff.Text = "Freie Wahl und zweiter Wurf";
                    }
                }

                
            }
            
        }

        private int mtBuffGhost_Body_MagicValue;
        public int MagicTalentGhostBody(int magicTalent)
        {
            
            if (1 <= magicTalent && magicTalent <= 5)
            {
                mtBuffGhost_Body_MagicValue = -2;
            }
            if (6 <= magicTalent && magicTalent <= 20)
            {
                mtBuffGhost_Body_MagicValue = -1;
            }
            if (81 <= magicTalent && magicTalent <= 95)
            {
                mtBuffGhost_Body_MagicValue = 1;
            }
            if (96 <= magicTalent && magicTalent <= 99)
            {
                mtBuffGhost_Body_MagicValue = 2;
            }
            if (magicTalent == 100)
            {
                mtBuffGhost_Body_MagicValue = 3;
            }

            return mtBuffGhost_Body_MagicValue;
        }

        private int intBuffGhostMagicValue;
        public int IntelligenceGhost(int intelligence)
        {
            
            if (1 <= intelligence && intelligence <= 5)
            {
                intBuffGhostMagicValue = -2;
            }
            if (6 <= intelligence && intelligence <= 20)
            {
                intBuffGhostMagicValue = -1;
            }
            if (81 <= intelligence && intelligence <= 95)
            {
                intBuffGhostMagicValue = 1;
            }
            if (96 <= intelligence && intelligence <= 100)
            {
                intBuffGhostMagicValue = 2;
            }

            return intBuffGhostMagicValue;
        }

        private int CoBuffBodyMagicValue;
        public int ConstitutionBody(int constitution)
        {
            
            if (1 <= constitution && constitution <= 5)
            {
                CoBuffBodyMagicValue = -2;
            }
            if (6 <= constitution && constitution <= 20)
            {
                CoBuffBodyMagicValue = -1;
            }
            if (81 <= constitution && constitution <= 95)
            {
                CoBuffBodyMagicValue = 1;
            }
            if (96 <= constitution && constitution <= 100)
            {
                CoBuffBodyMagicValue = 2;
            }

            return CoBuffBodyMagicValue;
        }

        private int areaMagicValue;
        public int AgilityArea(int agility)
        {
            
            if (1 <= agility && agility <= 5)
            {
                areaMagicValue = -2;
            }
            if (6 <= agility && agility <= 20)
            {
                areaMagicValue = -1;
            }
            if (81 <= agility && agility <= 95)
            {
                areaMagicValue = 1;
            }
            if (96 <= agility && agility <= 100)
            {
                areaMagicValue = 2;
            }
            return areaMagicValue;
        }

        private int ghostMagicValue;
        public int GhostMagic(int mtBuffGhost_Body_MagicValue, int intBuffGhostMagicValue)
        {
            
            if (mtBuffGhost_Body_MagicValue > intBuffGhostMagicValue && intBuffGhostMagicValue < 0)
            {
                ghostMagicValue = mtBuffGhost_Body_MagicValue + intBuffGhostMagicValue;
            }
            if (mtBuffGhost_Body_MagicValue > intBuffGhostMagicValue && intBuffGhostMagicValue >= 0)
            {
                ghostMagicValue = mtBuffGhost_Body_MagicValue;
            }
            if (intBuffGhostMagicValue > mtBuffGhost_Body_MagicValue && mtBuffGhost_Body_MagicValue < 0)
            {
                ghostMagicValue = intBuffGhostMagicValue + mtBuffGhost_Body_MagicValue;
            }
            if (intBuffGhostMagicValue > mtBuffGhost_Body_MagicValue && mtBuffGhost_Body_MagicValue >= 0)
            {
                ghostMagicValue = intBuffGhostMagicValue;
            }
            if (intBuffGhostMagicValue == mtBuffGhost_Body_MagicValue)
            {
                ghostMagicValue = intBuffGhostMagicValue;
            }
            return ghostMagicValue;
        }

        private int bodyMagicValue;
        public int BodyMagic(int mtBuffGhost_Body_MagicValue, int CoBuffBodyMagicValue)
        {
            
            if (mtBuffGhost_Body_MagicValue > CoBuffBodyMagicValue && CoBuffBodyMagicValue < 0)
            {
                bodyMagicValue = mtBuffGhost_Body_MagicValue + CoBuffBodyMagicValue;
            }
            if (mtBuffGhost_Body_MagicValue > CoBuffBodyMagicValue && CoBuffBodyMagicValue >= 0)
            {
                bodyMagicValue = mtBuffGhost_Body_MagicValue;
            }
            if (CoBuffBodyMagicValue > mtBuffGhost_Body_MagicValue && mtBuffGhost_Body_MagicValue < 0)
            {
                bodyMagicValue = CoBuffBodyMagicValue + mtBuffGhost_Body_MagicValue;
            }
            if (CoBuffBodyMagicValue > mtBuffGhost_Body_MagicValue && mtBuffGhost_Body_MagicValue >= 0)
            {
                bodyMagicValue = CoBuffBodyMagicValue;
            }
            if (CoBuffBodyMagicValue == mtBuffGhost_Body_MagicValue)
            {
                bodyMagicValue = CoBuffBodyMagicValue;
            }
            return bodyMagicValue;
        }

        // Calculation of the charisma
        public void Charisma()
        {
            if(Application.OpenForms.Count > 1)
            {
                FrmCreateCharacter ce = Application.OpenForms[1] as FrmCreateCharacter;
                if (ce.mtxtCharisma.Text != "___" && ce.mtxtCharisma.Text !="")
                {
                    
                    int tempCharismaValue = 0;
                    tempCharismaValue = Convert.ToInt32(ce.mtxtCharisma.Text) + (3 * ((Convert.ToInt32(ce.mtxtIntelligence.Text) / 10) +
                        (Convert.ToInt32(ce.mtxtAppearance.Text) / 10))) - 30;

                    if (tempCharismaValue >= 0)
                    {
                        ce.txtCharisma.Text = Convert.ToString(tempCharismaValue);
                    }
                    else
                    {
                        ce.txtCharisma.Text = "0";
                    }
                }
                
            }
            
            
        }

        // Calculation of the willpower
        public void Willpower()
        {
            if (Application.OpenForms.Count > 1)
            {
                FrmCreateCharacter ce = Application.OpenForms[1] as FrmCreateCharacter;

                if (ce.mtxtWillpower.Text != "" && ce.mtxtWillpower.Text != "___")
                {
                    int tempWillpowerValue = 0;
                    tempWillpowerValue = Convert.ToInt32(ce.mtxtWillpower.Text) + (3 * ((Convert.ToInt32(ce.mtxtConstitution.Text) / 10) +
                        (Convert.ToInt32(ce.mtxtIntelligence.Text) / 10))) - 40;

                    if (tempWillpowerValue > 0)
                    {
                        ce.txtWillpower.Text = Convert.ToString(tempWillpowerValue);
                    }
                    else
                    {
                        ce.txtWillpower.Text = "0";
                    }
                }
                
            }

        }

        // Calculation of the selfcontrol
        public void SelfControl()
        {
            if (Application.OpenForms.Count > 1)
            {
                FrmCreateCharacter ce = Application.OpenForms[1] as FrmCreateCharacter;

                if (ce.mtxtSelfControl.Text != "" && ce.mtxtSelfControl.Text != "___")
                {
                    int tempSelfControlAValue = 0;

                    tempSelfControlAValue = Convert.ToInt32(ce.mtxtSelfControl.Text) + (3 * ((Convert.ToInt32(ce.mtxtIntelligence.Text) / 10) +
                        (Convert.ToInt32(ce.txtWillpower.Text) / 10)));

                    if (tempSelfControlAValue > 0)
                    {
                        ce.txtSelfControlA.Text = Convert.ToString(tempSelfControlAValue);
                    }
                    else
                    {
                        ce.txtSelfControlA.Text = "0";
                    }

                    int tempSelfControlBValue = 0;

                    tempSelfControlBValue = Convert.ToInt32(ce.mtxtSelfControl.Text) + (3 * ((Convert.ToInt32(ce.mtxtIntelligence.Text) / 10) +
                        (Convert.ToInt32(ce.txtWillpower.Text) / 10))) - 50;

                    if (tempSelfControlBValue > 0)
                    {
                        ce.txtSelfControlB.Text = Convert.ToString(tempSelfControlBValue);
                    }
                    else
                    {
                        ce.txtSelfControlB.Text = "0";
                    }

                    int tempSelfControlCValue = 0;

                    tempSelfControlCValue = Convert.ToInt32(ce.mtxtSelfControl.Text) + (3 * ((Convert.ToInt32(ce.mtxtIntelligence.Text) / 10) +
                        (Convert.ToInt32(ce.txtWillpower.Text) / 10))) - 30;

                    if (tempSelfControlCValue > 0)
                    {
                        ce.txtSelfControlC.Text = Convert.ToString(tempSelfControlCValue);
                    }
                    else
                    {
                        ce.txtSelfControlC.Text = "0";
                    }
                }

                
            }
        }

        // Calculation of the hand specialization
        public void Handed()
        {
            if (Application.OpenForms.Count > 1)
            {

                FrmCreateCharacter ce = Application.OpenForms[1] as FrmCreateCharacter;

                if (ce.mtxtHanded.Text != "" && ce.mtxtHanded.Text != "__")
                {
                    int handed = 0;

                    handed = Convert.ToInt32(ce.mtxtHanded.Text);

                    if (handed <= 15)
                    {
                        ce.txtHanded.Text = "Rechtshänder";
                    }

                    if (handed > 15 && handed < 20)
                    {
                        ce.txtHanded.Text = "Linkshänder";
                    }

                    if (handed == 20)
                    {
                        ce.txtHanded.Text = "Beidhänder";
                    }
                }           
            }
        }
    }
}
