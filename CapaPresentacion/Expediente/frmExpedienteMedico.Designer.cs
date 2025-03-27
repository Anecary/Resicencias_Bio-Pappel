namespace CapaPresentacion.Expediente
{
    partial class frmExpedienteMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExpedienteMedico));
            this.pContenedorExp = new System.Windows.Forms.Panel();
            this.pContenedor = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pSeccionesExpediente = new System.Windows.Forms.Panel();
            this.btnControlAcciones = new System.Windows.Forms.Button();
            this.btnSeguimientoCaso = new System.Windows.Forms.Button();
            this.btnFactoresSeguridad = new System.Windows.Forms.Button();
            this.btnNoPatologicos = new System.Windows.Forms.Button();
            this.btnDatosGenerales = new System.Windows.Forms.Button();
            this.pDatosGenerales = new System.Windows.Forms.Panel();
            this.label42 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtIdEmpleado = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNumeroNomina = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNombreEmpleado = new MaterialSkin.Controls.MaterialTextBox();
            this.btnBuscarEmpleado = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.txtNoExpediente = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSexo = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEstadoCivil = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNSS = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEdad = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTelefono = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDomicilio = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.txtPuesto = new MaterialSkin.Controls.MaterialTextBox();
            this.cboxProceso = new MaterialSkin.Controls.MaterialComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtFechaIngreso = new MaterialSkin.Controls.MaterialTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label62 = new System.Windows.Forms.Label();
            this.txtDescripcionAccidente = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.label32 = new System.Windows.Forms.Label();
            this.pContenedorExp.SuspendLayout();
            this.pContenedor.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pSeccionesExpediente.SuspendLayout();
            this.pDatosGenerales.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pContenedorExp
            // 
            this.pContenedorExp.BackColor = System.Drawing.Color.White;
            this.pContenedorExp.Controls.Add(this.pContenedor);
            this.pContenedorExp.Controls.Add(this.pSeccionesExpediente);
            this.pContenedorExp.Controls.Add(this.panel2);
            this.pContenedorExp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContenedorExp.Location = new System.Drawing.Point(0, 0);
            this.pContenedorExp.Name = "pContenedorExp";
            this.pContenedorExp.Size = new System.Drawing.Size(934, 632);
            this.pContenedorExp.TabIndex = 0;
            // 
            // pContenedor
            // 
            this.pContenedor.Controls.Add(this.pDatosGenerales);
            this.pContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContenedor.Location = new System.Drawing.Point(0, 145);
            this.pContenedor.Name = "pContenedor";
            this.pContenedor.Size = new System.Drawing.Size(934, 487);
            this.pContenedor.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(934, 100);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(253, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(141)))));
            this.label1.Location = new System.Drawing.Point(374, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expediente Clínico";
            // 
            // pSeccionesExpediente
            // 
            this.pSeccionesExpediente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(141)))));
            this.pSeccionesExpediente.Controls.Add(this.btnControlAcciones);
            this.pSeccionesExpediente.Controls.Add(this.btnSeguimientoCaso);
            this.pSeccionesExpediente.Controls.Add(this.btnFactoresSeguridad);
            this.pSeccionesExpediente.Controls.Add(this.btnNoPatologicos);
            this.pSeccionesExpediente.Controls.Add(this.btnDatosGenerales);
            this.pSeccionesExpediente.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSeccionesExpediente.Location = new System.Drawing.Point(0, 100);
            this.pSeccionesExpediente.Name = "pSeccionesExpediente";
            this.pSeccionesExpediente.Size = new System.Drawing.Size(934, 45);
            this.pSeccionesExpediente.TabIndex = 12;
            // 
            // btnControlAcciones
            // 
            this.btnControlAcciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnControlAcciones.FlatAppearance.BorderSize = 0;
            this.btnControlAcciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControlAcciones.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControlAcciones.ForeColor = System.Drawing.Color.White;
            this.btnControlAcciones.Location = new System.Drawing.Point(740, 0);
            this.btnControlAcciones.Name = "btnControlAcciones";
            this.btnControlAcciones.Size = new System.Drawing.Size(185, 40);
            this.btnControlAcciones.TabIndex = 9;
            this.btnControlAcciones.Text = "Estudios Paraclínicos";
            this.btnControlAcciones.UseVisualStyleBackColor = true;
            // 
            // btnSeguimientoCaso
            // 
            this.btnSeguimientoCaso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeguimientoCaso.FlatAppearance.BorderSize = 0;
            this.btnSeguimientoCaso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeguimientoCaso.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeguimientoCaso.ForeColor = System.Drawing.Color.White;
            this.btnSeguimientoCaso.Location = new System.Drawing.Point(555, 0);
            this.btnSeguimientoCaso.Name = "btnSeguimientoCaso";
            this.btnSeguimientoCaso.Size = new System.Drawing.Size(185, 40);
            this.btnSeguimientoCaso.TabIndex = 8;
            this.btnSeguimientoCaso.Text = "Exploración Física";
            this.btnSeguimientoCaso.UseVisualStyleBackColor = true;
            // 
            // btnFactoresSeguridad
            // 
            this.btnFactoresSeguridad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFactoresSeguridad.FlatAppearance.BorderSize = 0;
            this.btnFactoresSeguridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFactoresSeguridad.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactoresSeguridad.ForeColor = System.Drawing.Color.White;
            this.btnFactoresSeguridad.Location = new System.Drawing.Point(370, 0);
            this.btnFactoresSeguridad.Name = "btnFactoresSeguridad";
            this.btnFactoresSeguridad.Size = new System.Drawing.Size(185, 40);
            this.btnFactoresSeguridad.TabIndex = 7;
            this.btnFactoresSeguridad.Text = "Patológicos";
            this.btnFactoresSeguridad.UseVisualStyleBackColor = true;
            // 
            // btnNoPatologicos
            // 
            this.btnNoPatologicos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNoPatologicos.FlatAppearance.BorderSize = 0;
            this.btnNoPatologicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoPatologicos.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoPatologicos.ForeColor = System.Drawing.Color.White;
            this.btnNoPatologicos.Location = new System.Drawing.Point(185, 0);
            this.btnNoPatologicos.Name = "btnNoPatologicos";
            this.btnNoPatologicos.Size = new System.Drawing.Size(185, 40);
            this.btnNoPatologicos.TabIndex = 6;
            this.btnNoPatologicos.Text = "No Patológicos";
            this.btnNoPatologicos.UseVisualStyleBackColor = true;
            // 
            // btnDatosGenerales
            // 
            this.btnDatosGenerales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDatosGenerales.FlatAppearance.BorderSize = 0;
            this.btnDatosGenerales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatosGenerales.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatosGenerales.ForeColor = System.Drawing.Color.White;
            this.btnDatosGenerales.Location = new System.Drawing.Point(0, 0);
            this.btnDatosGenerales.Name = "btnDatosGenerales";
            this.btnDatosGenerales.Size = new System.Drawing.Size(185, 40);
            this.btnDatosGenerales.TabIndex = 5;
            this.btnDatosGenerales.Text = "Datos Generales";
            this.btnDatosGenerales.UseVisualStyleBackColor = true;
            // 
            // pDatosGenerales
            // 
            this.pDatosGenerales.AutoScroll = true;
            this.pDatosGenerales.Controls.Add(this.panel4);
            this.pDatosGenerales.Controls.Add(this.label26);
            this.pDatosGenerales.Controls.Add(this.panel3);
            this.pDatosGenerales.Location = new System.Drawing.Point(0, 10);
            this.pDatosGenerales.Name = "pDatosGenerales";
            this.pDatosGenerales.Size = new System.Drawing.Size(934, 487);
            this.pDatosGenerales.TabIndex = 0;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(141)))));
            this.label42.Location = new System.Drawing.Point(12, 10);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(188, 25);
            this.label42.TabIndex = 96;
            this.label42.Text = "Datos Generales";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.txtFechaIngreso);
            this.panel3.Controls.Add(this.cboxProceso);
            this.panel3.Controls.Add(this.txtPuesto);
            this.panel3.Controls.Add(this.txtDomicilio);
            this.panel3.Controls.Add(this.txtTelefono);
            this.panel3.Controls.Add(this.txtEdad);
            this.panel3.Controls.Add(this.txtNSS);
            this.panel3.Controls.Add(this.txtEstadoCivil);
            this.panel3.Controls.Add(this.txtSexo);
            this.panel3.Controls.Add(this.txtNoExpediente);
            this.panel3.Controls.Add(this.btnBuscarEmpleado);
            this.panel3.Controls.Add(this.label42);
            this.panel3.Controls.Add(this.txtIdEmpleado);
            this.panel3.Controls.Add(this.txtNumeroNomina);
            this.panel3.Controls.Add(this.txtNombreEmpleado);
            this.panel3.Location = new System.Drawing.Point(8, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(900, 437);
            this.panel3.TabIndex = 97;
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.AnimateReadOnly = false;
            this.txtIdEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdEmpleado.Depth = 0;
            this.txtIdEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdEmpleado.Hint = "IdEmpleado";
            this.txtIdEmpleado.LeadingIcon = null;
            this.txtIdEmpleado.Location = new System.Drawing.Point(687, 106);
            this.txtIdEmpleado.MaxLength = 50;
            this.txtIdEmpleado.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIdEmpleado.Multiline = false;
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(183, 50);
            this.txtIdEmpleado.TabIndex = 101;
            this.txtIdEmpleado.Text = "";
            this.txtIdEmpleado.TrailingIcon = null;
            this.txtIdEmpleado.Visible = false;
            // 
            // txtNumeroNomina
            // 
            this.txtNumeroNomina.AnimateReadOnly = false;
            this.txtNumeroNomina.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumeroNomina.Depth = 0;
            this.txtNumeroNomina.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumeroNomina.Hint = "No. Nomina: ";
            this.txtNumeroNomina.LeadingIcon = null;
            this.txtNumeroNomina.Location = new System.Drawing.Point(17, 38);
            this.txtNumeroNomina.MaxLength = 18;
            this.txtNumeroNomina.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNumeroNomina.Multiline = false;
            this.txtNumeroNomina.Name = "txtNumeroNomina";
            this.txtNumeroNomina.Size = new System.Drawing.Size(263, 50);
            this.txtNumeroNomina.TabIndex = 97;
            this.txtNumeroNomina.Text = "";
            this.txtNumeroNomina.TrailingIcon = null;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.AnimateReadOnly = false;
            this.txtNombreEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreEmpleado.Depth = 0;
            this.txtNombreEmpleado.Enabled = false;
            this.txtNombreEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreEmpleado.Hint = "Nombre del colaborador:";
            this.txtNombreEmpleado.LeadingIcon = null;
            this.txtNombreEmpleado.Location = new System.Drawing.Point(17, 106);
            this.txtNombreEmpleado.MaxLength = 50;
            this.txtNombreEmpleado.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreEmpleado.Multiline = false;
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(869, 50);
            this.txtNombreEmpleado.TabIndex = 99;
            this.txtNombreEmpleado.Text = "";
            this.txtNombreEmpleado.TrailingIcon = null;
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.Depth = 0;
            this.btnBuscarEmpleado.Icon = ((System.Drawing.Image)(resources.GetObject("btnBuscarEmpleado.Icon")));
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(304, 43);
            this.btnBuscarEmpleado.Mini = true;
            this.btnBuscarEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(40, 40);
            this.btnBuscarEmpleado.TabIndex = 102;
            this.btnBuscarEmpleado.Text = "materialFloatingActionButton2";
            this.btnBuscarEmpleado.UseVisualStyleBackColor = true;
            this.btnBuscarEmpleado.Click += new System.EventHandler(this.btnBuscarEmpleado_Click);
            // 
            // txtNoExpediente
            // 
            this.txtNoExpediente.AnimateReadOnly = false;
            this.txtNoExpediente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNoExpediente.Depth = 0;
            this.txtNoExpediente.Enabled = false;
            this.txtNoExpediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNoExpediente.Hint = "No. Expediente: ";
            this.txtNoExpediente.LeadingIcon = null;
            this.txtNoExpediente.Location = new System.Drawing.Point(547, 38);
            this.txtNoExpediente.MaxLength = 18;
            this.txtNoExpediente.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNoExpediente.Multiline = false;
            this.txtNoExpediente.Name = "txtNoExpediente";
            this.txtNoExpediente.Size = new System.Drawing.Size(339, 50);
            this.txtNoExpediente.TabIndex = 103;
            this.txtNoExpediente.Text = "";
            this.txtNoExpediente.TrailingIcon = null;
            // 
            // txtSexo
            // 
            this.txtSexo.AnimateReadOnly = false;
            this.txtSexo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSexo.Depth = 0;
            this.txtSexo.Enabled = false;
            this.txtSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSexo.Hint = "Sexo:";
            this.txtSexo.LeadingIcon = null;
            this.txtSexo.Location = new System.Drawing.Point(240, 175);
            this.txtSexo.MaxLength = 50;
            this.txtSexo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSexo.Multiline = false;
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(200, 50);
            this.txtSexo.TabIndex = 104;
            this.txtSexo.Text = "";
            this.txtSexo.TrailingIcon = null;
            // 
            // txtEstadoCivil
            // 
            this.txtEstadoCivil.AnimateReadOnly = false;
            this.txtEstadoCivil.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEstadoCivil.Depth = 0;
            this.txtEstadoCivil.Enabled = false;
            this.txtEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEstadoCivil.Hint = "Estado Civil:";
            this.txtEstadoCivil.LeadingIcon = null;
            this.txtEstadoCivil.Location = new System.Drawing.Point(463, 175);
            this.txtEstadoCivil.MaxLength = 50;
            this.txtEstadoCivil.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEstadoCivil.Multiline = false;
            this.txtEstadoCivil.Name = "txtEstadoCivil";
            this.txtEstadoCivil.Size = new System.Drawing.Size(200, 50);
            this.txtEstadoCivil.TabIndex = 105;
            this.txtEstadoCivil.Text = "";
            this.txtEstadoCivil.TrailingIcon = null;
            // 
            // txtNSS
            // 
            this.txtNSS.AnimateReadOnly = false;
            this.txtNSS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNSS.Depth = 0;
            this.txtNSS.Enabled = false;
            this.txtNSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNSS.Hint = "No. IMSS:";
            this.txtNSS.LeadingIcon = null;
            this.txtNSS.Location = new System.Drawing.Point(686, 175);
            this.txtNSS.MaxLength = 50;
            this.txtNSS.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNSS.Multiline = false;
            this.txtNSS.Name = "txtNSS";
            this.txtNSS.Size = new System.Drawing.Size(200, 50);
            this.txtNSS.TabIndex = 106;
            this.txtNSS.Text = "";
            this.txtNSS.TrailingIcon = null;
            // 
            // txtEdad
            // 
            this.txtEdad.AnimateReadOnly = false;
            this.txtEdad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEdad.Depth = 0;
            this.txtEdad.Enabled = false;
            this.txtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEdad.Hint = "Edad:";
            this.txtEdad.LeadingIcon = null;
            this.txtEdad.Location = new System.Drawing.Point(17, 175);
            this.txtEdad.MaxLength = 50;
            this.txtEdad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEdad.Multiline = false;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(200, 50);
            this.txtEdad.TabIndex = 107;
            this.txtEdad.Text = "";
            this.txtEdad.TrailingIcon = null;
            // 
            // txtTelefono
            // 
            this.txtTelefono.AnimateReadOnly = false;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Depth = 0;
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelefono.Hint = "Teléfono:";
            this.txtTelefono.LeadingIcon = null;
            this.txtTelefono.Location = new System.Drawing.Point(687, 241);
            this.txtTelefono.MaxLength = 200;
            this.txtTelefono.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(200, 50);
            this.txtTelefono.TabIndex = 108;
            this.txtTelefono.Text = "";
            this.txtTelefono.TrailingIcon = null;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.AnimateReadOnly = false;
            this.txtDomicilio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDomicilio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDomicilio.Depth = 0;
            this.txtDomicilio.Enabled = false;
            this.txtDomicilio.HideSelection = true;
            this.txtDomicilio.Hint = "Domicilio:";
            this.txtDomicilio.Location = new System.Drawing.Point(17, 241);
            this.txtDomicilio.MaxLength = 32767;
            this.txtDomicilio.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.PasswordChar = '\0';
            this.txtDomicilio.ReadOnly = false;
            this.txtDomicilio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDomicilio.SelectedText = "";
            this.txtDomicilio.SelectionLength = 0;
            this.txtDomicilio.SelectionStart = 0;
            this.txtDomicilio.ShortcutsEnabled = true;
            this.txtDomicilio.Size = new System.Drawing.Size(646, 110);
            this.txtDomicilio.TabIndex = 110;
            this.txtDomicilio.TabStop = false;
            this.txtDomicilio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDomicilio.UseSystemPasswordChar = false;
            // 
            // txtPuesto
            // 
            this.txtPuesto.AnimateReadOnly = false;
            this.txtPuesto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPuesto.Depth = 0;
            this.txtPuesto.Enabled = false;
            this.txtPuesto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPuesto.Hint = "Puesto:";
            this.txtPuesto.LeadingIcon = null;
            this.txtPuesto.Location = new System.Drawing.Point(17, 365);
            this.txtPuesto.MaxLength = 200;
            this.txtPuesto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(646, 50);
            this.txtPuesto.TabIndex = 111;
            this.txtPuesto.Text = "";
            this.txtPuesto.TrailingIcon = null;
            // 
            // cboxProceso
            // 
            this.cboxProceso.AutoResize = false;
            this.cboxProceso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboxProceso.Depth = 0;
            this.cboxProceso.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboxProceso.DropDownHeight = 174;
            this.cboxProceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxProceso.DropDownWidth = 121;
            this.cboxProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboxProceso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboxProceso.FormattingEnabled = true;
            this.cboxProceso.Hint = "Proceso:";
            this.cboxProceso.IntegralHeight = false;
            this.cboxProceso.ItemHeight = 43;
            this.cboxProceso.Items.AddRange(new object[] {
            "REH",
            "ALM",
            "MEC",
            "EEI",
            "PLA",
            "TEC",
            "CEL",
            "PAP",
            "EMB",
            "FZA",
            "FRE",
            "SPR",
            "SEG",
            "SGE",
            "ADM",
            "ABM",
            "TFO",
            "DIR",
            "ECO",
            "EXT",
            "POB",
            "COM",
            "SIS",
            "SIG"});
            this.cboxProceso.Location = new System.Drawing.Point(687, 302);
            this.cboxProceso.MaxDropDownItems = 4;
            this.cboxProceso.MouseState = MaterialSkin.MouseState.OUT;
            this.cboxProceso.Name = "cboxProceso";
            this.cboxProceso.Size = new System.Drawing.Size(200, 49);
            this.cboxProceso.StartIndex = 0;
            this.cboxProceso.TabIndex = 112;
            // 
            // label26
            // 
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Transparent;
            this.label26.Location = new System.Drawing.Point(3, 778);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(144, 18);
            this.label26.TabIndex = 111;
            this.label26.Text = "Trabajo habitual";
            // 
            // txtFechaIngreso
            // 
            this.txtFechaIngreso.AnimateReadOnly = false;
            this.txtFechaIngreso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFechaIngreso.Depth = 0;
            this.txtFechaIngreso.Enabled = false;
            this.txtFechaIngreso.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFechaIngreso.Hint = "Fecha De Ingreso:";
            this.txtFechaIngreso.LeadingIcon = null;
            this.txtFechaIngreso.Location = new System.Drawing.Point(687, 365);
            this.txtFechaIngreso.MaxLength = 200;
            this.txtFechaIngreso.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFechaIngreso.Name = "txtFechaIngreso";
            this.txtFechaIngreso.Size = new System.Drawing.Size(200, 50);
            this.txtFechaIngreso.TabIndex = 113;
            this.txtFechaIngreso.Text = "";
            this.txtFechaIngreso.TrailingIcon = null;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.label32);
            this.panel4.Controls.Add(this.label62);
            this.panel4.Controls.Add(this.txtDescripcionAccidente);
            this.panel4.Location = new System.Drawing.Point(8, 498);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(900, 271);
            this.panel4.TabIndex = 112;
            // 
            // label62
            // 
            this.label62.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(141)))));
            this.label62.Location = new System.Drawing.Point(13, 42);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(413, 17);
            this.label62.TabIndex = 117;
            this.label62.Text = "Heredo Familiares:";
            // 
            // txtDescripcionAccidente
            // 
            this.txtDescripcionAccidente.AnimateReadOnly = false;
            this.txtDescripcionAccidente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDescripcionAccidente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDescripcionAccidente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcionAccidente.Depth = 0;
            this.txtDescripcionAccidente.HideSelection = true;
            this.txtDescripcionAccidente.Location = new System.Drawing.Point(13, 62);
            this.txtDescripcionAccidente.MaxLength = 32767;
            this.txtDescripcionAccidente.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescripcionAccidente.Name = "txtDescripcionAccidente";
            this.txtDescripcionAccidente.PasswordChar = '\0';
            this.txtDescripcionAccidente.ReadOnly = false;
            this.txtDescripcionAccidente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescripcionAccidente.SelectedText = "";
            this.txtDescripcionAccidente.SelectionLength = 0;
            this.txtDescripcionAccidente.SelectionStart = 0;
            this.txtDescripcionAccidente.ShortcutsEnabled = true;
            this.txtDescripcionAccidente.Size = new System.Drawing.Size(873, 188);
            this.txtDescripcionAccidente.TabIndex = 118;
            this.txtDescripcionAccidente.TabStop = false;
            this.txtDescripcionAccidente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescripcionAccidente.UseSystemPasswordChar = false;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(141)))));
            this.label32.Location = new System.Drawing.Point(377, 10);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(145, 24);
            this.label32.TabIndex = 119;
            this.label32.Text = "Antecedentes:";
            // 
            // frmExpedienteMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 632);
            this.Controls.Add(this.pContenedorExp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmExpedienteMedico";
            this.Text = "frmExpedienteMedico";
            this.pContenedorExp.ResumeLayout(false);
            this.pContenedor.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pSeccionesExpediente.ResumeLayout(false);
            this.pDatosGenerales.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pContenedorExp;
        private System.Windows.Forms.Panel pContenedor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pSeccionesExpediente;
        private System.Windows.Forms.Button btnControlAcciones;
        private System.Windows.Forms.Button btnSeguimientoCaso;
        private System.Windows.Forms.Button btnFactoresSeguridad;
        private System.Windows.Forms.Button btnNoPatologicos;
        private System.Windows.Forms.Button btnDatosGenerales;
        private System.Windows.Forms.Panel pDatosGenerales;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label42;
        private MaterialSkin.Controls.MaterialTextBox txtIdEmpleado;
        private MaterialSkin.Controls.MaterialTextBox txtNumeroNomina;
        private MaterialSkin.Controls.MaterialTextBox txtNombreEmpleado;
        private MaterialSkin.Controls.MaterialFloatingActionButton btnBuscarEmpleado;
        private MaterialSkin.Controls.MaterialTextBox txtNoExpediente;
        private MaterialSkin.Controls.MaterialTextBox txtEdad;
        private MaterialSkin.Controls.MaterialTextBox txtNSS;
        private MaterialSkin.Controls.MaterialTextBox txtEstadoCivil;
        private MaterialSkin.Controls.MaterialTextBox txtSexo;
        private MaterialSkin.Controls.MaterialTextBox txtTelefono;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtDomicilio;
        private MaterialSkin.Controls.MaterialTextBox txtPuesto;
        private MaterialSkin.Controls.MaterialComboBox cboxProceso;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label26;
        private MaterialSkin.Controls.MaterialTextBox txtFechaIngreso;
        private System.Windows.Forms.Label label62;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtDescripcionAccidente;
        private System.Windows.Forms.Label label32;
    }
}