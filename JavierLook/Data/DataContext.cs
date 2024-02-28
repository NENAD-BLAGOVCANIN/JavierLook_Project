using JavierLook.Models;
using Microsoft.EntityFrameworkCore;

namespace JavierLook.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Booking> bookings { get; set; }

    }
}
