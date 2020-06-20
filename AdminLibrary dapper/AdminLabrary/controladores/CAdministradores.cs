using AdminLabrary.entidades;
using AdminLabrary.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminLabrary.controladores
{
    class CAdministradores
    {
        MAdministradores MAdministrador = new MAdministradores();
        public List<Administradores> Listado()
        {
            return MAdministrador.Listado();
        }
        public void guardar(Administradores c)
        {
            MAdministrador.guardar(c);
        }
        public void Actualizar(Administradores c)
        {
            MAdministrador.Actualizar(c);
        }
        public void Eliminar(Administradores c)
        {
            MAdministrador.Eliminar(c);
        }

    }
}
