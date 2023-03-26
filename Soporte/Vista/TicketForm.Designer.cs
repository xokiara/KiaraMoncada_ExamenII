namespace Vista
{
    partial class TicketForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.NombreClienteTextBox = new System.Windows.Forms.TextBox();
            this.BuscarClienteButton = new System.Windows.Forms.Button();
            this.IdentidadTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DescripcionSoporteTextBox = new System.Windows.Forms.TextBox();
            this.BuscarSoporteButton = new System.Windows.Forms.Button();
            this.CodigoSoporteTextBox = new System.Windows.Forms.TextBox();
            this.DescripcionResTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DescripcionSolTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DescuentoTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ISVTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SubTotalTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nuevo Ticket";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.UsuarioTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 48);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Location = new System.Drawing.Point(106, 18);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.ReadOnly = true;
            this.UsuarioTextBox.Size = new System.Drawing.Size(191, 22);
            this.UsuarioTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuario:";
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(668, 71);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(191, 22);
            this.FechaDateTimePicker.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(577, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.CadetBlue;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(-4, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(932, 51);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.NombreClienteTextBox);
            this.groupBox3.Controls.Add(this.BuscarClienteButton);
            this.groupBox3.Controls.Add(this.IdentidadTextBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 148);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(854, 62);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " Cliente";
            // 
            // NombreClienteTextBox
            // 
            this.NombreClienteTextBox.Location = new System.Drawing.Point(345, 27);
            this.NombreClienteTextBox.Name = "NombreClienteTextBox";
            this.NombreClienteTextBox.ReadOnly = true;
            this.NombreClienteTextBox.Size = new System.Drawing.Size(500, 22);
            this.NombreClienteTextBox.TabIndex = 4;
            // 
            // BuscarClienteButton
            // 
            this.BuscarClienteButton.Location = new System.Drawing.Point(303, 27);
            this.BuscarClienteButton.Name = "BuscarClienteButton";
            this.BuscarClienteButton.Size = new System.Drawing.Size(36, 23);
            this.BuscarClienteButton.TabIndex = 3;
            this.BuscarClienteButton.Text = "...";
            this.BuscarClienteButton.UseVisualStyleBackColor = true;
            this.BuscarClienteButton.Click += new System.EventHandler(this.BuscarClienteButton_Click);
            // 
            // IdentidadTextBox
            // 
            this.IdentidadTextBox.Location = new System.Drawing.Point(106, 27);
            this.IdentidadTextBox.Name = "IdentidadTextBox";
            this.IdentidadTextBox.Size = new System.Drawing.Size(191, 22);
            this.IdentidadTextBox.TabIndex = 2;
            this.IdentidadTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdentidadTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 14);
            this.label4.TabIndex = 1;
            this.label4.Text = "Identidad:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DescripcionSoporteTextBox);
            this.groupBox4.Controls.Add(this.BuscarSoporteButton);
            this.groupBox4.Controls.Add(this.CodigoSoporteTextBox);
            this.groupBox4.Controls.Add(this.DescripcionResTextBox);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.DescripcionSolTextBox);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(15, 211);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(854, 136);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Soporte";
            // 
            // DescripcionSoporteTextBox
            // 
            this.DescripcionSoporteTextBox.Location = new System.Drawing.Point(342, 26);
            this.DescripcionSoporteTextBox.Name = "DescripcionSoporteTextBox";
            this.DescripcionSoporteTextBox.ReadOnly = true;
            this.DescripcionSoporteTextBox.Size = new System.Drawing.Size(500, 22);
            this.DescripcionSoporteTextBox.TabIndex = 9;
            // 
            // BuscarSoporteButton
            // 
            this.BuscarSoporteButton.Location = new System.Drawing.Point(300, 26);
            this.BuscarSoporteButton.Name = "BuscarSoporteButton";
            this.BuscarSoporteButton.Size = new System.Drawing.Size(36, 23);
            this.BuscarSoporteButton.TabIndex = 8;
            this.BuscarSoporteButton.Text = "...";
            this.BuscarSoporteButton.UseVisualStyleBackColor = true;
            this.BuscarSoporteButton.Click += new System.EventHandler(this.BuscarSoporteButton_Click);
            // 
            // CodigoSoporteTextBox
            // 
            this.CodigoSoporteTextBox.Location = new System.Drawing.Point(103, 26);
            this.CodigoSoporteTextBox.Name = "CodigoSoporteTextBox";
            this.CodigoSoporteTextBox.Size = new System.Drawing.Size(191, 22);
            this.CodigoSoporteTextBox.TabIndex = 7;
            this.CodigoSoporteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodigoSoporteTextBox_KeyPress);
            // 
            // DescripcionResTextBox
            // 
            this.DescripcionResTextBox.Location = new System.Drawing.Point(152, 94);
            this.DescripcionResTextBox.Name = "DescripcionResTextBox";
            this.DescripcionResTextBox.Size = new System.Drawing.Size(691, 22);
            this.DescripcionResTextBox.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 14);
            this.label7.TabIndex = 5;
            this.label7.Text = "Descripción Respuesta:";
            // 
            // DescripcionSolTextBox
            // 
            this.DescripcionSolTextBox.Location = new System.Drawing.Point(150, 57);
            this.DescripcionSolTextBox.Name = "DescripcionSolTextBox";
            this.DescripcionSolTextBox.Size = new System.Drawing.Size(692, 22);
            this.DescripcionSolTextBox.TabIndex = 4;
            this.DescripcionSolTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DescripcionSolTextBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 14);
            this.label6.TabIndex = 3;
            this.label6.Text = "Descripción Solicitud:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 14);
            this.label5.TabIndex = 1;
            this.label5.Text = "Codigo:";
            // 
            // DetalleDataGridView
            // 
            this.DetalleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalleDataGridView.Location = new System.Drawing.Point(-4, 353);
            this.DetalleDataGridView.Name = "DetalleDataGridView";
            this.DetalleDataGridView.Size = new System.Drawing.Size(889, 161);
            this.DetalleDataGridView.TabIndex = 6;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.CancelarButton);
            this.groupBox5.Controls.Add(this.GuardarButton);
            this.groupBox5.Controls.Add(this.TotalTextBox);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.DescuentoTextBox);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.ISVTextBox);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.SubTotalTextBox);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Location = new System.Drawing.Point(12, 520);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(854, 192);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Facturación";
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(742, 130);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(104, 44);
            this.CancelarButton.TabIndex = 28;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(632, 130);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(104, 44);
            this.GuardarButton.TabIndex = 27;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(106, 130);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(191, 22);
            this.TotalTextBox.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 14);
            this.label11.TabIndex = 25;
            this.label11.Text = "Total a Pagar:";
            // 
            // DescuentoTextBox
            // 
            this.DescuentoTextBox.Location = new System.Drawing.Point(106, 66);
            this.DescuentoTextBox.Name = "DescuentoTextBox";
            this.DescuentoTextBox.Size = new System.Drawing.Size(191, 22);
            this.DescuentoTextBox.TabIndex = 24;
            this.DescuentoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DescuentoTextBox_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 14);
            this.label10.TabIndex = 23;
            this.label10.Text = "Descuento:";
            // 
            // ISVTextBox
            // 
            this.ISVTextBox.Location = new System.Drawing.Point(106, 35);
            this.ISVTextBox.Name = "ISVTextBox";
            this.ISVTextBox.ReadOnly = true;
            this.ISVTextBox.Size = new System.Drawing.Size(191, 22);
            this.ISVTextBox.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 14);
            this.label9.TabIndex = 21;
            this.label9.Text = "ISV:";
            // 
            // SubTotalTextBox
            // 
            this.SubTotalTextBox.Location = new System.Drawing.Point(106, 98);
            this.SubTotalTextBox.Name = "SubTotalTextBox";
            this.SubTotalTextBox.ReadOnly = true;
            this.SubTotalTextBox.Size = new System.Drawing.Size(191, 22);
            this.SubTotalTextBox.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 14);
            this.label12.TabIndex = 19;
            this.label12.Text = "Sub Total:";
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(884, 723);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.DetalleDataGridView);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "TicketForm";
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.TicketForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox NombreClienteTextBox;
        private System.Windows.Forms.Button BuscarClienteButton;
        private System.Windows.Forms.TextBox IdentidadTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DescripcionResTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DescripcionSolTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DetalleDataGridView;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox DescuentoTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ISVTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SubTotalTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button BuscarSoporteButton;
        private System.Windows.Forms.TextBox CodigoSoporteTextBox;
        private System.Windows.Forms.TextBox DescripcionSoporteTextBox;
    }
}