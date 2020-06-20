using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminLabrary.entidades
{
   public class Libros
    {
        public int Id_libro { get; set; }
        public string Nombre { get; set; }
        public int cantidad { get; set; }
        public string Año { get; set; }
        public int Numero_edicion { get; set; }
        public int Id_autor { get; set; }
        public int Id_Editorial { get; set; }
        public int Id_categoria { get; set; }
        public int estado { get; set; }



    }
}
