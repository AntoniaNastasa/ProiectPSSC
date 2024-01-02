using EShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CSharp.Choices;

namespace EShop.Domain.Models
{
    public static partial class CosCumparaturi
    {
        public interface ICosCumparaturi { Client client { get; } };
        public record CosCumparaturiGol(Client client) : ICosCumparaturi;
        public record CosNevalidat(Client client, Produs produs) : ICosCumparaturi;
        public record CosValidat(Client client, Produs produs) : ICosCumparaturi;


    }
}
