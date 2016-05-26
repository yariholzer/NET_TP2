using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Personas : BusinessEntity
    {
        private int idPlan;
        private int legajo;
        private string nombre;
        private string apellido;
        private string telefono;
        private string email;
        private string direccion;
        private DateTime fechaNacimiento;
        //private TipoPersonas tipoPersona; (En el diagrama no esta pero supongo que habrá que agregar la clase

        public int IdPlan
        {
            get { return idPlan; }
            set { idPlan = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        public int Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        //public TiposPersonas tipoPersona { get; set; } // ver de donde sale el tipo personas

    }
}
