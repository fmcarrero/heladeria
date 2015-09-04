using System; 
 using System.Collections.Generic; 
 using System.Linq; 
 using System.Text; 
 namespace heladeria.backend.VO{ 
 
	 public class remision_salida{ 
	 	 public String Codigo {get;set;}
	 	 public String Descripcion {get;set;}
	 	 public decimal Documento_Identidad {get;set;}
	 	 public DateTime Fecha {get;set;}
	 	 public String Hora {get;set;}
	 	 public String Usuario {get;set;}
	
 	 public remision_salida(){}
 	 public remision_salida (String codigo,String descripcion,decimal documento_identidad,DateTime fecha,String hora,String usuario) { 
 	 	 this.Codigo=codigo;
 	 	 this.Descripcion=descripcion;
 	 	 this.Documento_Identidad=documento_identidad;
 	 	 this.Fecha=fecha;
 	 	 this.Hora=hora;
 	 	 this.Usuario=usuario;  
}
 }
 }