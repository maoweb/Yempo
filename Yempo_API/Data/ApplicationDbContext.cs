using Microsoft.EntityFrameworkCore;
using Yempo_API.Models;

namespace Yempo_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Person>().HasData(
                new Person
                {
                    Id = 1,
                    Firstname = "John",
                    Lastname = "Doe",
                    Age = 38
                },
                new Person
                {
                    Id = 2,
                    Firstname = "Jenny",
                    Lastname = "Doe",
                    Age = 24
                },
                new Person
                {
                    Id = 3,
                    Firstname = "Mark",
                    Lastname = "Smith",
                    Age = 22
                });

        }
    }
}
