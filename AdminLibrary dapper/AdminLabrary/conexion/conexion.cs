using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace AdminLabrary.conexion
{
    public static class Conexion
    {
        public static IDbConnection Conectar()
        {
            //cambiar los datos según su sqlserver
            String cadena = "Data Source=.\\;" +
                "Initial Catalog=Biblioteca;" +
                "Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadena);
            IDbConnection conexion = cn;
            return conexion;
        }
    }
}
