namespace Vista
{
    partial class BuscarSoporte
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
            this.SoporteDataGridView = new System.Windows.Forms.DataGridView();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.AceptarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SoporteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SoporteDataGridView
            // 
            this.SoporteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SoporteDataGridView.Location = new System.Drawing.Point(1, 124);
            this.SoporteDataGridView.Name = "SoporteDataGridView";
            this.SoporteDataGridView.Size = new System.Drawing.Size(743, 278);
            this.SoporteDataGridView.TabIndex = 12;
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionTextBox.Location = new System.Drawing.Point(124, 22);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(609, 22);
            this.DescripcionTextBox.TabIndex = 11;
            this.DescripcionTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DescripcionTextBox_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "Descripción:";
            // 
            // CancelarButton
            // 
            this.CancelarButton.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.Location = new System.Drawing.Point(632, 60);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(96, 44);
            this.CancelarButton.TabIndex = 14;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // AceptarButton
            // 
            this.AceptarButton.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AceptarButton.Location = new System.Drawing.Point(530, 60);
            this.AceptarButton.Name = "AceptarButton";
            this.AceptarButton.Size = new System.Drawing.Size(96, 44);
            this.AceptarButton.TabIndex = 13;
            this.AceptarButton.Text = "Aceptar";
            this.AceptarButton.UseVisualStyleBackColor = true;
            this.AceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // BuscarSoporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 401);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.AceptarButton);
            this.Controls.Add(this.SoporteDataGridView);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.label1);
            this.Name = "BuscarSoporte";
            this.Text = "BuscarSoporte";
            this.Load += new System.EventHandler(this.BuscarSoporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SoporteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SoporteDataGridView;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button AceptarButton;
    }
}