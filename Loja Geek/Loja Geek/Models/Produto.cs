using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaGeek.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public double Preco { get; set; }

        public double Quantidade { get; set; }
    }
}
