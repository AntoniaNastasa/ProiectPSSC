using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Data.Models
{
    public class Client
    {
        public Client(string nume, string telefon, string adresa)
        {
            this.client_id = client_id;
            this.nume = nume;
            this.telefon = telefon;
            this.adresa = adresa;
        }

        public int client_id { get; set; }
        public string nume { get; set; }
        public string adresa { get; set; }
        public string telefon { get; set; }
    }
}
