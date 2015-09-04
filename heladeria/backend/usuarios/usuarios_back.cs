using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace heladeria.backend.usuarios
{
    public class usuarios_back
    {
        public static int elimiarUser(String user) {
            int retornar = 0;
            using (SqlConnection Conn = conexion.obtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("delete from usuario where usuario='{0}';",
                   user), Conn);
                retornar = Comando.ExecuteNonQuery();
                Console.Write(user);



            }
            return retornar;
        }
        public static VO.usuario updateUser(String data)
        {
            VO.usuario USER = new VO.usuario();
            using (SqlConnection con = conexion.obtenerConexion())
            {
                String sql = "select * from usuario,permiso where usuario = '{0}'  and permiso.codigo=usuario.id_permiso";


                SqlCommand comando = new SqlCommand(string.Format(sql,data), con);


                SqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {

                    USER.Usuario = reader.GetString(0);
                    USER.Clave = reader.GetString(1);
                    USER.Descripcion = reader.GetString(2);
                    USER.Id_Permiso = reader.GetString(5);
                    Console.WriteLine("entro");

                }
                con.Close();

              
            }
            return USER;
        }

        public static int agregarUser(String usuario,String clave,String descripcion,String nombre_permiso,String com1) {
           
            String idPermiso = obtenerIdPermiso(nombre_permiso);
            int retornar = 0;
            String sql = "";
            if (com1.Equals("yes"))
            {
                sql = "update usuario set usuario='{0}',clave= '{1}',descripcion= '{2}', id_permiso='{3}' where usuario='{4}' ";
            }
            else {
                sql = "insert into usuario values('{0}','{1}','{2}','{3}');";
            }
            using (SqlConnection Conn = conexion.obtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format(sql,
                   usuario, clave, descripcion,idPermiso,usuario), Conn);
                retornar = Comando.ExecuteNonQuery();
              


            }
            
            return retornar;
        }
        public static String obtenerIdPermiso(String nombre_permiso)
        {
            String data = "";
            using (SqlConnection con2 = conexion.obtenerConexion())
            {
                
                SqlCommand comando2 = new SqlCommand(string.Format("SELECT * from permiso where nombre = '{0}'",nombre_permiso),con2);
                SqlDataReader reader2 = comando2.ExecuteReader();
                if (reader2.Read())
                {

                  data = reader2.GetString(0);


                }
                con2.Close();
                return data;
            }
        }

        public static List<String> llenar_combo() {
            //SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='usuario'
            List<String> lista = new List<String>();
            using (SqlConnection con = conexion.obtenerConexion())
            {
                
                SqlCommand comando = new SqlCommand(string.Format("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='usuario'"), con);


                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                   
                    String user = reader.GetString(0);
                    lista.Add(user);
                   
                   

                }
                con.Close();
                return lista;
            }
            
        }

        public static List<String> llenar_combo_idPermiso()
        {
            //SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='usuario'
            List<String> lista = new List<String>();
            using (SqlConnection con = conexion.obtenerConexion())
            {

                SqlCommand comando = new SqlCommand(string.Format("SELECT nombre from permiso"), con);


                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    String user = reader.GetString(0);
                    lista.Add(user);



                }
                con.Close();
                return lista;
            }

        }
        public static List<VO.usuario> listarUsuarios(String atributo, String valorAtributo)
        {

            List<VO.usuario> lista = new List<VO.usuario>();
            using (SqlConnection con = conexion.obtenerConexion())
            {
                String sql = "select * from usuario,permiso where {0} like '%{1}%' and usuario.id_permiso=permiso.codigo ";
                if (valorAtributo.Equals("*")) {
                    sql = "select * from usuario,permiso where usuario.id_permiso=permiso.codigo";
                }

                SqlCommand comando = new SqlCommand(string.Format(sql, atributo, valorAtributo), con);


                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    VO.usuario user = new VO.usuario();
                    user.Usuario = reader.GetString(0);
                    user.Clave = reader.GetString(1);
                    user.Descripcion = reader.GetString(2);
                    user.Id_Permiso = reader.GetString(5);
                    lista.Add(user);

                }
                con.Close();
                return lista;
            }
        }
    }


}