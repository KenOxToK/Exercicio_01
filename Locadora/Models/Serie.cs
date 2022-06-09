using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.Models
{
    public class Serie : Item
    {
        public int Quantidade { get; set; }
        public int Valor { get; set; }
        public string Titulo { get; set; }
        public int Temporadas { get; set; }
    }
}
