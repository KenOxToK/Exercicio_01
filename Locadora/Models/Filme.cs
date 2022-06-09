using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.Models
{
    public class Filme : Item
    {
        public string Titulo { get; set; }
        public int Quantidade { get; set; }
        public int Valor { get; set; }
        public int Duracao { get; set; }
    }
}
