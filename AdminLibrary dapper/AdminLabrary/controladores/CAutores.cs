using AdminLabrary.entidades;
using AdminLabrary.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminLabrary.controladores
{
    class CAutores
    {
        MAutores MAutores = new MAutores();
        public List<Autores> Listado()
        {
            return MAutores.Listado();
        }
        internal void guardar(Autores c)
        {
            MAutores.guardar(c);
        }
        public void actualizar(entidades.Autores c)
        {
            MAutores.actualizar(c);
        }
        public void Eliminar(entidades.Autores C)
        {
            MAutores.Eliminar(C);
        }
    }
}
