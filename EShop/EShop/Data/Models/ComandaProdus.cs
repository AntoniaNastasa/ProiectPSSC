using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Data.Models
{
    internal class ComandaProdus
    {
        public int comanda_produs_id { get; set; }
        public int comanda_id { get; set; }
        public Comanda Comanda { get; set; }
        public int produs_id { get; set; }
        public Produs Produs { get; set; }
        public int cantitate { get; set; }
    }
}
