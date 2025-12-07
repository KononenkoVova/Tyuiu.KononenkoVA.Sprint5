using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KononenkoVA.Sprint5.Task5.V13.Lib
{
    public class DataService : ISprint5Task5V13
    {
        public double LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Файл не найден по пути: {path}");
            }

            double sum = 0;
            int count = 0;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] strNumbers = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string strNum in strNumbers)
                    {
                        if (double.TryParse(strNum, NumberStyles.Any, CultureInfo.InvariantCulture, out double value))
                        {
                            if (value >= -1.5 && value <= 1.5)
                            {
                                sum += value;
                                count++;
                            }
                        }
                    }
                }
            }

            if (count == 0) return 0;

            double average = sum / count;

            return Math.Round(average, 3);
        }
    }
}