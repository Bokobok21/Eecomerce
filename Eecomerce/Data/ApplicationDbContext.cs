using Eecomerce.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Eecomerce.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; } //Category is the entity and Categories is the table in the database
    }
}
