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
            if (formTitle == "MCreator - Zwerg")
            {
                bodySize = bodysizeA + (strength / 10) + 130;
            }

            //Calculation for elfs
            if (formTitle == "MCreator - Elf")
            {
                bodySize = bodysizeA + bodysizeB + (strength / 10) + 160;
            }

            //Calculation for gnomes
            if (formTitle == "MCreator - Gnom")
            {
                bodySize = bodysizeA + (strength / 10) + 90;
            }

            //Calculation for halflings
            if (formTitle == "MCreator - Halbling")
            {
                bodySize = bodysizeA + bodysizeB + (strength / 10) + 100;
            }

            //Calculation for human
            if (formTitle == "MCreator - Mensch")
            {
                bodySize = bodysizeA + bodysizeB + (strength / 10);
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
            if (formTitle == "MCreator - Zwerg")
            {
                bodyWeight = bodyweightA + bodyweightB + bodyweightC + bodyweightD +
                    (strength / 10) + bodysize - 90;
            }

            //Calculation for elfs
            if (formTitle == "MCreator - Elf")
            {
                bodyWeight = bodyweightA + bodyweightB + bodyweightC + bodyweightD +
                    (strength / 10) + bodysize - 128;
            }

            //Calculation for gnomes
            if (formTitle == "MCreator - Gnom")
            {
                bodyWeight = bodyweightA + bodyweightB + bodyweightC +
                    (strength / 10) + bodysize - 90;
            }

            //Calculation for halflings
            if (formTitle == "MCreator - Halbling")
            {
                bodyWeight = bodyweightA + bodyweightB + bodyweightC +
                    (strength / 10) + bodysize - 87;
            }

            //Calculation for human
            if (formTitle == "MCreator - Mensch")
            {
                bodyWeight = bodyweightA + bodyweightB + bodyweightC + bodyweightD +
                    (strength / 10) + bodysize - 120;
            }

            return bodyWeight;
        }


    }
}

