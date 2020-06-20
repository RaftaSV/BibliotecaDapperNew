using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminLabrary.conexion;
using AdminLabrary.entidades;
using Dapper;

namespace AdminLabrary.modelos
{
    class MAlquileres
    {


        public List<entidades.Alquileres> Listado()
        {
            IDbConnection con = Conexion.Conectar();
            String consulta = "select *from Alquileres a where a.fecha_de_entrega != '1900-01-01'";
            List<entidades.Alquileres> listado = new List<entidades.Alquileres>();
            con.Open();
            listado = con.Query<entidades.Alquileres>(consulta).ToList();
            con.Close();
            return listado;

        }
        public void Guardar(entidades.Alquileres c)
        {
            IDbConnection con = Conexion.Conectar();
            String consulta = "sp_insertaralquiler";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id_lector", c.Id_Lector, DbType.Int32);
            parametros.Add("@id_libro", c.Id_libro, DbType.Int32);
            parametros.Add("@entregado", c.Entregado, DbType.Int32);
            con.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            con.Close();

        }
        public List<entidades.AlquileresPendientes> ListadoP()
        {
            IDbConnection con = Conexion.Conectar();
            String consulta = "sp_MostrarLibrosconentregaproxima1";
            List<entidades.AlquileresPendientes> listadop = new List<entidades.AlquileresPendientes>();
            con.Open();
            listadop = con.Query<entidades.AlquileresPendientes>(consulta, commandType: CommandType.StoredProcedure).ToList();
            con.Close();
            return listadop;
        }
        public void Recibir(entidades.AlquileresPendientes c)
        {
            IDbConnection con = Conexion.Conectar();
            string consulta = "sp_RecibirLibro";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id_alquiler", c.Id_alquiler, DbType.Int32);
            parametros.Add("@recibido", c.Recibir, DbType.Int32);
            con.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            con.Close();

        }
    }
}
