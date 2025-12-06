using tyuiu.cources.programming.interfaces.Sprint5;
using System.Globalization;

namespace Tyuiu.KononenkoVA.Sprint5.Task4.V1.Lib
{
    public class DataService : ISprint5Task4V1
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path).Trim();

            double x = double.Parse(strX, CultureInfo.InvariantCulture);

            double denominator = Math.Cos(x) + x;

            if (Math.Abs(denominator) < 0.000001)
            {
                throw new DivideByZeroException("Знаменатель (cos(x) + x) равен нулю. Деление на ноль невозможно.");
            }

            double result = 1.0 / denominator - 4.12 * x;

            result = Math.Round(result, 3);

            return result;
        }
    }
}