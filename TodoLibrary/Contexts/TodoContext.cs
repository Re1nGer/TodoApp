using Microsoft.EntityFrameworkCore;
using TodoLibrary.Models;

namespace MediatRApi.Data
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<Todo> Todos { get; set; }
    }
}
