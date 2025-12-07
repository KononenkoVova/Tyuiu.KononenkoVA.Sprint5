using Tyuiu.KononenkoVA.Sprint5.Task6.V22.Lib;

namespace Tyuiu.KononenkoVA.Sprint5.Task6.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Кононенко Владимир Андреевич | ИСПБ-25-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл, в котором есть набор символьных данных. Найти количество      *");
            Console.WriteLine("* удвоенных букв \"мм\" в заданной строке.                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string dir = Path.GetTempPath();
            string fileName = "InPutDataFileTask6V22.txt";
            string path = Path.Combine(dir, fileName);

            string fileContent = "Мама прислала телеграмму, там написано, что фильм называется 'Кримммм'";
            File.WriteAllText(path, fileContent);

            Console.WriteLine($"Путь к файлу: {path}");
            Console.WriteLine($"Содержимое файла: '{fileContent}'");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            try
            {
                int res = ds.LoadFromDataFile(path);
                Console.WriteLine($"Количество удвоенных букв \"мм\": {res}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}