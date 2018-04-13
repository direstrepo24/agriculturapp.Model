using System.Collections.Generic;

namespace agricultureapp.Model.Models.Comercial
{
    public class TipoProducto
    {
        public long Id{get;set;}
        public string Nombre{get;set;}
        public string Icono{get;set;}
        public ICollection<DetalleTipoProducto> DetalleTipoProducto{get;set;}
    }
}