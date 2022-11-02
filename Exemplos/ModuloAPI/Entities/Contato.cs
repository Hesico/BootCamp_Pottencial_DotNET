using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloAPI.Entities
{
    public class Contato
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string Telefone { get; set; }
        public bool Ativo { get; set; }
    }
}