using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AT_C__Felipe.Models;

namespace AT_C__Felipe.Data
{
    public class AT_C__FelipeContext : DbContext
    {
        public AT_C__FelipeContext (DbContextOptions<AT_C__FelipeContext> options)
            : base(options)
        {
        }

        public DbSet<AT_C__Felipe.Models.Carta> Carta { get; set; } = default!;

        public DbSet<AT_C__Felipe.Models.jogador>? jogador { get; set; }
    }
}
