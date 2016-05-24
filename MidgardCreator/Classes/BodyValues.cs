using System;

namespace mcreator.Classes
{
    class BodyValues
    {
        // Calculate of the bodysize
        private int bodySize;
        public int BodySize(string mtxtBodySizeA, string mtxtBodySizeB, string mtxtStrength, string formTitle)
        {
            // Convert to int for better usability
            int bodysizeA = Convert.ToInt32(mtxtBodySizeA);
            int bodysizeB = Convert.ToInt32(mtxtBodySizeB);

            int strength = Convert.ToInt32(mtxtStrength);

            //Calculation for dwarfs
            if (formTitle == "Midgard Creator - Zwerg" || formTitle == "Midgard Creator - Dwarf")
            {
                bodySize = bodysizeA + (strength / 10) + 130;
            }

            //Calculation for elfs
            if (formTitle == "Midgard Creator - Elf")
            {
                bodySize = bodysizeA + bodysizeB + (strength / 10) + 160;
            }

            //Calculation for gnomes
            if (formTitle == "Midgard Creator - Gnom" || formTitle == "Midgard Creator - Gnome")
            {
                bodySize = bodysizeA + (strength / 10) + 90;
            }

            //Calculation for halflings
            if (formTitle == "Midgard Creator - Halbling" || formTitle == "Midgard Creator - Halfling")
            {
                bodySize = bodysizeA + bodysizeB + (strength / 10) + 100;
            }
            
            return bodySize;
        }

        // Calculate of the bodyweight
        private int bodyWeight;
        public int BodyWeight(string mtxtBodyWeightA, string mtxtBodyWeightB, string mtxtBodyWeightC,
            string mtxtBodyWeightD, string mtxtStrength, string txtBodySize, string formTitle)
        {
            // Convert to int for better usability
            int bodyweightA = Convert.ToInt32(mtxtBodyWeightA);
            int bodyweightB = Convert.ToInt32(mtxtBodyWeightB);
            int bodyweightC = Convert.ToInt32(mtxtBodyWeightC);
            int bodyweightD = Convert.ToInt32(mtxtBodyWeightD);

            int strength = Convert.ToInt32(mtxtStrength);
            int bodysize = Convert.ToInt32(txtBodySize);

            //Calculation for dwarfs
            if (formTitle == "Midgard Creator - Zwerg" || formTitle == "Midgard Creator - Dwarf")
            {
                bodyWeight = bodyweightA + bodyweightB + bodyweightC + bodyweightD +
                    (strength / 10) + bodysize - 90;
            }

            //Calculation for elfs
            if (formTitle == "Midgard Creator - Elf")
            {
                bodyWeight = bodyweightA + bodyweightB + bodyweightC + bodyweightD +
                    (strength / 10) + bodysize - 128;
            }

            //Calculation for gnomes
            if (formTitle == "Midgard Creator - Gnom" || formTitle == "Midgard Creator - Gnome")
            {
                bodyWeight = bodyweightA + bodyweightB + bodyweightC +
                    (strength / 10) + bodysize - 90;
            }

            //Calculation for halflings
            if (formTitle == "Midgard Creator - Halbling" || formTitle == "Midgard Creator - Halfling")
            {
                bodyWeight = bodyweightA + bodyweightB + bodyweightC +
                    (strength / 10) + bodysize - 87;
            }

            return bodyWeight;
        }


    }
}

