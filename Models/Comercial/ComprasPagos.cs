// FILE: /Users/torrefuertesas/Documents/AGRICULTUREAPP/desarrollo/desarrollo/desarrollo/Comercial/comprasPagos.cs

// In this section you can add your own using directives
// section -64--88-100-66--3af3d28b:1604fedd038:-8000:000000000000102D begin
// section -64--88-100-66--3af3d28b:1604fedd038:-8000:000000000000102D end
using System;

namespace agricultureapp.Model.Models.Comercial {

/// <summary>
    ///  A class that represents ...
    /// 
    ///  @see OtherClasses
    ///  @author your_name_here
     /// </summary>
public class ComprasPagos
{    /* {src_lang=CSharp}*/

    // Attributes

    public long Id{ get; set; }
    
    //asociations
    
    public Pagos pagos{get;set;}
    public long PagoId{ get; set; }

    public Compras compras{get;set;}
    public long CompraId{ get; set; }

    public DateTimeOffset CreatedOn { get; set; }

    public DateTimeOffset UpdatedOn { get; set; }

    // Associations


    /// <summary> 
    /// </summary>
} /* end class comprasPagos */

}
