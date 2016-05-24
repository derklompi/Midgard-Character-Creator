using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mcreator.Classes
{
    class Soul
    {
        // Calculation of the charisma
        private int charismaValue;
        public int Charisma(string mtxtCharisma, string mtxtIntelligence, string mtxtAppearance)
        {
            int tempCharismaValue = 0;
            tempCharismaValue = Convert.ToInt32(mtxtCharisma) + (3 * ((Convert.ToInt32(mtxtIntelligence) / 10) + 
                (Convert.ToInt32(mtxtAppearance) / 10))) - 30;

            if (tempCharismaValue >= 0)
            {
                charismaValue = tempCharismaValue;
            }
            else
            {
                charismaValue = 0;
            }
            return charismaValue;
        }

        // Calculation of the willpower
        private int willpowerValue;
        public int Willpower(string mtxtWillpower, string mtxtConstitution, string mtxtIntelligence)
        {

            int tempWillpowerValue = 0;
            tempWillpowerValue = Convert.ToInt32(mtxtWillpower) + (3 * ((Convert.ToInt32(mtxtConstitution) / 10) + 
                (Convert.ToInt32(mtxtIntelligence) / 10))) - 40;

            if (tempWillpowerValue > 0)
            {
                willpowerValue = tempWillpowerValue;
            }
            else
            {
                willpowerValue = 0;
            }
            return willpowerValue;
        }

        // Calculation of the selfcontrol
        private int selfControlAValue;
        public int SelfControlA(string mtxtSelfControl, string mtxtIntelligence, string txtWillpower)
        {
            int tempSelfControlAValue = 0;

            tempSelfControlAValue = Convert.ToInt32(mtxtSelfControl) + (3 * ((Convert.ToInt32(mtxtIntelligence) / 10) + 
                (Convert.ToInt32(txtWillpower) / 10)));

            if (tempSelfControlAValue > 0)
            {
                selfControlAValue = tempSelfControlAValue;
            }
            else
            {
                selfControlAValue = 0;
            }
            return selfControlAValue;
        }

        // Calculation of the selfcontrol
        private int selfControlBValue;
        public int SelfControlB(string mtxtSelfControl, string mtxtIntelligence, string txtWillpower)
        {
            int tempSelfControlBValue = 0;

            tempSelfControlBValue = Convert.ToInt32(mtxtSelfControl) + (3 * ((Convert.ToInt32(mtxtIntelligence) / 10) + 
                (Convert.ToInt32(txtWillpower) / 10))) - 50;

            if (tempSelfControlBValue > 0)
            {
                selfControlBValue = tempSelfControlBValue;
            }
            else
            {
                selfControlBValue = 0;
            }
            return selfControlBValue;
        }

        // Calculation of the selfcontrol
        private int selfControlCValue;
        public int SelfControlC(string mtxtSelfControl, string mtxtIntelligence, string txtWillpower)
        {
            int tempSelfControlCValue = 0;

            tempSelfControlCValue = Convert.ToInt32(mtxtSelfControl) + (3 * ((Convert.ToInt32(mtxtIntelligence) / 10) + 
                (Convert.ToInt32(txtWillpower) / 10))) - 30;

            if (tempSelfControlCValue > 0)
            {
                selfControlCValue = tempSelfControlCValue;
            }
            else
            {
                selfControlCValue = 0;
            }
            return selfControlCValue;
        }

        // Calculation of the hand specialization
        private string handedValue;
        public string Handed(string mtxtHanded)
        {
            int handed = 0;

            handed = Convert.ToInt32(mtxtHanded);

            if (handed <= 15)
            {
                handedValue = "Rechtshänder";
            }

            if (handed > 15 && handed < 20)
            {
                handedValue = "Linkshänder";
            }

            if (handed == 20)
            {
                handedValue = "Beidhänder";
            }

            return handedValue;
        }
    }
}
