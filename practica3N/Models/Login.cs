using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica3N.Models
{
    public class Login
    {
        public string ValidarUsuario(string usuario, string password)
        {
            // Verificar que ambos campos estén llenos
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(password))
            {
                return "Error: Debe ingresar tanto el usuario como la contraseña.";
            }

            // Validar usuario y contraseña
            if (usuario == "admin" && password == "1234")
            {
                return "Bienvenido";
            }
            else
            {
                return "Usuario o contraseña incorrectos.";
            }
        }
    }
}
