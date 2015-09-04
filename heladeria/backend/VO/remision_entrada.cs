using System; 
 using System.Collections.Generic; 
 using System.Linq; 
 using System.Text; 
 namespace heladeria.backend.VO{ 
 
	 public class remision_entrada{ 
	 	 public String Codigo {get;set;}
	 	 public String Descripcion {get;set;}
	 	 public DateTime Fecha {get;set;}
	 	 public String Hora {get;set;}
	 	 public String Nit {get;set;}
	 	 public String Usuario {get;set;}
	
 	 public remision_entrada(){}
 	 public remision_entrada (String codigo,String descripcion,DateTime fecha,String hora,String nit,String usuario) { 
 	 	 this.Codigo=codigo;
 	 	 this.Descripcion=descripcion;
 	 	 this.Fecha=fecha;
 	 	 this.Hora=hora;
 	 	 this.Nit=nit;
 	 	 this.Usuario=usuario;  
}
 }
 }