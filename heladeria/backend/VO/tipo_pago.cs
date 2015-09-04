using System; 
 using System.Collections.Generic; 
 using System.Linq; 
 using System.Text; 
 namespace heladeria.backend.VO{ 
 
	 public class tipo_pago{ 
	 	 public String Codigo {get;set;}
	 	 public String Descripcion {get;set;}
	 	 public String Nombre {get;set;}
	
 	 public tipo_pago(){}
 	 public tipo_pago (String codigo,String descripcion,String nombre) { 
 	 	 this.Codigo=codigo;
 	 	 this.Descripcion=descripcion;
 	 	 this.Nombre=nombre;  
}
 }
 }