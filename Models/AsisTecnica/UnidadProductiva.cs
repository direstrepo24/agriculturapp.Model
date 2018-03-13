// FILE: /Users/torrefuertesas/Documents/AGRICULTUREAPP/desarrollo/desarrollo/AsisTecnica/UnidadProductiva.cs

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

// In this section you can add your own using directives
// section 127-0-0-1-b925873:1602388c7c9:-8000:000000000000089F begin
// section 127-0-0-1-b925873:1602388c7c9:-8000:000000000000089F end
namespace agricultureapp.Model.Models.AsisTecnica {

/// <summary>
    ///  A class that represents ...
    /// 
    ///  @see OtherClasses
    ///  @author your_name_here
     /// </summary>
public class UnidadProductiva
{    /* {src_lang=CSharp}*/

    // Attributes Código


    public long Id{get;set;}

    public string Codigo{get;set;}

    public string nombre{get;set;}
    public string descripcion{get;set;}

    public decimal Area{get;set;}

   public ICollection<LocalizacionUp>  Localizacion{get;set;}
    // Associations
   public UnidadMedida UnidadMedida{get;set;}
     public int UnidadMedidaId{get;set;}
   public ICollection<Lote>  lotes{get;set;}

    /// <summary> 
    /// </summary>
    public Usuario  Usuario{get;set;}
    public long UsuarioId{get;set;}
    public Ciudad Ciudad{get;set;}
    public long CiudadId{get;set;} 

    // Operations
    public  UnidadProductiva()
    {
       
        lotes=new Collection<Lote>();
    }

   
} /* end class UnidadProductiva */

}
