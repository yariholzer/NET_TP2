using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Comision:BusinessEntity
    {
        public int anioEspecialidad { get; set; }
        public int idPlan { get; set; }
        public string descripcion { get; set; }
        

        
    }
}
