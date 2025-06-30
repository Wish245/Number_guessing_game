using System;
using System.Collections.Generic;

class ToDO
{
   public static String addTask(Dictionary<int, String>Tasks, String new_task)
    {
        if (Tasks.Count == null)
        {
            Tasks.AddFirst(1, new_task);
            return new_task;
        }
        else
        {
            int new_key = traverseTasks(Tasks);
            Tasks.Add(new_key, new_task);
            return new_task;
        }
    }
    public static String removeTask(Dictionary<int, String> Tasks, int input)
    {
        if (Tasks.Count == null)
        {
            String Error = "List is empty";
            return Error;
        }
        else
        {
            if (Tasks.ContainsKey(input))
            {
                Tasks.Remove(input);
                return "Task is removed";
            }
        }
    }
    public static void traverseTasks(Dictionary<int, String> Tasks)
    {
        if (Tasks.Count == null)
        {
            return null;
        }
        else
        {
            int tail = 0;

            foreach(int i in Tasks)
            {
                if (Tasks[i+1] == null)
                {
                    tail = i;
                }
                else
                {
                    i++;
                }
            }
            return tail;
        }
    }
}