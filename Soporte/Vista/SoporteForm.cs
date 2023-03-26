using Datos;
using Entidades;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class SoporteForm : Form
    {
        public SoporteForm()
        {
            InitializeComponent();
        }

        string operacion;
        Soporte soporte;
        SoporteDB soporteDB = new SoporteDB();

        private void NuevoButton_Click(object sender, System.EventArgs e)
        {
            operacion = "Nuevo";
            HabilitarControles();
        }

        private void HabilitarControles()
        {
            CodigoTextBox.Enabled = true;
            DescripcionTextBox.Enabled = true;
            PrecioTextBox.Enabled = true;
            EstaActivoCheckBox.Enabled = true;
            GuardarButton.Enabled = true;
            CancelarButton.Enabled = true;
            NuevoButton.Enabled = false;
        }

        private void LimpiarControles()
        {
            CodigoTextBox.Clear();
            DescripcionTextBox.Clear();
            PrecioTextBox.Clear();
            EstaActivoCheckBox.Checked = false;
            soporte = null;
        }

        private void DesahibilitarControles()
        {
            CodigoTextBox.Enabled = false;
            DescripcionTextBox.Enabled = false;
            PrecioTextBox.Enabled = false;
            EstaActivoCheckBox.Enabled = false;
            GuardarButton.Enabled = false;
            CancelarButton.Enabled = false;
            NuevoButton.Enabled = true;
        }

        private void ModificarButton_Click(object sender, System.EventArgs e)
        {
            operacion = "Modificar";
            if (SoporteDataGridView.SelectedRows.Count > 0)
            {
                CodigoTextBox.Text = SoporteDataGridView.CurrentRow.Cells["Codigo"].Value.ToString();
                DescripcionTextBox.Text = SoporteDataGridView.CurrentRow.Cells["Descripcion"].Value.ToString();
                PrecioTextBox.Text = SoporteDataGridView.CurrentRow.Cells["Precio"].Value.ToString();
                EstaActivoCheckBox.Checked = Convert.ToBoolean(SoporteDataGridView.CurrentRow.Cells["EstaActivo"].Value);

                HabilitarControles();
                CodigoTextBox.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un soporte");
            }
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            soporte = new Soporte();
            soporte.Codigo = CodigoTextBox.Text;
            soporte.Descripcion = DescripcionTextBox.Text;
            soporte.Precio = Convert.ToDecimal(PrecioTextBox.Text);
            soporte.EstaActivo = EstaActivoCheckBox.Checked;

            if (operacion == "Nuevo")
            {
                if (string.IsNullOrEmpty(CodigoTextBox.Text))
                {
                    errorProvider1.SetError(CodigoTextBox, "Ingrese un código");
                    CodigoTextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(DescripcionTextBox.Text))
                {
                    errorProvider1.SetError(DescripcionTextBox, "Ingrese una descripción");
                    DescripcionTextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(PrecioTextBox.Text))
                {
                    errorProvider1.SetError(PrecioTextBox, "Ingrese un precio");
                    PrecioTextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                bool inserto = soporteDB.Insertar(soporte);
                if (inserto)
                {
                    DesahibilitarControles();
                    LimpiarControles();
                    TraerSoportes();
                    MessageBox.Show("Registro guardado con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (operacion == "Modificar")
            {
                bool modifico = soporteDB.Editar(soporte);
                if (modifico)
                {
                    CodigoTextBox.ReadOnly = false;
                    DesahibilitarControles();
                    LimpiarControles();
                    TraerSoportes();
                    MessageBox.Show("Registro actualizado con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PrecioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled |= true;
            }
        }

        private void SoporteForm_Load(object sender, EventArgs e)
        {
            TraerSoportes();
        }

        private void TraerSoportes()
        {
            SoporteDataGridView.DataSource = soporteDB.DevolverSoporte();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (SoporteDataGridView.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro de elminar el registro?", "Advertencia", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    bool elimino = soporteDB.Eliminar(SoporteDataGridView.CurrentRow.Cells["Codigo"].Value.ToString());
                    if (elimino)
                    {
                        LimpiarControles();
                        DesahibilitarControles();
                        TraerSoportes();
                        MessageBox.Show("Registro eliminado");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el registro");
                    }
                }

            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DesahibilitarControles();
        }
    }
}
