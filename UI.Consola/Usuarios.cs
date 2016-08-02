using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;


namespace UI.Consola
{
    public class Usuarios
    {
        public Business.Logic.UsuarioLogic UsuarioNegocio { get; set; }

        public Usuarios()
        {
            this.UsuarioNegocio = new Business.Logic.UsuarioLogic();
        }
        public void Menu()
        {
            int opcion = 0;
            while (opcion < 6)
            {
                System.Console.WriteLine("Menu");
                System.Console.WriteLine("1-Listado general");
                System.Console.WriteLine("2-Consulta");
                System.Console.WriteLine("3-Agregar");
                System.Console.WriteLine("4-Modificar");
                System.Console.WriteLine("5-Eliminar");
                System.Console.WriteLine("6-salir");
                System.Console.WriteLine("Ingrese la opcion deseada");
                opcion =int.Parse(System.Console.ReadLine());
                switch (opcion)
                {
                    case 1: ListadoGeneral();
                        break;
                    case 2: Consultar();
                        break;
                    case 3: Agregar();
                        break;
                    case 4: Modificar();
                        break;
                    case 5: Eliminar();
                        break;
                    default: Console.WriteLine("la opcion introducida es incorrecta");
                        break;
                }
            }
        }
        public void ListadoGeneral()
        {
            Console.Clear();
            foreach (Usuario usr in UsuarioNegocio.GetAll())
            {
                MostrarDatos(usr);
            }
        }

        public void MostrarDatos(Usuario usr)
        {
            Console.WriteLine("Usuario: {0}", usr.ID);
            Console.WriteLine("\t\tNombre: {0}", usr.Nombre);
            Console.WriteLine("\t\tApellido: {0}", usr.Apellido);
            Console.WriteLine("\t\tNombre de Usuario: {0}", usr.NombreUsuario);
            Console.WriteLine("\t\tClave: {0}", usr.Clave);
            Console.WriteLine("\t\tEmail: {0}", usr.EMail);
            Console.WriteLine("\t\tHabilitado: {0}", usr.Habilitado);
            Console.WriteLine();
        }

        public void Consultar()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Ingrese el ID del usuario a consultar");
                int ID = int.Parse(Console.ReadLine());
                this.MostrarDatos(UsuarioNegocio.GetOne(ID));
            }
            catch (FormatException fe)
            {
                Console.WriteLine();
                Console.WriteLine("la ID ingresada debe ser un numero entero");
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }

        }
        public void Modificar()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Ingrese el ID del usuario a consultar");
                int ID = int.Parse(Console.ReadLine());
                Usuario usuario = UsuarioNegocio.GetOne(ID);
                Console.WriteLine("Ingrese Nombre: ");
                usuario.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese Apellido: ");
                usuario.Apellido = Console.ReadLine();
                Console.WriteLine("Ingrese Nombre de Usuario: ");
                usuario.NombreUsuario = Console.ReadLine();
                Console.WriteLine("Ingrese Clave: ");
                usuario.Clave = Console.ReadLine();
                Console.WriteLine("Ingrese Email: ");
                usuario.EMail = Console.ReadLine();
                Console.WriteLine("Ingrese Habilitacion de usuario (1-Si/otro-no): ");
                usuario.Habilitado = (Console.ReadLine()=="1");
                usuario.State = BusinessEntity.States.Modified;
                UsuarioNegocio.Save(usuario);
            }
            catch (FormatException fe)
            {
                Console.WriteLine();
                Console.WriteLine("la ID ingresada debe ser un numero entero");
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }

        }

        public void Agregar()
        {
            Usuario usuario = new Usuario();

            Console.Clear();
            Console.WriteLine("Ingrese Nombre: ");
            usuario.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Apellido: ");
            usuario.Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese Nombre de Usuario: ");
            usuario.NombreUsuario = Console.ReadLine();
            Console.WriteLine("Ingrese Clave: ");
            usuario.Clave = Console.ReadLine();
            Console.WriteLine("Ingrese Email: ");
            usuario.EMail = Console.ReadLine();
            Console.WriteLine("Ingrese Habilitacion de usuario (1-Si/otro-no): ");
            usuario.Habilitado = (Console.ReadLine() == "1");
            usuario.State = BusinessEntity.States.New;
            UsuarioNegocio.Save(usuario);
            Console.WriteLine();
            Console.WriteLine("ID: {0}", usuario.ID);
        }

        public void Eliminar()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Ingrese el ID del usuario a eliminar");
                int ID = int.Parse(Console.ReadLine());
                UsuarioNegocio.Delete(ID);
            }
            catch (FormatException fe)
            {
                Console.WriteLine();
                Console.WriteLine("la ID ingresada debe ser un numero entero");
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }

        }
    }
}