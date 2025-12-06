using Tyuiu.KononenkoVA.Sprint5.Task4.V1.Lib;

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

            string path = @"C:\DataSprint5\InPutDataFileTask4V1.txt";

            if (!File.Exists(path))
            {
                path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "InPutDataFileTask4V1.txt");

                if (!File.Exists(path))
                {
                    Console.WriteLine($"Файл не найден по пути: {path}");
                    Console.WriteLine("Создаем тестовый файл с значением 1.5");

                    string customPath = @"C:\DataSprint5\";
                    if (!Directory.Exists(customPath))
                    {
                        Directory.CreateDirectory(customPath);
                    }

                    path = Path.Combine(customPath, "InPutDataFileTask4V1.txt");
                    File.WriteAllText(path, "1.5");
                }
            }

            Console.WriteLine($"Путь к файлу: {path}");

            try
            {
                string fileContent = File.ReadAllText(path);
                Console.WriteLine($"Содержимое файла: {fileContent}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            try
            {
                double result = ds.LoadFromDataFile(path);

                string strX = File.ReadAllText(path);
                double x = Convert.ToDouble(strX);

                Console.WriteLine($"Формула: y = 1/(cos(x) + x) - 4.12x");
                Console.WriteLine($"Значение x из файла: {x}");
                Console.WriteLine($"Результат вычисления: y = {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Файл должен содержать числовое значение.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Ошибка ввода-вывода: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}