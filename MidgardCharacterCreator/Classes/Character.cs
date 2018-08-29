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

namespace mcc.Classes
{   
    class Character
    {
        CharacterArrayStore characterArray = new CharacterArrayStore();
      

        // Calculate of the bodysize
        public double BodySize(string cbBodySizeA, string cbBodySizeB, string cbStrength, string formTitle)
        {
            double bodySize = 0;
            // Convert to int for better usability
            double bodysizeA = Convert.ToInt32(cbBodySizeA);
            double bodysizeB = Convert.ToInt32(cbBodySizeB);

            double strength = Convert.ToInt32(cbStrength);
           
            switch (formTitle)
            {
                case "MCreator - Zwerg":
                    bodySize = bodysizeA + (strength / 10.0) + 130;
                    break;
                case "MCreator - Elf":
                    bodySize = bodysizeA + bodysizeB + (strength / 10.0) + 160;
                    break;
                case "MCreator - Gnom":
                    bodySize = bodysizeA + (strength / 10.0) + 90;
                    break;
                case "MCreator - Halbling":
                    bodySize = bodysizeA + bodysizeB + (strength / 10.0) + 100;
                    break;
                case "MCreator - Mensch":
                    bodySize = bodysizeA + bodysizeB + (strength / 10.0);
                    break;
                default:
                    MessageBox.Show("fail");
                    break;
            }

            return bodySize;
        }

        // Calculate of the bodyweight
        public double BodyWeight(string cbBodyWeightA, string cbBodyWeightB, string cbBodyWeightC,
            string cbBodyWeightD, string cbStrength, string txtBodySize, string formTitle)
        {
            double BodyWeightValue = 0;

            // Convert to int for better usability
            double bodyweightA = Convert.ToDouble(cbBodyWeightA);
            double bodyweightB = Convert.ToDouble(cbBodyWeightB);
            double bodyweightC = Convert.ToDouble(cbBodyWeightC);
            double bodyweightD = Convert.ToDouble(cbBodyWeightD);

            double strength = Convert.ToDouble(cbStrength);
            double bodysize = Convert.ToDouble(txtBodySize);

            switch (formTitle)
            {
                case "MCreator - Zwerg":
                    BodyWeightValue = bodyweightA + bodyweightB + bodyweightC + bodyweightD + (strength / 10.0) + bodysize - 90.0;
                    break;
                case "MCreator - Elf":
                    BodyWeightValue = bodyweightA + bodyweightB + bodyweightC + bodyweightD + (strength / 10.0) + bodysize - 128.0;
                    break;
                case "MCreator - Gnom":
                    BodyWeightValue = bodyweightA + bodyweightB + bodyweightC + (strength / 10.0) + bodysize - 90.0;
                    break;
                case "MCreator - Halbling":
                    BodyWeightValue = bodyweightA + bodyweightB + bodyweightC + (strength / 10.0) + bodysize - 87.0;
                    break;
                case "MCreator - Mensch":
                    BodyWeightValue = bodyweightA + bodyweightB + bodyweightC + bodyweightD + (strength / 10.0) + bodysize - 120.0;
                    break;
                default:
                    MessageBox.Show("fail");
                    break;
            }
            return BodyWeightValue; 
        }

        // Calculation of the attack buff
        public double AttackBuff(double dexterity)
        {
            double AttackBuffValue;

            AttackBuffValue = inrange_single(Convert.ToInt32(dexterity), characterArray.AttackBuffArray, 0);

            return AttackBuffValue;
        }

        // Calculation of the defense buff
        public double DefenseBuff(double agility)
        {
            double DefenceBuffValue;

            DefenceBuffValue = inrange_single(Convert.ToInt32(agility), characterArray.DefenseBuffArray, 0);

            return DefenceBuffValue;
        }

        // Calculation of the magic buff
        public double MagicBuff(double magicTalent)
        {
            double MagicBuffValue;

            MagicBuffValue = inrange_single(Convert.ToInt32(magicTalent),characterArray.MagicBuffArray, 0);

            return MagicBuffValue;                   
        }

        // Calculation for adventure points of barbarians, warriors. etc.
        public int AdventurePointsA(string cbAdventurePointsA, string txtStaminaBuff, string formTitle)
        {
            int adventurePointsValueA = 0;

            if (cbAdventurePointsA != "" && txtStaminaBuff != "")
            {
                int tempAdventurePointsAValue = 0;

                tempAdventurePointsAValue = Convert.ToInt32(cbAdventurePointsA) + 4 + Convert.ToInt32(txtStaminaBuff);

                if (tempAdventurePointsAValue >= 4)
                {
                    switch (formTitle)
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

        public int AdventurePointsB(string cbAdventurePointsB, string txtStaminaBuff, string formTitle)
        {
            int adventurePointsValueB = 0;

            if (cbAdventurePointsB != "" && txtStaminaBuff != "")
            {
                int tempAdventurePointsBValue = 0;

                tempAdventurePointsBValue = Convert.ToInt32(cbAdventurePointsB) + 3 + Convert.ToInt32(txtStaminaBuff);

                if (tempAdventurePointsBValue >= 4)
                {
                    switch (formTitle)
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

        public int AdventurePointsC(string cbAdventurePointsC, string txtStaminaBuff, string formTitle)
        {
            int adventurePointsValueC = 0;

            if (cbAdventurePointsC != "" && txtStaminaBuff != "")
            {
                int tempAdventurePointsCValue = 0;

                tempAdventurePointsCValue = Convert.ToInt32(cbAdventurePointsC) + 2 + Convert.ToInt32(txtStaminaBuff);

                if (tempAdventurePointsCValue >= 4)
                {
                    switch (formTitle)
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
        public double LifePoints(string cbConstitution, string cbLifePoints, string formTitle)
        {
            double lifePointsValue = 0;

            if (cbConstitution != "" && cbLifePoints != "" && formTitle != "")
            {
                // Convert the strings to Int
                double constitution = Convert.ToDouble(cbConstitution);
                double templifePoints = Convert.ToDouble(cbLifePoints);
                lifePointsValue = 0;

                switch (formTitle)
                {
                    case "MCreator - Zwerg":
                        lifePointsValue = (constitution / 10.0) + templifePoints + 4.0;
                        break;
                    case "MCreator - Elf":
                        lifePointsValue = (constitution / 10.0) + templifePoints + 4.0;
                        break;
                    case "MCreator - Gnom":
                        lifePointsValue = (constitution / 10.0) + templifePoints - 1.0;
                        break;
                    case "MCreator - Halbling":
                        lifePointsValue = (constitution / 10.0) + templifePoints + 2.0;
                        break;
                    case "MCreator - Mensch":
                        lifePointsValue = (constitution / 10.0) + templifePoints + 5.0;
                        break;
                    default:
                        MessageBox.Show("fail");
                        break;
                }                              
            }
            return lifePointsValue;
        }

        public string InbornBuff(string cbInbornBuff, string txtWillpower)
        {
            if (cbInbornBuff != "" && txtWillpower != "")
            {   
                int inbornBuff;
                inbornBuff = Convert.ToInt32(cbInbornBuff);

                if (1 <= inbornBuff && inbornBuff < 3)
                {
                    return "Kurzsichtigkeit (nur Sehen +4)";
                }
                else if (inbornBuff == 0)
                {
                    return "";
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
                    double berserk = 0;
                    berserk = 18 - (Convert.ToDouble(txtWillpower) / 5.0);
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

        public int inrange_single(int value, int[,] range, int defval)
        {
            int rc;
            // range.Length < values.Length ? range.Length-1 : values.Length-1
            // 		get the lovest of the two arrays lengths , subtract 1 since the index is 0 based
            //		search backwards to find the value in range that is lower than the value we are searching for
            //		we do not need to compare with the upper bound since it is implicit ie the upper bound +1
            //		is equal to previous lower bound

            for (rc = range.GetLength(0) - 1; rc >= 0; rc--)
            {
                if (value > range[rc, 0]) return range[rc, 1]; ;
            }
            // not found ? return defval
            return defval;
        }

        public int MagicTalentGhostBody(int magicTalent)
        {
            int MagicTalentGhostBodyValue;

            MagicTalentGhostBodyValue = inrange_single(magicTalent, characterArray.MagicTalentGhostBodyArray, 7);

            return MagicTalentGhostBodyValue;
        }

        public int IntelligenceGhost(int intelligence)
        {
            int IntelligenceGhostValue;

            IntelligenceGhostValue = inrange_single(intelligence,characterArray.IntelligenceGhostArray, 0);

            return IntelligenceGhostValue;
        }

        public int ConstitutionBody(int constitution)
        {
            int ConstitutionBodyValue;

            ConstitutionBodyValue = inrange_single(constitution,characterArray.ConstitutionBodyArray, 0);

            return ConstitutionBodyValue;
        }

        public int AgilityArea(int agility)
        {
            int AgilityAreaValue;

            AgilityAreaValue = inrange_single(agility, characterArray.AgilityAreaArray, 0);
            return AgilityAreaValue;           
        }

        public int GhostMagic(int mtBuffGhost_Body_MagicValue, int intBuffGhostMagicValue)
        {
            
            if (mtBuffGhost_Body_MagicValue > intBuffGhostMagicValue && intBuffGhostMagicValue < 0)
            {
                return mtBuffGhost_Body_MagicValue + intBuffGhostMagicValue;
            }
            else if (mtBuffGhost_Body_MagicValue > intBuffGhostMagicValue && intBuffGhostMagicValue >= 0)
            {
                return mtBuffGhost_Body_MagicValue;
            }
            else if (intBuffGhostMagicValue > mtBuffGhost_Body_MagicValue && mtBuffGhost_Body_MagicValue < 0)
            {
                return intBuffGhostMagicValue + mtBuffGhost_Body_MagicValue;
            }
            else if (intBuffGhostMagicValue > mtBuffGhost_Body_MagicValue && mtBuffGhost_Body_MagicValue >= 0)
            {
                return intBuffGhostMagicValue;
            }
            else if (intBuffGhostMagicValue == mtBuffGhost_Body_MagicValue)
            {
                return intBuffGhostMagicValue;
            }
            else
            {
                return 0;
            }
        }

        public int BodyMagic(int mtBuffGhost_Body_MagicValue, int CoBuffBodyMagicValue)
        {
            
            if (mtBuffGhost_Body_MagicValue > CoBuffBodyMagicValue && CoBuffBodyMagicValue < 0)
            {
                return mtBuffGhost_Body_MagicValue + CoBuffBodyMagicValue;
            }
            else if (mtBuffGhost_Body_MagicValue > CoBuffBodyMagicValue && CoBuffBodyMagicValue >= 0)
            {
                return mtBuffGhost_Body_MagicValue;
            }
            else if (CoBuffBodyMagicValue > mtBuffGhost_Body_MagicValue && mtBuffGhost_Body_MagicValue < 0)
            {
                return CoBuffBodyMagicValue + mtBuffGhost_Body_MagicValue;
            }
            else if (CoBuffBodyMagicValue > mtBuffGhost_Body_MagicValue && mtBuffGhost_Body_MagicValue >= 0)
            {
                return CoBuffBodyMagicValue;
            }
            else if (CoBuffBodyMagicValue == mtBuffGhost_Body_MagicValue)
            {
                return CoBuffBodyMagicValue;
            }
            else
            {
                return 0;
            }
        }

        // Calculation of the charisma

        public double Charisma(string cbCharisma, string cbIntelligence, string cbAppearance)
        {
            if(cbCharisma != "" && cbIntelligence != "" && cbAppearance != "")
            {
                double tempCharismaValue = 0;
                tempCharismaValue = Convert.ToDouble(cbCharisma) + (3.0 * ((Convert.ToDouble(cbIntelligence) / 10.0) +
                    (Convert.ToDouble(cbAppearance) / 10.0))) - 30.0;

                if (tempCharismaValue >= 0)
                {
                    return tempCharismaValue;
                }
                else
                {
                    return 0;
                }                
            }
            else
            {
                return 0;
            }
        }

        // Calculation of the willpower
        public double Willpower(string cbWillpower, string cbIntelligence, string cbConstitution)
        {
            if (cbWillpower != "" && cbIntelligence != "" && cbConstitution != "")
            {
                double tempWillpowerValue = 0;
                tempWillpowerValue = Convert.ToDouble(cbWillpower) + (3 * ((Convert.ToDouble(cbConstitution) / 10) +
                    (Convert.ToDouble(cbIntelligence) / 10))) - 40;

                if (tempWillpowerValue > 0)
                {
                    return tempWillpowerValue;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }

        // Calculation of the selfcontrol
        public double SelfControlA(string cbSelfControl, string txtWillpower, string cbIntelligence)
        {
            if (cbSelfControl != "" && txtWillpower != "" && cbIntelligence !="")
            {
                double tempSelfControlAValue = 0;

                tempSelfControlAValue = Convert.ToDouble(cbSelfControl) + (3 * ((Convert.ToDouble(cbIntelligence) / 10) +
                    (Convert.ToDouble(txtWillpower) / 10)));

                if (tempSelfControlAValue > 0)
                {
                    return tempSelfControlAValue;
                }
                else
                {
                    return 0;
                }               
            }
            else
            {
                return 0;
            }
        }

        public double SelfControlB(string cbSelfControl, string txtWillpower, string cbIntelligence)
        {
            if (cbSelfControl != "" && txtWillpower != "" && cbIntelligence != "")
            {
                double tempSelfControlBValue = 0;

                tempSelfControlBValue = Convert.ToDouble(cbSelfControl) + (3 * ((Convert.ToDouble(cbIntelligence) / 10) +
                    (Convert.ToDouble(txtWillpower) / 10))) - 50;

                if (tempSelfControlBValue > 0)
                {
                    return tempSelfControlBValue;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }               
        }

        public double SelfControlC(string cbSelfControl, string txtWillpower, string cbIntelligence)
        {
            if (cbSelfControl != "" && txtWillpower != "" && cbIntelligence != "")
            {
                double tempSelfControlCValue = 0;

                tempSelfControlCValue = Convert.ToDouble(cbSelfControl) + (3 * ((Convert.ToDouble(cbIntelligence) / 10) +
                    (Convert.ToDouble(txtWillpower) / 10))) - 30;

                if (tempSelfControlCValue > 0)
                {
                    return tempSelfControlCValue;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }
        
        // Calculation of the hand specialization
        public string Handed(string cbHanded)
        {
            if (cbHanded != "")
            {
                int handed = 0;

                handed = Convert.ToInt32(cbHanded);

                if (handed == 0)
                {
                    return "";
                }
                else if (handed < 16)
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
