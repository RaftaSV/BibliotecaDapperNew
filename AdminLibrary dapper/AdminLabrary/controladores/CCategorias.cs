using AdminLabrary.entidades;
using AdminLabrary.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminLabrary.controladores
{
    class CCategorias
    {
        MCategorias MCategorias = new MCategorias();
        public List<Categorias> Listado()
        {
            return MCategorias.Listado();
        }
        internal void guardar(Categorias c)
        {
            MCategorias.guardar(c);
        }
        public void Actualizar(entidades.Categorias C)
        {
            MCategorias.Actualizar(C);
        }
        public void Eliminar(entidades.Categorias C)
        {
            MCategorias.elminar(C);
        }

    }
}
