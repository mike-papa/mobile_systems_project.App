using mobile_systems_project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobile_systems_project.Repository
{
    
    public class NumberRepository
    {
        private const string FileName = "numbers.txt";
        private static readonly string FilePath = Path.Combine(FileSystem.Current.AppDataDirectory, FileName);
        Number[] numbers = new Number[100];

        public Number[] GetNumbers()
        {
            if (File.Exists(FilePath))
            {
                int index = 0;
                using (var reader = new StreamReader(FilePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split('\t');
                        if (parts.Length == 2)
                        {
                            string numericValue = parts[0];
                            string textualValue = parts[1];

                            Number number = new Number
                            {
                                NumericValue = numericValue,
                                TextualValue = textualValue
                            };

                            numbers[index] = number;
                            index++;
                        }
                    }
                }
            }

            return numbers;
        }

        public void SaveNumbers(Number[] numbers)
        {
            using (var writer = new StreamWriter(FilePath))
            {
                foreach (var number in numbers)
                {
                    writer.WriteLine($"{number.NumericValue}\t{number.TextualValue}");
                }
            }
        }
    }
}
