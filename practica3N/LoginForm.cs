using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using practica3N.Models;

namespace practica3N
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // Crear una instancia de la clase Login
            Login login = new Login();

            // Llamar al método ValidarUsuario y mostrar el resultado
            string usuario = tbUsuario.Text;
            string password = tbPw.Text;
            string mensaje = login.ValidarUsuario(usuario, password);

            // Mostrar mensaje en un MessageBox
            MessageBox.Show(mensaje);
        }
    }
}
