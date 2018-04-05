using System;
namespace TodoWebbApp.Services
{
    public interface IToDo
    {
        void Create(string task);
        void Delete(int taskIndex);

    }
}
