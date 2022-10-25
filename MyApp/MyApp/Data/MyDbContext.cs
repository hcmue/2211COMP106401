﻿using Microsoft.EntityFrameworkCore;

namespace MyApp.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options): base(options)
        {
        }

        public DbSet<Loai>? Loais { get; set; }
        public DbSet<HangHoa>? HangHoas { get; set; }
    }
}
