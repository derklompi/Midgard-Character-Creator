namespace MidgardCreator.Classes
{
    class Resistance
    {          
        private int mtBuffGhost_Body_MagicValue;
        public int MagicTalentGhostBody(int magicTalent)
        {
             if (1 <= magicTalent && magicTalent <= 5)
                    {
                mtBuffGhost_Body_MagicValue = -2;
            }
                    if (6 <= magicTalent && magicTalent <= 20)
                    {
                mtBuffGhost_Body_MagicValue = -1;
            }
                    if (81 <= magicTalent && magicTalent <= 95)
                    {
                mtBuffGhost_Body_MagicValue = 1;
            }
                    if (96 <= magicTalent && magicTalent <= 99)
                    {
                mtBuffGhost_Body_MagicValue = 2;
            }
                    if (magicTalent == 100)
                    {
                mtBuffGhost_Body_MagicValue = 3;
            }

            return mtBuffGhost_Body_MagicValue;
        }

        private int intBuffGhostMagicValue;
        public int IntelligenceGhost(int intelligence)
        {
            if (1 <= intelligence && intelligence <= 5)
            {
                intBuffGhostMagicValue = -2;
            }
            if (6 <= intelligence && intelligence <= 20)
            {
                intBuffGhostMagicValue = -1;
            }
            if (81 <= intelligence && intelligence <= 95)
            {
                intBuffGhostMagicValue = 1;
            }
            if (96 <= intelligence && intelligence <= 100)
            {
                intBuffGhostMagicValue = 2;
            }

            return intBuffGhostMagicValue;
        }

        private int CoBuffBodyMagicValue;
        public int ConstitutionBody(int constitution)
        {
            if (1 <= constitution && constitution <= 5)
            {
                CoBuffBodyMagicValue = -2;
            }
            if (6 <= constitution && constitution <= 20)
            {
                CoBuffBodyMagicValue = -1;
            }
            if (81 <= constitution && constitution <= 95)
            {
                CoBuffBodyMagicValue = 1;
            }
            if (96 <= constitution && constitution <= 100)
            {
                CoBuffBodyMagicValue = 2;
            }

            return CoBuffBodyMagicValue;
        }

        private int areaMagicValue;
        public int AgilityArea(int agility)
        {
            if (1 <= agility && agility <= 5)
            {
                areaMagicValue = -2;
            }
            if (6 <= agility && agility <= 20)
            {
                areaMagicValue = -1;
            }
            if (81 <= agility && agility <= 95)
            {
                areaMagicValue = 1;
            }
            if (96 <= agility && agility <= 100)
            {
                areaMagicValue = 2;
            }
            return areaMagicValue;
        }

        private int ghostMagicValue;
        public int GhostMagic(int mtBuffGhost_Body_MagicValue, int intBuffGhostMagicValue)
        {
            if (mtBuffGhost_Body_MagicValue > intBuffGhostMagicValue && intBuffGhostMagicValue < 0)
            {
                ghostMagicValue = mtBuffGhost_Body_MagicValue + intBuffGhostMagicValue;
            }
            if (mtBuffGhost_Body_MagicValue > intBuffGhostMagicValue && intBuffGhostMagicValue >= 0)
            {
                ghostMagicValue = mtBuffGhost_Body_MagicValue;
            }
            if (intBuffGhostMagicValue > mtBuffGhost_Body_MagicValue && mtBuffGhost_Body_MagicValue < 0)
            {
                ghostMagicValue = intBuffGhostMagicValue + mtBuffGhost_Body_MagicValue;
            }
            if (intBuffGhostMagicValue > mtBuffGhost_Body_MagicValue && mtBuffGhost_Body_MagicValue >= 0)
            {
                ghostMagicValue = intBuffGhostMagicValue;
            }
            if (intBuffGhostMagicValue == mtBuffGhost_Body_MagicValue)
            {
                ghostMagicValue = intBuffGhostMagicValue;
            }
            return ghostMagicValue;
        }

        private int bodyMagicValue;
        public int BodyMagic(int mtBuffGhost_Body_MagicValue, int CoBuffBodyMagicValue)
        {
            if (mtBuffGhost_Body_MagicValue > CoBuffBodyMagicValue && CoBuffBodyMagicValue < 0)
            {
                bodyMagicValue = mtBuffGhost_Body_MagicValue + CoBuffBodyMagicValue;
            }
            if (mtBuffGhost_Body_MagicValue > CoBuffBodyMagicValue && CoBuffBodyMagicValue >= 0)
            {
                bodyMagicValue = mtBuffGhost_Body_MagicValue;
            }
            if (CoBuffBodyMagicValue > mtBuffGhost_Body_MagicValue && mtBuffGhost_Body_MagicValue < 0)
            {
                bodyMagicValue = CoBuffBodyMagicValue + mtBuffGhost_Body_MagicValue;
            }
            if (CoBuffBodyMagicValue > mtBuffGhost_Body_MagicValue && mtBuffGhost_Body_MagicValue >= 0)
            {
                bodyMagicValue = CoBuffBodyMagicValue;
            }
            if (CoBuffBodyMagicValue == mtBuffGhost_Body_MagicValue)
            {
                bodyMagicValue = CoBuffBodyMagicValue;
            }
            return bodyMagicValue;
        }                  
    }
}
