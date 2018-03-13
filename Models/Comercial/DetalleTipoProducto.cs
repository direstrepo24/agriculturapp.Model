namespace agricultureapp.Model.Models.Comercial
{
    public class DetalleTipoProducto
    {
        public long Id{get;set;}
        public string Nombre{get;set;}
        public string Descripcion{get;set;}

        //Asociations
        public virtual TipoProducto TipoProducto{get;set;}
        public long TipoProductoId{get;set;}
    }
}