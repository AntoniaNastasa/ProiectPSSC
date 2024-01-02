using Domain.Operations;
using EShop.Data.Models;
using EShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Workflows
{
    internal class ProcesareComanda
    {
        public async Task<IProcesareComanda> execute(Client client, List<ProdusInvalid> produsInvalid)
        {
            IEventComanda eventComanda = null;

            //creare cos de cumparaturi cu informatiile clientului
            ICosCumparaturi cosCumparaturi = new CosCumparaturiGol(client);
            CosCumparaturi = ComandaOperation.adaugaProduse((CosCumparaturiGol)cosCumparaturi, produsInvalid);

           
        }
    }
}
