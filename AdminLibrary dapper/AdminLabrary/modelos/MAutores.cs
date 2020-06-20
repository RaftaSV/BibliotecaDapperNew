using AdminLabrary.conexion;
using AdminLabrary.entidades;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminLabrary.modelos
{
    class MAutores
    {
        public List<entidades.Autores> Listado()
        {
            IDbConnection con = Conexion.Conectar();
            String consulta = "sp_MostrarAutores";
            List<entidades.Autores> listado = new List<entidades.Autores>();
            con.Open();
            listado = con.Query<entidades.Autores>(consulta,commandType: CommandType.StoredProcedure).ToList();
            con.Close();
            return listado;
        }

       

        internal void guardar(entidades.Autores c)
        {
            IDbConnection con = Conexion.Conectar();
            String consulta = "sp_insertarAutores";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@Nombre", c.Nombre, DbType.String);
            parametros.Add("@fecha_nacimiento", c.fecha_nacimiento, DbType.Date);
            parametros.Add("@Nacionalidad", c.Nacionalidad, DbType.String);
            con.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            con.Close();

        }

        public void actualizar(entidades.Autores c)
        {
            IDbConnection con = Conexion.Conectar();
            String consulta = "sp_ActualizarAutores";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", c.Id_autor, DbType.Int32);
            parametros.Add("@Nombre", c.Nombre, DbType.String);
            parametros.Add("@fecha_nacimiento", c.fecha_nacimiento, DbType.Date);
            parametros.Add("@Nacionalidad", c.Nacionalidad, DbType.String);
            con.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            con.Close();
        }
        public void Eliminar(entidades.Autores c)
        {
            IDbConnection con = Conexion.Conectar();
            String consulta = "sp_EliminarAutores";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", c.Id_autor, DbType.Int32);
            con.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            con.Close();
        }
    }
}
