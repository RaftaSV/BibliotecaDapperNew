using AdminLabrary.entidades;
using AdminLabrary.modelos;
using RazorEngine.Compilation.ImpromptuInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminLabrary.controladores
{
    class CLibros
    {
        MLibros MLibros = new MLibros();
        public List<Libros> Listado()
        {
            return MLibros.Listado();
        }
        public void guardar(entidades.Libros c)
        {
            MLibros.guardar(c);
        }
        public void Actualizar(entidades.Libros c)
        {
            MLibros.Actualizar(c);
        }
        public void Eliminar(entidades.Libros c)
        {
            MLibros.Eliminar(c);
        }
        public List<Libros> ListadoL()
        {
            return MLibros.ListadoL();
        }
    }
}
