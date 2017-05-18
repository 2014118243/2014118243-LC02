using _2014118243_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2014118243;

namespace _2014118243_PER
{
    public class PantallastoreDbContext : DbContext

    {
        public DbSet<Pantallastore> Pantallas { get; set; }
        public DbSet<Pantalla> Pantalla { get; set; }
        

    }
}