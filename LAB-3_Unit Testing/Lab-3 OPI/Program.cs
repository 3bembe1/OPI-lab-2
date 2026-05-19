using System;
using System.Collections.Generic;

namespace Lab_3_OPI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                // Робота із завданням
                Task task1 = new Task(1, "Лабораторна робота", "ЗавершитиUML-модель");
                task1.Create();
                task1.Update("ЛР 03", "Реалізувати програмний модуль");
                task1.CompleteTask();

                // Робота з таймером
                Timer timer = new Timer(5);
                timer.Start();

                // Робота зі статистикою
                Statistics stats = new Statistics();
                stats.AddSession(25);
                stats.AddSession(30);
                stats.AddSession(45);
                stats.ShowStatistics();
            }
            catch (Exception ex)

            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}