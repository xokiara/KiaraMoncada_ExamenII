using Datos;
using Entidades;
using System;
using System.Data;
using System.Windows.Forms;

namespace Vista
{
    public partial class UsuariosForm : Form
    {
        public UsuariosForm()
        {
            InitializeComponent();
        }

        string tipoOperacion;

        DataTable dt = new DataTable();
        UsuarioDB UsuarioDB = new UsuarioDB();
        Usuario user = new Usuario();

        private void HabilitarControles()
        {
            CodigoTextBox.Enabled = true;
            NombreTextBox.Enabled = true;
            ContraseñaTextBox.Enabled = true;
            CorreoTextBox.Enabled = true;
            GuardarButton.Enabled = true;
            CancelarButton.Enabled = true;
            ModificarButton.Enabled = false;

        }

        private void DesabilitarControles()
        {
            CodigoTextBox.Enabled = false;
            NombreTextBox.Enabled = false;
            ContraseñaTextBox.Enabled = false;
            CorreoTextBox.Enabled = false;
            GuardarButton.Enabled = false;
            CancelarButton.Enabled = false;
            ModificarButton.Enabled = true;
        }

        private void LimpiarControles()
        {
            CodigoTextBox.Clear();
            NombreTextBox.Clear();
            ContraseñaTextBox.Clear();
            CorreoTextBox.Clear();

        }

        private void TraerUsuarios()
        {
            dt = UsuarioDB.DevolverUsuarios();

            UsuariosDataGridView.DataSource = dt;
        }
        private void UsuariosForm_Load(object sender, EventArgs e)
        {
            TraerUsuarios();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            CodigoTextBox.Focus();
            HabilitarControles();
            tipoOperacion = "Nuevo";
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            tipoOperacion = "Modificar";
            if (UsuariosDataGridView.SelectedRows.Count > 0)
            {
                CodigoTextBox.Text = UsuariosDataGridView.CurrentRow.Cells["CodigoUsuario"].Value.ToString();
                NombreTextBox.Text = UsuariosDataGridView.CurrentRow.Cells["Nombre"].Value.ToString();
                ContraseñaTextBox.Text = UsuariosDataGridView.CurrentRow.Cells["Contrasena"].Value.ToString();
                CorreoTextBox.Text = UsuariosDataGridView.CurrentRow.Cells["Correo"].Value.ToString();

                HabilitarControles();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro");

            }
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (tipoOperacion == "Nuevo")
            {
                if (string.IsNullOrEmpty(CodigoTextBox.Text))
                {
                    errorProvider1.SetError(CodigoTextBox, "Ingrese un código");
                    CodigoTextBox.Focus();
                    return;
                }
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(NombreTextBox.Text))
                {
                    errorProvider1.SetError(NombreTextBox, "Ingrese un nombre");
                    NombreTextBox.Focus();
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

                user.CodigoUsuario = CodigoTextBox.Text;
                user.Nombre = NombreTextBox.Text;
                user.Contraseña = ContraseñaTextBox.Text;
                user.Correo = CorreoTextBox.Text;

                bool inserto = UsuarioDB.Insertar(user);
                if (inserto)
                {
                    LimpiarControles();
                    DesabilitarControles();
                    TraerUsuarios();
                    MessageBox.Show("Registro Guardado");
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el registro");
                }

            }
            else if (tipoOperacion == "Modificar")
            {
                user.CodigoUsuario = CodigoTextBox.Text;
                user.Nombre = NombreTextBox.Text;
                user.Contraseña = ContraseñaTextBox.Text;
                user.Correo = CorreoTextBox.Text;

                bool modifico = UsuarioDB.Editar(user);
                if (modifico)
                {
                    LimpiarControles();
                    DesabilitarControles();
                    TraerUsuarios();
                    MessageBox.Show("Registro actualizado correctamente");
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el registro");
                }
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (UsuariosDataGridView.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro de elminar el registro?", "Advertencia", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    bool elimino = UsuarioDB.Eliminar(UsuariosDataGridView.CurrentRow.Cells["CodigoUsuario"].Value.ToString());

                    if (elimino)
                    {
                        LimpiarControles();
                        DesabilitarControles();
                        TraerUsuarios();
                        MessageBox.Show("Registro eliminado");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el registro");
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro");

            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DesabilitarControles();
            LimpiarControles();
        }
    }
}
