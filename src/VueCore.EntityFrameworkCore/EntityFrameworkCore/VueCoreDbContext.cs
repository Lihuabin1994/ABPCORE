using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using VueCore.Authorization.Roles;
using VueCore.Authorization.Users;
using VueCore.MultiTenancy;
using VueCore.Trades;

namespace VueCore.EntityFrameworkCore
{
    public class VueCoreDbContext : AbpZeroDbContext<Tenant, Role, User, VueCoreDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Trade> Trade { get; set; }
        public DbSet<TradeDetail> TradeDetail { get; set; }
       
        public VueCoreDbContext(DbContextOptions<VueCoreDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Trade>().Property(x => x.StrikePx).HasColumnType("decimal(18,9)");
            modelBuilder.Entity<Trade>().Property(x => x.TradePrice).HasColumnType("decimal(18,9)");
        }
    }
}
