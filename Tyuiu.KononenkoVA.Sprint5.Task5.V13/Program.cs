using System;
using System.IO;
using System.Globalization;
using Tyuiu.KononenkoVA.Sprint5.Task5.V13.Lib;

namespace Tyuiu.KononenkoVA.Sprint5.Task5.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Кононенко Владимир Андреевич | ИСПБ-25-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найти среднее значение всех чисел в файле, которые находятся в          *");
            Console.WriteLine("* промежутке от -1.5 до 1.5. Округлить до трёх знаков.                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = Path.GetTempFileName();
            string content = "1.2 5.5 -0.5 -2.0 0.8 1.6 -1.6 1.0";
            File.WriteAllText(path, content);

            Console.WriteLine($"Путь к файлу: {path}");
            Console.WriteLine($"Данные в файле: {content}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            try
            {
                double res = ds.LoadFromDataFile(path);
                Console.WriteLine($"Среднее значение чисел от -1.5 до 1.5 = {res}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}