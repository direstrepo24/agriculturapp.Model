// FILE: /Users/torrefuertesas/Documents/AGRICULTUREAPP/DISEÑO/DISEÑO/Contabilidad/Tercero.cs

// In this section you can add your own using directives
// section -64--88-100-66--3af3d28b:1604fedd038:-8000:0000000000000F78 begin
// section -64--88-100-66--3af3d28b:1604fedd038:-8000:0000000000000F78 end
using System.Collections.Generic;

namespace agricultureapp.Model.Models.Contabilidad {

/// <summary>
    ///  A class that represents ...
    /// 
    ///  @see OtherClasses
    ///  @author Didier Restrepo Bravo
    ///3184042440 
     /// </summary>
public class Tercero
{    /* {src_lang=CSharp}*/
    // Attributes
    public int Id{get;set;}

    public string Nombre{get;set;}

    public string Apellido{get;set;}

    public string Nit_RUC{get;set;}
    public string Direccion{get;set;}
    // Associations
    /// <summary> 
    /// </summary>
    public ICollection<Transaccion>  myTransaccion;
} /* end class Tercero */

}
