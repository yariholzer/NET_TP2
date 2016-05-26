using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Curso : BusinessEntity
    {
        private int idComision;
        private int idMateria;
        private int cupo;
        private int anioCalendario;
        private string descripcion;

        public int AnioCalendario
        {
            get { return anioCalendario; }
            set { anioCalendario = value; }
        }
        public int Cupo
        {
            get { return cupo; }
            set { cupo = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public int IdComision
        {
            get { return idComision; }
            set { idComision = value; }
        }
        public int IdMateria
        {
            get { return idMateria ; }
            set { idMateria = value; }
        }
    }
}
