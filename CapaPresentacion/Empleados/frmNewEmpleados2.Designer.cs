namespace CapaPresentacion.Empleados
{
    partial class frmNewEmpleados2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewEmpleados2));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pDatosPersonales = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtRFC = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            this.txtApellidoM = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtApellidoP = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNss = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTelefono = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCheckbox2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txtNumero = new MaterialSkin.Controls.MaterialTextBox();
            this.cmbSexo = new MaterialSkin.Controls.MaterialComboBox();
            this.txtCalle = new MaterialSkin.Controls.MaterialTextBox();
            this.cmbEstadoCivil = new MaterialSkin.Controls.MaterialComboBox();
            this.txtColonia = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCp = new MaterialSkin.Controls.MaterialTextBox();
            this.txtMunicipio = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEstado = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.btnGrabar = new MaterialSkin.Controls.MaterialButton();
            this.pSeccionesDatos = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.pDatosPersonales.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pSeccionesDatos.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(141)))));
            this.label1.Location = new System.Drawing.Point(276, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(603, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Nuevos Colaboradores";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pDatosPersonales);
            this.panel1.Controls.Add(this.pSeccionesDatos);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 632);
            this.panel1.TabIndex = 4;
            // 
            // pDatosPersonales
            // 
            this.pDatosPersonales.Controls.Add(this.panel3);
            this.pDatosPersonales.Controls.Add(this.materialButton1);
            this.pDatosPersonales.Controls.Add(this.btnGrabar);
            this.pDatosPersonales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDatosPersonales.Location = new System.Drawing.Point(0, 145);
            this.pDatosPersonales.Name = "pDatosPersonales";
            this.pDatosPersonales.Size = new System.Drawing.Size(934, 487);
            this.pDatosPersonales.TabIndex = 35;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.txtRFC);
            this.panel3.Controls.Add(this.txtNombre);
            this.panel3.Controls.Add(this.txtApellidoM);
            this.panel3.Controls.Add(this.materialLabel3);
            this.panel3.Controls.Add(this.txtApellidoP);
            this.panel3.Controls.Add(this.txtNss);
            this.panel3.Controls.Add(this.txtTelefono);
            this.panel3.Controls.Add(this.materialCheckbox2);
            this.panel3.Controls.Add(this.dateTimePicker2);
            this.panel3.Controls.Add(this.txtNumero);
            this.panel3.Controls.Add(this.cmbSexo);
            this.panel3.Controls.Add(this.txtCalle);
            this.panel3.Controls.Add(this.cmbEstadoCivil);
            this.panel3.Controls.Add(this.txtColonia);
            this.panel3.Controls.Add(this.txtCp);
            this.panel3.Controls.Add(this.txtMunicipio);
            this.panel3.Controls.Add(this.txtEstado);
            this.panel3.Location = new System.Drawing.Point(35, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(847, 410);
            this.panel3.TabIndex = 77;
            // 
            // txtRFC
            // 
            this.txtRFC.AnimateReadOnly = false;
            this.txtRFC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRFC.Depth = 0;
            this.txtRFC.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRFC.Hint = "RFC: ";
            this.txtRFC.LeadingIcon = null;
            this.txtRFC.Location = new System.Drawing.Point(433, 150);
            this.txtRFC.MaxLength = 18;
            this.txtRFC.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRFC.Multiline = false;
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(380, 50);
            this.txtRFC.TabIndex = 75;
            this.txtRFC.Text = "";
            this.txtRFC.TrailingIcon = null;
            // 
            // txtNombre
            // 
            this.txtNombre.AnimateReadOnly = false;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.Hint = "Nombre(s)";
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(14, 15);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(383, 50);
            this.txtNombre.TabIndex = 58;
            this.txtNombre.Text = "";
            this.txtNombre.TrailingIcon = null;
            // 
            // txtApellidoM
            // 
            this.txtApellidoM.AnimateReadOnly = false;
            this.txtApellidoM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidoM.Depth = 0;
            this.txtApellidoM.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtApellidoM.Hint = "Apellido Materno:";
            this.txtApellidoM.LeadingIcon = null;
            this.txtApellidoM.Location = new System.Drawing.Point(644, 15);
            this.txtApellidoM.MaxLength = 30;
            this.txtApellidoM.MouseState = MaterialSkin.MouseState.OUT;
            this.txtApellidoM.Multiline = false;
            this.txtApellidoM.Name = "txtApellidoM";
            this.txtApellidoM.Size = new System.Drawing.Size(182, 50);
            this.txtApellidoM.TabIndex = 62;
            this.txtApellidoM.Text = "";
            this.txtApellidoM.TrailingIcon = null;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.ForeColor = System.Drawing.Color.Green;
            this.materialLabel3.Location = new System.Drawing.Point(435, 98);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(150, 19);
            this.materialLabel3.TabIndex = 74;
            this.materialLabel3.Text = "Fecha de Nacimiento";
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.AnimateReadOnly = false;
            this.txtApellidoP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidoP.Depth = 0;
            this.txtApellidoP.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtApellidoP.Hint = "Apellido Paterno:";
            this.txtApellidoP.LeadingIcon = null;
            this.txtApellidoP.Location = new System.Drawing.Point(433, 15);
            this.txtApellidoP.MaxLength = 30;
            this.txtApellidoP.MouseState = MaterialSkin.MouseState.OUT;
            this.txtApellidoP.Multiline = false;
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Size = new System.Drawing.Size(175, 50);
            this.txtApellidoP.TabIndex = 61;
            this.txtApellidoP.Text = "";
            this.txtApellidoP.TrailingIcon = null;
            // 
            // txtNss
            // 
            this.txtNss.AnimateReadOnly = false;
            this.txtNss.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNss.Depth = 0;
            this.txtNss.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNss.Hint = "NSS: ";
            this.txtNss.LeadingIcon = null;
            this.txtNss.Location = new System.Drawing.Point(433, 215);
            this.txtNss.MaxLength = 18;
            this.txtNss.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNss.Multiline = false;
            this.txtNss.Name = "txtNss";
            this.txtNss.Size = new System.Drawing.Size(380, 50);
            this.txtNss.TabIndex = 73;
            this.txtNss.Text = "";
            this.txtNss.TrailingIcon = null;
            // 
            // txtTelefono
            // 
            this.txtTelefono.AnimateReadOnly = false;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Depth = 0;
            this.txtTelefono.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelefono.Hint = "Teléfono:";
            this.txtTelefono.LeadingIcon = null;
            this.txtTelefono.Location = new System.Drawing.Point(14, 82);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(383, 50);
            this.txtTelefono.TabIndex = 59;
            this.txtTelefono.Text = "";
            this.txtTelefono.TrailingIcon = null;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // materialCheckbox2
            // 
            this.materialCheckbox2.AutoSize = true;
            this.materialCheckbox2.Depth = 0;
            this.materialCheckbox2.Location = new System.Drawing.Point(216, 356);
            this.materialCheckbox2.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox2.Name = "materialCheckbox2";
            this.materialCheckbox2.ReadOnly = false;
            this.materialCheckbox2.Ripple = true;
            this.materialCheckbox2.Size = new System.Drawing.Size(118, 37);
            this.materialCheckbox2.TabIndex = 72;
            this.materialCheckbox2.Text = "Sin Número";
            this.materialCheckbox2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(589, 97);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(193, 20);
            this.dateTimePicker2.TabIndex = 63;
            // 
            // txtNumero
            // 
            this.txtNumero.AnimateReadOnly = false;
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumero.Depth = 0;
            this.txtNumero.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumero.Hint = "Número: ";
            this.txtNumero.LeadingIcon = null;
            this.txtNumero.Location = new System.Drawing.Point(14, 349);
            this.txtNumero.MaxLength = 8;
            this.txtNumero.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNumero.Multiline = false;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(163, 50);
            this.txtNumero.TabIndex = 71;
            this.txtNumero.Text = "";
            this.txtNumero.TrailingIcon = null;
            // 
            // cmbSexo
            // 
            this.cmbSexo.AutoResize = false;
            this.cmbSexo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbSexo.Depth = 0;
            this.cmbSexo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbSexo.DropDownHeight = 174;
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.DropDownWidth = 121;
            this.cmbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbSexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Hint = "Sexo";
            this.cmbSexo.IntegralHeight = false;
            this.cmbSexo.ItemHeight = 43;
            this.cmbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbSexo.Location = new System.Drawing.Point(14, 149);
            this.cmbSexo.MaxDropDownItems = 4;
            this.cmbSexo.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(163, 49);
            this.cmbSexo.StartIndex = 0;
            this.cmbSexo.TabIndex = 64;
            // 
            // txtCalle
            // 
            this.txtCalle.AnimateReadOnly = false;
            this.txtCalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCalle.Depth = 0;
            this.txtCalle.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCalle.Hint = "Calle: ";
            this.txtCalle.LeadingIcon = null;
            this.txtCalle.Location = new System.Drawing.Point(433, 349);
            this.txtCalle.MaxLength = 18;
            this.txtCalle.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCalle.Multiline = false;
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(380, 50);
            this.txtCalle.TabIndex = 70;
            this.txtCalle.Text = "";
            this.txtCalle.TrailingIcon = null;
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
            this.cmbEstadoCivil.Location = new System.Drawing.Point(215, 149);
            this.cmbEstadoCivil.MaxDropDownItems = 4;
            this.cmbEstadoCivil.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(182, 49);
            this.cmbEstadoCivil.StartIndex = 0;
            this.cmbEstadoCivil.TabIndex = 65;
            // 
            // txtColonia
            // 
            this.txtColonia.AnimateReadOnly = false;
            this.txtColonia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtColonia.Depth = 0;
            this.txtColonia.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtColonia.Hint = "Colonia:";
            this.txtColonia.LeadingIcon = null;
            this.txtColonia.Location = new System.Drawing.Point(14, 282);
            this.txtColonia.MaxLength = 18;
            this.txtColonia.MouseState = MaterialSkin.MouseState.OUT;
            this.txtColonia.Multiline = false;
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(380, 50);
            this.txtColonia.TabIndex = 69;
            this.txtColonia.Text = "";
            this.txtColonia.TrailingIcon = null;
            // 
            // txtCp
            // 
            this.txtCp.AnimateReadOnly = false;
            this.txtCp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCp.Depth = 0;
            this.txtCp.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCp.Hint = "Código Postal:";
            this.txtCp.LeadingIcon = null;
            this.txtCp.Location = new System.Drawing.Point(14, 215);
            this.txtCp.MaxLength = 5;
            this.txtCp.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCp.Multiline = false;
            this.txtCp.Name = "txtCp";
            this.txtCp.Size = new System.Drawing.Size(163, 50);
            this.txtCp.TabIndex = 66;
            this.txtCp.Text = "";
            this.txtCp.TrailingIcon = null;
            this.txtCp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCp_KeyPress);
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.AnimateReadOnly = false;
            this.txtMunicipio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMunicipio.Depth = 0;
            this.txtMunicipio.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMunicipio.Hint = "Municipio/Alcaldia: ";
            this.txtMunicipio.LeadingIcon = null;
            this.txtMunicipio.Location = new System.Drawing.Point(433, 282);
            this.txtMunicipio.MaxLength = 18;
            this.txtMunicipio.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMunicipio.Multiline = false;
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(380, 50);
            this.txtMunicipio.TabIndex = 68;
            this.txtMunicipio.Text = "";
            this.txtMunicipio.TrailingIcon = null;
            // 
            // txtEstado
            // 
            this.txtEstado.AnimateReadOnly = false;
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEstado.Depth = 0;
            this.txtEstado.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEstado.Hint = "Estado:";
            this.txtEstado.LeadingIcon = null;
            this.txtEstado.Location = new System.Drawing.Point(216, 215);
            this.txtEstado.MaxLength = 18;
            this.txtEstado.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEstado.Multiline = false;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(181, 50);
            this.txtEstado.TabIndex = 67;
            this.txtEstado.Text = "";
            this.txtEstado.TrailingIcon = null;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = ((System.Drawing.Image)(resources.GetObject("materialButton1.Icon")));
            this.materialButton1.Location = new System.Drawing.Point(465, 431);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(122, 50);
            this.materialButton1.TabIndex = 76;
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
            this.btnGrabar.Location = new System.Drawing.Point(312, 431);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGrabar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGrabar.Size = new System.Drawing.Size(124, 50);
            this.btnGrabar.TabIndex = 75;
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
            this.pSeccionesDatos.Location = new System.Drawing.Point(0, 100);
            this.pSeccionesDatos.Name = "pSeccionesDatos";
            this.pSeccionesDatos.Size = new System.Drawing.Size(934, 45);
            this.pSeccionesDatos.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Datos Personales:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(934, 100);
            this.panel2.TabIndex = 4;
            // 
            // frmNewEmpleados2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 632);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNewEmpleados2";
            this.Load += new System.EventHandler(this.frmNewEmpleados2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pDatosPersonales.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pSeccionesDatos.ResumeLayout(false);
            this.pSeccionesDatos.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pSeccionesDatos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pDatosPersonales;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox txtNss;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox2;
        private MaterialSkin.Controls.MaterialTextBox txtNumero;
        private MaterialSkin.Controls.MaterialTextBox txtCalle;
        private MaterialSkin.Controls.MaterialTextBox txtColonia;
        private MaterialSkin.Controls.MaterialTextBox txtMunicipio;
        private MaterialSkin.Controls.MaterialTextBox txtEstado;
        private MaterialSkin.Controls.MaterialTextBox txtCp;
        private MaterialSkin.Controls.MaterialComboBox cmbEstadoCivil;
        private MaterialSkin.Controls.MaterialComboBox cmbSexo;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private MaterialSkin.Controls.MaterialTextBox txtNombre;
        private MaterialSkin.Controls.MaterialTextBox txtTelefono;
        private MaterialSkin.Controls.MaterialTextBox txtApellidoP;
        private MaterialSkin.Controls.MaterialTextBox txtApellidoM;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton btnGrabar;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialTextBox txtRFC;
    }
}