using System.Collections.Generic;
using System.Threading.Tasks;
using TodoLibrary.Models;

namespace TodoServices.Interfaces
{
    public interface ITodoService
    {
        void CreateTodo(Todo todoItem);
        void UpdateTodo(Todo todoItem);
        IEnumerable<Todo> GetAllTodos();
        Todo GetTodoById(int id);
        void DeleteTodo(int id);
    }
}
