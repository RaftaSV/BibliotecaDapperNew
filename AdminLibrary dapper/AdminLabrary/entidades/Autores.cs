using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminLabrary.entidades
{
   public class Autores
    {
        public int Id_autor { get; set; }
        public string Nombre { get; set; }
        public DateTime fecha_nacimiento { get; set; }

        public string Nacionalidad { get; set; }

        public int estado { get; set; }


    }
}
