// FILE: /Users/torrefuertesas/Documents/AGRICULTUREAPP/desarrollo/desarrollo/AsisTecnica/Usuario.cs

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using agricultureapp.Model.Models.Comercial;

// In this section you can add your own using directives
// section -64--88-100-66--25ee2308:1618a464798:-8000:000000000000106A begin
// section -64--88-100-66--25ee2308:1618a464798:-8000:000000000000106A end
namespace agricultureapp.Model.Models.AsisTecnica {

/// <summary>
    ///  A class that represents ...
    /// 
    ///  @see OtherClasses
    ///  @author your_name_here
     /// </summary>
public class Usuario
{    /* {src_lang=CSharp}*/

    // Attributes

    public string Id{get;set;}

    public string Nombre{get;set;}

    public string Apellidos{get;set;}

    public string Identificacion{get;set;}

    public string Estado{get;set;}

    public string Nro_movil{get;set;}

     public string Email{get;set;} //character varying(256) COLLATE pg_catalog."default",
    
     public bool EmailConfirmed{get;set;}// boolean NOT NULL,
     public string PhoneNumber{get;set;}// text COLLATE pg_catalog."default",
      
     public bool PhoneNumberConfirmed{get;set;}// boolean NOT NULL,
   
    public string UserName{get;set;}// character varying(256) COLLATE pg_catalog."default",
    public string NumeroCuenta{get;set;}

     public string Fotopefil{get;set;}
     public DetalleMetodopago DetallemetodoPago{get;set;}  
     public int DetallemetodoPagoId{get;set;} 

    // Associations
    public DateTime FechaRegistro{get;set;}

    /// <summary> 
    /// </summary>
    public string RolId{get;set;}
   // public Rol  rol;

   public ICollection<UnidadProductiva> UnidadProductiva{get;set;}
   public  Usuario()
    {
       
        UnidadProductiva=new Collection<UnidadProductiva>();
    }
    // Operations

    /// <summary>
    ///  An operation that does...
    /// 
    ///  @param firstParam a description of this parameter
    /// </summary>
    /// <returns>
    /// </returns>
   
} /* end class Usuario */

}
