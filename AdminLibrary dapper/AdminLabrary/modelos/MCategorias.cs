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
    class MCategorias
    {

        public List<entidades.Categorias> Listado()
        {
            IDbConnection con = Conexion.Conectar();
            String consulta = "sp_MostrarCategorias";
            List<entidades.Categorias> listado = new List<entidades.Categorias>();
            con.Open();
            listado = con.Query<entidades.Categorias>(consulta, commandType: CommandType.StoredProcedure).ToList();
            con.Close();
            return listado;
        }
        internal void guardar(entidades.Categorias c)
        {
            IDbConnection con = Conexion.Conectar();
            String consulta = "sp_InsertarCategoria";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@Categoria", c.Categoria, DbType.String);
            con.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            con.Close();
        }
        public void Actualizar(entidades.Categorias c)
        {
            IDbConnection con = Conexion.Conectar();
            String consulta = "sp_ActualizarCategoria";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", c.Id_categoria, DbType.Int32);
            parametros.Add("@Categoria", c.Categoria, DbType.String);
            con.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            con.Close();
        }
        public void elminar(entidades.Categorias c)
        {
            IDbConnection con = Conexion.Conectar();
            String consulta = "sp_EliminarCategoria";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", c.Id_categoria, DbType.Int32);
            con.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            con.Close();
        }
    
    }
}
