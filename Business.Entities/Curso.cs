using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Curso:BusinessEntity
    {
        public int anioCalendario { get; set; }
        public int cupo { get; set; }
        public string descripcion { get; set; }
        public int idComision { get; set; }
        public int idMateria { get; set; }
    }
}
