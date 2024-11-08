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
using practica3N.Servicios;

namespace practica3N.Formularios
{
    public partial class RegistrationForm : MetroFramework.Forms.MetroForm
    {
        // Instancia de la clase de lógica de registro
        private RegistroUsuario registroUsuario;

        public RegistrationForm()
        {
            InitializeComponent();
            registroUsuario = new RegistroUsuario(); // Inicializar la instancia de registro de usuario
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los campos de texto
            string nombre = tbNombre.Text;
            string apellido = tbApellido.Text;
            string correo = tbCorreo.Text;
            string contraseña = tbPw.Text;
            string confirmarContraseña = tbConfirmarPw.Text;

            // Validar los campos y mostrar mensajes según el resultado
            if (registroUsuario.ValidarCampos(nombre, apellido, correo, contraseña, confirmarContraseña, out string mensajeError))
            {
                // Si la validación es exitosa, registrar al usuario y mostrar un mensaje de éxito
                Usuario usuario = registroUsuario.RegistrarUsuario(nombre, apellido, correo, contraseña);
                MessageBox.Show("Usuario registrado exitosamente", "Registro Completo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Mostrar mensaje de error si la validación falla
                MessageBox.Show(mensajeError, "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
