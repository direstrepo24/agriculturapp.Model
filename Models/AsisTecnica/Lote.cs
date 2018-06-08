// FILE: /Users/torrefuertesas/Documents/AGRICULTUREAPP/desarrollo/desarrollo/AsisTecnica/Lote.cs

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

// In this section you can add your own using directives
// section 127-0-0-1-b925873:1602388c7c9:-8000:00000000000008A8 begin
// section 127-0-0-1-b925873:1602388c7c9:-8000:00000000000008A8 end
namespace agricultureapp.Model.Models.AsisTecnica {

/// <summary>
    ///  A class that represents ...
    /// 
    ///  @see OtherClasses
    ///  @author your_name_here
     /// </summary>
public class Lote
{    /* {src_lang=CSharp}*/

    // Attributes
    public long Id{ get; set; }

    public string Codigo{ get; set; }
    public string Nombre{get;set;}
    public string Descripcion{get;set;}

    public string Localizacion{ get; set; }

    public string Localizacion_Poligono{ get; set; }

    public float Area{ get; set; }

    // Associations

    /// <summary> 
    /// </summary>
    //en metros cuadrados o hectareas
    public int UnidadMedidaId{get;set;}
    public UnidadMedida UnidadMedida{get;set;}
    public long unidadproductivaId{get;set;}
    public UnidadProductiva  unidadproductiva{ get; set; }

    public ICollection<Cultivo>  Cultivo{ get; set; }

    // Operations

    /// <summary>
    ///  An operation that does...
    /// 
    ///  @param firstParam a description of this parameter
    /// </summary>
    /// <returns>
    /// </returns>
    public Lote()
        {
            Cultivo= new Collection<Cultivo>();
        }
} /* end class Lote */

}
