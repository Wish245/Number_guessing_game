using System;
using System.Collections.Generic;

class ToDO
{
   public static void addTask(Dictionary<int, String>Tasks, String new_task)
    {
        if (Tasks.Count == 0)
        {
            Tasks.Add(1, new_task);
            Console.WriteLine("New task added successfully, now work hard");
        }
        else
        {
            int new_key = traverseTasks(Tasks);
            Tasks.Add(new_key, new_task);
            Console.WriteLine("New task added successfully, now work hard");
        }
    }
    public static void removeTask(Dictionary<int, String> Tasks, int input)
    {
        if (Tasks.Count == 0)
        {
            Console.WriteLine("List is Empty");
        }
        else
        {
            if (Tasks.ContainsKey(input))
            {
                Tasks.Remove(input);
               Console.WriteLine("Task is removed");
            }
            else
            {
                Console.WriteLine("Task is not found");
            }
        }
    }
    public static void doneTask(Dictionary<int, String> Tasks, int input)
    {
        if (Tasks.Count == 0)
        {
           Console.WriteLine("List is empty");
        }
        else
        {
            if (Tasks.ContainsKey(input))
            {
                Tasks.Remove(input);
                Console.WriteLine("Task is done Great achievement!!!");
            }
        }
    }
    public static void updateTasks(Dictionary<int, String> Tasks, int input, String new_task)
    {
        if(Tasks.ContainsKey(input))
        {
            Tasks[input] = new_task;
            Console.WriteLine("Task updated successful");
        }
    }
    public static int traverseTasks(Dictionary<int, String> Tasks)
    {
        if (Tasks.Count == 0)
        {
            return -1;
        }
        else
        {
            int tail = 0;

            foreach(var item in Tasks)
            {
                if (item.Key > tail)
                {
                    tail = item.Key;
                }
            }
            return tail +1;
        }
    }
    public static void viewTasks(Dictionary<int, String> Tasks)
    {
        if(Tasks.Count == 0)
        {
            Console.WriteLine("List is empty");
        }
        else
        {
            Console.WriteLine("Let's view your Tasks");
            foreach (var item in Tasks)
            {
                Console.WriteLine($"[{item.Key}] {item.Value}");
            }
            Console.WriteLine("Welcome to the Main menue: ");
            Console.WriteLine("1. Add Task \n2. Remove Task");
            Console.WriteLine("3. Update Task\n4. Done Task");
            Console.WriteLine("s. Exit");
        }
    }
    public static void Main(String[] args)
    {
        Dictionary<int, String> Tasks = new Dictionary<int, string>();
        bool status = true;
        do
        {
            viewTasks(Tasks);
            if (Tasks.Count == 0)
            {
                Console.WriteLine("Welcome to the ToDo List App");
                Console.WriteLine("Your List is Empty");
                Console.WriteLine("For initial begeining add a task: ");
                String first_task = Console.ReadLine();
                addTask(Tasks, first_task);
                viewTasks(Tasks);
            }
            else
            {
                viewTasks(Tasks);
                Console.WriteLine("Choose a metod: ");
                String choise = Console.ReadLine();
                int.TryParse(choise, out int decision);

                if (decision == 1)
                {
                    Console.WriteLine("Write down the task: ");
                    String new_task = Console.ReadLine();
                    addTask(Tasks, new_task);
                    viewTasks(Tasks);
                }
                if (decision == 2)
                {
                    Console.WriteLine("Write the task number: ");
                    String dead_task = Console.ReadLine();
                    int.TryParse(dead_task, out int dead_decision);
                    removeTask(Tasks, dead_decision);
                    viewTasks(Tasks);
                }
                if (decision == 3)
                {
                    Console.WriteLine("Task number: ");
                    String updated_task_no = Console.ReadLine();
                    int.TryParse(updated_task_no, out int updated_decision);
                    Console.WriteLine("Write down the new task change: ");
                    String updated_task = Console.ReadLine();
                    updateTasks(Tasks, updated_decision, updated_task);
                    viewTasks(Tasks);
                }
                if (decision == 4)
                {
                    Console.WriteLine("Put the Task no: ");
                    String done_task = Console.ReadLine();
                    int.TryParse(done_task, out int done_decision);
                    doneTask(Tasks, done_decision);
                    Console.WriteLine("Good work buddy");
                    viewTasks(Tasks);
                }
                if (decision == 5)
                {
                    status = false;
                }
            }
        } while (status);
    }
}