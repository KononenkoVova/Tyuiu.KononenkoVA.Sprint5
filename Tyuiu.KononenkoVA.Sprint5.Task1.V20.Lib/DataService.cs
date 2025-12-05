using tyuiu.cources.programming.interfaces.Sprint5;
using System.Text;
using System.Globalization;

namespace Tyuiu.KononenkoVA.Sprint5.Task1.V20.Lib
{
    public class DataService : ISprint5Task1V20
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            StringBuilder sb = new StringBuilder();
            CultureInfo culture = CultureInfo.GetCultureInfo("ru-RU");

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Sin(x) + 3;
                double result;

                if (Math.Abs(denominator) < 0.000001)
                {
                    result = 0;
                }
                else
                {
                    double numerator = 5 * x + 2.5;
                    double fraction = numerator / denominator;
                    result = fraction + 2 * x + Math.Cos(x);
                }

                result = Math.Round(result, 2);

                string formattedResult = result.ToString(culture);
                if (formattedResult.EndsWith(",00"))
                {
                    formattedResult = formattedResult.Substring(0, formattedResult.Length - 3);
                }
                else if (formattedResult.EndsWith(",0"))
                {
                    formattedResult = formattedResult.Substring(0, formattedResult.Length - 2);
                }

                sb.Append(formattedResult);

                if (x < stopValue)
                {
                    sb.AppendLine();
                }
            }

            File.WriteAllText(path, sb.ToString());
            return path;
        }
    }
}