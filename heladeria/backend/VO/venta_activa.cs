using System; 
 using System.Collections.Generic; 
 using System.Linq; 
 using System.Text; 
 namespace heladeria.backend.VO{ 
 
	 public class venta_activa{ 
	 	 public DateTime Fecha {get;set;}
	 	 public String Hora {get;set;}
	 	 public String Id_Factura {get;set;}
	 	 public decimal Total {get;set;}
	 	 public String Usuario {get;set;}
	
 	 public venta_activa(){}
 	 public venta_activa (DateTime fecha,String hora,String id_factura,decimal total,String usuario) { 
 	 	 this.Fecha=fecha;
 	 	 this.Hora=hora;
 	 	 this.Id_Factura=id_factura;
 	 	 this.Total=total;
 	 	 this.Usuario=usuario;  
}
 }
 }