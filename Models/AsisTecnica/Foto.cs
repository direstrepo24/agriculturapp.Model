// FILE: /Users/torrefuertesas/Documents/AGRICULTUREAPP/desarrollo/desarrollo/AsisTecnica/Enfermedades.cs

using System;

namespace agricultureapp.Model.Models.AsisTecnica
{
    public class Foto
    {
        public long Id { get; set; }
        public string Titulo{ get; set; }
        public string Descripcion { get; set; }
        public string Ruta { get; set; }
        public DateTime FechaCreacion{ get; set; }
        public string Hora{ get; set; }
        //asociations
       
        public Enfermedades Enfermedades{get;set;}
         public long EnfermedadesId{get;set;}
    }
}