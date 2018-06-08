// FILE: /Users/torrefuertesas/Documents/AGRICULTUREAPP/desarrollo/desarrollo/AsisTecnica/Insumo.cs

using System;
using System.Collections;

// In this section you can add your own using directives
    // section 127-0-0-1-b925873:1602388c7c9:-8000:000000000000089D begin
    // section 127-0-0-1-b925873:1602388c7c9:-8000:000000000000089D end
namespace agricultureapp.Model.Models.AsisTecnica{

/// <summary>
    ///  A class that represents ...
    /// 
    ///  @see OtherClasses
    ///  @author your_name_here
     /// </summary>
public class Insumo
{    /* {src_lang=CSharp}*/

    // Attributes

    public long Id{ get; set; }

    public string Nombre{ get; set; }

    public string Descripcion{ get; set; }

    public DateTime Fecha_Vencimiento{ get; set; }

    public String lote_laboratorio{ get; set; }
    public string Imagen{get;set;} 

    // Associations
  

    public virtual Laboratorio  laboratorio{ get; set; } 
      public long laboratorioId{ get; set; } 

   
    public virtual Tipo_Insumo  Tipoinsumo{ get; set; } 
     public int Tipo_InsumoId{ get; set; }  
} /* end class Insumo */

}
