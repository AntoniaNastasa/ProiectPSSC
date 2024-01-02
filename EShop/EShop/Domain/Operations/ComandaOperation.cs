using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using EShop.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Domain.Operations
{
    public class ComandaOperation
    {
        //operatii legate de comanda 


        //adaugare produse in cos
        public ICosCumparaturi adaugaProduse(CosCumparaturiGol cosCumparaturiGol, ProdusInvalid produsInvalid)
        {
            if (produsInvalid.count > 0)
                return new CosNevalidat(cosCumparaturiGol.client, produsInvalid);
            else return cosCumparaturiGol;
        }

        //validare produse
        public static Task<IDate> ValidareDate(Func<ProdusId>, Option<ProdusId>> verificaExistentaProdusului) => //ValidareDate primeste un obiect ProdusId si returneaza Option<ProdusId>
            produse.CosCumparaturi.MatchAsync( //parcurgem toate produsele din cosul de cumparaturi
                Right: produseValidate => new ValidareDate(produseValidate),
                LeftAsync: errorMessage => Task.FromResult((IDate)new ProdusInvalid(produse.CosCumparaturi, errorMessage))
                );

        //aplicare de reduceri
      
    }
}