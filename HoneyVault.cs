using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    static class HoneyVault
    {
        public const float NECTAR_CONVERSION_RATIO = .19f;
        public const float LOW_LEVEL_WARNING = 10;
        private static float honey = 25f;
        private static float nectar = 100f;

        public static void CollectNectar(float amount)
        {
            if (amount > 0f)
            {
                nectar += amount;
            }
        }

        public static void ConvertNectarToHoney(float amount)
        {
            float nectarToConvert = amount;
            if (nectarToConvert > nectar)
            {
                nectar = nectarToConvert;
                nectar -= nectarToConvert;
                honey += nectarToConvert * NECTAR_CONVERSION_RATIO;
            }
        }

        public static bool ConsumeHoney(float amount)
        {
            if (honey >= amount)
            {
                honey -= amount;
                return true;
            }
            return false;
        }

        public static string StatusReport
        {
            get
            {
                string status = $"Jednostki miodu: {honey:0.0}\n" +
                                $"Jednostki nektaru: {nectar:0.0}";
                string warnings = "";
                if (honey < LOW_LEVEL_WARNING)
                {
                    warnings += "\nNiski poziom miodu - dodaj producentkę miodu";
                }
                if (nectar < LOW_LEVEL_WARNING)
                {
                    warnings += "\nNiski poziom nektaru - dodaj zbieraczkę nektaru";
                }
                return status + warnings;
            }
        }
    }
}
