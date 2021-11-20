using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IstrateBogdan_Laborator5.Models;
using Microsoft.Extensions.DependencyInjection;

namespace IstrateBogdan_Laborator5.Models
{
    public class ExpenseContext : DbContext
    {
        public ExpenseContext(DbContextOptions<ExpenseContext> options) : base(options)
        {
        }
        public DbSet<Expense> Expense { get; set; }
        public DbSet<ExpenseDTO> ExpenseDTO { get; set; }

    }
}
