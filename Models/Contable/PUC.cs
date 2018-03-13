// FILE: /Users/torrefuertesas/Documents/AGRICULTUREAPP/DISEÑO/DISEÑO/Contabilidad/PUC.cs


// In this section you can add your own using directives
// section -64--88-100-66--3af3d28b:1604fedd038:-8000:0000000000000F77 begin
// section -64--88-100-66--3af3d28b:1604fedd038:-8000:0000000000000F77 end
using System.Collections.Generic;

namespace agricultureapp.Model.Models.Contabilidad {

/// <summary>
    ///  A class that represents ...
    /// 
    ///  @see OtherClasses
    ///  @author your_name_here
     /// </summary>
public class PUC
{    /* {src_lang=CSharp}*/

    // Attributes
    public long Id{get;set;}
    public string Codigo{get;set;}

    public string Descripcion{get;set;}

    public CategoriaPUC Categoria{get;set;}

    // Associations

    /// <summary> 
    /// </summary>
    public ICollection<Transaccion>  Transaccion{get;set;}
} /* end class PUC */

}
