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
            this.btnCancelar = new CapaPresentacion.BotonPersonalizado();
            this.btnGrabar = new CapaPresentacion.BotonPersonalizado();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFechaIngreso = new CapaPresentacion.selectorFechaPersonalizado();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbPuestos = new CapaPresentacion.comboBoxPersonalizado();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTurno = new CapaPresentacion.comboBoxPersonalizado();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdPuesto = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNoNomina = new CapaPresentacion.TextPersonalizado();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtidempleado = new CapaPresentacion.TextPersonalizado();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDomicilio = new CapaPresentacion.TextPersonalizado();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefono = new CapaPresentacion.TextPersonalizado();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreCompleto = new CapaPresentacion.TextPersonalizado();
            this.label66 = new System.Windows.Forms.Label();
            this.txtNssBusqueda = new CapaPresentacion.TextPersonalizado();
            this.btnBuscarEmpleadoNSS = new CapaPresentacion.BotonPersonalizado();
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
            this.panel1.Size = new System.Drawing.Size(945, 645);
            this.panel1.TabIndex = 0;
            // 
            // pDatosLaborales
            // 
            this.pDatosLaborales.Controls.Add(this.btnCancelar);
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
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.btnCancelar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.btnCancelar.BorderColor = System.Drawing.Color.LavenderBlush;
            this.btnCancelar.BorderRadius = 20;
            this.btnCancelar.BorderSize = 0;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(472, 427);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnCancelar.Size = new System.Drawing.Size(184, 53);
            this.btnCancelar.TabIndex = 147;
            this.btnCancelar.Text = " Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.btnGrabar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.btnGrabar.BorderColor = System.Drawing.Color.LavenderBlush;
            this.btnGrabar.BorderRadius = 20;
            this.btnGrabar.BorderSize = 0;
            this.btnGrabar.Enabled = false;
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.dtpFechaIngreso);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.cmbPuestos);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.cmbTurno);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txtIdPuesto);
            this.panel4.Controls.Add(this.txtNoNomina);
            this.panel4.Location = new System.Drawing.Point(17, 226);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(916, 193);
            this.panel4.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.label9.Location = new System.Drawing.Point(371, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 16);
            this.label9.TabIndex = 163;
            this.label9.Text = "Fecha de Ingreso:";
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.BorderColor = System.Drawing.Color.DarkCyan;
            this.dtpFechaIngreso.BorderSize = 1;
            this.dtpFechaIngreso.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dtpFechaIngreso.CalendarTitleBackColor = System.Drawing.Color.DarkCyan;
            this.dtpFechaIngreso.Enabled = false;
            this.dtpFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.dtpFechaIngreso.Location = new System.Drawing.Point(374, 41);
            this.dtpFechaIngreso.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.dtpFechaIngreso.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(494, 35);
            this.dtpFechaIngreso.SkinColor = System.Drawing.Color.WhiteSmoke;
            this.dtpFechaIngreso.TabIndex = 162;
            this.dtpFechaIngreso.TextColor = System.Drawing.Color.DimGray;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.label8.Location = new System.Drawing.Point(371, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 161;
            this.label8.Text = "Puesto: ";
            // 
            // cmbPuestos
            // 
            this.cmbPuestos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbPuestos.BorderColor = System.Drawing.Color.DarkCyan;
            this.cmbPuestos.BorderSize = 1;
            this.cmbPuestos.DisplayMember = "";
            this.cmbPuestos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPuestos.Enabled = false;
            this.cmbPuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbPuestos.ForeColor = System.Drawing.Color.DimGray;
            this.cmbPuestos.IconColor = System.Drawing.Color.DarkCyan;
            this.cmbPuestos.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino",
            "Nocturno",
            "Mixto"});
            this.cmbPuestos.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbPuestos.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbPuestos.Location = new System.Drawing.Point(371, 116);
            this.cmbPuestos.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbPuestos.Name = "cmbPuestos";
            this.cmbPuestos.Padding = new System.Windows.Forms.Padding(1);
            this.cmbPuestos.Size = new System.Drawing.Size(497, 30);
            this.cmbPuestos.TabIndex = 160;
            this.cmbPuestos.ValueMember = "";
            this.cmbPuestos.OnSelectedIndexChanged += new System.EventHandler(this.materialComboBox2_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.label7.Location = new System.Drawing.Point(56, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 159;
            this.label7.Text = "Turno: ";
            // 
            // cmbTurno
            // 
            this.cmbTurno.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbTurno.BorderColor = System.Drawing.Color.DarkCyan;
            this.cmbTurno.BorderSize = 1;
            this.cmbTurno.DisplayMember = "";
            this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurno.Enabled = false;
            this.cmbTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbTurno.ForeColor = System.Drawing.Color.DimGray;
            this.cmbTurno.IconColor = System.Drawing.Color.DarkCyan;
            this.cmbTurno.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino",
            "Nocturno",
            "Mixto"});
            this.cmbTurno.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbTurno.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbTurno.Location = new System.Drawing.Point(56, 116);
            this.cmbTurno.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Padding = new System.Windows.Forms.Padding(1);
            this.cmbTurno.SelectedIndex = 1;
            this.cmbTurno.Size = new System.Drawing.Size(249, 30);
            this.cmbTurno.TabIndex = 158;
            this.cmbTurno.ValueMember = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.label6.Location = new System.Drawing.Point(56, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 16);
            this.label6.TabIndex = 137;
            this.label6.Text = "Número de Nómina: ";
            // 
            // txtIdPuesto
            // 
            this.txtIdPuesto.AnimateReadOnly = false;
            this.txtIdPuesto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdPuesto.Depth = 0;
            this.txtIdPuesto.Enabled = false;
            this.txtIdPuesto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdPuesto.Hint = "id puesto:";
            this.txtIdPuesto.LeadingIcon = null;
            this.txtIdPuesto.Location = new System.Drawing.Point(625, 61);
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
            // txtNoNomina
            // 
            this.txtNoNomina.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNoNomina.BorderColor = System.Drawing.Color.Gray;
            this.txtNoNomina.BorderFocusColor = System.Drawing.Color.DarkCyan;
            this.txtNoNomina.BorderRadius = 12;
            this.txtNoNomina.BorderSize = 2;
            this.txtNoNomina.Enabled = false;
            this.txtNoNomina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoNomina.ForeColor = System.Drawing.Color.DimGray;
            this.txtNoNomina.Location = new System.Drawing.Point(56, 41);
            this.txtNoNomina.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoNomina.MaxLength = 32767;
            this.txtNoNomina.Multiline = false;
            this.txtNoNomina.Name = "txtNoNomina";
            this.txtNoNomina.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNoNomina.PasswordChar = false;
            this.txtNoNomina.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNoNomina.PlaceholderText = "";
            this.txtNoNomina.Size = new System.Drawing.Size(253, 35);
            this.txtNoNomina.TabIndex = 136;
            this.txtNoNomina.UnderlinedStyle = true;
            this.txtNoNomina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoNomina_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.txtidempleado);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtDomicilio);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtTelefono);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtNombreCompleto);
            this.panel3.Controls.Add(this.label66);
            this.panel3.Controls.Add(this.txtNssBusqueda);
            this.panel3.Controls.Add(this.btnBuscarEmpleadoNSS);
            this.panel3.Location = new System.Drawing.Point(17, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(916, 181);
            this.panel3.TabIndex = 60;
            // 
            // txtidempleado
            // 
            this.txtidempleado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtidempleado.BorderColor = System.Drawing.Color.Gray;
            this.txtidempleado.BorderFocusColor = System.Drawing.Color.DarkCyan;
            this.txtidempleado.BorderRadius = 12;
            this.txtidempleado.BorderSize = 2;
            this.txtidempleado.Enabled = false;
            this.txtidempleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidempleado.ForeColor = System.Drawing.Color.DimGray;
            this.txtidempleado.Location = new System.Drawing.Point(756, 83);
            this.txtidempleado.Margin = new System.Windows.Forms.Padding(4);
            this.txtidempleado.MaxLength = 32767;
            this.txtidempleado.Multiline = false;
            this.txtidempleado.Name = "txtidempleado";
            this.txtidempleado.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtidempleado.PasswordChar = false;
            this.txtidempleado.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtidempleado.PlaceholderText = "";
            this.txtidempleado.Size = new System.Drawing.Size(102, 35);
            this.txtidempleado.TabIndex = 136;
            this.txtidempleado.UnderlinedStyle = true;
            this.txtidempleado.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.label5.Location = new System.Drawing.Point(365, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 135;
            this.label5.Text = "Domicilio:  ";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDomicilio.BorderColor = System.Drawing.Color.Gray;
            this.txtDomicilio.BorderFocusColor = System.Drawing.Color.DarkCyan;
            this.txtDomicilio.BorderRadius = 12;
            this.txtDomicilio.BorderSize = 2;
            this.txtDomicilio.Enabled = false;
            this.txtDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomicilio.ForeColor = System.Drawing.Color.DimGray;
            this.txtDomicilio.Location = new System.Drawing.Point(361, 125);
            this.txtDomicilio.Margin = new System.Windows.Forms.Padding(4);
            this.txtDomicilio.MaxLength = 32767;
            this.txtDomicilio.Multiline = false;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDomicilio.PasswordChar = false;
            this.txtDomicilio.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDomicilio.PlaceholderText = "";
            this.txtDomicilio.Size = new System.Drawing.Size(497, 35);
            this.txtDomicilio.TabIndex = 134;
            this.txtDomicilio.UnderlinedStyle = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.label4.Location = new System.Drawing.Point(56, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 133;
            this.label4.Text = "Teléfono: ";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTelefono.BorderColor = System.Drawing.Color.Gray;
            this.txtTelefono.BorderFocusColor = System.Drawing.Color.DarkCyan;
            this.txtTelefono.BorderRadius = 12;
            this.txtTelefono.BorderSize = 2;
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.DimGray;
            this.txtTelefono.Location = new System.Drawing.Point(52, 125);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.MaxLength = 32767;
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTelefono.PasswordChar = false;
            this.txtTelefono.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTelefono.PlaceholderText = "";
            this.txtTelefono.Size = new System.Drawing.Size(253, 35);
            this.txtTelefono.TabIndex = 132;
            this.txtTelefono.UnderlinedStyle = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.label3.Location = new System.Drawing.Point(365, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 16);
            this.label3.TabIndex = 131;
            this.label3.Text = "Nombre del Colaborador: ";
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombreCompleto.BorderColor = System.Drawing.Color.Gray;
            this.txtNombreCompleto.BorderFocusColor = System.Drawing.Color.DarkCyan;
            this.txtNombreCompleto.BorderRadius = 12;
            this.txtNombreCompleto.BorderSize = 2;
            this.txtNombreCompleto.Enabled = false;
            this.txtNombreCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCompleto.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombreCompleto.Location = new System.Drawing.Point(361, 40);
            this.txtNombreCompleto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreCompleto.MaxLength = 32767;
            this.txtNombreCompleto.Multiline = false;
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNombreCompleto.PasswordChar = false;
            this.txtNombreCompleto.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNombreCompleto.PlaceholderText = "";
            this.txtNombreCompleto.Size = new System.Drawing.Size(497, 35);
            this.txtNombreCompleto.TabIndex = 130;
            this.txtNombreCompleto.UnderlinedStyle = true;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label66.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.label66.Location = new System.Drawing.Point(56, 24);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(176, 16);
            this.label66.TabIndex = 129;
            this.label66.Text = "Número de Nomina/NSS";
            // 
            // txtNssBusqueda
            // 
            this.txtNssBusqueda.BackColor = System.Drawing.SystemColors.Window;
            this.txtNssBusqueda.BorderColor = System.Drawing.Color.Gray;
            this.txtNssBusqueda.BorderFocusColor = System.Drawing.Color.DarkCyan;
            this.txtNssBusqueda.BorderRadius = 12;
            this.txtNssBusqueda.BorderSize = 2;
            this.txtNssBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNssBusqueda.ForeColor = System.Drawing.Color.DimGray;
            this.txtNssBusqueda.Location = new System.Drawing.Point(52, 40);
            this.txtNssBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.txtNssBusqueda.MaxLength = 32767;
            this.txtNssBusqueda.Multiline = false;
            this.txtNssBusqueda.Name = "txtNssBusqueda";
            this.txtNssBusqueda.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNssBusqueda.PasswordChar = false;
            this.txtNssBusqueda.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNssBusqueda.PlaceholderText = "";
            this.txtNssBusqueda.Size = new System.Drawing.Size(208, 35);
            this.txtNssBusqueda.TabIndex = 128;
            this.txtNssBusqueda.UnderlinedStyle = true;
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
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialTextBox txtIdPuesto;
        private BotonPersonalizado btnBuscarEmpleadoNSS;
        private BotonPersonalizado btnCancelar;
        private BotonPersonalizado btnGrabar;
        private System.Windows.Forms.Label label6;
        private TextPersonalizado txtNoNomina;
        private System.Windows.Forms.Label label5;
        private TextPersonalizado txtDomicilio;
        private System.Windows.Forms.Label label4;
        private TextPersonalizado txtTelefono;
        private System.Windows.Forms.Label label3;
        private TextPersonalizado txtNombreCompleto;
        private System.Windows.Forms.Label label66;
        private TextPersonalizado txtNssBusqueda;
        private System.Windows.Forms.Label label7;
        private comboBoxPersonalizado cmbTurno;
        private comboBoxPersonalizado cmbPuestos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private selectorFechaPersonalizado dtpFechaIngreso;
        private TextPersonalizado txtidempleado;
    }
}