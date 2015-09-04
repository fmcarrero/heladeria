using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;


namespace heladeria.backend.usuarios
{
   
    public class Login_back
    {
        
        public VO.usuario validar(String usuario, String password) {
            VO.usuario Obusuario = null;
            
            using (SqlConnection con = conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("select * from usuario where usuario='{0}' and clave= '{1}' ", usuario, password), con);

                SqlDataReader reader = comando.ExecuteReader();
                if (reader.Read()) {
                   
                     Obusuario = new VO.usuario(reader.GetString(0),reader.GetString(1),reader.GetString(2),reader.GetString(3));

                }
                comando.Cancel();
                con.Close();
            }
                
                return Obusuario;
        }
    }
}
