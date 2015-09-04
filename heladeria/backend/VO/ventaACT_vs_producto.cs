using System; 
 using System.Collections.Generic; 
 using System.Linq; 
 using System.Text; 
 namespace heladeria.backend.VO{ 
 
	 public class ventaACT_vs_producto{ 
	 	 public decimal Cantidad {get;set;}
	 	 public String Codigo_Producto {get;set;}
	 	 public String Id_Factura {get;set;}
	 	 public decimal Precio_Venta {get;set;}
	 	 public decimal Total {get;set;}
	
 	 public ventaACT_vs_producto(){}
 	 public ventaACT_vs_producto (decimal cantidad,String codigo_producto,String id_factura,decimal precio_venta,decimal total) { 
 	 	 this.Cantidad=cantidad;
 	 	 this.Codigo_Producto=codigo_producto;
 	 	 this.Id_Factura=id_factura;
 	 	 this.Precio_Venta=precio_venta;
 	 	 this.Total=total;  
}
 }
 }