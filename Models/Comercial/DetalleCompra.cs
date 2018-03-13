// FILE: /Users/torrefuertesas/Documents/AGRICULTUREAPP/desarrollo/desarrollo/desarrollo/Comercial/DetalleCompra.cs

// In this section you can add your own using directives
// section -64--88-100-66--3af3d28b:1604fedd038:-8000:0000000000000F6B begin
// section -64--88-100-66--3af3d28b:1604fedd038:-8000:0000000000000F6B end
using System;

namespace agricultureapp.Model.Models.Comercial {

/// <summary>
    ///  A class that represents ...
    /// 
    ///  @see OtherClasses
    ///  @author your_name_here
     /// </summary>
public class DetalleCompra
{    /* {src_lang=CSharp}*/

    // Attributes

    public long Id{ get; set; }

    public decimal Precio{ get; set; }

    public decimal Quantity { get;set;}

    public decimal? Impuesto{get;set;}

    public string descripcion{get;set;}

    // Associations
   
    public Producto producto{get;set;}
    public long ProductoId{ get; set; }

    public Compras Compras{get;set;}
    public long ComprasId{get;set;}

    /// <summary> 
    /// </summary>
} /* end class DetalleCompra */

}
