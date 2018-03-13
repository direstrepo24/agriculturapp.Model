// FILE: /Users/torrefuertesas/Documents/AGRICULTUREAPP/desarrollo/desarrollo/desarrollo/Comercial/Pagos.cs

using System;
using System.Collections;
using System.Collections.Generic;

// In this section you can add your own using directives
// section -64--88-100-66-546e8268:1604ba4a48f:-8000:0000000000000B63 begin
// section -64--88-100-66-546e8268:1604ba4a48f:-8000:0000000000000B63 end
namespace agricultureapp.Model.Models.Comercial {

/// <summary>
    ///  A class that represents ...
    /// 
    ///  @see OtherClasses
    ///  @author your_name_here
     /// </summary>
public class Pagos
{    /* {src_lang=CSharp}*/

    // Attributes

    public long Id{get;set;}

    public decimal Monto{get;set;}

    public decimal? Saldo{get;set;}

    public MetodoPago MetodoPago{get;set;}
    public int MetodoPagoId{get;set;}

    public DateTimeOffset CreatedOn { get; set; }

     public DateTimeOffset UpdatedOn { get; set; }

    // Associations

    public ICollection<ComprasPagos>  comprasPagos;

    /// <summary> 
    /// </summary>
} /* end class Pagos */

}
