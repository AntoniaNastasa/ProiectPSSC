using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Data.Models
{
    public class ComandaProdus
    {

        public ComandaProdus(int comanda_produs_id, int comanda_id, int produs_id, int cantitate)
        {
            this.cantitate = cantitate;
            this.produs_id = produs_id;
            this.comanda_id = comanda_id;
            this.comanda_produs_id = comanda_produs_id;



        }
        public int comanda_produs_id { get; set; }
        public int comanda_id { get; set; }
        public Comanda Comanda { get; set; }
        public int produs_id { get; set; }
        public Produs Produs { get; set; }
        public int cantitate { get; set; }
    }
}
