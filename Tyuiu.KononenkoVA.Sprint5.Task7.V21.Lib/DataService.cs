using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KononenkoVA.Sprint5.Task7.V21.Lib
{
    public class DataService : ISprint5Task7V21
    {
        public string LoadDataAndSave(string path)
        {
            string fileContent = File.ReadAllText(path);

            string cleanedText = new string(fileContent.Where(c => !char.IsPunctuation(c)).ToArray());

            string outPath = path.Replace("InPutDataFileTask7V21.txt", "OutPutDataFileTask7V21.txt");

            File.WriteAllText(outPath, cleanedText);

            return outPath;
        }
    }
}