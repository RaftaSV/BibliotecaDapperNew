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
    class MAdministradores
    {
       
        public List<entidades.Administradores> Listado()
        {
            IDbConnection con = Conexion.Conectar();
            String consulta = "Select * from Administradores a where a.estado =0";
            List<entidades.Administradores> listado = new List<entidades.Administradores>();
            con.Open();
            listado = con.Query<entidades.Administradores>(consulta).ToList();
            con.Close();
            return listado;
        }
        public void guardar(entidades.Administradores c)
        {
            IDbConnection con = Conexion.Conectar();
            String consulta = "sp_InsertarAdministradores";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@Usuario", c.Usuario, DbType.String);
            parametros.Add("@Contraseña", c.Contraseña, DbType.String);
            parametros.Add("@id_lector", c.Id_Lector, DbType.Int32);
            con.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            con.Close();
        }
        public void Actualizar(entidades.Administradores c)
        {
            IDbConnection con = Conexion.Conectar();
            String consulta = "sp_ActualizarAdministradores";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", c.Id_Admin, DbType.Int32);
            parametros.Add("@Usuario", c.Usuario, DbType.String);
            parametros.Add("@Contraseña", c.Contraseña, DbType.String);
            parametros.Add("@Idlector", c.Id_Lector, DbType.Int32);
            con.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            con.Close();
        }
        public void Eliminar(entidades.Administradores c)
        {
            IDbConnection con = Conexion.Conectar();
            String consulta = "sp_EliminarAdmin";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", c.Id_Admin, DbType.Int32);
            con.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            con.Close();
        }
    }
}
