using tyuiu.cources.programming.interfaces.Sprint5;
using System.Text;

namespace Tyuiu.KononenkoVA.Sprint5.Task1.V20.Lib
{
    public class DataService : ISprint5Task1V20
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            StringBuilder sb = new StringBuilder();

            for (int x = startValue; x <= stopValue; x++)
            {
                try
                {
                    double denominator = Math.Sin(x) + 3;

                    if (Math.Abs(denominator) < 0.000001) 
                    {
                        sb.AppendLine("0.00");
                    }
                    else
                    {
                        double numerator = 5 * x + 2.5;
                        double fraction = numerator / denominator;
                        double result = fraction + 2 * x + Math.Cos(x);

                        result = Math.Round(result, 2);
                        sb.AppendLine(result.ToString("F2"));
                    }
                }
                catch (DivideByZeroException)
                {
                    sb.AppendLine("0.00");
                }
            }

            File.WriteAllText(path, sb.ToString());
            return path;
        }
    }
}