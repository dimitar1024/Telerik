using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.AfterTime
{
    class AfterTime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter date in format \"day.month.year hour:minute:second\"");
            DateTime date = DateTime.Parse(Console.ReadLine());
            date = date.AddHours(+6);
            date = date.AddMinutes(+30);
            string dayOfWeek = date.DayOfWeek.ToString();
            switch (dayOfWeek)
            {
                case "Monday": dayOfWeek = "Понеделник"; break;
                case "Tuesday": dayOfWeek = "Вторник"; break;
                case "Wednesday": dayOfWeek = "Сряда"; break;
                case "Thursday": dayOfWeek = "Четвъртък"; break;
                case "Friday": dayOfWeek = "Петък"; break;
                case "Saturday": dayOfWeek = "Събота"; break;
                case "Sunday": dayOfWeek = "Неделя"; break;
                default:
                    break;
            }
            Console.WriteLine(date + " " + dayOfWeek);
        }
    }
}
