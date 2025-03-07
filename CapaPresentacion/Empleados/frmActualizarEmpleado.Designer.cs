namespace CapaPresentacion.Empleados
{
    partial class frmActualizarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActualizarEmpleado));
            this.pContenedorAct = new System.Windows.Forms.Panel();
            this.pConsultaIndividual = new System.Windows.Forms.Panel();
            this.btnActualizar = new MaterialSkin.Controls.MaterialButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbTurno = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbPuesto = new MaterialSkin.Controls.MaterialComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNoNomina = new MaterialSkin.Controls.MaterialTextBox();
            this.materialFloatingActionButton2 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtNumero = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCalle = new MaterialSkin.Controls.MaterialTextBox();
            this.txtColonia = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCiudad = new MaterialSkin.Controls.MaterialTextBox();
            this.cmbEstadoCivil = new MaterialSkin.Controls.MaterialComboBox();
            this.txtTelefono = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCp = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEstado = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNss = new MaterialSkin.Controls.MaterialTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSexo = new MaterialSkin.Controls.MaterialTextBox();
            this.txtFechaNac = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            this.pSeccionesDatos = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btmCancelar = new MaterialSkin.Controls.MaterialButton();
            this.pContenedorAct.SuspendLayout();
            this.pConsultaIndividual.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pContenedorAct
            // 
            this.pContenedorAct.BackColor = System.Drawing.Color.White;
            this.pContenedorAct.Controls.Add(this.pConsultaIndividual);
            this.pContenedorAct.Controls.Add(this.pSeccionesDatos);
            this.pContenedorAct.Controls.Add(this.panel2);
            this.pContenedorAct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContenedorAct.Location = new System.Drawing.Point(0, 0);
            this.pContenedorAct.Name = "pContenedorAct";
            this.pContenedorAct.Size = new System.Drawing.Size(945, 666);
            this.pContenedorAct.TabIndex = 0;
            // 
            // pConsultaIndividual
            // 
            this.pConsultaIndividual.AutoScroll = true;
            this.pConsultaIndividual.Controls.Add(this.btmCancelar);
            this.pConsultaIndividual.Controls.Add(this.btnActualizar);
            this.pConsultaIndividual.Controls.Add(this.panel4);
            this.pConsultaIndividual.Controls.Add(this.panel3);
            this.pConsultaIndividual.Controls.Add(this.panel5);
            this.pConsultaIndividual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pConsultaIndividual.Location = new System.Drawing.Point(0, 136);
            this.pConsultaIndividual.Name = "pConsultaIndividual";
            this.pConsultaIndividual.Size = new System.Drawing.Size(945, 530);
            this.pConsultaIndividual.TabIndex = 7;
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = false;
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Enabled = false;
            this.btnActualizar.HighEmphasis = true;
            this.btnActualizar.Icon = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Icon")));
            this.btnActualizar.Location = new System.Drawing.Point(223, 664);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnActualizar.Size = new System.Drawing.Size(140, 50);
            this.btnActualizar.TabIndex = 105;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnActualizar.UseAccentColor = true;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Controls.Add(this.cmbTurno);
            this.panel4.Controls.Add(this.cmbPuesto);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(17, 490);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(883, 146);
            this.panel4.TabIndex = 104;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(369, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 114;
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
            this.cmbTurno.Location = new System.Drawing.Point(52, 59);
            this.cmbTurno.MaxDropDownItems = 4;
            this.cmbTurno.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(254, 49);
            this.cmbTurno.StartIndex = 0;
            this.cmbTurno.TabIndex = 113;
            // 
            // cmbPuesto
            // 
            this.cmbPuesto.AutoResize = false;
            this.cmbPuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbPuesto.Depth = 0;
            this.cmbPuesto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbPuesto.DropDownHeight = 174;
            this.cmbPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPuesto.DropDownWidth = 121;
            this.cmbPuesto.Enabled = false;
            this.cmbPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbPuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbPuesto.FormattingEnabled = true;
            this.cmbPuesto.Hint = "Puesto:";
            this.cmbPuesto.IntegralHeight = false;
            this.cmbPuesto.ItemHeight = 43;
            this.cmbPuesto.Location = new System.Drawing.Point(369, 59);
            this.cmbPuesto.MaxDropDownItems = 4;
            this.cmbPuesto.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbPuesto.Name = "cmbPuesto";
            this.cmbPuesto.Size = new System.Drawing.Size(489, 49);
            this.cmbPuesto.StartIndex = 0;
            this.cmbPuesto.TabIndex = 112;
            this.cmbPuesto.SelectedIndexChanged += new System.EventHandler(this.cmbPuesto_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(141)))));
            this.label5.Location = new System.Drawing.Point(47, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 29);
            this.label5.TabIndex = 96;
            this.label5.Text = "Datos Laborales:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtNoNomina);
            this.panel3.Controls.Add(this.materialFloatingActionButton2);
            this.panel3.Location = new System.Drawing.Point(17, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(883, 110);
            this.panel3.TabIndex = 96;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(141)))));
            this.label3.Location = new System.Drawing.Point(47, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Buscar Colaborador";
            // 
            // txtNoNomina
            // 
            this.txtNoNomina.AnimateReadOnly = false;
            this.txtNoNomina.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNoNomina.Depth = 0;
            this.txtNoNomina.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNoNomina.Hint = "Numero de Nomina: ";
            this.txtNoNomina.LeadingIcon = null;
            this.txtNoNomina.Location = new System.Drawing.Point(52, 47);
            this.txtNoNomina.MaxLength = 18;
            this.txtNoNomina.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNoNomina.Multiline = false;
            this.txtNoNomina.Name = "txtNoNomina";
            this.txtNoNomina.Size = new System.Drawing.Size(208, 50);
            this.txtNoNomina.TabIndex = 59;
            this.txtNoNomina.Text = "";
            this.txtNoNomina.TrailingIcon = null;
            // 
            // materialFloatingActionButton2
            // 
            this.materialFloatingActionButton2.Depth = 0;
            this.materialFloatingActionButton2.Icon = ((System.Drawing.Image)(resources.GetObject("materialFloatingActionButton2.Icon")));
            this.materialFloatingActionButton2.Location = new System.Drawing.Point(266, 57);
            this.materialFloatingActionButton2.Mini = true;
            this.materialFloatingActionButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton2.Name = "materialFloatingActionButton2";
            this.materialFloatingActionButton2.Size = new System.Drawing.Size(40, 40);
            this.materialFloatingActionButton2.TabIndex = 95;
            this.materialFloatingActionButton2.Text = "materialFloatingActionButton2";
            this.materialFloatingActionButton2.UseVisualStyleBackColor = true;
            this.materialFloatingActionButton2.Click += new System.EventHandler(this.materialFloatingActionButton2_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Controls.Add(this.txtNumero);
            this.panel5.Controls.Add(this.txtCalle);
            this.panel5.Controls.Add(this.txtColonia);
            this.panel5.Controls.Add(this.txtCiudad);
            this.panel5.Controls.Add(this.cmbEstadoCivil);
            this.panel5.Controls.Add(this.txtTelefono);
            this.panel5.Controls.Add(this.txtCp);
            this.panel5.Controls.Add(this.txtEstado);
            this.panel5.Controls.Add(this.txtNss);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.txtSexo);
            this.panel5.Controls.Add(this.txtFechaNac);
            this.panel5.Controls.Add(this.txtNombre);
            this.panel5.Location = new System.Drawing.Point(17, 134);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(883, 332);
            this.panel5.TabIndex = 61;
            // 
            // txtNumero
            // 
            this.txtNumero.AnimateReadOnly = false;
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumero.Depth = 0;
            this.txtNumero.Enabled = false;
            this.txtNumero.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumero.Hint = "N°:";
            this.txtNumero.LeadingIcon = null;
            this.txtNumero.Location = new System.Drawing.Point(491, 258);
            this.txtNumero.MaxLength = 18;
            this.txtNumero.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNumero.Multiline = false;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(95, 50);
            this.txtNumero.TabIndex = 111;
            this.txtNumero.Text = "";
            this.txtNumero.TrailingIcon = null;
            // 
            // txtCalle
            // 
            this.txtCalle.AnimateReadOnly = false;
            this.txtCalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCalle.Depth = 0;
            this.txtCalle.Enabled = false;
            this.txtCalle.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCalle.Hint = "Calle:";
            this.txtCalle.LeadingIcon = null;
            this.txtCalle.Location = new System.Drawing.Point(283, 258);
            this.txtCalle.MaxLength = 18;
            this.txtCalle.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCalle.Multiline = false;
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(185, 50);
            this.txtCalle.TabIndex = 110;
            this.txtCalle.Text = "";
            this.txtCalle.TrailingIcon = null;
            // 
            // txtColonia
            // 
            this.txtColonia.AnimateReadOnly = false;
            this.txtColonia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtColonia.Depth = 0;
            this.txtColonia.Enabled = false;
            this.txtColonia.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtColonia.Hint = "Colonia:";
            this.txtColonia.LeadingIcon = null;
            this.txtColonia.Location = new System.Drawing.Point(52, 258);
            this.txtColonia.MaxLength = 18;
            this.txtColonia.MouseState = MaterialSkin.MouseState.OUT;
            this.txtColonia.Multiline = false;
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(214, 50);
            this.txtColonia.TabIndex = 109;
            this.txtColonia.Text = "";
            this.txtColonia.TrailingIcon = null;
            // 
            // txtCiudad
            // 
            this.txtCiudad.AnimateReadOnly = false;
            this.txtCiudad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCiudad.Depth = 0;
            this.txtCiudad.Enabled = false;
            this.txtCiudad.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCiudad.Hint = "Ciudad:";
            this.txtCiudad.LeadingIcon = null;
            this.txtCiudad.Location = new System.Drawing.Point(491, 193);
            this.txtCiudad.MaxLength = 18;
            this.txtCiudad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCiudad.Multiline = false;
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(367, 50);
            this.txtCiudad.TabIndex = 108;
            this.txtCiudad.Text = "";
            this.txtCiudad.TrailingIcon = null;
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.AutoResize = false;
            this.cmbEstadoCivil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbEstadoCivil.Depth = 0;
            this.cmbEstadoCivil.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbEstadoCivil.DropDownHeight = 174;
            this.cmbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoCivil.DropDownWidth = 121;
            this.cmbEstadoCivil.Enabled = false;
            this.cmbEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbEstadoCivil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.Hint = "Estado Civil";
            this.cmbEstadoCivil.IntegralHeight = false;
            this.cmbEstadoCivil.ItemHeight = 43;
            this.cmbEstadoCivil.Items.AddRange(new object[] {
            "Soltero",
            "Casado",
            "Divorciado",
            "Viudo"});
            this.cmbEstadoCivil.Location = new System.Drawing.Point(576, 128);
            this.cmbEstadoCivil.MaxDropDownItems = 4;
            this.cmbEstadoCivil.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(282, 49);
            this.cmbEstadoCivil.StartIndex = 0;
            this.cmbEstadoCivil.TabIndex = 107;
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
            this.txtTelefono.Location = new System.Drawing.Point(605, 258);
            this.txtTelefono.MaxLength = 18;
            this.txtTelefono.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(253, 50);
            this.txtTelefono.TabIndex = 106;
            this.txtTelefono.Text = "";
            this.txtTelefono.TrailingIcon = null;
            // 
            // txtCp
            // 
            this.txtCp.AnimateReadOnly = false;
            this.txtCp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCp.Depth = 0;
            this.txtCp.Enabled = false;
            this.txtCp.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCp.Hint = "Código Postal:";
            this.txtCp.LeadingIcon = null;
            this.txtCp.Location = new System.Drawing.Point(52, 193);
            this.txtCp.MaxLength = 18;
            this.txtCp.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCp.Multiline = false;
            this.txtCp.Name = "txtCp";
            this.txtCp.Size = new System.Drawing.Size(214, 50);
            this.txtCp.TabIndex = 105;
            this.txtCp.Text = "";
            this.txtCp.TrailingIcon = null;
            // 
            // txtEstado
            // 
            this.txtEstado.AnimateReadOnly = false;
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEstado.Depth = 0;
            this.txtEstado.Enabled = false;
            this.txtEstado.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEstado.Hint = "Estado:";
            this.txtEstado.LeadingIcon = null;
            this.txtEstado.Location = new System.Drawing.Point(283, 193);
            this.txtEstado.MaxLength = 18;
            this.txtEstado.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEstado.Multiline = false;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(185, 50);
            this.txtEstado.TabIndex = 104;
            this.txtEstado.Text = "";
            this.txtEstado.TrailingIcon = null;
            // 
            // txtNss
            // 
            this.txtNss.AnimateReadOnly = false;
            this.txtNss.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNss.Depth = 0;
            this.txtNss.Enabled = false;
            this.txtNss.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNss.Hint = "Número de Seguro:";
            this.txtNss.LeadingIcon = null;
            this.txtNss.Location = new System.Drawing.Point(283, 127);
            this.txtNss.MaxLength = 18;
            this.txtNss.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNss.Multiline = false;
            this.txtNss.Name = "txtNss";
            this.txtNss.Size = new System.Drawing.Size(266, 50);
            this.txtNss.TabIndex = 103;
            this.txtNss.Text = "";
            this.txtNss.TrailingIcon = null;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(141)))));
            this.label4.Location = new System.Drawing.Point(47, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 29);
            this.label4.TabIndex = 96;
            this.label4.Text = "Datos Personales:";
            // 
            // txtSexo
            // 
            this.txtSexo.AnimateReadOnly = false;
            this.txtSexo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSexo.Depth = 0;
            this.txtSexo.Enabled = false;
            this.txtSexo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSexo.Hint = "Sexo:";
            this.txtSexo.LeadingIcon = null;
            this.txtSexo.Location = new System.Drawing.Point(52, 127);
            this.txtSexo.MaxLength = 18;
            this.txtSexo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSexo.Multiline = false;
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(214, 50);
            this.txtSexo.TabIndex = 101;
            this.txtSexo.Text = "";
            this.txtSexo.TrailingIcon = null;
            // 
            // txtFechaNac
            // 
            this.txtFechaNac.AnimateReadOnly = false;
            this.txtFechaNac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFechaNac.Depth = 0;
            this.txtFechaNac.Enabled = false;
            this.txtFechaNac.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFechaNac.Hint = "Fecha de Nacimiento:";
            this.txtFechaNac.LeadingIcon = null;
            this.txtFechaNac.Location = new System.Drawing.Point(576, 61);
            this.txtFechaNac.MaxLength = 18;
            this.txtFechaNac.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFechaNac.Multiline = false;
            this.txtFechaNac.Name = "txtFechaNac";
            this.txtFechaNac.Size = new System.Drawing.Size(282, 50);
            this.txtFechaNac.TabIndex = 97;
            this.txtFechaNac.Text = "";
            this.txtFechaNac.TrailingIcon = null;
            // 
            // txtNombre
            // 
            this.txtNombre.AnimateReadOnly = false;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Depth = 0;
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.Hint = "Nombre del Colaborador: ";
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(52, 61);
            this.txtNombre.MaxLength = 18;
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(497, 50);
            this.txtNombre.TabIndex = 96;
            this.txtNombre.Text = "";
            this.txtNombre.TrailingIcon = null;
            // 
            // pSeccionesDatos
            // 
            this.pSeccionesDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(141)))));
            this.pSeccionesDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSeccionesDatos.Location = new System.Drawing.Point(0, 100);
            this.pSeccionesDatos.Name = "pSeccionesDatos";
            this.pSeccionesDatos.Size = new System.Drawing.Size(945, 36);
            this.pSeccionesDatos.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(945, 100);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(141)))));
            this.label1.Location = new System.Drawing.Point(254, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(693, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Actualizar Informacion de Colaboradores";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(253, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btmCancelar
            // 
            this.btmCancelar.AutoSize = false;
            this.btmCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btmCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btmCancelar.Depth = 0;
            this.btmCancelar.Enabled = false;
            this.btmCancelar.HighEmphasis = true;
            this.btmCancelar.Icon = ((System.Drawing.Image)(resources.GetObject("btmCancelar.Icon")));
            this.btmCancelar.Location = new System.Drawing.Point(426, 664);
            this.btmCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btmCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btmCancelar.Name = "btmCancelar";
            this.btmCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btmCancelar.Size = new System.Drawing.Size(140, 50);
            this.btmCancelar.TabIndex = 106;
            this.btmCancelar.Text = "Cancelar";
            this.btmCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btmCancelar.UseAccentColor = true;
            this.btmCancelar.UseVisualStyleBackColor = true;
            this.btmCancelar.Click += new System.EventHandler(this.btmCancelar_Click);
            // 
            // frmActualizarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 666);
            this.Controls.Add(this.pContenedorAct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmActualizarEmpleado";
            this.pContenedorAct.ResumeLayout(false);
            this.pConsultaIndividual.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pContenedorAct;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pSeccionesDatos;
        private System.Windows.Forms.Panel pConsultaIndividual;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialTextBox txtNoNomina;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton2;
        private System.Windows.Forms.Panel panel5;
        private MaterialSkin.Controls.MaterialTextBox txtTelefono;
        private MaterialSkin.Controls.MaterialTextBox txtCp;
        private MaterialSkin.Controls.MaterialTextBox txtEstado;
        private MaterialSkin.Controls.MaterialTextBox txtNss;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialTextBox txtSexo;
        private MaterialSkin.Controls.MaterialTextBox txtFechaNac;
        private MaterialSkin.Controls.MaterialTextBox txtNombre;
        private MaterialSkin.Controls.MaterialTextBox txtColonia;
        private MaterialSkin.Controls.MaterialTextBox txtCiudad;
        private MaterialSkin.Controls.MaterialComboBox cmbEstadoCivil;
        private MaterialSkin.Controls.MaterialComboBox cmbPuesto;
        private MaterialSkin.Controls.MaterialTextBox txtNumero;
        private MaterialSkin.Controls.MaterialTextBox txtCalle;
        private MaterialSkin.Controls.MaterialComboBox cmbTurno;
        private MaterialSkin.Controls.MaterialButton btnActualizar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialButton btmCancelar;
    }
}