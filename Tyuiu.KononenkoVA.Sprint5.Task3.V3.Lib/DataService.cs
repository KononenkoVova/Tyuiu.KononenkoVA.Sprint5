using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KononenkoVA.Sprint5.Task3.V3.Lib
{
    public class DataService : ISprint5Task3V3
    {
        public string SaveToFileTextData(int x)
        {
            double result = x * Math.Sqrt(x + 3);

            result = Math.Round(result, 3);

            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                writer.Write(result);
            }

            return path;
        }
    }
}