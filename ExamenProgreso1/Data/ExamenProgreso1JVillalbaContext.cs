using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExamenProgreso1.Models;

namespace ExamenProgreso1.Data
{
    public class ExamenProgreso1JVillalbaContext : DbContext
    {
        public ExamenProgreso1JVillalbaContext (DbContextOptions<ExamenProgreso1JVillalbaContext> options)
            : base(options)
        {
        }

        public DbSet<ExamenProgreso1.Models.JVillalba> JVillalba { get; set; } = default!;
    }
}
