using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace heladeria.backend
{
    public class proveedores_back
    {
        public static String codigoUpdate = "";
        public static VO.proveedor updateProveedor(String data)
        {
            VO.proveedor proveedorOb = new VO.proveedor();
            using (SqlConnection con = conexion.obtenerConexion())
            {
                String sql = "select * from proveedor,categoria_proveedores where proveedor.nit = '{0}'  and proveedor.codigo=categoria_proveedores.codigo";
                Console.WriteLine(data);

                SqlCommand comando = new SqlCommand(string.Format(sql, data), con);


                SqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {

                    proveedorOb.Nit = reader.GetString(0);
                    proveedorOb.Nombre = reader.GetString(1);
                    proveedorOb.Telefono = reader.GetDecimal(2);
                    proveedorOb.Celular = reader.GetDecimal(3);
                    proveedorOb.Descripcion = reader.GetString(4);
                    proveedorOb.Fax = reader.GetDecimal(5);
                    proveedorOb.Direccion = reader.GetString(6);
                    proveedorOb.Correo = reader.GetString(7);
                    proveedorOb.Codigo = reader.GetString(10);
                    codigoUpdate = reader.GetString(9);


                }
                con.Close();


            }
            return proveedorOb;
        }
        public static int agregarProveedor(backend.VO.proveedor objetProveedor, String com1)
        {

            
            int retornar = 0;
            String sql = "";
            if (com1.Equals("yes"))
            {
                sql = "update proveedor set nit='{0}',nombre= '{1}',telefono= {2}, celular={3}, descripcion='{4}', fax={5}, direccion='{6}', correo='{7}', codigo='{8}' where nit='{0}' ";
                objetProveedor.Codigo = codigoUpdate;
            }
            else
            {
                sql = "insert into proveedor values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}');";
            }
            using (SqlConnection Conn = conexion.obtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format(sql,
                   objetProveedor.Nit, objetProveedor.Nombre, objetProveedor.Telefono, objetProveedor.Celular, objetProveedor.Descripcion, objetProveedor.Fax, objetProveedor.Direccion, objetProveedor.Correo, objetProveedor.Codigo), Conn);
                retornar = Comando.ExecuteNonQuery();



            }

            return retornar;
        }

        public static String obtenerCodigoCatProveedor(String nombre) {
            String codigo = "";
            using (SqlConnection con = conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("SELECT nombre,codigo from categoria_proveedores where nombre='{0}'", nombre), con);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    codigo = reader.GetString(1);
                   
                }
                con.Close();
               
            }
            return codigo;
        }
        public static List<String> llenar_combo_categoria()
        {
            //SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='usuario'
            List<String> lista = new List<String>();
            using (SqlConnection con = conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("SELECT nombre from categoria_proveedores"), con);
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

        public static int elimiarProveedor(String proveedor)
        {
            int retornar = 0;
            using (SqlConnection Conn = conexion.obtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("delete from proveedor where nit='{0}';",
                   proveedor), Conn);
                retornar = Comando.ExecuteNonQuery();
                Console.Write(proveedor);
            }
            return retornar;
        }

        public static List<VO.proveedor> listarProveedores(String atributo, String valorAtributo)
        {

            List<VO.proveedor> lista = new List<VO.proveedor>();
            using (SqlConnection con = conexion.obtenerConexion())
            {
                String sql = "select * from proveedor,categoria_proveedores where proveedor.{0} like '%{1}%' and categoria_proveedores.codigo=proveedor.codigo ";
                if (valorAtributo.Equals("*"))
                {
                    sql = "select * from proveedor,categoria_proveedores where categoria_proveedores.codigo=proveedor.codigo";
                }

                SqlCommand comando = new SqlCommand(string.Format(sql, atributo, valorAtributo), con);

                Console.WriteLine("-----------"+valorAtributo+"---"+atributo+"--"+sql);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    VO.proveedor proveedor = new VO.proveedor();
                    proveedor.Nit = (String)reader.GetValue(0);
                    proveedor.Nombre = (String)reader.GetValue(1);
                    proveedor.Telefono = (decimal)reader.GetValue(2);
                    proveedor.Celular = (decimal)reader.GetValue(3);
                    proveedor.Descripcion = (String)reader.GetValue(4);
                    proveedor.Fax= (decimal)reader.GetValue(5);
                    proveedor.Direccion = (String)reader.GetValue(6);
                    proveedor.Correo = (String)reader.GetValue(7);
                    proveedor.Codigo = (String)reader.GetValue(10);
                    lista.Add(proveedor);

                }
                con.Close();
                return lista;
            }
        }

        public static List<String> llenar_combo()
        {
            //SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='usuario'
            List<String> lista = new List<String>();
            using (SqlConnection con = conexion.obtenerConexion())
            {

                SqlCommand comando = new SqlCommand(string.Format("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='proveedor'"), con);
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
    }
}
