using System; 
 using System.Collections.Generic; 
 using System.Linq; 
 using System.Text; 
 namespace heladeria.backend.VO{ 
 
	 public class usuario{ 
	 	 public String Clave {get;set;}
	 	 public String Descripcion {get;set;}
	 	 public String Id_Permiso {get;set;}
	 	 public String Usuario {get;set;}
	
 	 public usuario(){}
 	 public usuario (String clave,String descripcion,String id_permiso,String usuario) { 
 	 	 this.Clave=clave;
 	 	 this.Descripcion=descripcion;
 	 	 this.Id_Permiso=id_permiso;
 	 	 this.Usuario=usuario;  
}
 }
 }