using System;

namespace agricultureapp.Model.Models.AsisTecnica
{
    public class Produccion
    {
        public long Id{get;set;}
        public DateTime FechaInicio{get;set;}
        //Fecha estimada de produccion 
        public DateTime FechaFin{get;set;}
          // Associations
        
        public Cultivo cultivo{get;set;} 
        public long CultivoId{get;set;}
        //cambiar nombre a produccion real
        public decimal produccionEstimada{get;set;}
        public UnidadMedida unidadMedida{get;set;}
        public int unidadMedidaId{get;set;}
        

    }
}