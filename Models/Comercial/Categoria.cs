

using System.Collections.Generic;
using System.Collections.ObjectModel;

// In this section you can add your own using directives
// section -64--88-100-66--3af3d28b:1604fedd038:-8000:0000000000000F75 begin
// section -64--88-100-66--3af3d28b:1604fedd038:-8000:0000000000000F75 end
namespace agricultureapp.Model.Models.Comercial {

/// <summary>
    ///  A class that represents ...
    /// 
    ///  @see OtherClasses
    ///  @author your_name_here
     /// </summary>
public class Categoria
{    /* {src_lang=CSharp}*/

    // Attributes

    public int Id{ get; set; }

    public string Nombre{ get; set; }

    public string Descripcion{ get; set; }

    //public Categoria Parent;

    public string Imagen{ get; set; }

    // Associations

    public ICollection<ProductCategoria>  productcategoria{ get; set; }

     public Categoria()
        {
            productcategoria= new Collection<ProductCategoria>();
        }
} /* end class Categoria */

}
