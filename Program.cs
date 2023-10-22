using System;
using System.Collections.Generic;

public class Stack
{
    private List<int> elements = new List<int>();

    public void Push(int item)
    {
        elements.Add(item);
        Console.WriteLine("ok");
    }

    public void Pop()
    {
        if (elements.Count > 0)
        {
            Console.WriteLine(elements[elements.Count - 1]);
            elements.RemoveAt(elements.Count - 1);
        }
    }

    public void Back()
    {
        if (elements.Count > 0)
            Console.WriteLine(elements[elements.Count - 1]);
    }

    public void Size()
    {
        Console.WriteLine(elements.Count);
    }

    public void Clear()
    {
        elements.Clear();
        Console.WriteLine("ok");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Stack stack = new Stack();
        string command;

        while ((command = Console.ReadLine()) != "exit")
        {
            string[] parts = command.Split(' ');

            switch (parts[0])
            {
                case "push":
                    stack.Push(int.Parse(parts[1]));
                    break;
                case "pop":
                    stack.Pop();
                    break;
                case "back":
                    stack.Back();
                    break;
                case "size":
                    stack.Size();
                    break;
                case "clear":
                    stack.Clear();
                    break;
            }
        }

        Console.WriteLine("bye");
    }
}
