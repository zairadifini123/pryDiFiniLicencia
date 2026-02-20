namespace pryDiFiniLicencia
{
    partial class frmLicencia
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLicencia));
            lblTitulo = new Label();
            lblEdad = new Label();
            txtEdad = new TextBox();
            lblLicencia = new Label();
            cmbLicencia = new ComboBox();
            btnSalir = new Button();
            btnAceptar = new Button();
            lblMultas = new Label();
            txtMultas = new TextBox();
            lblExamenMedico = new Label();
            cmbMedico = new ComboBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(248, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Licencia de conducir";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(4, 60);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 1;
            lblEdad.Text = "Edad";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(43, 57);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(47, 23);
            txtEdad.TabIndex = 2;
            txtEdad.KeyPress += txtEdad_KeyPress;
            // 
            // lblLicencia
            // 
            lblLicencia.AutoSize = true;
            lblLicencia.Location = new Point(2, 107);
            lblLicencia.Name = "lblLicencia";
            lblLicencia.Size = new Size(88, 15);
            lblLicencia.TabIndex = 3;
            lblLicencia.Text = "¿Tiene licencia?";
            // 
            // cmbLicencia
            // 
            cmbLicencia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLicencia.FormattingEnabled = true;
            cmbLicencia.Items.AddRange(new object[] { "SI", "NO" });
            cmbLicencia.Location = new Point(96, 104);
            cmbLicencia.Name = "cmbLicencia";
            cmbLicencia.Size = new Size(61, 23);
            cmbLicencia.TabIndex = 4;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(8, 263);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 23);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(126, 263);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(112, 23);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblMultas
            // 
            lblMultas.AutoSize = true;
            lblMultas.Location = new Point(2, 161);
            lblMultas.Name = "lblMultas";
            lblMultas.Size = new Size(110, 15);
            lblMultas.TabIndex = 7;
            lblMultas.Text = "Cantidad de multas";
            // 
            // txtMultas
            // 
            txtMultas.Location = new Point(118, 158);
            txtMultas.Name = "txtMultas";
            txtMultas.Size = new Size(47, 23);
            txtMultas.TabIndex = 8;
            // 
            // lblExamenMedico
            // 
            lblExamenMedico.AutoSize = true;
            lblExamenMedico.Location = new Point(8, 213);
            lblExamenMedico.Name = "lblExamenMedico";
            lblExamenMedico.Size = new Size(157, 15);
            lblExamenMedico.TabIndex = 9;
            lblExamenMedico.Text = "¿Aprobó el examen médico?";
            // 
            // cmbMedico
            // 
            cmbMedico.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMedico.FormattingEnabled = true;
            cmbMedico.Items.AddRange(new object[] { "SI", "NO" });
            cmbMedico.Location = new Point(171, 210);
            cmbMedico.Name = "cmbMedico";
            cmbMedico.Size = new Size(61, 23);
            cmbMedico.TabIndex = 10;
            // 
            // frmLicencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(262, 324);
            Controls.Add(cmbMedico);
            Controls.Add(lblExamenMedico);
            Controls.Add(txtMultas);
            Controls.Add(lblMultas);
            Controls.Add(btnAceptar);
            Controls.Add(btnSalir);
            Controls.Add(cmbLicencia);
            Controls.Add(lblLicencia);
            Controls.Add(txtEdad);
            Controls.Add(lblEdad);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmLicencia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLicencia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblEdad;
        private TextBox txtEdad;
        private Label lblLicencia;
        private ComboBox cmbLicencia;
        private Button btnSalir;
        private Button btnAceptar;
        private Label lblMultas;
        private TextBox txtMultas;
        private Label lblExamenMedico;
        private ComboBox cmbMedico;
    }
}
