using System;
using System.Windows.Forms;


namespace Vista
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void UsuariosToolStripButton_Click(object sender, EventArgs e)
        {
            UsuariosForm userForm = new UsuariosForm();
            //
            userForm.Show();

        }

        private void ClientesToolStripButton_Click(object sender, EventArgs e)
        {
            ClientesForm clientesForm = new ClientesForm();
            //
            clientesForm.Show();
        }
    }
}
