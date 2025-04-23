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
            this.txtIdPuesto = new MaterialSkin.Controls.MaterialTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbPuestos = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbTurno = new MaterialSkin.Controls.MaterialComboBox();
            this.txtNoNomina = new MaterialSkin.Controls.MaterialTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDomicilio = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTelefono = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNombreCompleto = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNssBusqueda = new MaterialSkin.Controls.MaterialTextBox();
            this.pSeccionesDatos = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnBuscarEmpleadoNSS = new CapaPresentacion.BotonPersonalizado();
            this.btmCancelar = new CapaPresentacion.BotonPersonalizado();
            this.btnGrabar = new CapaPresentacion.BotonPersonalizado();
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
            this.panel1.Size = new System.Drawing.Size(945, 645);
            this.panel1.TabIndex = 0;
            // 
            // pDatosLaborales
            // 
            this.pDatosLaborales.Controls.Add(this.btmCancelar);
            this.pDatosLaborales.Controls.Add(this.btnGrabar);
            this.pDatosLaborales.Controls.Add(this.panel4);
            this.pDatosLaborales.Controls.Add(this.panel3);
            this.pDatosLaborales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDatosLaborales.Location = new System.Drawing.Point(0, 153);
            this.pDatosLaborales.Name = "pDatosLaborales";
            this.pDatosLaborales.Size = new System.Drawing.Size(945, 492);
            this.pDatosLaborales.TabIndex = 36;
            this.pDatosLaborales.Paint += new System.Windows.Forms.PaintEventHandler(this.pDatosLaborales_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.txtIdPuesto);
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Controls.Add(this.materialLabel6);
            this.panel4.Controls.Add(this.cmbPuestos);
            this.panel4.Controls.Add(this.cmbTurno);
            this.panel4.Controls.Add(this.txtNoNomina);
            this.panel4.Location = new System.Drawing.Point(17, 226);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(916, 193);
            this.panel4.TabIndex = 61;
            // 
            // txtIdPuesto
            // 
            this.txtIdPuesto.AnimateReadOnly = false;
            this.txtIdPuesto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdPuesto.Depth = 0;
            this.txtIdPuesto.Enabled = false;
            this.txtIdPuesto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdPuesto.Hint = "Numero de Nomina: ";
            this.txtIdPuesto.LeadingIcon = null;
            this.txtIdPuesto.Location = new System.Drawing.Point(371, 73);
            this.txtIdPuesto.MaxLength = 18;
            this.txtIdPuesto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIdPuesto.Multiline = false;
            this.txtIdPuesto.Name = "txtIdPuesto";
            this.txtIdPuesto.Size = new System.Drawing.Size(254, 50);
            this.txtIdPuesto.TabIndex = 61;
            this.txtIdPuesto.Text = "";
            this.txtIdPuesto.TrailingIcon = null;
            this.txtIdPuesto.Visible = false;
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
            this.cmbPuestos.Enabled = false;
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
            // cmbTurno
            // 
            this.cmbTurno.AutoResize = false;
            this.cmbTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbTurno.Depth = 0;
            this.cmbTurno.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbTurno.DropDownHeight = 174;
            this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurno.DropDownWidth = 121;
            this.cmbTurno.Enabled = false;
            this.cmbTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbTurno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Hint = "Turno";
            this.cmbTurno.IntegralHeight = false;
            this.cmbTurno.ItemHeight = 43;
            this.cmbTurno.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino",
            "Nocturno"});
            this.cmbTurno.Location = new System.Drawing.Point(52, 117);
            this.cmbTurno.MaxDropDownItems = 4;
            this.cmbTurno.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(254, 49);
            this.cmbTurno.StartIndex = 0;
            this.cmbTurno.TabIndex = 60;
            this.cmbTurno.SelectedIndexChanged += new System.EventHandler(this.materialComboBox1_SelectedIndexChanged);
            // 
            // txtNoNomina
            // 
            this.txtNoNomina.AnimateReadOnly = false;
            this.txtNoNomina.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNoNomina.Depth = 0;
            this.txtNoNomina.Enabled = false;
            this.txtNoNomina.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNoNomina.Hint = "Numero de Nomina: ";
            this.txtNoNomina.LeadingIcon = null;
            this.txtNoNomina.Location = new System.Drawing.Point(52, 15);
            this.txtNoNomina.MaxLength = 18;
            this.txtNoNomina.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNoNomina.Multiline = false;
            this.txtNoNomina.Name = "txtNoNomina";
            this.txtNoNomina.Size = new System.Drawing.Size(254, 50);
            this.txtNoNomina.TabIndex = 59;
            this.txtNoNomina.Text = "";
            this.txtNoNomina.TrailingIcon = null;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.btnBuscarEmpleadoNSS);
            this.panel3.Controls.Add(this.txtDomicilio);
            this.panel3.Controls.Add(this.txtTelefono);
            this.panel3.Controls.Add(this.txtNombreCompleto);
            this.panel3.Controls.Add(this.txtNssBusqueda);
            this.panel3.Location = new System.Drawing.Point(17, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(916, 181);
            this.panel3.TabIndex = 60;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.AnimateReadOnly = false;
            this.txtDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDomicilio.Depth = 0;
            this.txtDomicilio.Enabled = false;
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
            this.txtTelefono.Enabled = false;
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
            // pSeccionesDatos
            // 
            this.pSeccionesDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.pSeccionesDatos.Controls.Add(this.label2);
            this.pSeccionesDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSeccionesDatos.Location = new System.Drawing.Point(0, 108);
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
            this.panel2.Size = new System.Drawing.Size(945, 108);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
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
            this.pictureBox2.Size = new System.Drawing.Size(253, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btnBuscarEmpleadoNSS
            // 
            this.btnBuscarEmpleadoNSS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.btnBuscarEmpleadoNSS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.btnBuscarEmpleadoNSS.BorderColor = System.Drawing.Color.LavenderBlush;
            this.btnBuscarEmpleadoNSS.BorderRadius = 20;
            this.btnBuscarEmpleadoNSS.BorderSize = 0;
            this.btnBuscarEmpleadoNSS.FlatAppearance.BorderSize = 0;
            this.btnBuscarEmpleadoNSS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEmpleadoNSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEmpleadoNSS.ForeColor = System.Drawing.Color.White;
            this.btnBuscarEmpleadoNSS.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarEmpleadoNSS.Image")));
            this.btnBuscarEmpleadoNSS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarEmpleadoNSS.Location = new System.Drawing.Point(265, 35);
            this.btnBuscarEmpleadoNSS.Name = "btnBuscarEmpleadoNSS";
            this.btnBuscarEmpleadoNSS.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnBuscarEmpleadoNSS.Size = new System.Drawing.Size(40, 40);
            this.btnBuscarEmpleadoNSS.TabIndex = 126;
            this.btnBuscarEmpleadoNSS.TextColor = System.Drawing.Color.White;
            this.btnBuscarEmpleadoNSS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarEmpleadoNSS.UseVisualStyleBackColor = false;
            this.btnBuscarEmpleadoNSS.Click += new System.EventHandler(this.btnBuscarEmpleadoNSS_Click);
            // 
            // btmCancelar
            // 
            this.btmCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.btmCancelar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.btmCancelar.BorderColor = System.Drawing.Color.LavenderBlush;
            this.btmCancelar.BorderRadius = 20;
            this.btmCancelar.BorderSize = 0;
            this.btmCancelar.FlatAppearance.BorderSize = 0;
            this.btmCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmCancelar.ForeColor = System.Drawing.Color.White;
            this.btmCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btmCancelar.Image")));
            this.btmCancelar.Location = new System.Drawing.Point(472, 427);
            this.btmCancelar.Name = "btmCancelar";
            this.btmCancelar.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btmCancelar.Size = new System.Drawing.Size(184, 53);
            this.btmCancelar.TabIndex = 147;
            this.btmCancelar.Text = " Cancelar";
            this.btmCancelar.TextColor = System.Drawing.Color.White;
            this.btmCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btmCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.btnGrabar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.btnGrabar.BorderColor = System.Drawing.Color.LavenderBlush;
            this.btnGrabar.BorderRadius = 20;
            this.btnGrabar.BorderSize = 0;
            this.btnGrabar.FlatAppearance.BorderSize = 0;
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.ForeColor = System.Drawing.Color.White;
            this.btnGrabar.Image = ((System.Drawing.Image)(resources.GetObject("btnGrabar.Image")));
            this.btnGrabar.Location = new System.Drawing.Point(280, 427);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnGrabar.Size = new System.Drawing.Size(184, 53);
            this.btnGrabar.TabIndex = 146;
            this.btnGrabar.Text = " Grabar";
            this.btnGrabar.TextColor = System.Drawing.Color.White;
            this.btnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // frmAltaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 645);
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
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialTextBox txtNoNomina;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialComboBox cmbTurno;
        private MaterialSkin.Controls.MaterialTextBox txtNombreCompleto;
        private MaterialSkin.Controls.MaterialTextBox txtTelefono;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialTextBox txtDomicilio;
        private MaterialSkin.Controls.MaterialTextBox txtIdPuesto;
        private BotonPersonalizado btnBuscarEmpleadoNSS;
        private BotonPersonalizado btmCancelar;
        private BotonPersonalizado btnGrabar;
    }
}