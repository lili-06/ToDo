using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> todos = new List<string>(); // lista todo
        string input;
        do
        {
            Console.WriteLine("Enter a command (add/remove/list/exit):");
            input = Console.ReadLine().ToLower(); 
            switch (input)
            {
                case "add":
                    Console.WriteLine("Enter a todo:");
                    string todo = Console.ReadLine();
                    todos.Add(todo); // dodaje todo do listy
                    break;
                case "remove":
                    Console.WriteLine("Enter the index of the todo to remove:");
                    int index = int.Parse(Console.ReadLine()); 
                    if (index >= 0 && index < todos.Count)
                    {
                        todos.RemoveAt(index); // usuwa todo z danym indeksem
                    }
                    else
                    {
                        Console.WriteLine("Invalid index!");
                    }
                    break;
                case "list":
                    Console.WriteLine("Todos:");
                    for (int i = 0; i < todos.Count; i++)
                    {
                        Console.WriteLine($"{i}: {todos[i]}"); // wyswietla kazde todo z indeksem
                    }
                    break;
                case "exit":
                    Console.WriteLine("Goodbye");
                    break;
                default:
                    Console.WriteLine("Invalid command");
                    break;
            }
        } while (input != "exit");
    }
}
