using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Materia:BusinessEntity
    {
        public string descripcion { get; set; }
        public int hsSemanales { get; set; }
        public int hsTotales { get; set; }
        public int idPlan { get; set; }
    }
}
