
/* {author=Didier Restrepo Bravo, version=0.1, since=11 noviembre 2017}*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using agricultureapp.Model.Models.Comercial;

// In this section you can add your own using directives
// section 127-0-0-1-b925873:1602388c7c9:-8000:0000000000000871 begin
// section 127-0-0-1-b925873:1602388c7c9:-8000:0000000000000871 end
namespace agricultureapp.Model.Models.AsisTecnica {

/// <summary>
    ///  A class that represents el proceso de aistencia tecnica...
    /// 
    ///  @see Clases AGRICULTUREAPP
    ///  @author Didier Restrepo
     /// </summary>
public class Cultivo
{    /* {src_lang=CSharp}*/

    // Attributes
     public long Id{ get; set; }
    public string Nombre{ get; set; }

    public string Descripcion{ get; set; }
    public DateTime FechaIncio{get;set;}
    public DateTime FechaFin{get;set;}
    public decimal EstimadoCosecha{get;set;}
     //numero de arboles sembrados   
    public long siembraTotal{get;set;}//P

    // Associations
    public virtual Lote  Lote{ get; set; }
    public long LoteId{get;set;}
    public int UnidadMedidaId{get;set;}
    public UnidadMedida UnidadMedida{get;set;}
   
    public DetalleTipoProducto DetalleTipoProducto{get;set;}
    public long DetalleTipoProductoId{get;set;}
    // Operations

   public ICollection<ControlPlaga> Controlplaga {get; set;}
        /// <summary>
    ///  An operation that does...
    /// 
    ///  @param firstParam a description of this parameter
    /// </summary>
    /// <param name="Nombre">
    /// </param>
    /// <returns>
    /// </returns>

    public  Cultivo()
    {
        Controlplaga= new Collection<ControlPlaga>();
    }
} /* end class Cultivo */

}
