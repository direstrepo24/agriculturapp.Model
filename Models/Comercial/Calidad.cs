// FILE: /Users/torrefuertesas/Documents/AGRICULTUREAPP/desarrollo/desarrollo/desarrollo/Comercial/Calidad.cs


using System.Collections.Generic;
using System.Collections.ObjectModel;

// In this section you can add your own using directives
// section -64--88-100-66--3af3d28b:1604fedd038:-8000:0000000000000F6C begin
// section -64--88-100-66--3af3d28b:1604fedd038:-8000:0000000000000F6C end
namespace agricultureapp.Model.Models.Comercial {

/// <summary>
    ///  A class that represents ...
    /// 
    ///  @see OtherClasses
    ///  @author your_name_here
     /// </summary>
public class Calidad
{    /* {src_lang=CSharp}*/

    // Attributes

    public long Id{ get; set; }

    public string Nombre{ get; set; }

    public string Descripcion{ get; set; }
   

    // Associations

    /// <summary> 
    /// </summary>


    public ICollection<Producto>  producto{ get; set; }

     public Calidad()
        {
            producto= new Collection<Producto>();
        }
} /* end class Calidad */

}
