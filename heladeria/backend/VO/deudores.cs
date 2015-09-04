using System; 
 using System.Collections.Generic; 
 using System.Linq; 
 using System.Text; 
 namespace heladeria.backend.VO{ 
 
	 public class deudores{ 
	 	 public decimal Documento_Identidad {get;set;}
	 	 public decimal Total_Debido {get;set;}
	
 	 public deudores(){}
 	 public deudores (decimal documento_identidad,decimal total_debido) { 
 	 	 this.Documento_Identidad=documento_identidad;
 	 	 this.Total_Debido=total_debido;  
}
 }
 }