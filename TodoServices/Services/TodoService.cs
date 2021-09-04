using MediatRApi.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoLibrary.Models;
using TodoServices.Interfaces;

namespace TodoServices.Services
{
    public class TodoService : ITodoService
    {
        private readonly TodoContext _context;

        public TodoService(TodoContext context)
        {
            _context = context;
        }

        public void CreateTodo(Todo todoItem)
        {
            _context.Todos.Add(todoItem);
            _context.SaveChanges();
        }

        public void DeleteTodo(int id)
        {
            var entityToDelete =  GetTodoById(id);
            _context.Todos.Remove(entityToDelete);
             _context.SaveChanges();
        }

        public IEnumerable<Todo> GetAllTodos()
        {
            return _context.Todos
                .ToList();
        }

        public Todo GetTodoById(int id)
        {
            return   _context.Todos
                .FirstOrDefault(x => x.Id == id);
        }

        public void UpdateTodo(Todo todoItem)
        {
            _context.ChangeTracker.Clear();
            _context.Todos.Update(todoItem);
            _context.SaveChanges();
        }
    }
}
