using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;


namespace heladeria.backend
{
   public  class refactory
    {
        private String Item1 { get; set; }
        private String Item2 { get; set; }
        private String Item3 { get; set; }

        public refactory(String primero,String segundo,String tercero) {
            this.Item1 = primero;
            this.Item2 = segundo;
            this.Item3 = tercero;
        }
        public refactory(){}

              
        public  void prueba1()
        {
            //SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='usuario'
            String inicio = "";
            String final = "";
            
            using (SqlConnection con = conexion.obtenerConexion())
            {
                
                SqlCommand comando = new SqlCommand(string.Format("SELECT distinct TABLE_NAME,COLUMN_NAME, DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS"), con);
                List<refactory> lista = new List<refactory>();
                SqlDataReader reader = comando.ExecuteReader();
                int i = 0;
                while (reader.Read())
                {
                    inicio = (String)reader.GetValue(0);
                    refactory refa = new refactory((string)reader.GetValue(0), (string)reader.GetValue(1),(string) reader.GetValue(2));
                    if (inicio.Equals(final) || i==0)
                    {
                        lista.Add(refa);
                        i++;
                    }
                    else {
                        
                        createFile(final , lista);
                        lista.RemoveRange(0, lista.Count());
                        lista.Add(refa);
                        i = 0;
                     }
                     final =(String)reader.GetValue(0);
                  
                }
                if (i != 0) {                   
                    createFile(final, lista);
                    lista.RemoveRange(0, lista.Count());
                }         
                con.Close();
            }

        }
        public void createFile(String title, List<refactory> refa) {

            foreach (refactory ye in refa) {
                Console.WriteLine("item3--------------"+ye.Item3);
            }

            backend.leerXml le = new backend.leerXml();
           //String var = le.leer("ruta");
            //var archivo = "C:\\Users\\FranklinMauricio\\Desktop\\my.cs";
            var archivo = le.leer("ruta")  + title+".cs";

            // eliminar el fichero si ya existe
            if (File.Exists(archivo))
                File.Delete(archivo);

            // crear el fichero
            String cabeceraConstructor = "";
            using (var fileStream = File.Create(archivo))
            {
                String body = "";
                String thisConstructor = "";
                foreach (refactory lis in refa) {

                    body = body + "\t \t " + "public " + getType(lis.Item3) + " " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(lis.Item2) + " {get;set;}" + "\n";
                    cabeceraConstructor = cabeceraConstructor + getType(lis.Item3) + " " + lis.Item2 + ",";
                    thisConstructor = thisConstructor + " \t \t this." + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(lis.Item2) + "=" + lis.Item2 + ";\n";
                }
                String cabeceras = "using System; \n using System.Collections.Generic; \n using System.Linq; \n using System.Text; \n ";
                String partOne = "namespace heladeria.backend.VO{ \n \n";
                String partOneFunction = "\t public class " + title + "{ \n";
                String methodVacio = "\n \t public " + title + "(){}";
                //quitar la ultima coma de la cadena
                cabeceraConstructor = cabeceraConstructor.Substring(0, cabeceraConstructor.Length - 1) + ") { \n";
                thisConstructor = thisConstructor.Substring(0, thisConstructor.Length - 1) + "  \n}";
                String constructor = "\n \t public " + title + " (" + cabeceraConstructor ;
                var texto = new UTF8Encoding(true).GetBytes(cabeceras + partOne + partOneFunction + body + "\t" + methodVacio + constructor  + thisConstructor + "\n }" + "\n }");
                fileStream.Write(texto, 0, texto.Length);
               
                fileStream.Flush();
                fileStream.Close();
            }
        }

        public String getType(String val) {

            String type = "";
            switch (val)
            {
                case "nvarchar":
                    type = "String";
                    break;
                case "int":
                    type = "int";
                    break;
                case "date":
                    type = "DateTime";
                    break;
                    
                case "float":
                    type = "float";
                    break;
                case "real":
                    type = "int";
                    break;
                case "numeric":
                    type = "decimal";
                    break;
                    
            }
                
            return type;
        }

    }
}
