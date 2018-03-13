// FILE: /Users/torrefuertesas/Documents/AGRICULTUREAPP/desarrollo/desarrollo/desarrollo/Comercial/MetodoPago.cs

// In this section you can add your own using directives
// section -64--88-100-66--3af3d28b:1604fedd038:-8000:0000000000000F66 begin
// section -64--88-100-66--3af3d28b:1604fedd038:-8000:0000000000000F66 end
using System.Collections.Generic;

namespace agricultureapp.Model.Models.Comercial {

/// <summary>
    ///  A class that represents ...
    /// 
    ///  @see OtherClasses
    ///  @author your_name_here
     /// </summary>
public class MetodoPago
{    /* {src_lang=CSharp}*/

    // Attributes
    public int Id{get;set;}

    public string Nombre{get;set;}

   

   public ICollection<DetalleMetodopago> DetalleMetodopago{get;set;}
    // Associations

    /// <summary> 
    /// </summary>
    public virtual ICollection<Pagos>  Pagos{get;set;}
} /* end class MetodoPago */

}
