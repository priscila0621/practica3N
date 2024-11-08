using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practica3N.Models;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace practica3N.Servicios
{
    public class LoginManager
    {
        public bool ValidarYMostrarMensaje(UsuarioInfo usuarioInfo)
        {
            // Verificar que ambos campos estén llenos después de aplicar Trim en el struct
            if (string.IsNullOrWhiteSpace(usuarioInfo.Usuario) || string.IsNullOrWhiteSpace(usuarioInfo.Password))
            {
                MessageBox.Show("Error: Debe ingresar tanto el usuario como la contraseña.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Retornar falso si hay un error
            }

            // Validar usuario y contraseña
            if (usuarioInfo.Usuario == "admin" && usuarioInfo.Password == "1234")
            {
                MessageBox.Show("Bienvenido, admin.",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true; // Retornar verdadero si la validación es exitosa
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Retornar falso si la validación falla
            }
        }
    }
}
