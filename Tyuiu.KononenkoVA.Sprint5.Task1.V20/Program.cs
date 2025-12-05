using Tyuiu.KononenkoVA.Sprint5.Task1.V20.Lib;
using System;
using System.Globalization;
using System.IO;

namespace Tyuiu.KononenkoVA.Sprint5.Task1.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Кононенко Владимир Андреевич | ИСПБ-25-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция, F(x) = (5x + 2.5)/(sin(x) + 3) + 2x + cos(x)              *");
            Console.WriteLine("* Произвести табулирование f(x) на заданном диапазоне [-5; 5] с шагом 1.  *");
            Console.WriteLine("* Произвести проверку деления на ноль. При делении на ноль вернуть        *");
            Console.WriteLine("* значение 0. Результат сохранить в текстовый файл OutPutFileTask1.txt    *");
            Console.WriteLine("* и вывести на консоль в таблицу. Значения округлить до двух знаков       *");
            Console.WriteLine("* после запятой.                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;
            int step = 1;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);
            Console.WriteLine("Шаг = " + step);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string path = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("Содержимое файла:");
            string fileContent = File.ReadAllText(path);
            Console.WriteLine(fileContent);

            Console.WriteLine("\nТаблица значений функции:");
            Console.WriteLine("+----------+------------+");
            Console.WriteLine("|    x     |    f(x)    |");
            Console.WriteLine("+----------+------------+");

            CultureInfo culture = CultureInfo.GetCultureInfo("ru-RU");
            string[] lines = fileContent.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

            for (int i = 0, x = startValue; x <= stopValue; x += step, i++)
            {
                string value = lines[i];
                Console.WriteLine($"| {x,8} | {value,10} |");
            }

            Console.WriteLine("+----------+------------+");

            Console.WriteLine("\nФайл сохранен: " + path);
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}