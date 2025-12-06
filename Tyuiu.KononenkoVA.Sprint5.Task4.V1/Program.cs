using Tyuiu.KononenkoVA.Sprint5.Task4.V1.Lib;
using System;
using System.IO;
using System.Globalization;

namespace Tyuiu.KononenkoVA.Sprint5.Task4.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Кононенко Владимир Андреевич | ИСПБ-25-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл, в котором есть вещественное значение. Прочитать значение      *");
            Console.WriteLine("* из файла и подставить вместо X в формуле y = 1/(cos(x) + x) - 4.12x     *");
            Console.WriteLine("* Вычислить значение по формуле (Полученное значение округлить до трёх    *");
            Console.WriteLine("* знаков после запятой) и вернуть полученный результат на консоль.        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"/app/data/AssesmentData/C#/Sprint5Task4/InPutDataFileTask4V1.txt";

            Console.WriteLine($"Путь к файлу: {path}");

            try
            {
                string fileContent = File.ReadAllText(path).Trim();
                Console.WriteLine($"Содержимое файла: '{fileContent}'");

                Console.WriteLine($"Длина строки: {fileContent.Length}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
                Console.WriteLine($"Стек вызовов: {ex.StackTrace}");
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            try
            {
                double result = ds.LoadFromDataFile(path);

                string strX = File.ReadAllText(path).Trim();
                double x = double.Parse(strX, CultureInfo.InvariantCulture);

                Console.WriteLine($"Формула: y = 1/(cos(x) + x) - 4.12x");
                Console.WriteLine($"Значение x из файла: {x}");
                Console.WriteLine($"Результат вычисления: y = {result}");

                double cosX = Math.Cos(x);
                double denominator = cosX + x;
                double fraction = 1.0 / denominator;
                double product = 4.12 * x;

                Console.WriteLine($"\nПромежуточные вычисления:");
                Console.WriteLine($"cos({x}) = {cosX}");
                Console.WriteLine($"cos({x}) + {x} = {denominator}");
                Console.WriteLine($"1 / {denominator} = {fraction}");
                Console.WriteLine($"4.12 * {x} = {product}");
                Console.WriteLine($"{fraction} - {product} = {result}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Ошибка формата: {ex.Message}");
                Console.WriteLine($"Убедитесь, что файл содержит число в правильном формате (например: 1.05)");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Ошибка ввода-вывода: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
                Console.WriteLine($"Тип ошибки: {ex.GetType()}");
                Console.WriteLine($"Стек вызовов: {ex.StackTrace}");
            }

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}