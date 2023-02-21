using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrackerWeb.Models;

namespace TrackerWeb.Data
{
    public class TrackerWebContext : DbContext
    {
        public TrackerWebContext (DbContextOptions<TrackerWebContext> options)
            : base(options)
        {
        }

        public DbSet<Issue> Issue { get; set; } = default!;
    }
}
