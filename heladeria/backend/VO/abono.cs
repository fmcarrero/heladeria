using System; 
 using System.Collections.Generic; 
 using System.Linq; 
 using System.Text; 
 namespace heladeria.backend.VO{ 
 
	 public class abono{ 
	 	 public String Codigo {get;set;}
	 	 public decimal Documento_Identidad {get;set;}
	 	 public DateTime Fecha {get;set;}
	 	 public String Hora {get;set;}
	 	 public String Usuario {get;set;}
	 	 public decimal Valor {get;set;
        }
	
 	 public abono(){}
 	 public abono (String codigo,decimal documento_identidad,DateTime fecha,String hora,String usuario,decimal valor) { 
 	 	 this.Codigo=codigo;
 	 	 this.Documento_Identidad=documento_identidad;
 	 	 this.Fecha=fecha;
 	 	 this.Hora=hora;
 	 	 this.Usuario=usuario;
 	 	 this.Valor=valor;  
}
 }
 }