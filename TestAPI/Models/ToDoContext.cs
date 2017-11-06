using Microsoft.EntityFrameworkCore;
namespace TestAPI.Models
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options)
            :base(options)
        {
        }
        public DbSet<ToDoItem> ToDoItems { get; set; }
    }
}
