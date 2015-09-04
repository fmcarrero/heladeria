using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace heladeria
{
    public class tipo_pago_data
    {
        public static int agregar(tipo_pago Tipo_pago) {
            int retornar = 0;
            using (SqlConnection Conn = conexion.obtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("insert into tipo_pago values('{0}','{1}','{2}');",
                    Tipo_pago.codigo, Tipo_pago.nombre, Tipo_pago.descripcion), Conn);
                retornar = Comando.ExecuteNonQuery();


            }
            return retornar;
        }

        public static List<tipo_pago> BuscarTipoPago(String atributo, String valorAtributo) {
            List<tipo_pago> Lista = new List<tipo_pago>();
            using (SqlConnection con = conexion.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("select * from tipo_pago where {0} like '%{1}%' ", atributo, valorAtributo), con);
                
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    tipo_pago TipoPago = new tipo_pago();
                    TipoPago.codigo = reader.GetString(0);
                    TipoPago.nombre = reader.GetString(1);
                    TipoPago.descripcion = reader.GetString(2);

                    Lista.Add(TipoPago);

                }
                con.Close();
                return Lista;
            } 
            
        }
    }
}
