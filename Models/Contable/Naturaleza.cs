// FILE: /Users/torrefuertesas/Documents/AGRICULTUREAPP/DISEÑO/DISEÑO/Contabilidad/Naturaleza.cs

// In this section you can add your own using directives
// section -64--88-100-66--3af3d28b:1604fedd038:-8000:0000000000000F76 begin
// section -64--88-100-66--3af3d28b:1604fedd038:-8000:0000000000000F76 end
using System.Collections.Generic;

namespace agricultureapp.Model.Models.Contabilidad {

/// <summary>
    ///  A class that represents ...
    /// 
    ///  @see OtherClasses
    ///  @author your_name_here
     /// </summary>
public class Naturaleza
{    /* {src_lang=CSharp}*/

    // Attributes

    public int Id{get;set;}

    public string Nombre{get;set;}

    // Associations

    /// <summary> 
    /// </summary>
    public virtual ICollection<Transaccion> transacciones{get;set;}
} /* end class Naturaleza */

}
