using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1petshop2.Models
{
    public class WebApplication1petshop2Context : DbContext
    {
        public WebApplication1petshop2Context (DbContextOptions<WebApplication1petshop2Context> options)
            : base(options)
        {
        }

        
        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Serviços> Serviços { get; set; }
        public DbSet<VendaRegistro> VendaRegistro { get; set; }
    }
}
