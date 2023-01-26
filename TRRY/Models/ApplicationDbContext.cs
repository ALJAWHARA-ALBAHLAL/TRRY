using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using System.Transactions;
using TRRY.Models;


namespace TRRY.Models
{
    //This context class typically includes DbSet<TEntity> properties for each entity in the model
    public class ApplicationDbContext : DbContext
    {
        //DbContextOptions manage connection
        // It is the connection between our entity classes and the database.
        // The DBContext is responsible for the database interactions like querying the database and loading the data into memory as entity.
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Order { get; set; }
    }
}
