namespace Tyuiu.GaberkornEL.Sprint1.Task2.V15;

using Tyuiu.GaberkornEL.Sprint1.Task2.V15.Lib;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Габеркорн Егор Леонидович | АСОиУб 25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Арифмитические операторы С#                                       *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #15                                                             *");
        Console.WriteLine("* Выполнил: Габеркорн Егор Леонидович | АСОиУб 25-2                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int x;

        Console.WriteLine("введите значение x (длину стороны куба):");
        x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Объем куба со стороной x = " + ds.CalculateCubeVolume(x));

        Console.ReadKey();


    }
}