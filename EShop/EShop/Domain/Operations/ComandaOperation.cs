using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using EShop.Data.Models;
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

      
    }
}