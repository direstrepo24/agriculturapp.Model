// FILE: /Users/torrefuertesas/Documents/AGRICULTUREAPP/desarrollo/desarrollo/AsisTecnica/Rol.cs

using System.Collections;
using System.Collections.Generic;

// In this section you can add your own using directives
// section -64--88-100-66--25ee2308:1618a464798:-8000:00000000000010A2 begin
// section -64--88-100-66--25ee2308:1618a464798:-8000:00000000000010A2 end
namespace agricultureapp.Model.Models.AsisTecnica {

/// <summary>
    ///  A class that represents ...
    /// 
    ///  @see OtherClasses
    ///  @author your_name_here
     /// </summary>
public class Rol
{    /* {src_lang=CSharp}*/

    // Attributes

    public string Id{get;set;}

    public string Nombre{get;set;}

    // Associations

    
    public ICollection<Usuario>  usuario{get;set;}
} /* end class Rol */

}
