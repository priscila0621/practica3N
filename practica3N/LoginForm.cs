using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using practica3N.Formularios;
using practica3N.Models;
using practica3N.Servicios;

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
            // Crear una instancia del struct UsuarioInfo con los datos de los TextBox
            UsuarioInfo usuarioInfo = new UsuarioInfo(tbUsuario.Text, tbPw.Text);

            // Crear una instancia de LoginManager y llamar al método de validación
            LoginManager loginManager = new LoginManager();
            if (loginManager.ValidarYMostrarMensaje(usuarioInfo))
            {
                // Abrir el formulario MenuFormulario si la validación es correcta
                MenuFormulario menuForm = new MenuFormulario();
                menuForm.Show();
                this.Hide(); // Oculta el formulario de inicio de sesión
            }
        }
    }
}
