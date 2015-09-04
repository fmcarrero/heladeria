using System; 
 using System.Collections.Generic; 
 using System.Linq; 
 using System.Text; 
 namespace heladeria.backend.VO{ 
 
	 public class factura{ 
	 	 public String Codigo {get;set;}
	 	 public decimal Documento_Identidad {get;set;}
	 	 public DateTime Fecha {get;set;}
	 	 public String Hora {get;set;}
	 	 public String Id_Pago {get;set;}
	 	 public decimal Total {get;set;}
	 	 public String Usuario {get;set;}
	
 	 public factura(){}
 	 public factura (String codigo,decimal documento_identidad,DateTime fecha,String hora,String id_pago,decimal total,String usuario) { 
 	 	 this.Codigo=codigo;
 	 	 this.Documento_Identidad=documento_identidad;
 	 	 this.Fecha=fecha;
 	 	 this.Hora=hora;
 	 	 this.Id_Pago=id_pago;
 	 	 this.Total=total;
 	 	 this.Usuario=usuario;  
}
 }
 }