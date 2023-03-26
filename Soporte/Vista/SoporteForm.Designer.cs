namespace Vista
{
    partial class SoporteForm
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
            this.components = new System.ComponentModel.Container();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CodigoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EstaActivoCheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SoporteDataGridView = new System.Windows.Forms.DataGridView();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SoporteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Enabled = false;
            this.DescripcionTextBox.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionTextBox.Location = new System.Drawing.Point(123, 51);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(272, 22);
            this.DescripcionTextBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 14);
            this.label2.TabIndex = 14;
            this.label2.Text = "Descripción:";
            // 
            // CodigoTextBox
            // 
            this.CodigoTextBox.Enabled = false;
            this.CodigoTextBox.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoTextBox.Location = new System.Drawing.Point(123, 20);
            this.CodigoTextBox.Name = "CodigoTextBox";
            this.CodigoTextBox.Size = new System.Drawing.Size(272, 22);
            this.CodigoTextBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 14);
            this.label1.TabIndex = 12;
            this.label1.Text = "Código:";
            // 
            // EstaActivoCheckBox
            // 
            this.EstaActivoCheckBox.AutoSize = true;
            this.EstaActivoCheckBox.Enabled = false;
            this.EstaActivoCheckBox.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstaActivoCheckBox.Location = new System.Drawing.Point(125, 122);
            this.EstaActivoCheckBox.Name = "EstaActivoCheckBox";
            this.EstaActivoCheckBox.Size = new System.Drawing.Size(15, 14);
            this.EstaActivoCheckBox.TabIndex = 36;
            this.EstaActivoCheckBox.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 14);
            this.label6.TabIndex = 35;
            this.label6.Text = "Esta Activo:";
            // 
            // SoporteDataGridView
            // 
            this.SoporteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SoporteDataGridView.Location = new System.Drawing.Point(-3, 203);
            this.SoporteDataGridView.Name = "SoporteDataGridView";
            this.SoporteDataGridView.Size = new System.Drawing.Size(574, 256);
            this.SoporteDataGridView.TabIndex = 34;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoButton.Location = new System.Drawing.Point(122, 157);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 26);
            this.NuevoButton.TabIndex = 33;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Enabled = false;
            this.CancelarButton.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.Location = new System.Drawing.Point(443, 157);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(74, 26);
            this.CancelarButton.TabIndex = 32;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Location = new System.Drawing.Point(363, 157);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(74, 26);
            this.EliminarButton.TabIndex = 31;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Enabled = false;
            this.GuardarButton.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Location = new System.Drawing.Point(283, 157);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(74, 26);
            this.GuardarButton.TabIndex = 30;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // ModificarButton
            // 
            this.ModificarButton.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarButton.Location = new System.Drawing.Point(203, 157);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(74, 26);
            this.ModificarButton.TabIndex = 29;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.UseVisualStyleBackColor = true;
            this.ModificarButton.Click += new System.EventHandler(this.ModificarButton_Click);
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Enabled = false;
            this.PrecioTextBox.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioTextBox.Location = new System.Drawing.Point(123, 83);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(272, 22);
            this.PrecioTextBox.TabIndex = 38;
            this.PrecioTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrecioTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 14);
            this.label4.TabIndex = 37;
            this.label4.Text = "Precio:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // SoporteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 459);
            this.Controls.Add(this.PrecioTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EstaActivoCheckBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SoporteDataGridView);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.ModificarButton);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CodigoTextBox);
            this.Controls.Add(this.label1);
            this.Name = "SoporteForm";
            this.Text = "SoporteForm";
            this.Load += new System.EventHandler(this.SoporteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SoporteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CodigoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox EstaActivoCheckBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView SoporteDataGridView;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button ModificarButton;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}