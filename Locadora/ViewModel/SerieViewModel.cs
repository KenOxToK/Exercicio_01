using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.ViewModel
{
    public class SerieViewModel
    {
        public int Quantidade { get; set; }
        public int Valor { get; set; }
        public string Titulo { get; set; }
        public int Temporadas { get; internal set; }
    }
}
