using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class DocenteCurso : BusinessEntity
    {
        private int idCurso;
        private int idDocente;
        //private TiposCargos cargo;  la clase "TiposCargos" no esta en en diagrama tampoco"

        //public TiposCargos cargo { get; set; }
        public int IdCurso
        {
            get { return IdCurso; }
            set { IdCurso = value; }
        }
        public int IdDocente
        {
            get { return idDocente; }
            set { idDocente = value; }
        }       
    }
}
