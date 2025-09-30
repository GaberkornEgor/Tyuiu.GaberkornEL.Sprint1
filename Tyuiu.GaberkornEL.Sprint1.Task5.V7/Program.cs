using Tyuiu.GaberkornEL.Sprint1.Task5.V7.Lib;
namespace Tyuiu.GaberkornEL.Sprint1.Task5.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил Габеркорн Егор Леонидович | АСОиУб 25-1";
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Спринт #1                                                                   *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                                  *");
            Console.WriteLine("* Задание #5                                                                  *");
            Console.WriteLine("* Вариант #7                                                                  *");
            Console.WriteLine("* Выполнил Габеркорн Егор Леонидович | АСОиУб 25-1                            *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Условие                                                                     *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:                        *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Исходные данные:                                                            *");
            Console.WriteLine("*******************************************************************************");
            double f;
            Console.WriteLine("Введите величину угла : ");
            f = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("* Результат:                                                                  *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine($"Количество часов прошедших от начала суток = {ds.AngleToHoursMinutes(f)}");
            Console.ReadKey();
        }
    }
}