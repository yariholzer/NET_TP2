using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class AlumnoInscripcion : BusinessEntity
    {
        private int idAlumno;
        private int idCurso;
        private string condicion;
        private int nota;

        public int IdAlumno
        {
            get { return idAlumno; }
            set { idAlumno = value; }
        }
        public int IdCurso
        {
            get { return idCurso; }
            set { idCurso = value; }
        }
        public string Condicion
        {
            get { return condicion; }
            set { condicion = value; }
        }
        public int Nota
        {
            get { return nota; }
            set { nota = value; }
        }
    }
}
