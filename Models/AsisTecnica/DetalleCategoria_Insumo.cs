using System.Collections.Generic;

namespace agricultureapp.Model.Models.AsisTecnica
{
    public class DetalleCategoria_Insumo
    {
        public int Id{get;set;}
        public string Nombre{get;set;}
        public char Letra{get;set;}
        public string Descripcion{get;set;}

        //Asociations
        public int CategoriaInsumoId{get;set;}
        public Categoria_Insumo Categoria_Insumo{get;set;}

        public ICollection<Tratamiento> Tratamientos{get;set;}

    }
}