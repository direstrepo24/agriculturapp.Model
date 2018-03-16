// FILE: /Users/torrefuertesas/Documents/AGRICULTUREAPP/desarrollo/desarrollo/desarrollo/Comercial/Ofertas.cs

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using agricultureapp.Model.Models.AsisTecnica;

// In this section you can add your own using directives
// section -87--2--92-4--19d3f9b4:1604c97e4e4:-8000:0000000000000B63 begin
// section -87--2--92-4--19d3f9b4:1604c97e4e4:-8000:0000000000000B63 end
namespace agricultureapp.Model.Models.Comercial {

/// <summary>
    ///  A class that represents ...
    /// 
    ///  @see OtherClasses
    ///  @author your_name_here
     /// </summary>
public class Ofertas
{    /* {src_lang=CSharp}*/

    // Attributes

    public long Id{get;set;}
    public Usuario Usuario{get;set;}
    public string UsuarioId{get;set;}
     public DateTimeOffset CreatedOn { get; set; }

    public DateTimeOffset UpdatedOn { get; set; }

     public Estado_Oferta EstadoOferta{get;set;}
     public int EstadoOfertaId{get;set;}
    // Associations

     
    public ICollection<DetalleOferta>  detalleoferta{get;set;}
     public Ofertas()
        {
            detalleoferta= new Collection<DetalleOferta>();
        }

    /// <summary> 
    /// </summary>
} /* end class Ofertas */

}
