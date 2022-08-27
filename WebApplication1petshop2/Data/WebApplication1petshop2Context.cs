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

        public DbSet<WebApplication1petshop2.Models.Serviços> Serviços { get; set; }
    }
}
