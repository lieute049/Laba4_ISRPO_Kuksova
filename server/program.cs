using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("приветствие");
        Console.WriteLine("Куксова Софья");
        Console.WriteLine("ИСП-243");
        Console.WriteLine($"Дата: {DateTime.Now}");
        Console.WriteLine();
        while (true)
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1 — ФИО");
            Console.WriteLine("2 — группа");
            Console.WriteLine("3 — дата");
            Console.WriteLine("4 — выход");
            Console.Write("Выбор: ");
            string choice = Console.ReadLine();
            if (choice == "1") Console.WriteLine("Куксова Софья");
            else if (choice == "2") Console.WriteLine("ИСП-243");
            else if (choice == "3") Console.WriteLine(DateTime.Now);
            else if (choice == "4") return;
            else Console.WriteLine("Неверный выбор");
            Console.WriteLine();
        }
    }
}