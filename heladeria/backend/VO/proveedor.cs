using System; 
 using System.Collections.Generic; 
 using System.Linq; 
 using System.Text; 
 namespace heladeria.backend.VO{ 
 
	 public class proveedor{
        public String Nit { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public String Direccion { get; set; }
        public decimal Celular {get;set;}
	 	 public String Codigo {get;set;}
	 	 public String Correo {get;set;}
	 	
	 	 public decimal Fax {get;set;}
	 	
	 	 public decimal Telefono {get;set;}
	
 	 public proveedor(){}
 	 public proveedor (decimal celular,String codigo,String correo,String descripcion,String direccion,decimal fax,String nit,String nombre,decimal telefono) { 
 	 	 this.Celular=celular;
 	 	 this.Codigo=codigo;
 	 	 this.Correo=correo;
 	 	 this.Descripcion=descripcion;
 	 	 this.Direccion=direccion;
 	 	 this.Fax=fax;
 	 	 this.Nit=nit;
 	 	 this.Nombre=nombre;
 	 	 this.Telefono=telefono;  
}
 }
 }