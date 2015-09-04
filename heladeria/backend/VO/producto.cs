using System; 
 using System.Collections.Generic; 
 using System.Linq; 
 using System.Text; 
 namespace heladeria.backend.VO{ 
 
	 public class producto{ 
	 	 public String Codigo {get;set;}
	 	 public String Descripcion {get;set;}
	 	 public float Descuento {get;set;}
	 	 public String Id_Categoria {get;set;}
	 	 public decimal Iva {get;set;}
	 	 public String Nombre {get;set;}
	 	 public float Precio_Base {get;set;}
	 	 public decimal Precio_Venta {get;set;}
	 	 public decimal Stock {get;set;}
	
 	 public producto(){}
 	 public producto (String codigo,String descripcion,float descuento,String id_categoria,decimal iva,String nombre,float precio_base,decimal precio_venta,decimal stock) { 
 	 	 this.Codigo=codigo;
 	 	 this.Descripcion=descripcion;
 	 	 this.Descuento=descuento;
 	 	 this.Id_Categoria=id_categoria;
 	 	 this.Iva=iva;
 	 	 this.Nombre=nombre;
 	 	 this.Precio_Base=precio_base;
 	 	 this.Precio_Venta=precio_venta;
 	 	 this.Stock=stock;  
}
 }
 }