using System;

namespace MidgardCreator.Classes
{
    class AdventureLifePoints
    {
        private string adventurePointsAValue;
        public string adventurePointsA(string mtxtAdventurePointsA, string txtStaminaBuff, string formTitle)
        {
            int adventurePointsA = 0;

            adventurePointsA = Convert.ToInt32(mtxtAdventurePointsA) + 4 + Convert.ToInt32(txtStaminaBuff);

            if (adventurePointsA >= 4)
            {
                if (formTitle == "Midgard Creator - Zwerg" || formTitle == "Midgard Creator - Dwarf")
                {
                    adventurePointsAValue = Convert.ToString(adventurePointsA);
                }
                if (formTitle == "Midgard Creator - Elf")
                {
                    adventurePointsAValue = Convert.ToString(adventurePointsA);
                }
                if (formTitle == "Midgard Creator - Gnom" || formTitle == "Midgard Creator - Gnome")
                {
                    int tempAdventurePointsValueFactorGnome = Convert.ToInt32(adventurePointsA) - 2;
                    adventurePointsAValue = Convert.ToString(tempAdventurePointsValueFactorGnome);
                }
                if (formTitle == "Midgard Creator - Halbling" || formTitle == "Midgard Creator - Halfling")
                {
                    int tempAdventurePointsValueFactorHalfling = Convert.ToInt32(adventurePointsA) - 1;
                    adventurePointsAValue = Convert.ToString(tempAdventurePointsValueFactorHalfling);
                }
                if (formTitle == "Midgard Creator - Mensch" || formTitle == "Midgard Creator - Human")
                {
                    adventurePointsAValue = Convert.ToString(adventurePointsA);
                }
            }
            else
            {
                adventurePointsAValue = "4";
            }

            return adventurePointsAValue;
        }

        private string adventurePointsBValue;
        public string adventurePointsB(string mtxtAdventurePointsB, string txtStaminaBuff, string formTitle)
        {
            int adventurePointsB = 0;

            adventurePointsB = Convert.ToInt32(mtxtAdventurePointsB) + 3 + Convert.ToInt32(txtStaminaBuff);

            if (adventurePointsB >= 4)
            {
                if (formTitle == "Midgard Creator - Zwerg" || formTitle == "Midgard Creator - Dwarf")
                {
                    adventurePointsBValue = Convert.ToString(adventurePointsB);
                }
                if (formTitle == "Midgard Creator - Elf")
                {
                    adventurePointsBValue = Convert.ToString(adventurePointsB);
                }
                if (formTitle == "Midgard Creator - Gnom" || formTitle == "Midgard Creator - Gnome")
                {
                    int tempAdventurePointsValueFactorGnome = Convert.ToInt32(adventurePointsB) - 2;
                    adventurePointsBValue = Convert.ToString(tempAdventurePointsValueFactorGnome);
                }
                if (formTitle == "Midgard Creator - Halbling" || formTitle == "Midgard Creator - Halfling")
                {
                    int tempAdventurePointsValueFactorHalfling = Convert.ToInt32(adventurePointsB) - 1;
                    adventurePointsBValue = Convert.ToString(tempAdventurePointsValueFactorHalfling);
                }
                if (formTitle == "Midgard Creator - Mensch" || formTitle == "Midgard Creator - Human")
                {
                    adventurePointsBValue = Convert.ToString(adventurePointsB);
                }
            }
            else
            {
                adventurePointsBValue = "4";
            }
            return adventurePointsBValue;
        }

        private string adventurePointsCValue;
        public string adventurePointsC(string mtxtAdventurePointsC, string txtStaminaBuff, string formTitle)
        {
            int adventurePointsC = 0;

            adventurePointsC = Convert.ToInt32(mtxtAdventurePointsC) + 2 + Convert.ToInt32(txtStaminaBuff);

            if (adventurePointsC >= 4)
            {
                if (formTitle == "Midgard Creator - Zwerg" || formTitle == "Midgard Creator - Dwarf")
                {
                    adventurePointsCValue = Convert.ToString(adventurePointsC);
                }
                if (formTitle == "Midgard Creator - Elf")
                {
                    adventurePointsCValue = Convert.ToString(adventurePointsC);
                }
                if (formTitle == "Midgard Creator - Gnom" || formTitle == "Midgard Creator - Gnome")
                {
                    int tempAdventurePointsValueFactorGnome = Convert.ToInt32(adventurePointsC) - 2;
                    adventurePointsCValue = Convert.ToString(tempAdventurePointsValueFactorGnome);
                }
                if (formTitle == "Midgard Creator - Halbling" || formTitle == "Midgard Creator - Halfling")
                {
                    int tempAdventurePointsValueFactorHalfling = Convert.ToInt32(adventurePointsC) - 1;
                    adventurePointsCValue = Convert.ToString(tempAdventurePointsValueFactorHalfling);
                }
                if (formTitle == "Midgard Creator - Mensch" || formTitle == "Midgard Creator - Human")
                {
                    adventurePointsCValue = Convert.ToString(adventurePointsC);
                }
            }
            else
            {
                adventurePointsCValue = "4";
            }
            return adventurePointsCValue;
        }

        private string lifePointsValue;
        public string lifePoints(string mtxtConstitution, string mtxtLifePoints, string formTitle)
        {
            if (formTitle == "Midgard Creator - Mensch" || formTitle == "Midgard Creator - Human")
            {
                lifePointsValue = Convert.ToString((Convert.ToInt32(mtxtConstitution) / 10) + Convert.ToInt32(mtxtLifePoints) + 5);
            }
            if (formTitle == "Midgard Creator - Elf")
            {
                lifePointsValue = Convert.ToString((Convert.ToInt32(mtxtConstitution) / 10) + Convert.ToInt32(mtxtLifePoints) + 6);
                int tempLifePointsValueFactorElf = Convert.ToInt32(lifePointsValue) - 2;
                lifePointsValue = Convert.ToString(tempLifePointsValueFactorElf);
            }
            if (formTitle == "Midgard Creator - Gnom" || formTitle == "Midgard Creator - Gnome")
            {
                lifePointsValue = Convert.ToString((Convert.ToInt32(mtxtConstitution) / 10) + Convert.ToInt32(mtxtLifePoints) + 1);
                int tempLifePointsValueFactorGnome = Convert.ToInt32(lifePointsValue) - 2;
                lifePointsValue = Convert.ToString(tempLifePointsValueFactorGnome);
            }
            if (formTitle == "Midgard Creator - Halbling" || formTitle == "Midgard Creator - Halfling")
            {
                lifePointsValue = Convert.ToString((Convert.ToInt32(mtxtConstitution) / 10) + Convert.ToInt32(mtxtLifePoints) + 3);
                int tempLifePointsValueFactorHalfling = Convert.ToInt32(lifePointsValue) - 1;
                lifePointsValue = Convert.ToString(tempLifePointsValueFactorHalfling);
            }
            if (formTitle == "Midgard Creator - Zwerg" || formTitle == "Midgard Creator - Dwarf")
            {
                lifePointsValue = Convert.ToString((Convert.ToInt32(mtxtConstitution) / 10) + Convert.ToInt32(mtxtLifePoints) + 6);
                int tempLifePointsValueFactorDwarf = Convert.ToInt32(lifePointsValue) - 2;
                lifePointsValue = Convert.ToString(tempLifePointsValueFactorDwarf);
            }
            return lifePointsValue;
        }

    }
}
