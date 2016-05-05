using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class AlumnoInscripcion:BusinessEntity
    {
        public string condicion { get; set; }
        public int idAlumno { get; set; }
        public int idCurso { get; set; }
        public int nota { get; set; }
    }
}
