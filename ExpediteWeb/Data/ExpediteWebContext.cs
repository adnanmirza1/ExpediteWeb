using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExpediteWeb.Models;

namespace ExpediteWeb.Data
{
    public class ExpediteWebContext : DbContext
    {
        public ExpediteWebContext (DbContextOptions<ExpediteWebContext> options)
            : base(options)
        {
        }

        public DbSet<ExpediteWeb.Models.User> User { get; set; }
    }
}
