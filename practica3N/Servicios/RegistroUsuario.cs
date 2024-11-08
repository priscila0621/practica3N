using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practica3N.Models;

namespace practica3N.Servicios
{
    // Lógica de validación y registro de usuario
    public class RegistroUsuario
    {
        // Método para validar los campos del formulario de registro
        public bool ValidarCampos(string nombre, string apellido, string correo, string contraseña, string confirmarContraseña, out string mensajeError)
        {
            // Inicialización del mensaje de error
            mensajeError = string.Empty;

            // Verificar si algún campo está vacío o no se ha completado
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(correo) ||
                string.IsNullOrWhiteSpace(contraseña) || string.IsNullOrWhiteSpace(confirmarContraseña))
            {
                mensajeError = "Todos los campos deben estar completos.";
                return false; // Retorna false si la validación falla
            }

            // Verificar si el correo contiene un símbolo '@'
            if (!correo.Contains("@"))
            {
                mensajeError = "El campo de correo electrónico debe contener un @.";
                return false; // Retorna false si la validación falla
            }

            // Verificar si las contraseñas coinciden
            if (contraseña != confirmarContraseña)
            {
                mensajeError = "Las contraseñas no coinciden.";
                return false; // Retorna false si la validación falla
            }

            // Retorna true si todas las validaciones pasan
            return true;
        }

        // Método para registrar un nuevo usuario y devolver la instancia creada
        public Usuario RegistrarUsuario(string nombre, string apellido, string correo, string contraseña)
        {
            return new Usuario(nombre, apellido, correo, contraseña); // Crea y retorna un nuevo usuario
        }
    }
}
