

// In this section you can add your own using directives
// section -64--88-100-66--3af3d28b:1604fedd038:-8000:0000000000000F68 begin
// section -64--88-100-66--3af3d28b:1604fedd038:-8000:0000000000000F68 end
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using agricultureapp.Model.Models.AsisTecnica;

namespace agricultureapp.Model.Models.Comercial {

/// <summary>
    ///  A class that represents ...
    /// 
    ///  @see OtherClasses
    ///  @author your_name_here
     /// </summary>
public class Compras
{    /* {src_lang=CSharp}*/

    // Attributes

    public long Id{ get; set; }

   public DateTimeOffset CreatedOn { get; set; }

    public DateTimeOffset UpdatedOn { get; set; }

   public decimal Descuento { get; set; }

    public string CodigoCupon { get; set; }
    public decimal Impuesto { get; set; }

    public decimal TotalCompra { get; set; }
    public string MetodoPago { get; set; }

    // Associations
    

     public virtual Usuario Usuario{get;set;}
    public long UsuarioId{ get; set; }
    

     public CompraStatus CompraStatus { get; set; }
    
    public ICollection<DetalleCompra>  detallecompra{ get; set; }

    public Compras()
        {
            
    
            CreatedOn = DateTimeOffset.Now;
            UpdatedOn = DateTimeOffset.Now;
            CompraStatus = CompraStatus.New;
      
            detallecompra= new Collection<DetalleCompra>();
        }
} /* end class Compras */

}
