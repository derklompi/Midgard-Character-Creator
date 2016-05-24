namespace MidgardCreator.Classes
{
    class InbornBuff
    {
        private string inbornBuffValue;
        public string Inborn(int inbornBuff, int willpower)
        {
            if (1 <= inbornBuff && inbornBuff <= 2)
            {
                inbornBuffValue = "Kurzsichtigkeit (nur Sehen +4)";
            }
            if (3 <= inbornBuff && inbornBuff <= 4)
            {
                inbornBuffValue = "Schwerhörigkeit (nur Hören +4)";
            }
            if (5 <= inbornBuff && inbornBuff <= 6)
            {
                inbornBuffValue = "nur Riechen +4";
            }
            if (7 <= inbornBuff && inbornBuff <= 8)
            {
                inbornBuffValue = "nur Schmecken +4";
            }
            if (9 <= inbornBuff && inbornBuff <= 10)
            {
                inbornBuffValue = "nur Tasten +4";
            }
            if (11 <= inbornBuff && inbornBuff <= 20)
            {
                inbornBuffValue = "Sehen +10";
            }
            if (21 <= inbornBuff && inbornBuff <= 30)
            {
                inbornBuffValue = "Hören +10";
            }
            if (31 <= inbornBuff && inbornBuff <= 40)
            {
                inbornBuffValue = "Riechen +10";
            }
            if (41 <= inbornBuff && inbornBuff <= 50)
            {
                inbornBuffValue = "Schmecken +10";
            }
            if (51 <= inbornBuff && inbornBuff <= 60)
            {
                inbornBuffValue = "Tasten +10";
            }
            if (61 <= inbornBuff && inbornBuff <= 65)
            {
                inbornBuffValue = "Sechster Sinn +6";
            }                
            if (66 <= inbornBuff && inbornBuff <= 70)
            {
                int berserk = 0;
                berserk = 18 - (willpower / 5);
                inbornBuffValue = "Berserkergang+ " + berserk;
            }
            if (71 <= inbornBuff && inbornBuff <= 75)
            {
                inbornBuffValue = "Gute Reflexe +9";
            }
            if (76 <= inbornBuff && inbornBuff <= 80)
            {
                inbornBuffValue = "Nachtsicht +8";
            }
            if (81 <= inbornBuff && inbornBuff <= 85)
            {
                inbornBuffValue = "Richtungssinn +12";
            }
            if (86 <= inbornBuff && inbornBuff <= 90)
            {
                inbornBuffValue = "Robustheit +9";
            }
            if (91 <= inbornBuff && inbornBuff <= 95)
            {
                inbornBuffValue = "Wachgabe +6";
            }
            if (96 <= inbornBuff && inbornBuff <= 99)
            {
                inbornBuffValue = "Einprägen +4";
            }
            if (inbornBuff == 100)
            {
                inbornBuffValue = "Freie Wahl und zweiter Wurf";
            }

            return inbornBuffValue;
        }
    }
}
