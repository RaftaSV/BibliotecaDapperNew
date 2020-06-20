using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminLabrary.entidades
{
    public class Alquileres
    {

        public int Id_alquiler { get; set; }
        public int Id_Lector { get; set; }
        public int Id_libro { get; set; }
        public int Entregado { get; set; }
        public DateTime fecha_salida { get; set; }
        public DateTime fecha_prevista_de_entrega { get; set; }
        public DateTime fecha_de_entrega { get; set; }
        public int Recibido { get; set; }



    }
 
}
