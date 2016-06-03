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
    class AdventureLifePoints
    {
        // Calculation for adventure points of barbarians, warriors. etc.
        private int adventurePointsAValue;
        public int adventurePointsA(string mtxtAdventurePointsA, string txtStaminaBuff, string formTitle)
        {
            int tempAdventurePointsAValue = 0;

            tempAdventurePointsAValue = Convert.ToInt32(mtxtAdventurePointsA) + 4 + Convert.ToInt32(txtStaminaBuff);

            if (tempAdventurePointsAValue >= 4)
            {
                // Calculations for dwarfs
                if (formTitle == "MCreator - Zwerg")
                {
                    adventurePointsAValue = tempAdventurePointsAValue;
                }
                
                // Calculations for elfs
                if (formTitle == "MCreator - Elf")
                {
                    adventurePointsAValue = tempAdventurePointsAValue;
                }

                // Calculations for gnomes
                if (formTitle == "MCreator - Gnom")
                {
                    adventurePointsAValue = tempAdventurePointsAValue - 2;
                }

                // Calculations for halflings
                if (formTitle == "MCreator - Halbling")
                {
                    adventurePointsAValue = tempAdventurePointsAValue - 1;
                }

                // Calculations for humans
                if (formTitle == "MCreator - Mensch")
                {
                    adventurePointsAValue = tempAdventurePointsAValue;
                }
            }
            else
            {
                adventurePointsAValue = 4;
            }

            return adventurePointsAValue;
        }

        private int adventurePointsBValue;
        public int adventurePointsB(string mtxtAdventurePointsB, string txtStaminaBuff, string formTitle)
        {
            int tempAdventurePointsBValue = 0;

            tempAdventurePointsBValue = Convert.ToInt32(mtxtAdventurePointsB) + 3 + Convert.ToInt32(txtStaminaBuff);

            if (tempAdventurePointsBValue >= 4)
            {
                // Calculations for dwarfs
                if (formTitle == "MCreator - Zwerg")
                {
                    adventurePointsBValue = tempAdventurePointsBValue;
                }

                // Calculations for elfs
                if (formTitle == "MCreator - Elf")
                {
                    adventurePointsBValue = tempAdventurePointsBValue;
                }

                // Calculations for gnomes
                if (formTitle == "MCreator - Gnom")
                {
                    adventurePointsBValue = tempAdventurePointsBValue -2;
                }

                // Calculations for halflings
                if (formTitle == "MCreator - Halbling")
                {
                    adventurePointsBValue = tempAdventurePointsBValue -1;
                }

                // Calculations for humans
                if (formTitle == "MCreator - Mensch")
                {
                    adventurePointsBValue = tempAdventurePointsBValue;
                }
            }
            else
            {
                adventurePointsBValue = 4;
            }
            return adventurePointsBValue;
        }

        private int adventurePointsCValue;
        public int adventurePointsC(string mtxtAdventurePointsC, string txtStaminaBuff, string formTitle)
        {
            int tempAdventurePointsCValue = 0;

            tempAdventurePointsCValue = Convert.ToInt32(mtxtAdventurePointsC) + 2 + Convert.ToInt32(txtStaminaBuff);

            if (tempAdventurePointsCValue >= 4)
            {
                // Calculations for dwarfs
                if (formTitle == "MCreator - Zwerg")
                {
                    adventurePointsCValue = tempAdventurePointsCValue;
                }

                // Calculations for elfs
                if (formTitle == "MCreator - Elf")
                {
                    adventurePointsCValue = tempAdventurePointsCValue;
                }

                // Calculations for gnomes
                if (formTitle == "MCreator - Gnom")
                {
                    adventurePointsCValue = tempAdventurePointsCValue - 2;
                }

                // Calculations for halflings
                if (formTitle == "MCreator - Halbling")
                {
                    adventurePointsCValue = tempAdventurePointsCValue - 1;
                }

                // Calculations for humans
                if (formTitle == "MCreator - Mensch")
                {
                    adventurePointsCValue = tempAdventurePointsCValue;
                }
            }
            else
            {
                adventurePointsCValue = 4;
            }
            return adventurePointsCValue;
        }

        // Calculations of the lifepoints
        private int lifePointsValue;
        public int lifePoints(string mtxtConstitution, string mtxtLifePoints, string formTitle)
        {
            // Convert the strings to Int
            int constitution = Convert.ToInt32(mtxtConstitution);
            int lifepoints = Convert.ToInt32(mtxtLifePoints);

            // Calculations for humans
            if (formTitle == "MCreator - Mensch")
            {
                lifePointsValue = (constitution / 10) + lifepoints + 5;
            }

            // Calculations for elfs
            if (formTitle == "MCreator - Elf")
            {
                lifePointsValue = (constitution / 10) + lifepoints + 4;
            }

            // Calculations for gnomes
            if (formTitle == "MCreator - Gnom")
            {
                lifePointsValue = (constitution / 10) + lifepoints - 1;
            }

            // Calculations for halflings
            if (formTitle == "MCreator - Halbling")
            {
                lifePointsValue = (constitution / 10) + lifepoints + 2;
            }

            // Calculations for dwarfs
            if (formTitle == "MCreator - Zwerg")
            {
                lifePointsValue = (constitution / 10) + lifepoints + 4;
            }

            return lifePointsValue;
        }

    }
}
