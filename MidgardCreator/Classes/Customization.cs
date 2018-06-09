using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mcc.Classes
{
    class Customization
    {

        public int MagicArts(string cbZauberkünsteA, string cbZauberkünsteB)
        {
            if (cbZauberkünsteA != "" && cbZauberkünsteB != "")
            {
                int zauberkuenste = 0;
                int zauberkuenste_ValueA = 0;
                int zauberkuenste_ValueB = 0;

                zauberkuenste_ValueA = Convert.ToInt32(cbZauberkünsteA);
                zauberkuenste_ValueB = Convert.ToInt32(cbZauberkünsteB);
                zauberkuenste = zauberkuenste_ValueA + zauberkuenste_ValueB;
                
                return zauberkuenste;
            }
            else
            {
                return 0;
            }
        }

        public int WeaponSkills(string cbWaffenfertigkeitenA, string cbWaffenfertigkeitenB)
        {
            if (cbWaffenfertigkeitenA != "" && cbWaffenfertigkeitenB != "")
            {
                int waffenfertigkeiten = 0;
                int waffenfertigkeiten_ValueA = 0;
                int waffenfertigkeiten_ValueB = 0;

                waffenfertigkeiten_ValueA = Convert.ToInt32(cbWaffenfertigkeitenA);
                waffenfertigkeiten_ValueB = Convert.ToInt32(cbWaffenfertigkeitenB);
                waffenfertigkeiten = waffenfertigkeiten_ValueA + waffenfertigkeiten_ValueB;               
                
                return waffenfertigkeiten;
            }
            else
            {
                return 0;
            }
        }

        public string SocialRank(int socialRankValue)
        {            
                if (socialRankValue <= 10)
                {
                    return "Unfrei";
                }
                if (socialRankValue <= 50 && socialRankValue > 10)
                {
                    return "Volk";
                }
                if (socialRankValue <= 90 && socialRankValue > 50)
                {
                    return "Mittelschicht";
                }
                if (socialRankValue <= 120 && socialRankValue > 90)
                {
                    return "Adel";
                }       
                else
                {
                    return "";
                }     
        }       
    }
}
