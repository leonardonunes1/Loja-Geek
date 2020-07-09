using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LojaGeek.Models;

namespace LojaGeek.Data
{
    public class LojaGeekContext : DbContext
    {
        public LojaGeekContext (DbContextOptions<LojaGeekContext> options)
            : base(options)
        {
        }

        public DbSet<LojaGeek.Models.Produto> Produto { get; set; }

        public DbSet<LojaGeek.Models.Cliente> Cliente { get; set; }
    }
}
