using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Src.Infrastructure.Data;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace backend.Src.Infrastructure.Data
{
    public class AppDbContextFactory: IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateAppDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseNpgsql("Host=ep-summer-darkness-a8z961xv-pooler.eastus2.azure.neon.tech;Username=neondb_owner;Password=npg_wdQt6ca2ezlg;Database=neondb;SSL Mode=Require;Trust Server Certificate=true;");
            return new AppDbContext(optionsBuilder.Options);
        }
    }
}