namespace CapaPresentacion.Empleados
{
    partial class frmAltaEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltaEmpleado));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pDatosLaborales = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbPuestos = new MaterialSkin.Controls.MaterialComboBox();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialTextBox3 = new MaterialSkin.Controls.MaterialTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDomicilio = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTelefono = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNombreCompleto = new MaterialSkin.Controls.MaterialTextBox();
            this.materialFloatingActionButton2 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.txtNssBusqueda = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.btnGrabar = new MaterialSkin.Controls.MaterialButton();
            this.pSeccionesDatos = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pDatosLaborales.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pSeccionesDatos.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pDatosLaborales);
            this.panel1.Controls.Add(this.pSeccionesDatos);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 754);
            this.panel1.TabIndex = 0;
            // 
            // pDatosLaborales
            // 
            this.pDatosLaborales.Controls.Add(this.panel4);
            this.pDatosLaborales.Controls.Add(this.panel3);
            this.pDatosLaborales.Controls.Add(this.materialButton1);
            this.pDatosLaborales.Controls.Add(this.btnGrabar);
            this.pDatosLaborales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDatosLaborales.Location = new System.Drawing.Point(0, 189);
            this.pDatosLaborales.Name = "pDatosLaborales";
            this.pDatosLaborales.Size = new System.Drawing.Size(945, 565);
            this.pDatosLaborales.TabIndex = 36;
            this.pDatosLaborales.Paint += new System.Windows.Forms.PaintEventHandler(this.pDatosLaborales_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Controls.Add(this.materialLabel6);
            this.panel4.Controls.Add(this.cmbPuestos);
            this.panel4.Controls.Add(this.materialComboBox1);
            this.panel4.Controls.Add(this.materialTextBox3);
            this.panel4.Location = new System.Drawing.Point(17, 244);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(916, 193);
            this.panel4.TabIndex = 61;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(530, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(338, 20);
            this.dateTimePicker1.TabIndex = 53;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.ForeColor = System.Drawing.Color.Green;
            this.materialLabel6.Location = new System.Drawing.Point(368, 35);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(125, 19);
            this.materialLabel6.TabIndex = 54;
            this.materialLabel6.Text = "Fecha de Ingreso:";
            // 
            // cmbPuestos
            // 
            this.cmbPuestos.AutoResize = false;
            this.cmbPuestos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbPuestos.Depth = 0;
            this.cmbPuestos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbPuestos.DropDownHeight = 174;
            this.cmbPuestos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPuestos.DropDownWidth = 121;
            this.cmbPuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbPuestos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbPuestos.FormattingEnabled = true;
            this.cmbPuestos.Hint = "Puestos";
            this.cmbPuestos.IntegralHeight = false;
            this.cmbPuestos.ItemHeight = 43;
            this.cmbPuestos.Location = new System.Drawing.Point(371, 117);
            this.cmbPuestos.MaxDropDownItems = 4;
            this.cmbPuestos.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbPuestos.Name = "cmbPuestos";
            this.cmbPuestos.Size = new System.Drawing.Size(497, 49);
            this.cmbPuestos.StartIndex = 0;
            this.cmbPuestos.TabIndex = 51;
            this.cmbPuestos.SelectedIndexChanged += new System.EventHandler(this.materialComboBox2_SelectedIndexChanged);
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.Hint = "Turno";
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino",
            "Nocturno"});
            this.materialComboBox1.Location = new System.Drawing.Point(62, 117);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(254, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 60;
            this.materialComboBox1.SelectedIndexChanged += new System.EventHandler(this.materialComboBox1_SelectedIndexChanged);
            // 
            // materialTextBox3
            // 
            this.materialTextBox3.AnimateReadOnly = false;
            this.materialTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox3.Depth = 0;
            this.materialTextBox3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox3.Hint = "Numero de Nomina: ";
            this.materialTextBox3.LeadingIcon = null;
            this.materialTextBox3.Location = new System.Drawing.Point(62, 15);
            this.materialTextBox3.MaxLength = 18;
            this.materialTextBox3.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox3.Multiline = false;
            this.materialTextBox3.Name = "materialTextBox3";
            this.materialTextBox3.Size = new System.Drawing.Size(254, 50);
            this.materialTextBox3.TabIndex = 59;
            this.materialTextBox3.Text = "";
            this.materialTextBox3.TrailingIcon = null;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.txtDomicilio);
            this.panel3.Controls.Add(this.txtTelefono);
            this.panel3.Controls.Add(this.txtNombreCompleto);
            this.panel3.Controls.Add(this.materialFloatingActionButton2);
            this.panel3.Controls.Add(this.txtNssBusqueda);
            this.panel3.Location = new System.Drawing.Point(17, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(916, 181);
            this.panel3.TabIndex = 60;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.AnimateReadOnly = false;
            this.txtDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDomicilio.Depth = 0;
            this.txtDomicilio.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDomicilio.Hint = "Domicilio: ";
            this.txtDomicilio.LeadingIcon = null;
            this.txtDomicilio.Location = new System.Drawing.Point(361, 105);
            this.txtDomicilio.MaxLength = 18;
            this.txtDomicilio.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDomicilio.Multiline = false;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(497, 50);
            this.txtDomicilio.TabIndex = 98;
            this.txtDomicilio.Text = "";
            this.txtDomicilio.TrailingIcon = null;
            // 
            // txtTelefono
            // 
            this.txtTelefono.AnimateReadOnly = false;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Depth = 0;
            this.txtTelefono.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelefono.Hint = "Teléfono: ";
            this.txtTelefono.LeadingIcon = null;
            this.txtTelefono.Location = new System.Drawing.Point(52, 105);
            this.txtTelefono.MaxLength = 18;
            this.txtTelefono.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(254, 50);
            this.txtTelefono.TabIndex = 97;
            this.txtTelefono.Text = "";
            this.txtTelefono.TrailingIcon = null;
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.AnimateReadOnly = false;
            this.txtNombreCompleto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreCompleto.Depth = 0;
            this.txtNombreCompleto.Enabled = false;
            this.txtNombreCompleto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreCompleto.Hint = "Nombre del Colaborador: ";
            this.txtNombreCompleto.LeadingIcon = null;
            this.txtNombreCompleto.Location = new System.Drawing.Point(361, 25);
            this.txtNombreCompleto.MaxLength = 18;
            this.txtNombreCompleto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreCompleto.Multiline = false;
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(497, 50);
            this.txtNombreCompleto.TabIndex = 96;
            this.txtNombreCompleto.Text = "";
            this.txtNombreCompleto.TrailingIcon = null;
            // 
            // materialFloatingActionButton2
            // 
            this.materialFloatingActionButton2.Depth = 0;
            this.materialFloatingActionButton2.Icon = ((System.Drawing.Image)(resources.GetObject("materialFloatingActionButton2.Icon")));
            this.materialFloatingActionButton2.Location = new System.Drawing.Point(266, 35);
            this.materialFloatingActionButton2.Mini = true;
            this.materialFloatingActionButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton2.Name = "materialFloatingActionButton2";
            this.materialFloatingActionButton2.Size = new System.Drawing.Size(40, 40);
            this.materialFloatingActionButton2.TabIndex = 95;
            this.materialFloatingActionButton2.Text = "materialFloatingActionButton2";
            this.materialFloatingActionButton2.UseVisualStyleBackColor = true;
            this.materialFloatingActionButton2.Click += new System.EventHandler(this.materialFloatingActionButton2_Click);
            // 
            // txtNssBusqueda
            // 
            this.txtNssBusqueda.AnimateReadOnly = false;
            this.txtNssBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNssBusqueda.Depth = 0;
            this.txtNssBusqueda.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNssBusqueda.Hint = "NSS: ";
            this.txtNssBusqueda.LeadingIcon = null;
            this.txtNssBusqueda.Location = new System.Drawing.Point(52, 25);
            this.txtNssBusqueda.MaxLength = 18;
            this.txtNssBusqueda.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNssBusqueda.Multiline = false;
            this.txtNssBusqueda.Name = "txtNssBusqueda";
            this.txtNssBusqueda.Size = new System.Drawing.Size(194, 50);
            this.txtNssBusqueda.TabIndex = 52;
            this.txtNssBusqueda.Text = "";
            this.txtNssBusqueda.TrailingIcon = null;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = ((System.Drawing.Image)(resources.GetObject("materialButton1.Icon")));
            this.materialButton1.Location = new System.Drawing.Point(453, 459);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(122, 50);
            this.materialButton1.TabIndex = 58;
            this.materialButton1.Text = "Cancelar";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = true;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            this.btnGrabar.AutoSize = false;
            this.btnGrabar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGrabar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGrabar.Depth = 0;
            this.btnGrabar.HighEmphasis = true;
            this.btnGrabar.Icon = ((System.Drawing.Image)(resources.GetObject("btnGrabar.Icon")));
            this.btnGrabar.Location = new System.Drawing.Point(300, 459);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGrabar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGrabar.Size = new System.Drawing.Size(124, 50);
            this.btnGrabar.TabIndex = 57;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGrabar.UseAccentColor = true;
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // pSeccionesDatos
            // 
            this.pSeccionesDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(141)))));
            this.pSeccionesDatos.Controls.Add(this.label2);
            this.pSeccionesDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSeccionesDatos.Location = new System.Drawing.Point(0, 144);
            this.pSeccionesDatos.Name = "pSeccionesDatos";
            this.pSeccionesDatos.Size = new System.Drawing.Size(945, 45);
            this.pSeccionesDatos.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Datos Laborales";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(945, 144);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(141)))));
            this.label1.Location = new System.Drawing.Point(276, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Altas de Nuevos Colaboradores";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(253, 144);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // frmAltaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 754);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAltaEmpleado";
            this.Text = "frmAltaEmpleado";
            this.panel1.ResumeLayout(false);
            this.pDatosLaborales.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.pSeccionesDatos.ResumeLayout(false);
            this.pSeccionesDatos.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pSeccionesDatos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pDatosLaborales;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialTextBox txtNssBusqueda;
        private MaterialSkin.Controls.MaterialComboBox cmbPuestos;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton btnGrabar;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox3;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialTextBox txtNombreCompleto;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton2;
        private MaterialSkin.Controls.MaterialTextBox txtTelefono;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialTextBox txtDomicilio;
    }
}