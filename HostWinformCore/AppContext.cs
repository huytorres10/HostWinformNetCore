using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace HostWinformCore
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {
            Database.EnsureDeleted();
            Database.Migrate();
        }
        public DbSet<Config> Configs { get; set; }
    }


    //Muốn DI được cần khai báo cái này mặc dù bên host đã services.DBContext rồi(winform 5.0 thôi)
    public class AppContextFactory : IDesignTimeDbContextFactory<AppContext>
    {
        public AppContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppContext>();
            optionsBuilder.UseSqlite(@"Data Source=test.db");

            return new AppContext(optionsBuilder.Options);
        }
    }
}
