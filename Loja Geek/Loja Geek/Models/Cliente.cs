using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaGeek.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public String Nome { get; set; }

        public DateTime Nascimento { get; set; }
    }
}
