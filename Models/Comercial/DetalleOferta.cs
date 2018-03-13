// FILE: /Users/torrefuertesas/Documents/AGRICULTUREAPP/desarrollo/desarrollo/desarrollo/Comercial/DetalleOferta.cs

// In this section you can add your own using directives
// section -64--88-100-66--3af3d28b:1604fedd038:-8000:0000000000000F6A begin
// section -64--88-100-66--3af3d28b:1604fedd038:-8000:0000000000000F6A end
using agricultureapp.Model.Models.AsisTecnica;

namespace agricultureapp.Model.Models.Comercial {

/// <summary>
    ///  A class that represents ...
    /// 
    ///  @see OtherClasses
    ///  @author your_name_here
     /// </summary>
public class DetalleOferta
{    /* {src_lang=CSharp}*/

    // Attributes

    public int Id{ get; set; }
    
    public decimal Cantidad{get;set;}


    public decimal Valor_Oferta{ get; set; }

    public decimal? Valor_minimo{ get; set; }

    public decimal? Valor_transaccion{ get; set; }

    // Associations
   

    public Producto Producto{get;set;}
     public long ProductoId{ get; set; }

    public Calidad Calidad{get;set;}
    public long CalidadId{get;set;}

 
    public UnidadMedida UnidadMedida{get;set;}
    public int UnidadMedidaId{get;set;}
    

    /// <summary> 
    /// </summary>
} /* end class DetalleOferta */

}
