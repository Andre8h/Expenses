using Microsoft.AspNetCore.Routing.Matching;
using Microsoft.EntityFrameworkCore;
using static System.Collections.Specialized.BitVector32;

namespace Expenses.Models
{
    public class expensesDbcontext : DbContext
    {
            public expensesDbcontext(DbContextOptions<expensesDbcontext> options) : base(options)
            {

            }
            public DbSet<Categories> categories { get; set; }
            public DbSet<Expense> expenses { get; set; }
            public DbSet<PaymentMethods> PaymentMethods { get; set; }


    }
}
