// FILE: /Users/torrefuertesas/Documents/AGRICULTUREAPP/desarrollo/desarrollo/AsisTecnica/Receta.cs

// In this section you can add your own using directives
    // section 127-0-0-1-b925873:1602388c7c9:-8000:00000000000008F4 begin
    // section 127-0-0-1-b925873:1602388c7c9:-8000:00000000000008F4 end
namespace agricultureapp.Model.Models.AsisTecnica {

/// <summary>
    ///  A class that represents ...
    /// 
    ///  @see OtherClasses
    ///  @author your_name_here
     /// </summary>
public class Receta
{    /* {src_lang=CSharp}*/

    // Attributes

    public long Id{get;set;}

     public string nombre{get;set;}

    public string Modo_uso{get;set;}

    public float Dosis{get;set;}

   

  

    // Associations

    /// <summary> 
    /// </summary>
     public long InsumoId{get;set;}
    public Insumo  insumo{get;set;}

  
    /// <summary> 
    /// </summary>
   
    public Equipo  equipo{get;set;}
    public long EquipoId{get;set;}

  
    /// <summary> 
    /// </summary>
   
    public UnidadMedida  unidad{get;set;}
     public int UnidadId{get;set;}

   
   
} /* end class Receta */

}
