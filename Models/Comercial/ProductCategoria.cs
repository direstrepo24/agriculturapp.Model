// FILE: /Users/torrefuertesas/Documents/AGRICULTUREAPP/desarrollo/desarrollo/desarrollo/Comercial/ProductCategoria.cs

// In this section you can add your own using directives
    // section -64--88-100-66--3af3d28b:1604fedd038:-8000:0000000000000FA1 begin
    // section -64--88-100-66--3af3d28b:1604fedd038:-8000:0000000000000FA1 end
namespace agricultureapp.Model.Models.Comercial {

/// <summary>
    ///  A class that represents ...
    /// 
    ///  @see OtherClasses
    ///  @author your_name_here
     /// </summary>
public class ProductCategoria
{    /* {src_lang=CSharp}*/

    // Attributes

    public long Id{get;set;}

    public bool IsDestacado;

    // Associations

    public virtual Categoria Categoria{get;set;}
    public int CategoriaId{get;set;}

    public virtual Producto Producto{get;set;}
     public long ProductoId{get;set;}

    /// <summary> 
    /// </summary>

    /// <summary> 
    /// </summary>
} /* end class ProductCategoria */

}
