// FILE: /Users/torrefuertesas/Documents/AGRICULTUREAPP/desarrollo/desarrollo/AsisTecnica/Equipo.cs

// In this section you can add your own using directives
// section 127-0-0-1-b925873:1602388c7c9:-8000:0000000000000921 begin
// section 127-0-0-1-b925873:1602388c7c9:-8000:0000000000000921 end
using System.Collections.Generic;

namespace agricultureapp.Model.Models.AsisTecnica {

/// <summary>
    ///  A class that represents ...
    /// 
    ///  @see OtherClasses
    ///  @author Didier Restrepo
     /// </summary>
public class Equipo
{    /* {src_lang=CSharp}*/

    // Attributes

    public long Id{ get; set; }

    public string Nombre{ get; set; }

    public string Marca{ get; set; }

    // Associations

    /// <summary> 
    /// </summary>
   public ICollection<Receta> recetas{ get; set; }
} /* end class Equipo */

}
