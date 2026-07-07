using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EstudoRecurso.Models
{
    // Certo: Apenas "public class", SEM a palavra "static"!
    public class AppDbContext : DbContext
    {
        public DbSet<Suplementos> Suplementos { get; set; }
    }
}
