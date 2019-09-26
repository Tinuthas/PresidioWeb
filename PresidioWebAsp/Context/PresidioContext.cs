using Microsoft.EntityFrameworkCore;
using PresidioWebAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PresidioWebAsp.Context
{
    public class PresidioContext : DbContext
    {

        public DbSet<Presidiario> Presidiarios { get; set; }
        public PresidioContext(DbContextOptions options)
               : base(options) { }

    }
}
