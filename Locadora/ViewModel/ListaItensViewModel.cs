using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.ViewModel
{
    public class ListaItensViewModel
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public int Valor { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
    }
}
