using iphound.API.Data.Context.Mapping;
using iphound.API.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace iphound.API.Data.Context;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<IpInfo> IpInfos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        modelBuilder.ApplyConfiguration(new IpInfoMap());
    }
}