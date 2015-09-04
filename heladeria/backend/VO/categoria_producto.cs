using System; 
 using System.Collections.Generic; 
 using System.Linq; 
 using System.Text; 
 namespace heladeria.backend.VO{ 
 
	 public class categoria_producto{ 
	 	 public String Codigo {get;set;}
	 	 public String Descripcion {get;set;}
	 	 public String Nombre {get;set;}
	
 	 public categoria_producto(){}
 	 public categoria_producto (String codigo,String descripcion,String nombre) { 
 	 	 this.Codigo=codigo;
 	 	 this.Descripcion=descripcion;
 	 	 this.Nombre=nombre;  
}
 }
 }