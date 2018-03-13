namespace agricultureapp.Model.Models.AsisTecnica
{
    public class Tratamiento
    {
        public long Id{get;set;}
        public string Nombre_Comercial{get;set;}
        public string IngredienteActivo{get;set;}
        
        public string Desc_Formulacion{get;set;}
        public string Desc_Aplicacion{get;set;}
        public string Modo_Accion{get;set;}
        public decimal precioAproximado{get;set;}
        public string proveedor{get;set;}
        //asociations
       
        public virtual Categoria_Insumo Categoria_Insumo{get;set;}
        public int Categoria_InsumoId{get;set;}
        public virtual Insumo Insumo{get;set;}
         public long InsumoId{get;set;}


    }
}