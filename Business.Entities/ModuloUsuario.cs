using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class ModuloUsuario : BusinessEntity
    {
        private int idModulo;
        private int idUsuario;
        private bool permiteAlta;
        private bool permiteBaja;
        private bool permiteConsulta;
        private bool permiteModificacion;

        public int IdModulo
        {
            get { return idModulo; }
            set { idModulo = value; }
        }
        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }
        public bool PermiteAlta
        {
            get { return permiteAlta; }
            set { permiteAlta = value; }
        }
        public bool PermiteBaja
        {
            get { return permiteBaja; }
            set { permiteBaja = value; }
        }
        public bool PermiteModificacion
        {
            get { return PermiteModificacion; }
            set { PermiteModificacion = value; }
        }
        public bool PermiteConsulta
        {
            get { return PermiteConsulta; }
            set { PermiteConsulta = value; }
        }
    }
}
