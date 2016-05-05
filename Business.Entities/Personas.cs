using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Personas:BusinessEntity
    {
        public string apellido { get; set; }
        public string direccion { get; set; }
        public string email { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public int idPlan { get; set; }
        public int legajo { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }
        public TiposPersonas tipoPersona { get; set; } // ver de donde sale el tipo personas

    }
}
