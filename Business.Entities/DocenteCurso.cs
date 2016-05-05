using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class DocenteCurso:BusinessEntity
    {
        public TiposCargos cargo { get; set; }
        public int idCurso { get; set; }

        public int idDocente { get; set; }

        
    }
}
