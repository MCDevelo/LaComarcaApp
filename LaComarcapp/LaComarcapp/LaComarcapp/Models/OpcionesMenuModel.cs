using System;
using System.Collections.Generic;
using System.Text;

namespace LaComarcapp.Models
{
    public class OpcionesMenuModel 
    {
        public int ID { get; set; }
        public string Titulo { get; set; }
        public string Icono { get; set; }
        public Type TipoVista { get; set; }
        public bool Visible { get; set; }
    }
}
