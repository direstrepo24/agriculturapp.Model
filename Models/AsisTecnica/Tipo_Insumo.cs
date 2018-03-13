// FILE: /Users/torrefuertesas/Documents/AGRICULTUREAPP/desarrollo/desarrollo/AsisTecnica/Tipo_Insumo.cs

// In this section you can add your own using directives
// section 127-0-0-1-b925873:1602388c7c9:-8000:0000000000000944 begin
// section 127-0-0-1-b925873:1602388c7c9:-8000:0000000000000944 end
using System.Collections.Generic;

namespace agricultureapp.Model.Models.AsisTecnica {

/// <summary>
    ///  A class that represents ...
    /// 
    ///  @see OtherClasses
    ///  @author your_name_here
     /// </summary>
public class Tipo_Insumo
{    /* {src_lang=CSharp}*/

    // Attributes

    public int Id{get;set;}

    public string Nombre{get;set;}

    // Associations

    /// <summary> 
    /// </summary>
    public ICollection<Insumo>  insumo{get;set;}
} /* end class Tipo_Insumo */

}
