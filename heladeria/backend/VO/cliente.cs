using System; 
 using System.Collections.Generic; 
 using System.Linq; 
 using System.Text; 
 namespace heladeria.backend.VO{ 
 
	 public class cliente{ 
	 	 public String Apellidos {get;set;}
	 	 public decimal Celular {get;set;}
	 	 public String Codigo {get;set;}
	 	 public String Correo {get;set;}
	 	 public String Direccion {get;set;}
	 	 public decimal Documento_Identidad {get;set;}
	 	 public String Estado {get;set;}
	 	 public String Nombres {get;set;}
	 	 public decimal Telefono {get;set;}
	
 	 public cliente(){}
 	 public cliente (String apellidos,decimal celular,String codigo,String correo,String direccion,decimal documento_identidad,String estado,String nombres,decimal telefono) { 
 	 	 this.Apellidos=apellidos;
 	 	 this.Celular=celular;
 	 	 this.Codigo=codigo;
 	 	 this.Correo=correo;
 	 	 this.Direccion=direccion;
 	 	 this.Documento_Identidad=documento_identidad;
 	 	 this.Estado=estado;
 	 	 this.Nombres=nombres;
 	 	 this.Telefono=telefono;  
}
 }
 }