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
                if (formTitle == "Midgard Creator - Zwerg" || formTitle == "Midgard Creator - Dwarf")
                {
                    adventurePointsAValue = tempAdventurePointsAValue;
                }
                
                // Calculations for elfs
                if (formTitle == "Midgard Creator - Elf")
                {
                    adventurePointsAValue = tempAdventurePointsAValue;
                }

                // Calculations for gnomes
                if (formTitle == "Midgard Creator - Gnom" || formTitle == "Midgard Creator - Gnome")
                {
                    adventurePointsAValue = tempAdventurePointsAValue - 2;
                }

                // Calculations for halflings
                if (formTitle == "Midgard Creator - Halbling" || formTitle == "Midgard Creator - Halfling")
                {
                    adventurePointsAValue = tempAdventurePointsAValue - 1;
                }

                // Calculations for humans
                if (formTitle == "Midgard Creator - Mensch" || formTitle == "Midgard Creator - Human")
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
                if (formTitle == "Midgard Creator - Zwerg" || formTitle == "Midgard Creator - Dwarf")
                {
                    adventurePointsBValue = tempAdventurePointsBValue;
                }

                // Calculations for elfs
                if (formTitle == "Midgard Creator - Elf")
                {
                    adventurePointsBValue = tempAdventurePointsBValue;
                }

                // Calculations for gnomes
                if (formTitle == "Midgard Creator - Gnom" || formTitle == "Midgard Creator - Gnome")
                {
                    adventurePointsBValue = tempAdventurePointsBValue -2;
                }

                // Calculations for halflings
                if (formTitle == "Midgard Creator - Halbling" || formTitle == "Midgard Creator - Halfling")
                {
                    adventurePointsBValue = tempAdventurePointsBValue -1;
                }

                // Calculations for humans
                if (formTitle == "Midgard Creator - Mensch" || formTitle == "Midgard Creator - Human")
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
                if (formTitle == "Midgard Creator - Zwerg" || formTitle == "Midgard Creator - Dwarf")
                {
                    adventurePointsCValue = tempAdventurePointsCValue;
                }

                // Calculations for elfs
                if (formTitle == "Midgard Creator - Elf")
                {
                    adventurePointsCValue = tempAdventurePointsCValue;
                }

                // Calculations for gnomes
                if (formTitle == "Midgard Creator - Gnom" || formTitle == "Midgard Creator - Gnome")
                {
                    adventurePointsCValue = tempAdventurePointsCValue - 2;
                }

                // Calculations for halflings
                if (formTitle == "Midgard Creator - Halbling" || formTitle == "Midgard Creator - Halfling")
                {
                    adventurePointsCValue = tempAdventurePointsCValue - 1;
                }

                // Calculations for humans
                if (formTitle == "Midgard Creator - Mensch" || formTitle == "Midgard Creator - Human")
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
            if (formTitle == "Midgard Creator - Mensch" || formTitle == "Midgard Creator - Human")
            {
                lifePointsValue = (constitution / 10) + lifepoints + 5;
            }

            // Calculations for elfs
            if (formTitle == "Midgard Creator - Elf")
            {
                lifePointsValue = (constitution / 10) + lifepoints + 4;
            }

            // Calculations for gnomes
            if (formTitle == "Midgard Creator - Gnom" || formTitle == "Midgard Creator - Gnome")
            {
                lifePointsValue = (constitution / 10) + lifepoints - 1;
            }

            // Calculations for halflings
            if (formTitle == "Midgard Creator - Halbling" || formTitle == "Midgard Creator - Halfling")
            {
                lifePointsValue = (constitution / 10) + lifepoints + 2;
            }

            // Calculations for dwarfs
            if (formTitle == "Midgard Creator - Zwerg" || formTitle == "Midgard Creator - Dwarf")
            {
                lifePointsValue = (constitution / 10) + lifepoints + 4;
            }

            return lifePointsValue;
        }

    }
}
