using System.Collections.Generic;
using agricultureapp.Model.Models.AsisTecnica;

namespace agricultureapp.Model.Models.Comercial
{
    public class DetalleMetodopago
    {
        public int Id{get;set;}
        public string Nombre{get;set;}

        public MetodoPago MetodoPago{get;set;}
        public int MetodoPagoId{get;set;}

        public ICollection<Usuario> Usuarios{get;set;}
         
    }
}