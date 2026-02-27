using System;

namespace Lab01_Variant15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ЛАБОРАТОРНАЯ РАБОТА №1. ВАРИАНТ 15 ===");
            Console.WriteLine("Программа для преобразования минут в различные форматы времени\n");

            // БАЗОВАЯ ЗАДАЧА (минуты → часы и минуты)
            Console.WriteLine("--- Задача 1: Перевод минут в часы и минуты ---");

            // Ввод данных для задачи 1
            Console.Write("Введите количество минут: ");
            int totalMinutes1 = int.Parse(Console.ReadLine());

            // Обработка для задачи 1
            int hours1 = totalMinutes1 / 60;      // Часы
            int minutes1 = totalMinutes1 % 60;    // Оставшиеся минуты

            // Вывод результатов для задачи 1
            Console.WriteLine($"\nРезультат:");
            Console.WriteLine($"{totalMinutes1} минут = {hours1} ч {minutes1} мин");

            Console.WriteLine("\n" + new string('-', 50) + "\n");

            // СРЕДНЯЯ ЗАДАЧА (минуты → сутки, часы, минуты)
            Console.WriteLine("--- Задача 2: Перевод минут в сутки, часы и минуты ---");

            // Ввод данных для задачи 2
            Console.Write("Введите количество минут: ");
            int totalMinutes2 = int.Parse(Console.ReadLine());

            // Обработка для задачи 2
            const int minutesPerDay = 24 * 60; // Константа: минут в сутках (1440)

            int days2 = totalMinutes2 / minutesPerDay;          // Сутки
            int remainingMinutes = totalMinutes2 % minutesPerDay; // Оставшиеся минуты после вычета суток
            int hours2 = remainingMinutes / 60;                 // Часы из оставшихся минут
            int minutes2 = remainingMinutes % 60;               // Оставшиеся минуты

            // Вывод результатов для задачи 2
            Console.WriteLine($"\nДетали расчета:");
            Console.WriteLine($"Всего минут: {totalMinutes2}");
            Console.WriteLine($"Минут в сутках: {minutesPerDay}");
            Console.WriteLine($"Полных суток: {days2}");
            Console.WriteLine($"Оставшихся минут после суток: {remainingMinutes}");
            Console.WriteLine($"Часов из оставшихся минут: {hours2}");
            Console.WriteLine($"Минут из оставшихся минут: {minutes2}");

            Console.WriteLine($"\nИтоговый результат:");

            // Форматированный вывод с правильными окончаниями
            string daysText = GetDaysText(days2);
            string hoursText = GetHoursText(hours2);
            string minutesText = GetMinutesText(minutes2);

            Console.WriteLine($"{totalMinutes2} минут = {days2} {daysText} {hours2} {hoursText} {minutes2} {minutesText}");

            // Альтернативный компактный вывод
            Console.WriteLine($"\nКомпактный формат:");
            Console.WriteLine($"{totalMinutes2} минут = {days2} сут {hours2} ч {minutes2} мин");

            // Задержка перед закрытием окна
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }

        // Вспомогательные методы для правильных окончаний
        static string GetDaysText(int days)
        {
            if (days == 1) return "сутки";
            if (days >= 2 && days <= 4) return "сутки";
            return "суток";
        }

        static string GetHoursText(int hours)
        {
            if (hours == 1) return "час";
            if (hours >= 2 && hours <= 4) return "часа";
            return "часов";
        }

        static string GetMinutesText(int minutes)
        {
            if (minutes == 1) return "минута";
            if (minutes >= 2 && minutes <= 4) return "минуты";
            return "минут";
        }
    }
}
