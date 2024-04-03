using Data.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<StatusHistory> StatusHistory { get; set; }
        public virtual DbSet<CarInfo> spCarInfo { get; set; }
        public virtual async Task<IEnumerable<CarInfo>> GetCarInfo()
        {
            return await Set<CarInfo>().FromSqlRaw("EXEC spCarInfo").ToListAsync();
        }

    }
}
