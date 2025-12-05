using tyuiu.cources.programming.interfaces.Sprint5;
using System.Text;

namespace Tyuiu.KononenkoVA.Sprint5.Task2.V22.Lib
{
    public class DataService : ISprint5Task2V22
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    int value = matrix[i, j];
                    int result = (value > 0) ? 1 : 0;

                    sb.Append(result);

                    if (j < columns - 1)
                    {
                        sb.Append(";");
                    }
                }

                if (i < rows - 1)
                {
                    sb.AppendLine();
                }
            }

            File.WriteAllText(path, sb.ToString());
            return path;
        }
    }
}