using Microsoft.EntityFrameworkCore;
using Projekt4.Controllers;
using Projekt4.Models;


namespace Projekt4.Data
{
    public class ApiContext : DbContext
    {
        public DbSet<HotelBooking> Bookings { get; set; }

        public ApiContext(DbContextOptions<ApiContext> options)
            : base(options)
        {

        }
    }
}
