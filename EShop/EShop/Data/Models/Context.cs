using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace EShop.Data.Models
{
 
        public class ProiectPsscDbContext : DbContext
        {
            public DbSet<Client> Clienti { get; set; }
            public DbSet<Produs> Produse { get; set; }
            public DbSet<Comanda> Comenzi { get; set; }
            public DbSet<ComandaProdus> ComenziProduse { get; set; }

            public ProiectPsscDbContext(DbContextOptions<ProiectPsscDbContext> options)
                : base(options)
            {
            }
        }
    
}
