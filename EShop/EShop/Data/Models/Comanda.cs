using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Data.Models
{
  public class Comanda
    {
        public int comanda_id { get; set; }
        public int client_id { get; set; }
        public Client Client { get; set; }
        public List<ComandaProdus> ComandaProduse { get; set; }
    }
}
