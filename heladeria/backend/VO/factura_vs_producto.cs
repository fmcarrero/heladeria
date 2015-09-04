using System; 
 using System.Collections.Generic; 
 using System.Linq; 
 using System.Text; 
 namespace heladeria.backend.VO{ 
 
	 public class factura_vs_producto{ 
	 	 public decimal Cantidad {get;set;}
	 	 public String Id_Factura {get;set;}
	 	 public String Id_Producto {get;set;}
	 	 public decimal Precio_Venta {get;set;}
	 	 public decimal Subtotal {get;set;}
	 	 public decimal Total {get;set;}
	
 	 public factura_vs_producto(){}
 	 public factura_vs_producto (decimal cantidad,String id_factura,String id_producto,decimal precio_venta,decimal subtotal,decimal total) { 
 	 	 this.Cantidad=cantidad;
 	 	 this.Id_Factura=id_factura;
 	 	 this.Id_Producto=id_producto;
 	 	 this.Precio_Venta=precio_venta;
 	 	 this.Subtotal=subtotal;
 	 	 this.Total=total;  
}
 }
 }