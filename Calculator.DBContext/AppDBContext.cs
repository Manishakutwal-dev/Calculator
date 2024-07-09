using Calculator.Main.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Calculator.DBContext
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
        : base(options)
        {
            //List<string> pd = Database.GetPendingMigrations();
            ////if (Database.GetPendingMigrations())
            ////{
            ////if(Database.auto)
            //  //Database.EnsureCreated();
            ////}
            ///
            Database.EnsureCreated();
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseInMemoryDatabase(databaseName: "CalculatorDB");

        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<User> userList = new List<User>
            {
                new User{Id=1,FirstName="Manisha", LastName="Kutwal", Email="manishaakutwal@gmail.com",Password="Manisha@05"}
            };
            modelBuilder.Entity<User>().HasData(userList);
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<CalculatorHistory> CalculatorHistories { get; set; }
    }
}
