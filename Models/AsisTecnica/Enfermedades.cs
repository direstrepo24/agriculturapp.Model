// FILE: /Users/torrefuertesas/Documents/AGRICULTUREAPP/desarrollo/desarrollo/AsisTecnica/Enfermedades.cs

// In this section you can add your own using directives
// section 127-0-0-1-b925873:1602388c7c9:-8000:000000000000089E begin
// section 127-0-0-1-b925873:1602388c7c9:-8000:000000000000089E end
using System.Collections.Generic;
using System.Collections.ObjectModel;
using agricultureapp.Model.Models.Comercial;

namespace agricultureapp.Model.Models.AsisTecnica  {

/// <summary>
    ///  A class that represents ...
    /// 
    ///  @see OtherClasses
    ///  @author your_name_here
     /// </summary>
public class Enfermedades
{    /* {src_lang=CSharp}*/

    // Attributes

    public long Id{ get; set; }

    public string Codigo{ get; set; }

   // public string Nombre{ get; set; }

   // public string NombreCientifico{ get; set; }

    //public string Descripcion{ get; set; }
    public TipoProducto TipoProducto{get;set;}
    public long TipoProductoId{get;set;}

    public TipoEnfermedad TipoEnfermedad{get;set;}
    public long TipoEnfermedadId{get;set;}
    
     
    public ICollection<Foto> Fotos {get; set;}
    public Enfermedades()
        {
            Fotos= new Collection<Foto>();
        }
  
} /* end class Enfermedades */

}
