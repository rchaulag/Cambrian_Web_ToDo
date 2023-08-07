using Microsoft.EntityFrameworkCore;
using Assignment_ToDoWebApp.ToDoWeb.Models.Entities;


namespace Assignment_ToDoWebApp.ToDoWeb.Data
{
    public class ToDoContext : DbContext
    {
        /// <summary>
        /// Passing ToDoContext into base class as options in the context constructor
        /// </summary>
        /// <param name="options"></param>
        public ToDoContext(DbContextOptions<ToDoContext> options)
        : base(options)
        { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDo>().HasKey(t => t.Id).HasName("PK_ToDoId");
        }

        //  public DbSet<ToDo> ToDos { get; set;}=null!; not preferred, but its ok
        public DbSet<ToDo> ToDos => Set<ToDo>(); // but set() returns null! anyways 


    }
}