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
           
            switch (formTitle)
            {
                case "MCreator - Zwerg":
                    bodySize = bodysizeA + (strength / 10) + 130;
                    break;
                case "MCreator - Elf":
                    bodySize = bodysizeA + bodysizeB + (strength / 10) + 160;
                    break;
                case "MCreator - Gnom":
                    bodySize = bodysizeA + (strength / 10) + 90;
                    break;
                case "MCreator - Halbling":
                    bodySize = bodysizeA + bodysizeB + (strength / 10) + 100;
                    break;
                case "MCreator - Mensch":
                    bodySize = bodysizeA + bodysizeB + (strength / 10);
                    break;
                default:
                    MessageBox.Show("fail");
                    break;
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

            switch (formTitle)
            {
                case "MCreator - Zwerg":
                    bodyWeight = bodyweightA + bodyweightB + bodyweightC + bodyweightD +
                    (strength / 10) + bodysize - 90;
                    break;
                case "MCreator - Elf":
                    bodyWeight = bodyweightA + bodyweightB + bodyweightC + bodyweightD +
                    (strength / 10) + bodysize - 128;
                    break;
                case "MCreator - Gnom":
                    bodyWeight = bodyweightA + bodyweightB + bodyweightC +
                    (strength / 10) + bodysize - 90;
                    break;
                case "MCreator - Halbling":
                    bodyWeight = bodyweightA + bodyweightB + bodyweightC +
                    (strength / 10) + bodysize - 87;
                    break;
                case "MCreator - Mensch":
                    bodyWeight = bodyweightA + bodyweightB + bodyweightC + bodyweightD +
                    (strength / 10) + bodysize - 120;
                    break;
                default:
                    MessageBox.Show("fail");
                    break;
            }           
            return bodyWeight;
        }

        // Calculation of the attack buff
        public int AttackBuff(int dexterity)
        {

            if (0 <= dexterity && dexterity < 6)
            {
                return -2;
            }
            else if (dexterity < 21)
            {
                return -1;
            }
            else if (dexterity < 81)
            {
                return 0;
            }
            else if (dexterity < 96)
            {
                return +1;
            }
            else if (dexterity < 101)
            {
                return +2;
            }
            else
            {
                return 0;
            }
        }

        // Calculation of the defense buff
        public int DefenseBuff(int agility)
        {
            if (0 <= agility && agility < 6)
            {
                return -2;
            }
            else if (agility < 21)
            {
                return -1;
            }
            else if (agility < 81)
            {
                return 0;
            }
            else if (agility < 96)
            {
                return +1;
            }
            else if (agility < 101)
            {
                return +2;
            }
            else
            {
                return 0;
            }
        }

        // Calculation of the magic buff
        public int MagicBuff(int magicTalent)
        {
            if (0 <= magicTalent && magicTalent < 6)
            {
                return -3;
            }
            else if (magicTalent < 21)
            {
                return -2;
            }
            else if (magicTalent < 41)
            {
                return -1;
            }
            else if (magicTalent < 61)
            {
                return 0;
            }
            else if (magicTalent < 81)
            {
                return +1;
            }
            else if (magicTalent < 96)
            {
                return +2;
            }
            else if (magicTalent < 100)
            {
                return +3;
            }
            else if (magicTalent == 100)
            {
                return +4;
            }
            else
            {
                return 0;
            }
        }

        // Calculation for adventure points of barbarians, warriors. etc.

        private int adventurePointsValueA;
        public int AdventurePointsA(string mtxtAdventurePointsA, string txtStaminaBuff, string Text)
        {
            if (mtxtAdventurePointsA != "" && txtStaminaBuff != "")
            {
                int tempAdventurePointsAValue = 0;

                tempAdventurePointsAValue = Convert.ToInt32(mtxtAdventurePointsA) + 4 + Convert.ToInt32(txtStaminaBuff);

                if (tempAdventurePointsAValue >= 4)
                {
                    switch (Text)
                    {
                        case "MCreator - Zwerg":
                            adventurePointsValueA = tempAdventurePointsAValue;
                            break;
                        case "MCreator - Elf":
                            adventurePointsValueA = tempAdventurePointsAValue;  
                            break;
                        case "MCreator - Gnom":
                            tempAdventurePointsAValue = tempAdventurePointsAValue - 2;
                            break;
                        case "MCreator - Halbling":
                            tempAdventurePointsAValue = tempAdventurePointsAValue - 1;
                            break;
                        case "MCreator - Mensch":   
                            adventurePointsValueA = tempAdventurePointsAValue;
                            break;
                        default:
                            MessageBox.Show("fail");
                            break;
                    }                                  
                }
                else
                {
                    adventurePointsValueA = 4;
                }

            }            
            return adventurePointsValueA;
        }

        private int adventurePointsValueB;
        public int AdventurePointsB(string mtxtAdventurePointsB, string txtStaminaBuff, string Text)
        {
            if (mtxtAdventurePointsB != "" && txtStaminaBuff != "")
            {
                int tempAdventurePointsBValue = 0;

                tempAdventurePointsBValue = Convert.ToInt32(mtxtAdventurePointsB) + 3 + Convert.ToInt32(txtStaminaBuff);

                if (tempAdventurePointsBValue >= 4)
                {
                    switch (Text)
                    {
                        case "MCreator - Zwerg":
                            adventurePointsValueB = tempAdventurePointsBValue;
                            break;
                        case "MCreator - Elf":
                            adventurePointsValueB = tempAdventurePointsBValue;
                            break;
                        case "MCreator - Gnom":
                            tempAdventurePointsBValue = tempAdventurePointsBValue - 2;
                            break;
                        case "MCreator - Halbling":
                            tempAdventurePointsBValue = tempAdventurePointsBValue - 1;
                            break;
                        case "MCreator - Mensch":
                            adventurePointsValueB = tempAdventurePointsBValue;
                            break;
                        default:
                            MessageBox.Show("fail");
                            break;
                    }
                }
                else
                {
                    adventurePointsValueB = 4;
                }
            }
           
            return adventurePointsValueB;
        }

        private int adventurePointsValueC;
        public int AdventurePointsC(string mtxtAdventurePointsC, string txtStaminaBuff, string Text)
        {            
            if (mtxtAdventurePointsC != "" && txtStaminaBuff != "")
            {
                int tempAdventurePointsCValue = 0;

                tempAdventurePointsCValue = Convert.ToInt32(mtxtAdventurePointsC) + 2 + Convert.ToInt32(txtStaminaBuff);

                if (tempAdventurePointsCValue >= 4)
                {
                    switch (Text)
                    {
                        case "MCreator - Zwerg":
                            adventurePointsValueC = tempAdventurePointsCValue;
                            break;
                        case "MCreator - Elf":
                            adventurePointsValueC = tempAdventurePointsCValue;
                            break;
                        case "MCreator - Gnom":
                            tempAdventurePointsCValue = tempAdventurePointsCValue - 2;
                            break;
                        case "MCreator - Halbling":
                            tempAdventurePointsCValue = tempAdventurePointsCValue - 1;
                            break;
                        case "MCreator - Mensch":
                            adventurePointsValueC = tempAdventurePointsCValue;
                            break;
                        default:
                            MessageBox.Show("fail");
                            break;
                    }
                }
                else
                {
                    adventurePointsValueC = 4;
                }
            }

            return adventurePointsValueC;
        }

        // Calculations of the lifepoints
        private int lifePointsValue;
        public int LifePoints(string mtxtConstitution, string mtxtLifePoints, string text)
        {
            if (mtxtConstitution != "" && mtxtLifePoints != "" && text != "")
            {
                // Convert the strings to Int
                int constitution = Convert.ToInt32(mtxtConstitution);
                int templifePoints = Convert.ToInt32(mtxtLifePoints);
                lifePointsValue = 0;

                switch (text)
                {
                    case "MCreator - Zwerg":
                        lifePointsValue = (constitution / 10) + templifePoints + 4;
                        break;
                    case "MCreator - Elf":
                        lifePointsValue = (constitution / 10) + templifePoints + 4;
                        break;
                    case "MCreator - Gnom":
                        lifePointsValue = (constitution / 10) + templifePoints - 1;
                        break;
                    case "MCreator - Halbling":
                        lifePointsValue = (constitution / 10) + templifePoints + 2;
                        break;
                    case "MCreator - Mensch":
                        lifePointsValue = (constitution / 10) + templifePoints + 5;
                        break;
                    default:
                        MessageBox.Show("fail");
                        break;
                }                              
            }
            return lifePointsValue;
        }

        public string InbornBuff(string mtxtInbornBuff, string txtWillpower)
        {
            if (mtxtInbornBuff != "" && txtWillpower != "")
            {   
                int inbornBuff;
                inbornBuff = Convert.ToInt32(mtxtInbornBuff);

                if (1 <= inbornBuff && inbornBuff < 3)
                {
                    return "Kurzsichtigkeit (nur Sehen +4)";
                }
                else if (inbornBuff < 5)
                {
                    return "Schwerhörigkeit (nur Hören +4)";
                }
                else if (inbornBuff < 7)
                {
                    return "nur Riechen +4";
                }
                else if (inbornBuff < 9)
                {
                    return "nur Schmecken +4";
                }
                else if (inbornBuff < 11)
                {
                    return "nur Tasten +4";
                }
                else if (inbornBuff < 21)
                {
                    return "Sehen +10";
                }
                else if (inbornBuff < 31)
                {
                    return "Hören +10";
                }
                else if (inbornBuff < 41)
                {
                    return "Riechen +10";
                }
                else if (inbornBuff < 51)
                {
                    return "Schmecken +10";
                }
                else if (inbornBuff < 61)
                {
                    return "Tasten +10";
                }
                else if (inbornBuff < 66)
                {
                    return "Sechster Sinn +6";
                }
                else if (inbornBuff < 71)
                {
                    int berserk = 0;
                    berserk = 18 - (Convert.ToInt32(txtWillpower) / 5);
                    return "Berserkergang+ " + berserk;
                }
                else if (inbornBuff < 76)
                {
                    return "Gute Reflexe +9";
                }
                else if (inbornBuff < 81)
                {
                    return "Nachtsicht +8";
                }
                else if (inbornBuff < 86)
                {
                    return "Richtungssinn +12";
                }
                else if (inbornBuff < 91)
                {
                    return "Robustheit +9";
                }
                else if (inbornBuff < 96)
                {
                    return "Wachgabe +6";
                }
                else if (inbornBuff < 100)
                {
                    return "Einprägen +4";
                }
                else if (inbornBuff == 100)
                {
                    return "Freie Wahl und zweiter Wurf";
                }
                else
                {
                    return "";
                }
            }
            else
            {
                return "";
            }
            
        }
   
        public int MagicTalentGhostBody(int magicTalent)
        {
            
            if (1 <= magicTalent && magicTalent < 6)
            {
                return -2;
            }
            else if (magicTalent < 21)
            {
                return -1;
            }
            else if (magicTalent < 96)
            {
                return 1;
            }
            else if (magicTalent < 100)
            {
                return 2;
            }
            else if (magicTalent == 100)
            {
                return 3;
            }
            else
            {
                return 0;
            }
        }

        public int IntelligenceGhost(int intelligence)
        {
            
            if (1 <= intelligence && intelligence < 6)
            {
                return -2;
            }
            else if (intelligence < 21)
            {
                return -1;
            }
            else if (intelligence < 96)
            {
                return 1;
            }
            else if (intelligence < 101)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }

        public int ConstitutionBody(int constitution)
        {
            
            if (1 <= constitution && constitution < 6)
            {
                return -2;
            }
            else if (constitution < 21)
            {
                return -1;
            }
            else if (constitution < 96)
            {
                return 1;
            }
            else if (constitution < 101)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }

        public int AgilityArea(int agility)
        {
            
            if (1 <= agility && agility < 6)
            {
                return -2;
            }
            else if (agility < 21)
            {
                return -1;
            }
            else if (agility < 96)
            {
                return 1;
            }
            else if (agility < 101)
            {
                return 2;
            }
            else
            {
                return 0;
            }
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

        private int charismavalue;
        public int Charisma(string mtxtCharisma, string mtxtIntelligence, string mtxtAppearance)
        {
            if(mtxtCharisma !="" && mtxtIntelligence !="" && mtxtAppearance !="")
            {
                int tempCharismaValue = 0;
                tempCharismaValue = Convert.ToInt32(mtxtCharisma) + (3 * ((Convert.ToInt32(mtxtIntelligence) / 10) +
                    (Convert.ToInt32(mtxtAppearance) / 10))) - 30;

                if (tempCharismaValue >= 0)
                {
                    charismavalue = tempCharismaValue;
                }
                else
                {
                    charismavalue = 0;
                }                
            }
            return charismavalue;
        }

        // Calculation of the willpower
        private int willpowervalue;
        public int Willpower(string mtxtWillpower, string mtxtIntelligence, string mtxtConstitution)
        {
            if (mtxtWillpower != "" && mtxtIntelligence != "" && mtxtConstitution != "")
            {
                int tempWillpowerValue = 0;
                tempWillpowerValue = Convert.ToInt32(mtxtWillpower) + (3 * ((Convert.ToInt32(mtxtConstitution) / 10) +
                    (Convert.ToInt32(mtxtIntelligence) / 10))) - 40;

                if (tempWillpowerValue > 0)
                {
                    willpowervalue = tempWillpowerValue;
                }
                else
                {
                    willpowervalue = 0;
                }
            }
            return willpowervalue;
        }

        // Calculation of the selfcontrol
        private int selfControlValueA;
        public int SelfControlA(string mtxtSelfControl, string txtWillpower, string mtxtIntelligence)
        {
            if (mtxtSelfControl != "" && txtWillpower != "" && mtxtIntelligence !="")
            {
                int tempSelfControlAValue = 0;

                tempSelfControlAValue = Convert.ToInt32(mtxtSelfControl) + (3 * ((Convert.ToInt32(mtxtIntelligence) / 10) +
                    (Convert.ToInt32(txtWillpower) / 10)));

                if (tempSelfControlAValue > 0)
                {
                    selfControlValueA = tempSelfControlAValue;
                }
                else
                {
                    selfControlValueA = 0;
                }               
            }
            return selfControlValueA;
        }

        private int selfControlValueB;
        public int SelfControlB(string mtxtSelfControl, string txtWillpower, string mtxtIntelligence)
        {
            if (mtxtSelfControl != "" && txtWillpower != "" && mtxtIntelligence != "")
            {
                int tempSelfControlBValue = 0;

                tempSelfControlBValue = Convert.ToInt32(mtxtSelfControl) + (3 * ((Convert.ToInt32(mtxtIntelligence) / 10) +
                    (Convert.ToInt32(txtWillpower) / 10))) - 50;

                if (tempSelfControlBValue > 0)
                {
                    selfControlValueB = tempSelfControlBValue;
                }
                else
                {
                    selfControlValueB = 0;
                }              
            }
            return selfControlValueB;
        }

        private int selfControlValueC;
        public int SelfControlC(string mtxtSelfControl, string txtWillpower, string mtxtIntelligence)
        {
            if (mtxtSelfControl != "" && txtWillpower != "" && mtxtIntelligence != "")
            {
               int tempSelfControlCValue = 0;

                tempSelfControlCValue = Convert.ToInt32(mtxtSelfControl) + (3 * ((Convert.ToInt32(mtxtIntelligence) / 10) +
                    (Convert.ToInt32(txtWillpower) / 10))) - 30;

                if (tempSelfControlCValue > 0)
                {
                    selfControlValueC = tempSelfControlCValue;
                }
                else
                {
                    selfControlValueC = 0;
                }
            }
            return selfControlValueC;
        }
        
        // Calculation of the hand specialization
        public string Handed(string mtxtHanded)
        {
            if (mtxtHanded != "")
            {
                int handed = 0;

                handed = Convert.ToInt32(mtxtHanded);

                if (handed < 16)
                {
                    return "Rechtshänder";
                }
                else if (handed < 20)
                {
                    return "Linkshänder";
                }
                else if (handed == 20)
                {
                    return "Beidhänder";
                }
                else
                {
                    return "";
                }
            }
            else
            {
                return "";
            }
        }        
    }
}
