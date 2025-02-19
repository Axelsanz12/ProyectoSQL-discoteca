using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDISCOsql
{
    internal class Discos
    {
     
       
        
        public string Titulo { get; set; }

        public DateTime FechaLanzamiento { get; set; }

        public int CantidadCanciones { get; set; }

        public string urlImagen   { get; set; }

        public Estilos tipo { get; set; }




    }
}
