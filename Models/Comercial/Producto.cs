// FILE: /Users/torrefuertesas/Documents/AGRICULTUREAPP/desarrollo/desarrollo/desarrollo/Comercial/Producto.cs

using System;
using System.Collections;
using agricultureapp.Model.Models.AsisTecnica;

// In this section you can add your own using directives
// section -64--88-100-66--3af3d28b:1604fedd038:-8000:0000000000000F69 begin
// section -64--88-100-66--3af3d28b:1604fedd038:-8000:0000000000000F69 end
namespace  agricultureapp.Model.Models.Comercial {

/// <summary>
    ///  A class that represents ...
    /// 
    ///  @see OtherClasses
    ///  @author your_name_here
     /// </summary>
public class Producto
{    /* {src_lang=CSharp}*/

    // Attributes, upid, loteId

    public long Id{get;set;}
    public string nombre{get;set;}

    public string CodigoUp{get;set;}

    public string Descripcion{get;set;}

    public decimal Precio{get;set;}

    public decimal? PrecioSpecial{get;set;}

    public float Stock{get;set;}

    public string Imagen{get;set;}

    public bool IsEnable{get;set;}

    public DateTime FechaLimiteDisponibilidad{get;set;}

    // Associations
    
    public Calidad Calidad{get;set;}
    public long CalidadId{get;set;}

    
    public Categoria Categoria{get;set;}
    public int CategoriaId{get;set;}

    public Cultivo Cultivo{get;set;}
    public long cultivoId{get;set;}
        
    /// <summary> 
    /// </summary>


} /* end class Producto */

}
