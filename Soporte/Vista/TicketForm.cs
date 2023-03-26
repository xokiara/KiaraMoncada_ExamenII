using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Vista
{
    public partial class TicketForm : Form
    {
        public TicketForm()
        {
            InitializeComponent();
        }

        Cliente miCliente = null;
        ClienteDB clienteDB = new ClienteDB();
        Soporte miSoporte = null;
        SoporteDB soporteDB = new SoporteDB();
        List<Detalle> ListaDetalles = new List<Detalle>();
        TicketDB ticketDB = new TicketDB();
        decimal subTotal = 0;
        decimal isv = 0;
        decimal totalAPagar = 0;
        decimal descuento = 0;



        private void IdentidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(IdentidadTextBox.Text))
            {
                miCliente = new Cliente();
                miCliente = clienteDB.DevolverClientePorIdentidad(IdentidadTextBox.Text);
                NombreClienteTextBox.Text = miCliente.Nombre;
            }
            else
            {
                miCliente = null;
                NombreClienteTextBox.Clear();
            }
        }

        private void BuscarClienteButton_Click(object sender, System.EventArgs e)
        {
            BuscarClienteForm form = new BuscarClienteForm();
            form.ShowDialog();
            miCliente = new Cliente();
            miCliente = form.cliente;
            IdentidadTextBox.Text = miCliente.Identidad;
            NombreClienteTextBox.Text = miCliente.Nombre;
        }

        private void TicketForm_Load(object sender, System.EventArgs e)
        {
            UsuarioTextBox.Text = System.Threading.Thread.CurrentPrincipal.Identity.Name;
        }

        private void CodigoSoporteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(CodigoSoporteTextBox.Text))
            {
                miSoporte = new Soporte();
                miSoporte = soporteDB.DevolverSoportePorCodigo(CodigoSoporteTextBox.Text);
                DescripcionSoporteTextBox.Text = miSoporte.Descripcion;
            }
            else
            {
                miSoporte = null;
                DescripcionSoporteTextBox.Clear();
            }
        }

        private void BuscarSoporteButton_Click(object sender, System.EventArgs e)
        {
            BuscarSoporte form = new BuscarSoporte();
            form.ShowDialog();
            miSoporte = new Soporte();
            miSoporte = form.soporte;
            CodigoSoporteTextBox.Text = miSoporte.Codigo;
            DescripcionSoporteTextBox.Text = miSoporte.Descripcion;
        }

        private void GuardarButton_Click(object sender, System.EventArgs e)
        {
            Ticket miTicket = new Ticket();
            miTicket.Fecha = FechaDateTimePicker.Value;
            miTicket.CodigoUsuario = System.Threading.Thread.CurrentPrincipal.Identity.Name;
            miTicket.IdentidadCliente = miCliente.Identidad;
            miTicket.SubTotal = subTotal;
            miTicket.ISV = isv;
            miTicket.Descuento = descuento;
            miTicket.Total = totalAPagar;

            bool inserto = ticketDB.Guardar(miTicket, ListaDetalles);

            if (inserto)
            {
                LimpiarControles();
                IdentidadTextBox.Focus();
                MessageBox.Show("Ticket registrado exitosamente");
            }
            else
                MessageBox.Show("No se pudo registrar el Ticket");
        }

        private void LimpiarControles()
        {
            miCliente = null;
            miSoporte = null;
            ListaDetalles = null;
            FechaDateTimePicker.Value = DateTime.Now;
            IdentidadTextBox.Clear();
            NombreClienteTextBox.Clear();
            CodigoSoporteTextBox.Clear();
            DescripcionSoporteTextBox.Clear();
            DescripcionSolTextBox.Clear();
            DescripcionResTextBox.Clear();
            DetalleDataGridView.DataSource = null;
            subTotal = 0;
            SubTotalTextBox.Clear();
            isv = 0;
            ISVTextBox.Clear();
            descuento = 0;
            DescuentoTextBox.Clear();
            totalAPagar = 0;
            TotalTextBox.Clear();
        }

        private void DescuentoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled |= true;
            }

            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(DescuentoTextBox.Text))
            {
                descuento = Convert.ToDecimal(DescuentoTextBox.Text);
                totalAPagar = totalAPagar - descuento;
                TotalTextBox.Text = totalAPagar.ToString();
            }
        }


        private void DescripcionSolTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(DescripcionSolTextBox.Text))
            {
                Detalle detalle = new Detalle();
                detalle.CodigoSoporte = miSoporte.Codigo;
                detalle.Precio = Convert.ToDecimal(miSoporte.Precio);
                detalle.Total = Convert.ToDecimal(miSoporte.Precio);
                detalle.Descripcion = miSoporte.Descripcion;

                subTotal += detalle.Total;
                isv = subTotal * 0.15M;
                totalAPagar = subTotal + isv;

                ListaDetalles.Add(detalle);
                DetalleDataGridView.DataSource = null;
                DetalleDataGridView.DataSource = ListaDetalles;

                SubTotalTextBox.Text = subTotal.ToString("N2");
                ISVTextBox.Text = isv.ToString("N2");
                TotalTextBox.Text = totalAPagar.ToString("N2");

                miSoporte = null;
                CodigoSoporteTextBox.Clear();
                DescripcionSoporteTextBox.Clear();
                CodigoSoporteTextBox.Focus();
            }
        }
    }
}
