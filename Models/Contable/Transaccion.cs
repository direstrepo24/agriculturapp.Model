// FILE: /Users/torrefuertesas/Documents/AGRICULTUREAPP/DISEÑO/DISEÑO/Contabilidad/Transaccion.cs

using System;


// In this section you can add your own using directives
    // section -64--88-100-66--3af3d28b:1604fedd038:-8000:00000000000010F3 begin
    // section -64--88-100-66--3af3d28b:1604fedd038:-8000:00000000000010F3 end
namespace agricultureapp.Model.Models.Contabilidad {

/// <summary>
    ///  A class that represents ...
    /// 
    ///  @see OtherClasses
    ///  @author your_name_here
     /// </summary>
public class Transaccion
{    /* {src_lang=CSharp}*/

    // Attributes

    public long Id{get;set;}

    public int PUC_Id;

    public string Concepto{get;set;}
    public decimal Cantidad{get;set;}

    public decimal Valor{get;set;}

    public DateTime Fecha{get;set;}


    // Associations
  public Tercero Tercero{get;set;}
  public int TerceroId{get;set;}
    /// <summary> 
    /// </summary>
   public Naturaleza Naturaleza{get;set;}
    public int NaturalezaId{get;set;}
    public Estado Estado{get;set;}
    public int EstadoId{get;set;}
    public long CultivoId{get;set;}
    //13 abril
    public string userId{get;set;}
    /// <summary> 
    /// </summary>

    /// <summary> 
    /// </summary>

    /// <summary> 
    /// </summary>
} /* end class Transaccion */

}
