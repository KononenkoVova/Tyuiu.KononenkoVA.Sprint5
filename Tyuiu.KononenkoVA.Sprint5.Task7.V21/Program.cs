using Tyuiu.KononenkoVA.Sprint5.Task7.V21.Lib;

namespace Tyuiu.KononenkoVA.Sprint5.Task7.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление операции сохранения в файл при работе в C#             *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Кононенко Владимир Андреевич | ИСПБ-25-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл, в котором есть набор символьных данных. Удалить все знаки     *");
            Console.WriteLine("* препинания из файла. Полученный результат сохранить в файл.             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string dir = Path.GetTempPath();
            string inFileName = "InPutDataFileTask7V21.txt";
            string inPath = Path.Combine(dir, inFileName);

            string initialContent = "Привет! Как твои дела? Сегодня отличный день, не так ли?";
            File.WriteAllText(inPath, initialContent);

            Console.WriteLine($"Путь к входному файлу: {inPath}");
            Console.WriteLine($"Исходное содержимое: \"{initialContent}\"");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            try
            {
                string outPath = ds.LoadDataAndSave(inPath);

                string resultContent = File.ReadAllText(outPath);

                Console.WriteLine($"Файл обработан и сохранен по пути:");
                Console.WriteLine(outPath);
                Console.WriteLine("---");
                Console.WriteLine($"Содержимое выходного файла:");
                Console.WriteLine($"\"{resultContent}\"");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}