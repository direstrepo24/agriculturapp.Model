// FILE: /Users/torrefuertesas/Documents/AGRICULTUREAPP/DISEÑO/DISEÑO/Contabilidad/Estado.cs

// In this section you can add your own using directives
// section -64--88-100-66--3af3d28b:1604fedd038:-8000:0000000000001118 begin
// section -64--88-100-66--3af3d28b:1604fedd038:-8000:0000000000001118 end
using System.Collections.Generic;

namespace agricultureapp.Model.Models.Contabilidad {

/// <summary>
    ///  A class that represents ...
    /// 
    ///  @see OtherClasses
    ///  @author your_name_here
     /// </summary>
public class Estado
{    /* {src_lang=CSharp}*/

    // Attributes

    public int Id{get;set;}

    public string Nombre{get;set;}

    // Associations

    /// <summary> 
    /// </summary>
    public ICollection<Transaccion> transacciones{get;set;}
} /* end class Estado */

}
