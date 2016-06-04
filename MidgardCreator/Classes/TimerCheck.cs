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

namespace mcreator.Classes
{
    class TimerCheck
    {
        private bool bodySizeCheck;
        public bool BodySizeCheck(string mtxtBodySizeA, string mtxtBodySizeB, bool rbStats, string title)
        {
            if (title == "MCreator - Mensch")
            {
                if (mtxtBodySizeA != "" && mtxtBodySizeB != "" && rbStats &&
                Convert.ToInt32(mtxtBodySizeA) <= 20 && Convert.ToInt32(mtxtBodySizeB) <= 20)
                {
                    bodySizeCheck = true;
                }
                else
                {
                    bodySizeCheck = false;
                }
            }
            else
            {
                if (mtxtBodySizeA != "" && mtxtBodySizeB != "" && rbStats &&
                Convert.ToInt32(mtxtBodySizeA) <= 6 && Convert.ToInt32(mtxtBodySizeB) <= 6)
                {
                    bodySizeCheck = true;
                }
                else
                {
                    bodySizeCheck = false;
                }
            }
            
            return bodySizeCheck;
        }

        private bool bodyWeightCheck;
        public bool BodyWeightCheck(string mtxtBodyWeightA, string mtxtBodyWeightB, 
            string mtxtBodyWeightC, string mtxtBodyWeightD, bool rbStats, string txtBodySize)
        {
            if (mtxtBodyWeightA != "" && mtxtBodyWeightB != "" && mtxtBodyWeightC != "" && mtxtBodyWeightD != "" &&
                rbStats && Convert.ToInt32(mtxtBodyWeightA) <= 6 && Convert.ToInt32(mtxtBodyWeightB) <= 6 && 
                Convert.ToInt32(mtxtBodyWeightC) <= 6 && Convert.ToInt32(mtxtBodyWeightD) <= 6 && txtBodySize != "")
            {
                bodyWeightCheck = true;
            }
            else
            {
                bodyWeightCheck = false;
            }
            return bodyWeightCheck;
        }

        private bool charismaCheck;
        public bool CharismaCheck(string mtxtAppearance, bool rbStats, string mtxtCharisma)
        {
            if (mtxtAppearance != "" && rbStats && mtxtCharisma != "" && 
                Convert.ToInt32(mtxtAppearance) <= 100 && Convert.ToInt32(mtxtCharisma) <= 100)
            {
                charismaCheck = true;
            }
            else
            {
                charismaCheck = false;
            }
            return charismaCheck;
        }

        private bool willpowerCheck;
        public bool WillpowerCheck(string mtxtWillpower, bool rbStats)
        {
            if (mtxtWillpower != "" && rbStats && Convert.ToInt32(mtxtWillpower) <= 100)
            {
                willpowerCheck = true;
            }
            else
            {
                willpowerCheck = false;
            }
            return willpowerCheck;
        }

        private bool selfControlCheck;
        public bool SelfControlCheck(string mtxtSelfControl, bool rbStats, string txtWillpower)
        {
            if (mtxtSelfControl != "" && rbStats && Convert.ToInt32(mtxtSelfControl) <= 100 && txtWillpower != "")
            {
                selfControlCheck = true;
            }
            else
            {
                selfControlCheck = false;
            }

            return selfControlCheck;
        }

        private bool handedCheck;
        public bool HandedCheck(string mtxtHanded, bool rbStats)
        {
            if (mtxtHanded != "" && Convert.ToInt32(mtxtHanded) <= 20 && rbStats)
            {
                handedCheck = true;
            }
            else
            {
                handedCheck = false;
            }

            return handedCheck;
        }

        private bool adventurePointsACheck;
        public bool AdventurePointsACheck(string mtxtAdventurePointsA, string txtStaminaBuff)
        {
            if (mtxtAdventurePointsA != "" && txtStaminaBuff != "" && Convert.ToInt32(mtxtAdventurePointsA) <= 6)
            {
                adventurePointsACheck = true;
            }
            else
            {
                adventurePointsACheck = false;
            }
            return adventurePointsACheck;
        }

        private bool adventurePointsBCheck;
        public bool AdventurePointsBCheck(string mtxtAdventurePointsB, string txtStaminaBuff)
        {
            if (mtxtAdventurePointsB != "" && txtStaminaBuff != "" && Convert.ToInt32(mtxtAdventurePointsB) <= 6)
            {
                adventurePointsBCheck = true;
            }
            else
            {
                adventurePointsBCheck = false;
            }
            return adventurePointsBCheck;
        }

        private bool adventurePointsCCheck;
        public bool AdventurePointsCCheck(string mtxtAdventurePointsC, string txtStaminaBuff)
        {
            if (mtxtAdventurePointsC != "" && txtStaminaBuff != "" && Convert.ToInt32(mtxtAdventurePointsC) <= 6)
            {
                adventurePointsCCheck = true;
            }
            else
            {
                adventurePointsCCheck = false;
            }
            return adventurePointsCCheck;
        }

        private bool lifePointsCheck;
        public bool LifePointsCheck(string mtxtLifePoints, bool rbStats)
        {
            if (mtxtLifePoints != "" && rbStats && Convert.ToInt32(mtxtLifePoints) <= 6)
            {
                lifePointsCheck = true;
            }
            else
            {
                lifePointsCheck = false;
            }
            return lifePointsCheck;
        }

        private bool inbornBuffCheck;
        public bool InbornBuffCheck(string mtxtInbornBuff)
        {
            if (mtxtInbornBuff != "" && Convert.ToInt32(mtxtInbornBuff) <= 100)
            {
                inbornBuffCheck = true;
            }

            else
            {
                inbornBuffCheck = false;
            }
            return inbornBuffCheck;
        }        
    }
}
