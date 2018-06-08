// FILE: /Users/torrefuertesas/Documents/AGRICULTUREAPP/desarrollo/desarrollo/AsisTecnica/ControlPlaga.cs

// In this section you can add your own using directives
// section 127-0-0-1-b925873:1602388c7c9:-8000:0000000000000955 begin
// section 127-0-0-1-b925873:1602388c7c9:-8000:0000000000000955 end
using System;

namespace agricultureapp.Model.Models.AsisTecnica {

/// <summary>
    ///  A class that represents ...
    /// 
    ///  @see OtherClasses
    ///  @author Didier Restrepo
     /// </summary>
public class ControlPlaga
{    /* {src_lang=CSharp}*/

    // Attributes

    public long Id{ get; set; }

    public DateTimeOffset Fecha_aplicacion{ get; set; }

    public float Dosis{ get; set; }

    // Associations

    /// <summary> 
    /// </summary>
    
    public Tratamiento Tratamiento{get;set;}
    public long Tratamiento_Id{get;set;}
    public UnidadMedida Unidad{get;set;}
    public int UnidadMedidaId{ get; set; }
    public Cultivo  Cultivo{ get; set; }
    public long CultivoId{ get; set; }
   
    public Enfermedades Enfermedades{get;set;}
    public long EnfermedadesId{get;set;}
    public bool estadoRadicacion{get;set;}
    public DateTimeOffset? FechaErradicacion { get; set; } 
   
} /* end class ControlPlaga */

}
