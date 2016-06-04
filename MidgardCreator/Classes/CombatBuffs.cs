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
namespace mcreator.Classes
{
    public class CombatBuffs
    {      
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
    }
}
