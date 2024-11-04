using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica3N.Models
{
    public struct UsuarioInfo
    {
        public string Usuario { get; set; }
        public string Password { get; set; }

        public UsuarioInfo(string usuario, string password)
        {
            Usuario = usuario.Trim();
            Password = password.Trim();
        }
    }

}
