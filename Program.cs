using System;

class Program
{
    delegate string dayDelegate();
    static void Main(string[] args)
    {
        string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
        int dayIndex = 0;

        dayDelegate getNextDay = () =>
        {
            string currentDay = days[dayIndex];

            dayIndex = (dayIndex + 1) % 7;
            return currentDay;
        };

        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine(getNextDay());
        }
    }
}

