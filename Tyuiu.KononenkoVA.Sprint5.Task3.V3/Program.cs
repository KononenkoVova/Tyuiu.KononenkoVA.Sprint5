using Tyuiu.KononenkoVA.Sprint5.Task3.V3.Lib;
using System;
using System.IO;

namespace Tyuiu.KononenkoVA.Sprint5.Task3.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Кононенко Владимир Андреевич | ИСПБ-25-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение y(x) = x * sqrt(x + 3)                                   *");
            Console.WriteLine("* Вычислить его значение при x = 3, результат сохранить в бинарный файл   *");
            Console.WriteLine("* OutPutFileTask3.bin и вывести на консоль. Округлить до трёх знаков      *");
            Console.WriteLine("* после запятой.                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 3;
            Console.WriteLine("x = " + x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = x * Math.Sqrt(x + 3);
            result = Math.Round(result, 3);

            Console.WriteLine($"Функция y(x) = x * sqrt(x + 3)");
            Console.WriteLine($"При x = {x}");
            Console.WriteLine($"Результат: y({x}) = {result}");

            string path = ds.SaveToFileTextData(x);
            Console.WriteLine($"\nРезультат сохранен в бинарный файл: {path}");

            Console.WriteLine("\nСодержимое бинарного файла:");
            try
            {
                using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
                {
                    double fileResult = reader.ReadDouble();
                    Console.WriteLine($"Прочитано из файла: {fileResult}");

                    if (Math.Abs(fileResult - result) < 0.0001)
                    {
                        Console.WriteLine("✓ Значение в файле соответствует вычисленному значению");
                    }
                    else
                    {
                        Console.WriteLine("✗ Значение в файле не соответствует вычисленному значению");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
            }

            Console.WriteLine("\nБайтовое представление файла:");
            byte[] fileBytes = File.ReadAllBytes(path);
            Console.WriteLine($"Размер файла: {fileBytes.Length} байт");
            Console.Write("Байты: ");
            foreach (byte b in fileBytes)
            {
                Console.Write($"{b:X2} ");
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}