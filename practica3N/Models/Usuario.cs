using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica3N.Models
{
    public struct Usuario
    {
        // Propiedades para almacenar la información del usuario
        public string Nombre;
        public string Apellido;
        public string Correo;
        public string Contraseña;

        // Constructor que inicializa los campos del usuario
        public Usuario(string nombre, string apellido, string correo, string contraseña)
        {
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
            Contraseña = contraseña;
        }
    }
}
