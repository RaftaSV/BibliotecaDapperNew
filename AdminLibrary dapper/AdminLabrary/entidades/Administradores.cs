using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminLabrary.entidades
{
   public class Administradores
    {
        public int Id_Admin { get; set; }
        public string Usuario { get; set; }

        public string Contraseña { get; set; }

        public int Id_Lector { get; set; }
        public int estado { get; set; }
    }
}
