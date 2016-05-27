using System;

namespace mcreator.Classes
{
    class TimerCheck
    {
        private bool bodySizeCheck;
        public bool BodySizeCheck(string mtxtBodySizeA, string mtxtBodySizeB, string txtStats, string title)
        {
            if(title == "Midgard Creator - Mensch")
            {
                if (mtxtBodySizeA != "" && mtxtBodySizeB != "" && txtStats == "true" &&
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
                if (mtxtBodySizeA != "" && mtxtBodySizeB != "" && txtStats == "true" &&
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
            string mtxtBodyWeightC, string mtxtBodyWeightD, string txtStats, string txtBodySize)
        {
            if (mtxtBodyWeightA != "" && mtxtBodyWeightB != "" && mtxtBodyWeightC != "" && mtxtBodyWeightD != "" && 
                txtStats == "true" && Convert.ToInt32(mtxtBodyWeightA) <= 6 && Convert.ToInt32(mtxtBodyWeightB) <= 6 && 
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
        public bool CharismaCheck(string mtxtAppearance, string txtStats, string mtxtCharisma)
        {
            if (mtxtAppearance != "" && txtStats == "true" && mtxtCharisma != "" && 
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
        public bool WillpowerCheck(string mtxtWillpower, string txtStats)
        {
            if (mtxtWillpower != "" && txtStats == "true" && Convert.ToInt32(mtxtWillpower) <= 100)
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
        public bool SelfControlCheck(string mtxtSelfControl, string txtStats, string txtWillpower)
        {
            if (mtxtSelfControl != "" && txtStats == "true" && Convert.ToInt32(mtxtSelfControl) <= 100 && txtWillpower != "")
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
        public bool HandedCheck(string mtxtHanded, string txtStats)
        {
            if (mtxtHanded != "" && Convert.ToInt32(mtxtHanded) <= 20 && txtStats == "true")
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
        public bool LifePointsCheck(string mtxtLifePoints, string txtStats)
        {
            if (mtxtLifePoints != "" && txtStats != "" && Convert.ToInt32(mtxtLifePoints) <= 6)
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
