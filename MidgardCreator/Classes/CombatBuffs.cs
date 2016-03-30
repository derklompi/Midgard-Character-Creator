namespace MidgardCreator.Classes
{
    public class CombatBuffs
    {      
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
    }
}
