using System; 
 using System.Collections.Generic; 
 using System.Linq; 
 using System.Text; 
 namespace heladeria.backend.VO{ 
 
	 public class factura_vs_deudores{ 
	 	 public decimal Documento_Identidad {get;set;}
	 	 public String Id_Factura {get;set;}
	 	 public decimal Total {get;set;}
	
 	 public factura_vs_deudores(){}
 	 public factura_vs_deudores (decimal documento_identidad,String id_factura,decimal total) { 
 	 	 this.Documento_Identidad=documento_identidad;
 	 	 this.Id_Factura=id_factura;
 	 	 this.Total=total;  
}
 }
 }