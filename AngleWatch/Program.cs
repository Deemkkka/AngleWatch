using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngleWatch
{
    internal class Program
    {

        static TimeWatch timeWatch;
        static Angle angle;
        static void Main(string[] args)
        {
            Greet();
            CalculateAngle();
            PrintResult();
            Console.ReadLine();
        }

        static private void PrintResult()
        {
            var angleResult = CalculateResult();
            Console.WriteLine($"Время:{timeWatch.hour.ToString("00")}:{timeWatch.minute.ToString("00")}");
            Console.WriteLine($"Угол между часовой и минутной стрелкой: {angleResult.ToString("N1")} °C");
        }

        static private double CalculateResult()
        {
            double result = Math.Abs(angle.angleHour - angle.angleMinute);
            result = result > 180 ? result - 360 : result;
            return result;
        }

        private static void CalculateAngle()
        {
            Console.WriteLine("Введите время в формате 'hour:minute'");
            timeWatch = new TimeWatch();
            //входные данные

            while (true)
            {
                string inputTime = Console.ReadLine();
                string[] times = inputTime.Split(':');

                timeWatch.hour = Convert.ToInt32(times[0]);
                timeWatch.minute = Convert.ToInt32(times[1]);
                if (timeWatch.hour > 24 || timeWatch.hour < 0)
                {
                    Console.WriteLine("Неверное время, укажите часы корректно от 0 до 24");
                    continue;
                }
                if (timeWatch.minute > 60 || timeWatch.minute < 0)
                {
                    Console.WriteLine("Неверное время, укажите минуты корректно от 0 до 60");
                    continue;
                }
                
                break;

            }

            // расчет

            // Найдите угол минутной стрелки с 12 часов
            double minuteAngle = (360 / 60) * timeWatch.minute;

            //найти смещение часовой стрелки от времени
            double hourBias = timeWatch.hour % 12;
            hourBias += (1f / 60) * timeWatch.minute;

            // Найдите угол часовой стрелки с 12 часов.

            double hourAngle = (360 / 12) * hourBias;

            angle = new Angle(hourAngle, minuteAngle);        


        }



        private static void Greet()
        {
            Console.WriteLine("Расчет градуса угла между часовой стрелкой и минутной");
        }
    }
}
