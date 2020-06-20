using AdminLabrary.conexion;
using AdminLabrary.controladores;
using AdminLabrary.entidades;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;


namespace AdminLabrary.modelos
{
    public class MLibros
    {
        public List<entidades.Libros> Listado()
        {
            IDbConnection con = Conexion.Conectar();
            String consulta = "sp_MostrarLibros";
            List<entidades.Libros> listado = new List<entidades.Libros>();
            con.Open();
            listado = con.Query<entidades.Libros>(consulta, commandType: CommandType.StoredProcedure).ToList();
            con.Close();
            return listado;
        }
        public void guardar(entidades.Libros c)
        {
            IDbConnection con = Conexion.Conectar();
            String consulta = "sp_InsertarLibros";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@Nombre", c.Nombre, DbType.String);
            parametros.Add("@cantidad", c.cantidad, DbType.Int32);
            parametros.Add("@Año", c.Año, DbType.Date);
            parametros.Add("@Numero_edicion", c.Numero_edicion, DbType.Int32);
            parametros.Add("@Id_autor", c.Id_autor, DbType.Int32);
            parametros.Add("@Id_Editorial", c.Id_Editorial, DbType.Int32);
            parametros.Add("@Id_categoria", c.Id_categoria, DbType.Int32);

            con.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            con.Close();
        }
        public void Actualizar(entidades.Libros c)
        {
            IDbConnection con = Conexion.Conectar();
            String consulta = "sp_ActualizarLibros";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", c.Id_libro, DbType.Int32);
            parametros.Add("@Nombre", c.Nombre, DbType.String);
            parametros.Add("@Cantidad", c.cantidad, DbType.Int32);
            parametros.Add("@Año", c.Año, DbType.Date);
            parametros.Add("@NumerodeEdicion", c.Numero_edicion, DbType.Int32);
            parametros.Add("@Idautor", c.Id_autor, DbType.Int32);
            parametros.Add("@IdEditorial", c.Id_Editorial, DbType.Int32);
            parametros.Add("@IdCategoria", c.Id_categoria, DbType.Int32);
            con.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            con.Close();
        }
        public void Eliminar(entidades.Libros c)
        {
            IDbConnection con = Conexion.Conectar();
            String consulta = "sp_EliminarLibros";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", c.Id_libro, DbType.Int32);
            con.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            con.Close();
        }
        public List<entidades.Libros> ListadoL()
        {
            IDbConnection con = Conexion.Conectar();
            String consulta = "sp_MostrarLibrosCantidad1";
            List<entidades.Libros> listado = new List<entidades.Libros>();
            con.Open();
            listado = con.Query<entidades.Libros>(consulta, commandType: CommandType.StoredProcedure).ToList();
            con.Close();
            return listado;
        }


    }
}
