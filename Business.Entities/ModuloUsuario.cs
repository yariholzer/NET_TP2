using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class ModuloUsuario:BusinessEntity
    {
        public int idUsuario { get; set; }
        public int idModulo { get; set; }
        public bool permiteAlta { get; set; }
        public bool permiteBaja { get; set; }
        public bool permiteModificacion { get; set; }
        public bool permiteConsulta { get; set; }
    }
}
