using mobile_systems_project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobile_systems_project.Seeder
{
    public class Seeder
    {
        private const string FileName = "numbers.txt";
        private static readonly string FilePath = Path.Combine(FileSystem.Current.AppDataDirectory, FileName);

        public static void SeedData()
        {
            if (!File.Exists(FilePath))
            {
                using (var writer = new StreamWriter(FilePath))
                {
                    foreach (var item in GetData())
                    {
                        writer.WriteLine($"{item.NumericValue}\t{item.TextualValue}");
                    }
                }
            }
        }

        private static Number[] GetData()
        {
            return new Number[]
            {
        new Number { NumericValue = "00", TextualValue = "drzewo" },
        new Number { NumericValue = "01", TextualValue = "samochód" },
        new Number { NumericValue = "02", TextualValue = "superman" },
        new Number { NumericValue = "03", TextualValue = "ognisko" },
        new Number { NumericValue = "04", TextualValue = "Vader" },
        new Number { NumericValue = "05", TextualValue = "żelazko" },
        new Number { NumericValue = "06", TextualValue = "miecz" },
        new Number { NumericValue = "07", TextualValue = "korona" },
        new Number { NumericValue = "08", TextualValue = "pies" },
        new Number { NumericValue = "09", TextualValue = "zombie" },
        new Number { NumericValue = "10", TextualValue = "huśtawka" },
        new Number { NumericValue = "11", TextualValue = "żyrandol" },
        new Number { NumericValue = "12", TextualValue = "księżyc" },
        new Number { NumericValue = "13", TextualValue = "smartphone" },
        new Number { NumericValue = "14", TextualValue = "Xardas" },
        new Number { NumericValue = "15", TextualValue = "niedźwiedź" },
        new Number { NumericValue = "16", TextualValue = "łańcuch" },
        new Number { NumericValue = "17", TextualValue = "kamień" },
        new Number { NumericValue = "18", TextualValue = "stół" },
        new Number { NumericValue = "19", TextualValue = "patelnia" },
        new Number { NumericValue = "20", TextualValue = "ksiądz" },
        new Number { NumericValue = "21", TextualValue = "paprotka" },
        new Number { NumericValue = "22", TextualValue = "rycerz" },
        new Number { NumericValue = "23", TextualValue = "pająk" },
        new Number { NumericValue = "24", TextualValue = "pistolet" },
        new Number { NumericValue = "25", TextualValue = "papierowa gazeta" },
        new Number { NumericValue = "26", TextualValue = "Arnold Schwarzenegger" },
        new Number { NumericValue = "27", TextualValue = "Zdjęcie" },
        new Number { NumericValue = "28", TextualValue = "Latający dywan" },
        new Number { NumericValue = "29", TextualValue = "Ośmiornica" },
        new Number { NumericValue = "30", TextualValue = "Hulajnoga" },
        new Number { NumericValue = "31", TextualValue = "Hantel" },
        new Number { NumericValue = "32", TextualValue = "Mapa" },
        new Number { NumericValue = "33", TextualValue = "Święty Mikołaj" },
        new Number { NumericValue = "34", TextualValue = "Helikopter" },
        new Number { NumericValue = "35", TextualValue = "Kaktus" },
        new Number { NumericValue = "36", TextualValue = "Judoga" },
        new Number { NumericValue = "37", TextualValue = "Motyl" },
        new Number { NumericValue = "38", TextualValue = "Lawa" },
        new Number { NumericValue = "39", TextualValue = "Komar" },
        new Number { NumericValue = "40", TextualValue = "Bocian" },
        new Number { NumericValue = "41", TextualValue = "laptop" },
        new Number { NumericValue = "42", TextualValue = "piłka" },
        new Number { NumericValue = "43", TextualValue = "dżdżownica" },
        new Number { NumericValue = "44", TextualValue = "jajko" },
        new Number { NumericValue = "45", TextualValue = "perfum" },
        new Number { NumericValue = "46", TextualValue = "basen (na ogródek)" },
        new Number { NumericValue = "47", TextualValue = "Shake białkowy (bidon)" },
        new Number { NumericValue = "48", TextualValue = "kawa w kubku" },
        new Number { NumericValue = "49", TextualValue = "Shrek" },
        new Number { NumericValue = "50", TextualValue = "książka" },
        new Number { NumericValue = "51", TextualValue = "czołg" },
        new Number { NumericValue = "52", TextualValue = "motocykl" },
        new Number { NumericValue = "53", TextualValue = "szympans" },
        new Number { NumericValue = "54", TextualValue = "młotek" },
        new Number { NumericValue = "55", TextualValue = "termometr" },
        new Number { NumericValue = "56", TextualValue = "skarpetka" },
        new Number { NumericValue = "57", TextualValue = "mojżesz" },
        new Number { NumericValue = "58", TextualValue = "paleta" },
        new Number { NumericValue = "59", TextualValue = "strona internetowa" },
        new Number { NumericValue = "60", TextualValue = "saturn" },
        new Number { NumericValue = "61", TextualValue = "kalosze" },
        new Number { NumericValue = "62", TextualValue = "panel słoneczny" },
        new Number { NumericValue = "63", TextualValue = "kapelusz" },
        new Number { NumericValue = "64", TextualValue = "dr house" },
        new Number { NumericValue = "65", TextualValue = "garfield" },
        new Number { NumericValue = "66", TextualValue = "samolot" },
        new Number { NumericValue = "67", TextualValue = "portfel" },
        new Number { NumericValue = "68", TextualValue = "mona lisa" },
        new Number { NumericValue = "69", TextualValue = "autobus" },
        new Number { NumericValue = "70", TextualValue = "szkielet (żywy, straszny)" },
        new Number { NumericValue = "71", TextualValue = "praca licencjacka" },
        new Number { NumericValue = "72", TextualValue = "steve z minecrafta" },
        new Number { NumericValue = "73", TextualValue = "statek" },
        new Number { NumericValue = "74", TextualValue = "gejzer" },
        new Number { NumericValue = "75", TextualValue = "gitara" },
        new Number { NumericValue = "76", TextualValue = "cytryna" },
        new Number { NumericValue = "77", TextualValue = "supeł" },
        new Number { NumericValue = "78", TextualValue = "hiob" },
        new Number { NumericValue = "79", TextualValue = "tabletki" },
        new Number { NumericValue = "80", TextualValue = "pasztet" },
        new Number { NumericValue = "81", TextualValue = "fajerwerki" },
        new Number { NumericValue = "82", TextualValue = "gargulec" },
        new Number { NumericValue = "83", TextualValue = "rower" },
        new Number { NumericValue = "84", TextualValue = "słoń" },
        new Number { NumericValue = "85", TextualValue = "spadochron" },
        new Number { NumericValue = "86", TextualValue = "choinka" },
        new Number { NumericValue = "87", TextualValue = "matrioszka" },
        new Number { NumericValue = "88", TextualValue = "ryba" },
        new Number { NumericValue = "89", TextualValue = "gumowa kaczka" },
        new Number { NumericValue = "90", TextualValue = "garnitur" },
        new Number { NumericValue = "91", TextualValue = "Budda" },
        new Number { NumericValue = "92", TextualValue = "Flaga" },
        new Number { NumericValue = "93", TextualValue = "Słoik" },
        new Number { NumericValue = "94", TextualValue = "Spodnie" },
        new Number { NumericValue = "95", TextualValue = "Tron" },
        new Number { NumericValue = "96", TextualValue = "Żaba" },
        new Number { NumericValue = "97", TextualValue = "Banan" },
        new Number { NumericValue = "98", TextualValue = "Popcorn" },
        new Number { NumericValue = "99", TextualValue = "husarz" }
            };
        }
    }
}
