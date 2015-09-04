using System; 
 using System.Collections.Generic; 
 using System.Linq; 
 using System.Text; 
 namespace heladeria.backend.VO{ 
 
	 public class proveedor_vs_producto{ 
	 	 public String Codigo {get;set;}
	 	 public String Nit {get;set;}
	 	 public decimal Precio_Venta {get;set;}
	
 	 public proveedor_vs_producto(){}
 	 public proveedor_vs_producto (String codigo,String nit,decimal precio_venta) { 
 	 	 this.Codigo=codigo;
 	 	 this.Nit=nit;
 	 	 this.Precio_Venta=precio_venta;  
}
 }
 }