using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Data.Models
{
    public record Client
    {
        public int client_id { get; set; }
        public string nume { get; set; }
        public string adresa { get; set; }
        public string telefon { get; set; }
    }
}
