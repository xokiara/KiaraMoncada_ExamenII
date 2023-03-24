using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void AceptarButton_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(UsuarioTextBox.Text))
            {
                errorProvider1.SetError(UsuarioTextBox, "Ingrese un usuario");
                UsuarioTextBox.Focus();
                return;

            }
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(ContraseñaTextBox.Text))
            {
                errorProvider1.SetError(ContraseñaTextBox, "Ingrese una contraseña");
                ContraseñaTextBox.Focus();
                return;

            }
            errorProvider1.Clear();

            //BASEDATOS

            Menu menu = new Menu();
            this.Hide();
            menu.Show();

        }

        private void CancelarButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void MostrarContraseñaButton_Click(object sender, EventArgs e)
        {
            if (ContraseñaTextBox.PasswordChar == '*')
            {
                ContraseñaTextBox.PasswordChar = '\0';
            }
            else
            {
                ContraseñaTextBox.PasswordChar = '*';
            }
        }
    }
}
