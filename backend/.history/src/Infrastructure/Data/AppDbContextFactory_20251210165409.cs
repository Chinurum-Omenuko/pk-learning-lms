using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Src.Infrastructure.Data;

namespace backend.Src.Infrastructure.Data
{
    public class AppDbContextFactory: IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateAppDbContext(string[] args)
        {
            
        }
    }
}