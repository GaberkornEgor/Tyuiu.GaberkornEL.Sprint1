using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.GaberkornEL.Sprint1.Task5.V7.Lib
{
    public class DataService : ISprint1Task5V7
    {
        public int AngleToHoursMinutes(double f)
        {
            return (int)Math.Round(f * 2.0 / 60.0, 1);
        }
    }
}