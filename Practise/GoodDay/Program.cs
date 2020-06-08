using System;
using System.Globalization;

namespace GoodDay
{
    class Program
    {
        public static void Main(string[] args)
        {
            DateTime localDate = DateTime.Now;
            DateTime utcDate = DateTime.UtcNow;
            String[] cultureNames = { "en-US", "en-GB", "fr-FR", "de-DE", "re-RU" };

            foreach (var cultureName in cultureNames)
            {
                var culture = new CultureInfo(cultureName);
                Console.WriteLine("{0}:", culture.NativeName);
                Console.WriteLine(" Local date andd Time: {0}, {1:G}", localDate.ToString(culture), localDate.Kind cultureNativeName);
                

            }
        }
    }
}
