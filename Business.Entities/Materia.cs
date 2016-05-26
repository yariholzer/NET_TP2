using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Materia : BusinessEntity
    {
        private int idPlan;
        private string descripcion;
        private int hsSemanales;
        private int hsTotales;
        
        public int IdPlan
        {
            get { return idPlan; }
            set { idPlan = value; }
        }
        public string descripciones
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public int horasSemanales
        {
            get { return hsSemanales; }
            set { hsSemanales = value; }
        }
        public int horasTotales
        {
            get { return hsTotales; }
            set { hsTotales = value; }
        }
    }
}
