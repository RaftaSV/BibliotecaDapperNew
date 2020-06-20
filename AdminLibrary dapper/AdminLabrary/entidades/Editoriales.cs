using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminLabrary.entidades
{
   public  class Editoriales
    {
        public int Id_Editorial { get; set; }
        public string Editorial { get; set; }
        public  DateTime Fundada { get; set; }
        public string Direccion { get; set; }
        public int estado { get; set; }
    }
}
