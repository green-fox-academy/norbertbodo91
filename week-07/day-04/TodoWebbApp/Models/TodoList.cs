using System;
using System.Collections.Generic;
using TodoWebbApp.Services;

namespace TodoWebbApp.Models
{
    public class TodoList : IToDo
    {
        public List<string> todo = new List<string>();

        public void Create(string task)
        {
            todo.Add(task); 
        }

        public void Delete(int taskIndex)
        {
            todo.RemoveAt(taskIndex);
        }
    }
}
