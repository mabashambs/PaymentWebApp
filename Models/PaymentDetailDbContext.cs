using Microsoft.EntityFrameworkCore;

namespace PaymentWebApp.Models
{
    public class PaymentDetailDbContext : DbContext
    {
        public PaymentDetailDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<PaymentDetail> PaymentDetails { get; set; }
    }
}
