using AdminLabrary.conexion;
using AdminLabrary.formularios.insert_update;
using AdminLabrary.formularios.principales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminLabrary.modelos
{
    class LinqL
    {
        public static frmInsertarLibro nuevoL = new frmInsertarLibro();
        public static frmPrincipal f = new frmPrincipal();
        public static int inicio =0;
        public static string Usuario = "";
        public static string Contra = "";
        public static string Buscar ="";
        public static string Editorial = "";
        public static  void login()
        {
           

            using (BibliotecaEntities1 db = new BibliotecaEntities1())
            {
                var lista = from admin in db.Administradores
                            where admin.Usuario == Usuario
                            && admin.Contraseña == Contra
                            select new
                            { id = admin.Id_Admin,
                            idlec= admin.Id_Lector
                            };



                if (lista.Count() > 0)
                {
                    foreach (var i in lista)
                    {
                        frmPrincipal.alquiler.id = i.id;
                        frmPrincipal.recibir.id = i.idlec;
                    }

                    
                    f.lblUsuario.Text = Usuario;
                    frmPrincipal.alquiler.txtUsuario.Text = Usuario;
                    frmPrincipal.recibir.txtUsuario.Text = Usuario;
                    inicio = 0;
                    f.Show();
                }
                else
                {
                    inicio = 1;
                }


            }

        }
        public static List<entidades.Autores> autorL = new List<entidades.Autores>();

        public static void filtroAutores()
        {
           
            
                
                var lista = from i in autorL
                            where i.Nombre.Contains(Buscar)
                            select new
                            {
                                Id_autor = i.Id_autor,
                                nombre = i.Nombre,
                                Fecha_nacimiento = i.fecha_nacimiento,
                                nacionalidad = i.Nacionalidad
                            };
                 nuevoL.f.dtgAutores.DataSource = lista.ToList();
            
        }
        public static List<entidades.Editoriales> edi = new List<entidades.Editoriales>();
        public static void filtroEdit()
        {    var lista = from i in edi
                            where i.Editorial.Contains(Buscar)
                            select new
                            {
                                Id_editorial = i.Id_Editorial,
                                Editorial = i.Editorial,
                                Fundada = i.Fundada,
                                Direccion = i.Direccion
                            };
                nuevoL.editorial.dtgEditoriales.DataSource = lista.ToList();
            
        }
        public static List<entidades.Libros> Libros = new List<entidades.Libros>();
        public static void filtroLibros()
        {
            
            var lista = from lib in Libros

                        where lib.Nombre.Contains(Buscar)
                        && lib.cantidad > 0
                        select new
                        {
                            Id_libro = lib.Id_libro,
                            Nombre = lib.Nombre,
                            CANTIDAD = lib.cantidad,
                        };
           frmPrincipal.buscarlibro.dgvLibros.DataSource = lista.ToList();
        }

    }
}
