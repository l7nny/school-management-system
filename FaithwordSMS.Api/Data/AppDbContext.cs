using Microsoft.EntityFrameworkCore;
using FaithwordSMS.Api.Auth.Models;
namespace FaithwordSMS.Api.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }

    }


}