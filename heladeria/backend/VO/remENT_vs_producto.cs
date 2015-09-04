using System; 
 using System.Collections.Generic; 
 using System.Linq; 
 using System.Text; 
 namespace heladeria.backend.VO{ 
 
	 public class remENT_vs_producto{ 
	 	 public decimal Cantidad {get;set;}
	 	 public String Codigo_Producto {get;set;}
	 	 public String Codigo_Rem {get;set;}
	 	 public decimal Precio_Venta {get;set;}
	
 	 public remENT_vs_producto(){}
 	 public remENT_vs_producto (decimal cantidad,String codigo_producto,String codigo_rem,decimal precio_venta) { 
 	 	 this.Cantidad=cantidad;
 	 	 this.Codigo_Producto=codigo_producto;
 	 	 this.Codigo_Rem=codigo_rem;
 	 	 this.Precio_Venta=precio_venta;  
}
 }
 }