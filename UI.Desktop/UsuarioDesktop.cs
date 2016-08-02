using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;


namespace UI.Desktop
{
    public partial class UsuarioDesktop : ApplicationForm
    {
        public Business.Entities.Usuario UsuarioActual { get; set; }
        public UsuarioDesktop()
        {
            InitializeComponent();
        }
        public UsuarioDesktop(ModoForm modo):this() 
        {
            ModoForm Modo = new ModoForm();
            Modo = modo;
        }
        public UsuarioDesktop(int ID, ModoForm modo) : this() 
        {
            ModoForm Modo = new ModoForm();
            UsuarioLogic u1 = new UsuarioLogic();
            Modo = modo;
            UsuarioActual=u1.GetOne(ID);
            MapearDeDatos();


        }
        public virtual void MapearDeDatos()
        {
            this.txtID.Text = this.UsuarioActual.ID.ToString();
            this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;
            this.txtNombre.Text = this.UsuarioActual.Nombre;
            this.txtApellido.Text = this.UsuarioActual.Apellido;
            this.txtEmail.Text = this.UsuarioActual.EMail;
            this.txtClave.Text = this.UsuarioActual.Clave;
            this.txtUsuario.Text = this.UsuarioActual.NombreUsuario;
            //this.txtConfirmarClave.Text = this.UsuarioActual.con;
            
            if (Modo.Equals("Alta"))
            {
                btnAceptar.Text = "Guardar";
            }
            else if(Modo.Equals("Modificacion"))
            {
                btnAceptar.Text = "Guardar";
            }
            else if (Modo.Equals("Baja"))
            {
                btnAceptar.Text = "Eliminar";
            }
            else 
            {
                btnAceptar.Text = "Aceptar";
            } 
        }

        public virtual void MapearADatos() 
        {
            if (Modo.Equals("Alta"))
            {
                Usuario u2 = new Usuario();
                UsuarioActual = u2;
                UsuarioActual.Nombre = this.txtNombre.ToString();
                UsuarioActual.Habilitado = this.chkHabilitado.Checked;
                UsuarioActual.Apellido = this.txtApellido.ToString();
                UsuarioActual.EMail = this.txtEmail.ToString();
                UsuarioActual.NombreUsuario = this.txtUsuario.ToString();
                UsuarioActual.Clave = this.txtClave.ToString();
                UsuarioActual.State = Usuario.States.New; 
                    
                }
                else if(Modo.Equals("Modificacion"))
                {
                UsuarioActual.ID = int.Parse(this.txtID.ToString());
                UsuarioActual.Nombre = this.txtNombre.ToString();
                UsuarioActual.Habilitado = this.chkHabilitado.Checked;
                UsuarioActual.Apellido = this.txtApellido.ToString();
                UsuarioActual.EMail = this.txtEmail.ToString();
                UsuarioActual.NombreUsuario = this.txtUsuario.ToString();
                UsuarioActual.Clave = this.txtClave.ToString();
                UsuarioActual.State = Usuario.States.Modified;
                }
                else if (Modo.Equals("Baja"))
                {
                    UsuarioActual.State = Usuario.States.Deleted;
                }
                else 
                {
                    UsuarioActual.State = Usuario.States.Unmodified; //preguntar si es asi 
                }
        }
        public virtual void GuardarCambios() 
        {
            MapearADatos();
            UsuarioLogic u1 = new UsuarioLogic();
            u1.Save(UsuarioActual);
        }
        public virtual bool Validar() { return false; } // hacer punto 17 lab 4
        public void Notificar(string titulo, string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }
        public void Notificar(string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            this.Notificar(this.Text, mensaje, botones, icono);
        }
        

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();
                Close();
            }
        }
        private void btnSalir_Click(object sender, EventArgs e) 
        {
            Close();
        }

    }
}
