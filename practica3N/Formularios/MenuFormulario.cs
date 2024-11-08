using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica3N.Formularios
{
    public partial class MenuFormulario : MetroFramework.Forms.MetroForm
    {
        public MenuFormulario()
        {
            InitializeComponent();
        }

        private void registrarDatosDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia del formulario RegistrationForm
            RegistrationForm registrationForm = new RegistrationForm();

            // Mostrar el formulario
            registrationForm.Show();
        }
    }
}
