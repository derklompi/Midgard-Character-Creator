using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidgardCreator.Classes
{
    class Soul
    {
        private string charismaValue;
        public string Charisma(string mtxtCharisma, string mtxtIntelligence, string mtxtAppearance)
        {
            int charisma = 0;
            charisma = Convert.ToInt32(mtxtCharisma) + (3 * ((Convert.ToInt32(mtxtIntelligence) / 10) + 
                (Convert.ToInt32(mtxtAppearance) / 10))) - 30;

            if (charisma >= 0)
            {
                charismaValue = Convert.ToString(charisma);
            }
            else
            {
                charismaValue = "0";
            }
            return charismaValue;
        }

        private string willpowerValue;
        public string Willpower(string mtxtWillpower, string mtxtConstitution, string mtxtIntelligence)
        {

            int willpower = 0;
            willpower = Convert.ToInt32(mtxtWillpower) + (3 * ((Convert.ToInt32(mtxtConstitution) / 10) + 
                (Convert.ToInt32(mtxtIntelligence) / 10))) - 40;

            if (willpower > 0)
            {
                willpowerValue = Convert.ToString(willpower);
            }
            else
            {
                willpowerValue = "0";
            }
            return willpowerValue;
        }

        private string selfControlAValue;
        public string SelfControlA(string mtxtSelfControl, string mtxtIntelligence, string txtWillpower)
        {
            int selfControlA = 0;

            selfControlA = Convert.ToInt32(mtxtSelfControl) + (3 * ((Convert.ToInt32(mtxtIntelligence) / 10) + 
                (Convert.ToInt32(txtWillpower) / 10)));

            if (selfControlA > 0)
            {
                selfControlAValue = Convert.ToString(selfControlA);
            }
            else
            {
                selfControlAValue = "0";
            }
            return selfControlAValue;
        }

        private string selfControlBValue;
        public string SelfControlB(string mtxtSelfControl, string mtxtIntelligence, string txtWillpower)
        {
            int selfControlB = 0;

            selfControlB = Convert.ToInt32(mtxtSelfControl) + (3 * ((Convert.ToInt32(mtxtIntelligence) / 10) + 
                (Convert.ToInt32(txtWillpower) / 10))) - 50;

            if (selfControlB > 0)
            {
                selfControlBValue = Convert.ToString(selfControlB);
            }
            else
            {
                selfControlBValue = "0";
            }
            return selfControlBValue;
        }

        private string selfControlCValue;
        public string SelfControlC(string mtxtSelfControl, string mtxtIntelligence, string txtWillpower)
        {
            int selfControlC = 0;

            selfControlC = Convert.ToInt32(mtxtSelfControl) + (3 * ((Convert.ToInt32(mtxtIntelligence) / 10) + 
                (Convert.ToInt32(txtWillpower) / 10))) - 30;

            if (selfControlC > 0)
            {
                selfControlCValue = Convert.ToString(selfControlC);
            }
            else
            {
                selfControlCValue = "0";
            }
            return selfControlCValue;
        }

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
