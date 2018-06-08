namespace agricultureapp.Model.Models.AsisTecnica
{
    public class Calificacion
    {
        public int Id{get;set;}
        public string Nombre{get;set;}

        public decimal Valor{get;set;}
        public Tratamiento Tratamiento{get;set;}
        public int? tratamientoId{get;set;}

        public string userId{get;set;}
    }
}