using Datos;
using Entidades;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class BuscarSoporte : Form
    {
        public BuscarSoporte()
        {
            InitializeComponent();
        }

        SoporteDB soporteDB = new SoporteDB();
        public Soporte soporte = new Soporte();

        private void BuscarSoporte_Load(object sender, EventArgs e)
        {
            SoporteDataGridView.DataSource = soporteDB.DevolverSoporte();
        }

        private void DescripcionTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            SoporteDataGridView.DataSource = soporteDB.DevolverSoportePorDescripcion(DescripcionTextBox.Text);
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            if (SoporteDataGridView.RowCount > 0)
            {
                if (SoporteDataGridView.SelectedRows.Count > 0)
                {
                    soporte.Codigo = SoporteDataGridView.CurrentRow.Cells["Codigo"].Value.ToString();
                    soporte.Descripcion = SoporteDataGridView.CurrentRow.Cells["Descripcion"].Value.ToString();
                    soporte.Precio = Convert.ToDecimal(SoporteDataGridView.CurrentRow.Cells["Precio"].Value);
                    soporte.EstaActivo = Convert.ToBoolean(SoporteDataGridView.CurrentRow.Cells["EstaActivo"].Value);
                    Close();
                }
            }

        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
