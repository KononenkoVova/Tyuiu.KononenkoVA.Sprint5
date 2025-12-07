using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KononenkoVA.Sprint5.Task6.V22.Lib
{
    public class DataService : ISprint5Task6V22
    {
        public int LoadFromDataFile(string path)
        {
            string fileContent = File.ReadAllText(path);

            int count = 0;
            string target = "мм";
            int targetLength = target.Length;

            for (int i = 0; i <= fileContent.Length - targetLength; i++)
            {
                string subString = fileContent.Substring(i, targetLength);

                if (subString.Equals(target, StringComparison.Ordinal))
                {
                    count++;
                }
            }

            return count;
        }
    }
}