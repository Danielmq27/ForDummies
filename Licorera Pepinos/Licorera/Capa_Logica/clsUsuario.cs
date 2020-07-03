using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    /*Mapeo de los procedimientos almacenados de la tabla usuario de la base de datos Licorera_Pepinos*/
    public class clsUsuario
    {
        /*Función de acceso al sistema, llamado del procedimeinto almacenado IniciarSesion*/
        public List<IniciarSesionResult> IniciarSesion(string Email, string Pass)
        {
            try
            {
                /*Creamos un objeto de LicoreraDataContext ya que aqui estan los procedimientos almacenados*/
                LicoreraDataContext dc = new LicoreraDataContext();
                /*Llammamos a el procedimiento IniciarSesion y con un ToList lo hacemos una lista*/
                List<IniciarSesionResult> data = dc.IniciarSesion(Email, Pass).ToList();
                /*Retornamos lo que hay en la variable data*/
                return data;
            }
            catch (Exception)
            {
                throw;
            }
        }
        /*Funcion para consultar todos los usuarios de la tabla*/
        public List<VerUsuariosResult> ConsultarUsuarios()
        {
            try
            {
                /*Creamos un objeto de LicoreraDataContext ya que aqui estan los procedimientos almacenados*/
                LicoreraDataContext dc = new LicoreraDataContext();
                /*Llammamos a el procedimiento VerUsuarios y con un ToList lo hacemos una lista*/
                List<VerUsuariosResult> data = dc.VerUsuarios().ToList();
                /*Retornamos lo que hay en la variable data*/
                return data;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /*Funcion para consultar un usuario en especifico*/
        public List<VerUsuarioResult> ConsultarUsuario(int Id)
        {
            try
            {
                /*Creamos un objeto de LicoreraDataContext ya que aqui estan los procedimientos almacenados*/
                LicoreraDataContext dc = new LicoreraDataContext();
                /*Llammamos a el procedimiento VerUsuario y con un ToList lo hacemos una lista, ademas de eso se le pasa una variable para consultar ese usuario en especifico*/
                List<VerUsuarioResult> data = dc.VerUsuario(Id).ToList();
                /*Retornamos lo que hay en la variable data*/
                return data;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /*Funcion para agregar un nuevo usuario a la base de datos*/
        public bool AgregarUsuario(int Cedula, string Nombre, string Apellido1, string Apellido2, int Telefono, DateTime FecNacimiento, string Email, string Pass, int IdRol)
        {
            try
            {
                /*Declaramos variable respuesta*/
                int respuesta = 1;
                /*Creamos un objeto de LicoreraDataContext ya que aqui estan los procedimientos almacenados*/
                LicoreraDataContext dc = new LicoreraDataContext();
                /*A la variable respuesta se le asiga el llamado al procedimiento almacenado AgregarUsuario si es correcto devuelve un 0*/
                respuesta = dc.AgregarUsuario(Cedula, Nombre, Apellido1, Apellido2, Telefono, FecNacimiento, Email, Pass, IdRol);
                /*Comparacion de los valores de la variable respuesta*/
                if (respuesta == 0)
                {
                    /*Retornamos verdadero*/
                    return true;
                } else
                {
                    /*Retornamos falso*/
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /*Funcion para agregar un nuevo usuario con rol de cliente a la base de datos*/
        public bool AgregarUsuarioCliente(int Cedula, string Nombre, string Apellido1, string Apellido2, int Telefono, DateTime FecNacimiento, string Email, string Pass)
        {
            try
            {
                /*Declaramos variable respuesta*/
                int respuesta = 1;
                /*Creamos un objeto de LicoreraDataContext ya que aqui estan los procedimientos almacenados*/
                LicoreraDataContext dc = new LicoreraDataContext();
                /*A la variable respuesta se le asiga el llamado al procedimiento almacenado AgregarUsuario si es correcto devuelve un 0*/
                respuesta = dc.AgregarUsuarioCliente(Cedula, Nombre, Apellido1, Apellido2, Telefono, FecNacimiento, Email, Pass);
                /*Comparacion de los valores de la variable respuesta*/
                if (respuesta == 0)
                {
                    /*Retornamos verdadero*/
                    return true;
                }
                else
                {
                    /*Retornamos falso*/
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /*Funcion para actualizar un  usuario ya existente de la base de datos*/
        public bool ActualizarUsuario(int Id, int Cedula, string Nombre, string Apellido1, string Apellido2, int Telefono, DateTime FecNacimiento, string Email, string Pass, int IdRol)
        {
            try
            {
                /*Creamos un objeto de LicoreraDataContext ya que aqui estan los procedimientos almacenados*/
                LicoreraDataContext dc = new LicoreraDataContext();
                /*Se llama al procedimiento almacenado ActualizarUsuario*/
                dc.ActualizarUsuario(Id, Cedula, Nombre, Apellido1, Apellido2, Telefono, FecNacimiento, Email, Pass, IdRol);
                /*Si se actualiza el usuario retorne verdadero*/
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /*Funcion para eliminar un  usuario ya existente de la base de datos*/
        public bool EliminarUsuario(int Id)
        {
            try
            {
                /*Creamos un objeto de LicoreraDataContext ya que aqui estan los procedimientos almacenados*/
                LicoreraDataContext dc = new LicoreraDataContext();
                /*Se llama al procedimiento almacenado EliminarUsuario*/
                dc.EliminarUsuario(Id);
                /*Si se elimina el usuario retorne verdadero*/
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
