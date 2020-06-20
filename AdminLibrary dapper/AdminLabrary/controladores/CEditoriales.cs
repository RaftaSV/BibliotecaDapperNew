using AdminLabrary.entidades;
using AdminLabrary.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminLabrary.controladores
{
    class CEditoriales
    {
        MEditoriales M = new MEditoriales();
        public List<Editoriales> Listado()
        {
            return M.Listado();
        }
        internal void guardar(Editoriales c)
        {
            M.guardar(c);
        }

       public void actualizar(entidades.Editoriales c)
        {
            M.actualizar(c);
        }
        public void Eliminar(entidades.Editoriales c)
        {
            M.Eliminar(c);
        }

    }
}
