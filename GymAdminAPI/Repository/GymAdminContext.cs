using Microsoft.EntityFrameworkCore;
using Repository.Models;

namespace Repository
{
    public class GymAdminContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerPayment> CustomerPayments { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Visit> Visits { get; set; }

        public GymAdminContext(DbContextOptions<GymAdminContext> options) : base(options)
        {

        }
    }
}
