using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Data.Models
{
    public class Produs
    {

        public Produs(int produs_id, string nume, decimal pret)
        {
            this.pret = pret;
            this.produs_id = produs_id;
            this.nume = nume;


        }

        public int produs_id { get; set; }
        public string nume { get; set; }
        public decimal pret { get; set; }
    }
}
