﻿using Microsoft.EntityFrameworkCore;
using Order = Core.Entities.Order;

namespace Infrastructure.Data;

public class AppDbContext : DbContext
{
    public DbSet<Order> Orders { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>().HasKey(o => o.Id);
        base.OnModelCreating(modelBuilder);
    }
}
