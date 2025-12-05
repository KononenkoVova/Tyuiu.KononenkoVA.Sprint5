using Tyuiu.KononenkoVA.Sprint5.Task1.V20.Lib;
using System;

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

            Console.WriteLine("Таблица значений функции:");
            Console.WriteLine("+----------+------------+");
            Console.WriteLine("|    x     |    f(x)    |");
            Console.WriteLine("+----------+------------+");

            for (int x = startValue; x <= stopValue; x += step)
            {
                try
                {
                    double denominator = Math.Sin(x) + 3;
                    double result;

                    if (Math.Abs(denominator) < 0.000001)
                    {
                        result = 0;
                    }
                    else
                    {
                        double numerator = 5 * x + 2.5;
                        double fraction = numerator / denominator;
                        result = fraction + 2 * x + Math.Cos(x);
                    }

                    result = Math.Round(result, 2);
                    Console.WriteLine($"| {x,8} | {result,10:F2} |");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine($"| {x,8} | {0,10:F2} |");
                }
            }

            Console.WriteLine("+----------+------------+");

            string path = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine();
            Console.WriteLine("Файл сохранен: " + path);

            Console.WriteLine("Содержимое файла:");
            string[] fileContent = File.ReadAllLines(path);
            foreach (string line in fileContent)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}