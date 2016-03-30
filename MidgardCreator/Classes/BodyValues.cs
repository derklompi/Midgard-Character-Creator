using System;

namespace MidgardCreator.Classes
{
    class BodyValues
    {
        private string bodyWeight;
        public string BodyWeight(string mtxtBodyWeightA, string mtxtBodyWeightB, string mtxtBodyWeightC, 
            string mtxtBodyWeightD, string mtxtStrength, string txtBodySize, string formTitle)
        {
            if (formTitle == "Midgard Creator - Zwerg" || formTitle == "Midgard Creator - Dwarf")
            {
                bodyWeight = Convert.ToString(
                    Convert.ToInt32(mtxtBodyWeightA) + Convert.ToInt32(mtxtBodyWeightB) + 
                    Convert.ToInt32(mtxtBodyWeightC) + Convert.ToInt32(mtxtBodyWeightD) + 
                    (Convert.ToInt32(mtxtStrength) / 10) + Convert.ToInt32(txtBodySize) - 90);
            }
            if (formTitle == "Midgard Creator - Elf")
            {
                bodyWeight = Convert.ToString(
                    Convert.ToInt32(mtxtBodyWeightA) + Convert.ToInt32(mtxtBodyWeightB) +
                    Convert.ToInt32(mtxtBodyWeightC) + Convert.ToInt32(mtxtBodyWeightD) +
                    (Convert.ToInt32(mtxtStrength) / 10) + Convert.ToInt32(txtBodySize) - 128);
            }
            if (formTitle == "Midgard Creator - Gnom" || formTitle == "Midgard Creator - Gnome")
            {
                bodyWeight = Convert.ToString(
                    Convert.ToInt32(mtxtBodyWeightA) + Convert.ToInt32(mtxtBodyWeightB) +
                    Convert.ToInt32(mtxtBodyWeightC) +
                    (Convert.ToInt32(mtxtStrength) / 10) + Convert.ToInt32(txtBodySize) - 90);
            }
            if (formTitle == "Midgard Creator - Halbling" || formTitle == "Midgard Creator - Halfling")
            {
                bodyWeight = Convert.ToString(
                    Convert.ToInt32(mtxtBodyWeightA) + Convert.ToInt32(mtxtBodyWeightB) +
                    Convert.ToInt32(mtxtBodyWeightC) + 
                    (Convert.ToInt32(mtxtStrength) / 10) + Convert.ToInt32(txtBodySize) - 87);
            }
       
            return bodyWeight;
        }

        private string bodySize;
        public string BodySize(string mtxtBodySizeA, string mtxtBodySizeB, string mtxtStrength, string formTitle)
        {
            if (formTitle == "Midgard Creator - Zwerg" || formTitle == "Midgard Creator - Dwarf")
            {
                bodySize = Convert.ToString(
                Convert.ToInt32(mtxtBodySizeA) + 
                (Convert.ToInt32(mtxtStrength) / 10) + 130);
            }
            if (formTitle == "Midgard Creator - Elf")
            {
                bodySize = Convert.ToString(
                Convert.ToInt32(mtxtBodySizeA) + Convert.ToInt32(mtxtBodySizeB) +
                (Convert.ToInt32(mtxtStrength) / 10) + 160);
            }
            if (formTitle == "Midgard Creator - Gnom" || formTitle == "Midgard Creator - Gnome")
            {
                bodySize = Convert.ToString(
                Convert.ToInt32(mtxtBodySizeA) + 
                (Convert.ToInt32(mtxtStrength) / 10) + 90);
            }
            if (formTitle == "Midgard Creator - Halbling" || formTitle == "Midgard Creator - Halfling")
            {
                bodySize = Convert.ToString(
                Convert.ToInt32(mtxtBodySizeA) + Convert.ToInt32(mtxtBodySizeB) +
                (Convert.ToInt32(mtxtStrength) / 10) + 100);
            }
            
            return bodySize;
        }
    }
}

