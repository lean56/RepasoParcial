using Microsoft.EntityFrameworkCore;
using Repso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repso.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Productos> Productos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= Database/Productos.db");
        }
    }
}
