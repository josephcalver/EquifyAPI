using System;
using Microsoft.EntityFrameworkCore;

namespace EquifyAPI.Models
{
    public class EquifyContext : DbContext
    {
        public EquifyContext(DbContextOptions<EquifyContext> options)
            : base(options)
        {
        }

        public DbSet<Deal> Deal { get; set; }
    }
}
