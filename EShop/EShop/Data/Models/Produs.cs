using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Data.Models
{
   public record Produs
    {
        public int produs_id { get; set; }
        public string nume { get; set; }
        public decimal pret { get; set; }
    }
}
