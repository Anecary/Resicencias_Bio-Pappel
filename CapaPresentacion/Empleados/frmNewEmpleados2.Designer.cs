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
            this.btmCancelar = new CapaPresentacion.BotonPersonalizado();
            this.btnGrabar = new CapaPresentacion.BotonPersonalizado();
            this.panel3 = new System.Windows.Forms.Panel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCheckbox2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.cmbSexo = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbEstadoCivil = new MaterialSkin.Controls.MaterialComboBox();
            this.pSeccionesDatos = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label66 = new System.Windows.Forms.Label();
            this.txtNombre = new CapaPresentacion.TextPersonalizado();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefono = new CapaPresentacion.TextPersonalizado();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRFC = new CapaPresentacion.TextPersonalizado();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNss = new CapaPresentacion.TextPersonalizado();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMunicipio = new CapaPresentacion.TextPersonalizado();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCalle = new CapaPresentacion.TextPersonalizado();
            this.label8 = new System.Windows.Forms.Label();
            this.txtColonia = new CapaPresentacion.TextPersonalizado();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNumero = new CapaPresentacion.TextPersonalizado();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCp = new CapaPresentacion.TextPersonalizado();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEstado = new CapaPresentacion.TextPersonalizado();
            this.label12 = new System.Windows.Forms.Label();
            this.txtApellidoP = new CapaPresentacion.TextPersonalizado();
            this.label13 = new System.Windows.Forms.Label();
            this.txtApellidoM = new CapaPresentacion.TextPersonalizado();
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
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
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
            this.pDatosPersonales.Controls.Add(this.btmCancelar);
            this.pDatosPersonales.Controls.Add(this.btnGrabar);
            this.pDatosPersonales.Controls.Add(this.panel3);
            this.pDatosPersonales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDatosPersonales.Location = new System.Drawing.Point(0, 145);
            this.pDatosPersonales.Name = "pDatosPersonales";
            this.pDatosPersonales.Size = new System.Drawing.Size(934, 487);
            this.pDatosPersonales.TabIndex = 35;
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
            this.btmCancelar.Location = new System.Drawing.Point(459, 428);
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
            this.btnGrabar.Location = new System.Drawing.Point(248, 428);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.txtApellidoM);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.txtApellidoP);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txtEstado);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtCp);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtNumero);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtColonia);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtCalle);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtMunicipio);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtNss);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtRFC);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtTelefono);
            this.panel3.Controls.Add(this.label66);
            this.panel3.Controls.Add(this.txtNombre);
            this.panel3.Controls.Add(this.materialLabel3);
            this.panel3.Controls.Add(this.materialCheckbox2);
            this.panel3.Controls.Add(this.dateTimePicker2);
            this.panel3.Controls.Add(this.cmbSexo);
            this.panel3.Controls.Add(this.cmbEstadoCivil);
            this.panel3.Location = new System.Drawing.Point(35, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(847, 410);
            this.panel3.TabIndex = 77;
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
            // pSeccionesDatos
            // 
            this.pSeccionesDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
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
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label66.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.label66.Location = new System.Drawing.Point(18, 14);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(84, 16);
            this.label66.TabIndex = 131;
            this.label66.Text = "Nombre(s):";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombre.BorderColor = System.Drawing.Color.Gray;
            this.txtNombre.BorderFocusColor = System.Drawing.Color.DarkCyan;
            this.txtNombre.BorderRadius = 12;
            this.txtNombre.BorderSize = 2;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.Location = new System.Drawing.Point(14, 30);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNombre.PasswordChar = false;
            this.txtNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNombre.PlaceholderText = "";
            this.txtNombre.Size = new System.Drawing.Size(383, 35);
            this.txtNombre.TabIndex = 130;
            this.txtNombre.UnderlinedStyle = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.label3.Location = new System.Drawing.Point(18, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 133;
            this.label3.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.SystemColors.Window;
            this.txtTelefono.BorderColor = System.Drawing.Color.Gray;
            this.txtTelefono.BorderFocusColor = System.Drawing.Color.DarkCyan;
            this.txtTelefono.BorderRadius = 12;
            this.txtTelefono.BorderSize = 2;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.DimGray;
            this.txtTelefono.Location = new System.Drawing.Point(14, 98);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTelefono.PasswordChar = false;
            this.txtTelefono.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTelefono.PlaceholderText = "";
            this.txtTelefono.Size = new System.Drawing.Size(383, 35);
            this.txtTelefono.TabIndex = 132;
            this.txtTelefono.UnderlinedStyle = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.label4.Location = new System.Drawing.Point(435, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 135;
            this.label4.Text = "RFC: ";
            // 
            // txtRFC
            // 
            this.txtRFC.BackColor = System.Drawing.SystemColors.Window;
            this.txtRFC.BorderColor = System.Drawing.Color.Gray;
            this.txtRFC.BorderFocusColor = System.Drawing.Color.DarkCyan;
            this.txtRFC.BorderRadius = 12;
            this.txtRFC.BorderSize = 2;
            this.txtRFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRFC.ForeColor = System.Drawing.Color.DimGray;
            this.txtRFC.Location = new System.Drawing.Point(433, 165);
            this.txtRFC.Margin = new System.Windows.Forms.Padding(4);
            this.txtRFC.Multiline = false;
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtRFC.PasswordChar = false;
            this.txtRFC.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtRFC.PlaceholderText = "";
            this.txtRFC.Size = new System.Drawing.Size(383, 35);
            this.txtRFC.TabIndex = 134;
            this.txtRFC.UnderlinedStyle = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.label5.Location = new System.Drawing.Point(435, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 16);
            this.label5.TabIndex = 137;
            this.label5.Text = "Número de Seguro: ";
            // 
            // txtNss
            // 
            this.txtNss.BackColor = System.Drawing.SystemColors.Window;
            this.txtNss.BorderColor = System.Drawing.Color.Gray;
            this.txtNss.BorderFocusColor = System.Drawing.Color.DarkCyan;
            this.txtNss.BorderRadius = 12;
            this.txtNss.BorderSize = 2;
            this.txtNss.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNss.ForeColor = System.Drawing.Color.DimGray;
            this.txtNss.Location = new System.Drawing.Point(433, 231);
            this.txtNss.Margin = new System.Windows.Forms.Padding(4);
            this.txtNss.Multiline = false;
            this.txtNss.Name = "txtNss";
            this.txtNss.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNss.PasswordChar = false;
            this.txtNss.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNss.PlaceholderText = "";
            this.txtNss.Size = new System.Drawing.Size(383, 35);
            this.txtNss.TabIndex = 136;
            this.txtNss.UnderlinedStyle = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.label6.Location = new System.Drawing.Point(435, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 16);
            this.label6.TabIndex = 139;
            this.label6.Text = "Municipio/Alcaldia: ";
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.BackColor = System.Drawing.SystemColors.Window;
            this.txtMunicipio.BorderColor = System.Drawing.Color.Gray;
            this.txtMunicipio.BorderFocusColor = System.Drawing.Color.DarkCyan;
            this.txtMunicipio.BorderRadius = 12;
            this.txtMunicipio.BorderSize = 2;
            this.txtMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMunicipio.ForeColor = System.Drawing.Color.DimGray;
            this.txtMunicipio.Location = new System.Drawing.Point(431, 298);
            this.txtMunicipio.Margin = new System.Windows.Forms.Padding(4);
            this.txtMunicipio.Multiline = false;
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMunicipio.PasswordChar = false;
            this.txtMunicipio.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMunicipio.PlaceholderText = "";
            this.txtMunicipio.Size = new System.Drawing.Size(383, 35);
            this.txtMunicipio.TabIndex = 138;
            this.txtMunicipio.UnderlinedStyle = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.label7.Location = new System.Drawing.Point(437, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 141;
            this.label7.Text = "Calle: ";
            // 
            // txtCalle
            // 
            this.txtCalle.BackColor = System.Drawing.SystemColors.Window;
            this.txtCalle.BorderColor = System.Drawing.Color.Gray;
            this.txtCalle.BorderFocusColor = System.Drawing.Color.DarkCyan;
            this.txtCalle.BorderRadius = 12;
            this.txtCalle.BorderSize = 2;
            this.txtCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalle.ForeColor = System.Drawing.Color.DimGray;
            this.txtCalle.Location = new System.Drawing.Point(433, 364);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(4);
            this.txtCalle.Multiline = false;
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCalle.PasswordChar = false;
            this.txtCalle.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCalle.PlaceholderText = "";
            this.txtCalle.Size = new System.Drawing.Size(383, 35);
            this.txtCalle.TabIndex = 140;
            this.txtCalle.UnderlinedStyle = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.label8.Location = new System.Drawing.Point(18, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 143;
            this.label8.Text = "Colonia:";
            // 
            // txtColonia
            // 
            this.txtColonia.BackColor = System.Drawing.SystemColors.Window;
            this.txtColonia.BorderColor = System.Drawing.Color.Gray;
            this.txtColonia.BorderFocusColor = System.Drawing.Color.DarkCyan;
            this.txtColonia.BorderRadius = 12;
            this.txtColonia.BorderSize = 2;
            this.txtColonia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColonia.ForeColor = System.Drawing.Color.DimGray;
            this.txtColonia.Location = new System.Drawing.Point(14, 298);
            this.txtColonia.Margin = new System.Windows.Forms.Padding(4);
            this.txtColonia.Multiline = false;
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtColonia.PasswordChar = false;
            this.txtColonia.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtColonia.PlaceholderText = "";
            this.txtColonia.Size = new System.Drawing.Size(383, 35);
            this.txtColonia.TabIndex = 142;
            this.txtColonia.UnderlinedStyle = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.label9.Location = new System.Drawing.Point(18, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 145;
            this.label9.Text = "Número: ";
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumero.BorderColor = System.Drawing.Color.Gray;
            this.txtNumero.BorderFocusColor = System.Drawing.Color.DarkCyan;
            this.txtNumero.BorderRadius = 12;
            this.txtNumero.BorderSize = 2;
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.ForeColor = System.Drawing.Color.DimGray;
            this.txtNumero.Location = new System.Drawing.Point(14, 364);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero.Multiline = false;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNumero.PasswordChar = false;
            this.txtNumero.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNumero.PlaceholderText = "";
            this.txtNumero.Size = new System.Drawing.Size(204, 35);
            this.txtNumero.TabIndex = 144;
            this.txtNumero.UnderlinedStyle = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.label10.Location = new System.Drawing.Point(18, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 16);
            this.label10.TabIndex = 147;
            this.label10.Text = "Código Postal:";
            // 
            // txtCp
            // 
            this.txtCp.BackColor = System.Drawing.SystemColors.Window;
            this.txtCp.BorderColor = System.Drawing.Color.Gray;
            this.txtCp.BorderFocusColor = System.Drawing.Color.DarkCyan;
            this.txtCp.BorderRadius = 12;
            this.txtCp.BorderSize = 2;
            this.txtCp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCp.ForeColor = System.Drawing.Color.DimGray;
            this.txtCp.Location = new System.Drawing.Point(14, 230);
            this.txtCp.Margin = new System.Windows.Forms.Padding(4);
            this.txtCp.Multiline = false;
            this.txtCp.Name = "txtCp";
            this.txtCp.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCp.PasswordChar = false;
            this.txtCp.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCp.PlaceholderText = "";
            this.txtCp.Size = new System.Drawing.Size(163, 35);
            this.txtCp.TabIndex = 146;
            this.txtCp.UnderlinedStyle = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.label11.Location = new System.Drawing.Point(220, 214);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 16);
            this.label11.TabIndex = 149;
            this.label11.Text = "Estado:";
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.SystemColors.Window;
            this.txtEstado.BorderColor = System.Drawing.Color.Gray;
            this.txtEstado.BorderFocusColor = System.Drawing.Color.DarkCyan;
            this.txtEstado.BorderRadius = 12;
            this.txtEstado.BorderSize = 2;
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.ForeColor = System.Drawing.Color.DimGray;
            this.txtEstado.Location = new System.Drawing.Point(216, 230);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstado.Multiline = false;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEstado.PasswordChar = false;
            this.txtEstado.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEstado.PlaceholderText = "";
            this.txtEstado.Size = new System.Drawing.Size(181, 35);
            this.txtEstado.TabIndex = 148;
            this.txtEstado.UnderlinedStyle = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.label12.Location = new System.Drawing.Point(437, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 16);
            this.label12.TabIndex = 151;
            this.label12.Text = "Apellido Paterno:";
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.BackColor = System.Drawing.SystemColors.Window;
            this.txtApellidoP.BorderColor = System.Drawing.Color.Gray;
            this.txtApellidoP.BorderFocusColor = System.Drawing.Color.DarkCyan;
            this.txtApellidoP.BorderRadius = 12;
            this.txtApellidoP.BorderSize = 2;
            this.txtApellidoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoP.ForeColor = System.Drawing.Color.DimGray;
            this.txtApellidoP.Location = new System.Drawing.Point(433, 30);
            this.txtApellidoP.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoP.Multiline = false;
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtApellidoP.PasswordChar = false;
            this.txtApellidoP.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtApellidoP.PlaceholderText = "";
            this.txtApellidoP.Size = new System.Drawing.Size(175, 35);
            this.txtApellidoP.TabIndex = 150;
            this.txtApellidoP.UnderlinedStyle = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.label13.Location = new System.Drawing.Point(641, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 16);
            this.label13.TabIndex = 153;
            this.label13.Text = "Apellido Materno:";
            // 
            // txtApellidoM
            // 
            this.txtApellidoM.BackColor = System.Drawing.SystemColors.Window;
            this.txtApellidoM.BorderColor = System.Drawing.Color.Gray;
            this.txtApellidoM.BorderFocusColor = System.Drawing.Color.DarkCyan;
            this.txtApellidoM.BorderRadius = 12;
            this.txtApellidoM.BorderSize = 2;
            this.txtApellidoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoM.ForeColor = System.Drawing.Color.DimGray;
            this.txtApellidoM.Location = new System.Drawing.Point(637, 30);
            this.txtApellidoM.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoM.Multiline = false;
            this.txtApellidoM.Name = "txtApellidoM";
            this.txtApellidoM.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtApellidoM.PasswordChar = false;
            this.txtApellidoM.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtApellidoM.PlaceholderText = "";
            this.txtApellidoM.Size = new System.Drawing.Size(179, 35);
            this.txtApellidoM.TabIndex = 152;
            this.txtApellidoM.UnderlinedStyle = true;
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
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox2;
        private MaterialSkin.Controls.MaterialComboBox cmbEstadoCivil;
        private MaterialSkin.Controls.MaterialComboBox cmbSexo;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private BotonPersonalizado btmCancelar;
        private BotonPersonalizado btnGrabar;
        private System.Windows.Forms.Label label6;
        private TextPersonalizado txtMunicipio;
        private System.Windows.Forms.Label label5;
        private TextPersonalizado txtNss;
        private System.Windows.Forms.Label label4;
        private TextPersonalizado txtRFC;
        private System.Windows.Forms.Label label3;
        private TextPersonalizado txtTelefono;
        private System.Windows.Forms.Label label66;
        private TextPersonalizado txtNombre;
        private System.Windows.Forms.Label label13;
        private TextPersonalizado txtApellidoM;
        private System.Windows.Forms.Label label12;
        private TextPersonalizado txtApellidoP;
        private System.Windows.Forms.Label label11;
        private TextPersonalizado txtEstado;
        private System.Windows.Forms.Label label10;
        private TextPersonalizado txtCp;
        private System.Windows.Forms.Label label9;
        private TextPersonalizado txtNumero;
        private System.Windows.Forms.Label label8;
        private TextPersonalizado txtColonia;
        private System.Windows.Forms.Label label7;
        private TextPersonalizado txtCalle;
    }
}