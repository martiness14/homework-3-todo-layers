using System;

namespace TodoFlat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskRepository repository = new TaskRepository();
            TaskService service = new TaskService(repository);

            string choice = "";
            while (choice != "0")
            {
                Console.WriteLine();
                Console.WriteLine("1 - незавършени задачи");
                Console.WriteLine("2 - нова задача");
                Console.WriteLine("3 - отбелязване като завършена");
                Console.WriteLine("0 - изход");
                Console.Write("Избор: ");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    foreach (TaskItem task in service.GetPending())
                    {
                        Console.WriteLine(task.Id + " " + task.Title);
                    }
                }
                else if (choice == "2")
                {
                    Console.Write("Заглавие: ");
                    string title = Console.ReadLine();
                    if (service.TryAdd(title))
                    {
                        Console.WriteLine("Задачата е добавена.");
                    }
                    else
                    {
                        Console.WriteLine("Празно заглавие.");
                    }
                }
                else if (choice == "3")
                {
                    Console.Write("Id: ");
                    string tekst = Console.ReadLine();
                    int id = int.Parse(tekst);
                    if (service.TryComplete(id))
                    {
                        Console.WriteLine("Задачата е завършена.");
                    }
                    else
                    {
                        Console.WriteLine("Действието е отказано.");
                    }
                }
            }
        }
    }
}
