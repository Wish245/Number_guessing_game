using System;
using System.Collections.Generic;

class ToDO
{
   public static String addTask(LinkedList<String>Tasks, String new_task)
    {
        if (Tasks.Count == 0)
        {
            Tasks.AddFirst(new_task);
            return new_task;
        }
        else
        {
            Tasks.AddLast(new_task);
            return new_task
        }
    }
    public static String removeTask(LinkedList<String> Tasks, int input)
    {
        if (Tasks.Count == 0)
        {
            String Error = "List is empty";
            return Error;
        }
        else
        {
            Tasks.
        }
    }
}