using Tyuiu.GaberkornEL.Sprint1.Task4.V27.Lib;
namespace Tyuiu.GaberkornEL.Sprint1.Task4.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил Габеркорн Егор Леонидович | АСОиУб 25-1";
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Спринт #1                                                                   *");
            Console.WriteLine("* Тема: Class Math                                                            *");
            Console.WriteLine("* Задание #4                                                                  *");
            Console.WriteLine("* Вариант #27                                                                 *");
            Console.WriteLine("* Выполнил Габеркорн Егор Леонидович | АСОиУб 25-1                            *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Условие                                                                     *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,     *");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                    *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Исходные данные:                                                            *");
            Console.WriteLine("*******************************************************************************");
            double x, y;
            Console.WriteLine("Введите первое значение : ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе значение : ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("* Результат:                                                                  *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine($"Результат = {ds.Calculate(x, y)}");
            Console.ReadKey();
        }
    }
}