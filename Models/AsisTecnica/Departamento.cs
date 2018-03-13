using System.Collections.Generic;

namespace agricultureapp.Model.Models.AsisTecnica
{
    public class Departamento
    {
         public long Id{ get; set; }
        
        public long codigodpto{ get; set; }
        public string Nombre{ get; set; }
        //[JsonIgnore]
        public virtual ICollection<Ciudad> ciudades{get;set;}
    }
}