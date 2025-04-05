using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ExpensesApp.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<ExpenseModel> Expenses { get; set; } = null!;

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = C:\\Users\\Студент\\Desktop\\Волков КС\\ExpensesApp\\ExpensesApp\\ExpensesAppDB.db");
        }
    }
}
