using Capa_Logica;
using Capa_Presentacion.Models;
using Capa_Presentacion.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Capa_Presentacion.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            try
            {
                List<Usuario> listaUsuarios = new List<Usuario>();
                clsUsuario usuario = new clsUsuario();
                var data = usuario.ConsultarUsuarios().ToList();
                foreach (var item in data)
                {
                    Usuario modelo = new Usuario();
                    modelo.Id = item.ID;
                    modelo.Cedula = item.Cedula;
                    modelo.Nombre = item.Nombre;
                    modelo.Apellido1 = item.Apellido1;
                    modelo.Apellido2 = item.Apellido2;
                    modelo.Telefono = item.Telefono;
                    modelo.FecNacimiento = item.FecNacimiento;
                    modelo.Email = item.Email;
                    modelo.Pass = item.Pass;
                    modelo.IdRol = item.IdRol;

                    listaUsuarios.Add(modelo);
                }
                return View(listaUsuarios);
            }
            catch
            {
                return RedirectToAction("Error");
            }
        }

        public ActionResult Crear()
        {
            try
            {
                clsRol listaRoles = new clsRol();
                ViewBag.ListaTiposRoles = listaRoles.ConsultarRoles();
                return View();
            }
            catch
            {
                return RedirectToAction("Error");
            }
        }

        [HttpPost]
        public ActionResult Crear(Usuario usuario)
        {
            try
            {
                clsUsuario objUsuario = new clsUsuario();
                bool resultado = objUsuario.AgregarUsuario(usuario.Cedula, usuario.Nombre, usuario.Apellido1, usuario.Apellido2, usuario.Telefono, usuario.FecNacimiento, Seguridad.Encriptar(usuario.Email), Seguridad.Encriptar(usuario.Pass), usuario.IdRol);
                if (resultado)
                {
                    return RedirectToAction("Index");
                } else
                {
                    return RedirectToAction("Error");
                }
            }
            catch
            {
                throw;
            }
        }

        public ActionResult Editar(int Id)
        {
            try
            {
                clsUsuario usuario = new clsUsuario();
                clsRol listaRoles = new clsRol();
                ViewBag.ListaTiposRoles = listaRoles.ConsultarRoles();
                var dato = usuario.ConsultarUsuario(Id);
                Usuario modelo = new Usuario();
                modelo.Id = dato[0].ID;
                modelo.Cedula = dato[0].Cedula;
                modelo.Nombre = dato[0].Nombre;
                modelo.Apellido1 = dato[0].Apellido1;
                modelo.Apellido2 = dato[0].Apellido2;
                modelo.Telefono = dato[0].Telefono;
                modelo.FecNacimiento = dato[0].FecNacimiento;
                modelo.Email = Seguridad.Desencriptar(dato[0].Email);
                modelo.Pass = dato[0].Pass;
                modelo.IdRol = dato[0].IdRol;

                return View(modelo);

            }
            catch
            {
                return RedirectToAction("Error");
            }
        }

        [HttpPost]
        public ActionResult Editar(int Id, Usuario usuario)
        {
            try
            {
                clsUsuario objUsuario = new clsUsuario();
                bool resultado = objUsuario.ActualizarUsuario(usuario.Id, usuario.Cedula, usuario.Nombre, usuario.Apellido1, usuario.Apellido2, usuario.Telefono, usuario.FecNacimiento, usuario.Email, usuario.Pass, usuario.IdRol);
                if (resultado)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("Error");
                }
            }
            catch
            {
                return RedirectToAction("Error");
            }
        }

        public ActionResult Eliminar(int Id)
        {
            try
            {
                clsUsuario usuario = new clsUsuario();
                bool resultado = usuario.EliminarUsuario(Id);
                if (resultado)
                {
                    return RedirectToAction("Index");
                } else
                {
                    return RedirectToAction("Error");
                }
            }
            catch
            {
                return RedirectToAction("Error");
            }
        }
    }
}