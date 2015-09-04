using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace heladeria
{
    public class conexion
    {
        public static SqlConnection obtenerConexion()
        {
            
            SqlConnection Conn = new SqlConnection("server=(local);Initial Catalog=heladeria;Integrated Security=True");
            Conn.Open();
            return Conn;
        }
    }
}
