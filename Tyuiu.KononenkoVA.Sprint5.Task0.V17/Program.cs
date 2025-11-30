using Tyuiu.KononenkoVA.Sprint5.Task0.V17.Lib;
using System;

namespace Tyuiu.KononenkoVA.Sprint5.Task0.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Кононенко Владимир Андреевич | ИСПБ-25-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение F(x) = 2.4x^3 + 0.4x^2 - 1.4x + 4.1, вычислить его       *");
            Console.WriteLine("* значение при x = 3, результат сохранить в текстовый файл               *");
            Console.WriteLine("* OutPutFileTask0.txt и вывести на консоль. Округлить до трёх знаков     *");
            Console.WriteLine("* после запятой.                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 3;
            Console.WriteLine("x = " + x);

            double result = 2.4 * Math.Pow(x, 3) + 0.4 * Math.Pow(x, 2) - 1.4 * x + 4.1;
            result = Math.Round(result, 3);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string path = ds.SaveToFileTextData(x);

            Console.WriteLine("Функция F(x) = 2.4x^3 + 0.4x^2 - 1.4x + 4.1");
            Console.WriteLine("При x = " + x);
            Console.WriteLine("Результат: " + result);
            Console.WriteLine("Файл сохранен: " + path);

            string fileContent = File.ReadAllText(path);
            Console.WriteLine("Содержимое файла: " + fileContent);

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}