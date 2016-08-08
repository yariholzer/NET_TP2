using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Usuario:BusinessEntity
    {
        private string apellido;
        private string clave;
        private string email;
        public bool habilitado;
        private string nombre;
        private string nombreUsuario;

        public String NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }
        public String Clave
        {
            get { return clave; }
            set { clave = value; }
        }
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public String EMail
        {
            get { return email; }
            set { email = value; }
        }
        public bool Habilitado
        {
            get { return habilitado; }
            set { habilitado = value; }
        }

    }
}
