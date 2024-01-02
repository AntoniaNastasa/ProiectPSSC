using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Domain.Operations
{
public class ComandaOperation
    {
        private readonly ProiectPsscDbContext _dbContext;

        public ComandaOperation(ProiectPsscDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreareComanda(int clientId, List<(int produsId, int cantitate)> produse)
        {
            // Creare comanda
            var comanda = new Comanda
            {
                ClientId = clientId,
                ComandaProduse = produse.Select(p => new ComandaProdus
                {
                    ProdusId = p.produsId,
                    Cantitate = p.cantitate
                }).ToList()
            };

            // Adaugare comanda in baza de date
            _dbContext.Comenzi.Add(comanda);
            await _dbContext.SaveChangesAsync();
        }

    }
}
