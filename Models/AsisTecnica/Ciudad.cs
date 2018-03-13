using System.Collections.Generic;
using Newtonsoft.Json;

namespace agricultureapp.Model.Models.AsisTecnica
{
    public class Ciudad
    {
         public long Id{ get; set; }
        public string Nombre{ get; set; }
        [JsonIgnore]
        public virtual Departamento departmento{ get; set; }
        public long departmentoId{ get; set; }
        
        
        [JsonIgnore]
        public virtual ICollection<UnidadProductiva> Elementos { get; set; }

    }
}