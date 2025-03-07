namespace CapaPresentacion.Empleados
{
    partial class frmConsultarEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarEmpleados));
            this.panel1 = new System.Windows.Forms.Panel();
            this.paContenedor = new System.Windows.Forms.Panel();
            this.pConsultaIndividual = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtFechaIngreso = new MaterialSkin.Controls.MaterialTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAntiguedad = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPuesto = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTurno = new MaterialSkin.Controls.MaterialTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNoNomina = new MaterialSkin.Controls.MaterialTextBox();
            this.materialFloatingActionButton2 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtTelefono = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCp = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDomicilio = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNss = new MaterialSkin.Controls.MaterialTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEstadoCivil = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSexo = new MaterialSkin.Controls.MaterialTextBox();
            this.txtFechaNac = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            this.pConsultaGeneral = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pSeccionesDatos = new System.Windows.Forms.Panel();
            this.btnConsultaIndividual = new System.Windows.Forms.Button();
            this.btnConsultaGral = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rbtTodos = new System.Windows.Forms.RadioButton();
            this.rbtInactivos = new System.Windows.Forms.RadioButton();
            this.rbtActivos = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.paContenedor.SuspendLayout();
            this.pConsultaIndividual.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pConsultaGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pSeccionesDatos.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.paContenedor);
            this.panel1.Controls.Add(this.pSeccionesDatos);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 715);
            this.panel1.TabIndex = 0;
            // 
            // paContenedor
            // 
            this.paContenedor.Controls.Add(this.pConsultaGeneral);
            this.paContenedor.Controls.Add(this.pConsultaIndividual);
            this.paContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paContenedor.Location = new System.Drawing.Point(0, 145);
            this.paContenedor.Name = "paContenedor";
            this.paContenedor.Size = new System.Drawing.Size(929, 570);
            this.paContenedor.TabIndex = 10;
            // 
            // pConsultaIndividual
            // 
            this.pConsultaIndividual.AutoScroll = true;
            this.pConsultaIndividual.Controls.Add(this.label6);
            this.pConsultaIndividual.Controls.Add(this.panel4);
            this.pConsultaIndividual.Controls.Add(this.panel3);
            this.pConsultaIndividual.Controls.Add(this.panel5);
            this.pConsultaIndividual.Location = new System.Drawing.Point(0, 0);
            this.pConsultaIndividual.Name = "pConsultaIndividual";
            this.pConsultaIndividual.Size = new System.Drawing.Size(926, 570);
            this.pConsultaIndividual.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(141)))));
            this.label6.Location = new System.Drawing.Point(-43, 713);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 29);
            this.label6.TabIndex = 101;
            this.label6.Text = "Datos Laborales:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.txtFechaIngreso);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txtAntiguedad);
            this.panel4.Controls.Add(this.txtPuesto);
            this.panel4.Controls.Add(this.txtTurno);
            this.panel4.Location = new System.Drawing.Point(17, 490);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(883, 201);
            this.panel4.TabIndex = 104;
            // 
            // txtFechaIngreso
            // 
            this.txtFechaIngreso.AnimateReadOnly = false;
            this.txtFechaIngreso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFechaIngreso.Depth = 0;
            this.txtFechaIngreso.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFechaIngreso.Hint = "Fecha de ingreso:";
            this.txtFechaIngreso.LeadingIcon = null;
            this.txtFechaIngreso.Location = new System.Drawing.Point(369, 130);
            this.txtFechaIngreso.MaxLength = 18;
            this.txtFechaIngreso.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFechaIngreso.Multiline = false;
            this.txtFechaIngreso.Name = "txtFechaIngreso";
            this.txtFechaIngreso.Size = new System.Drawing.Size(489, 50);
            this.txtFechaIngreso.TabIndex = 101;
            this.txtFechaIngreso.Text = "";
            this.txtFechaIngreso.TrailingIcon = null;
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
            // txtAntiguedad
            // 
            this.txtAntiguedad.AnimateReadOnly = false;
            this.txtAntiguedad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAntiguedad.Depth = 0;
            this.txtAntiguedad.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAntiguedad.Hint = "Antigüedad:";
            this.txtAntiguedad.LeadingIcon = null;
            this.txtAntiguedad.Location = new System.Drawing.Point(52, 131);
            this.txtAntiguedad.MaxLength = 18;
            this.txtAntiguedad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAntiguedad.Multiline = false;
            this.txtAntiguedad.Name = "txtAntiguedad";
            this.txtAntiguedad.Size = new System.Drawing.Size(282, 50);
            this.txtAntiguedad.TabIndex = 100;
            this.txtAntiguedad.Text = "";
            this.txtAntiguedad.TrailingIcon = null;
            // 
            // txtPuesto
            // 
            this.txtPuesto.AnimateReadOnly = false;
            this.txtPuesto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPuesto.Depth = 0;
            this.txtPuesto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPuesto.Hint = "Puesto Actual:";
            this.txtPuesto.LeadingIcon = null;
            this.txtPuesto.Location = new System.Drawing.Point(369, 59);
            this.txtPuesto.MaxLength = 18;
            this.txtPuesto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPuesto.Multiline = false;
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(489, 50);
            this.txtPuesto.TabIndex = 99;
            this.txtPuesto.Text = "";
            this.txtPuesto.TrailingIcon = null;
            // 
            // txtTurno
            // 
            this.txtTurno.AnimateReadOnly = false;
            this.txtTurno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTurno.Depth = 0;
            this.txtTurno.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTurno.Hint = "Turno:";
            this.txtTurno.LeadingIcon = null;
            this.txtTurno.Location = new System.Drawing.Point(52, 59);
            this.txtTurno.MaxLength = 18;
            this.txtTurno.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTurno.Multiline = false;
            this.txtTurno.Name = "txtTurno";
            this.txtTurno.Size = new System.Drawing.Size(282, 50);
            this.txtTurno.TabIndex = 98;
            this.txtTurno.Text = "";
            this.txtTurno.TrailingIcon = null;
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
            this.label3.Size = new System.Drawing.Size(275, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Colaborador a Consultar";
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
            this.panel5.Controls.Add(this.txtTelefono);
            this.panel5.Controls.Add(this.txtCp);
            this.panel5.Controls.Add(this.txtDomicilio);
            this.panel5.Controls.Add(this.txtNss);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.txtEstadoCivil);
            this.panel5.Controls.Add(this.txtSexo);
            this.panel5.Controls.Add(this.txtFechaNac);
            this.panel5.Controls.Add(this.txtNombre);
            this.panel5.Location = new System.Drawing.Point(17, 134);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(883, 332);
            this.panel5.TabIndex = 61;
            // 
            // txtTelefono
            // 
            this.txtTelefono.AnimateReadOnly = false;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Depth = 0;
            this.txtTelefono.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelefono.Hint = "Teléfono:";
            this.txtTelefono.LeadingIcon = null;
            this.txtTelefono.Location = new System.Drawing.Point(283, 267);
            this.txtTelefono.MaxLength = 18;
            this.txtTelefono.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(266, 50);
            this.txtTelefono.TabIndex = 106;
            this.txtTelefono.Text = "";
            this.txtTelefono.TrailingIcon = null;
            // 
            // txtCp
            // 
            this.txtCp.AnimateReadOnly = false;
            this.txtCp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCp.Depth = 0;
            this.txtCp.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCp.Hint = "Código Postal:";
            this.txtCp.LeadingIcon = null;
            this.txtCp.Location = new System.Drawing.Point(52, 267);
            this.txtCp.MaxLength = 18;
            this.txtCp.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCp.Multiline = false;
            this.txtCp.Name = "txtCp";
            this.txtCp.Size = new System.Drawing.Size(214, 50);
            this.txtCp.TabIndex = 105;
            this.txtCp.Text = "";
            this.txtCp.TrailingIcon = null;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.AnimateReadOnly = false;
            this.txtDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDomicilio.Depth = 0;
            this.txtDomicilio.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDomicilio.Hint = "Domicilio:";
            this.txtDomicilio.LeadingIcon = null;
            this.txtDomicilio.Location = new System.Drawing.Point(52, 200);
            this.txtDomicilio.MaxLength = 18;
            this.txtDomicilio.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDomicilio.Multiline = false;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(806, 50);
            this.txtDomicilio.TabIndex = 104;
            this.txtDomicilio.Text = "";
            this.txtDomicilio.TrailingIcon = null;
            // 
            // txtNss
            // 
            this.txtNss.AnimateReadOnly = false;
            this.txtNss.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNss.Depth = 0;
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
            // txtEstadoCivil
            // 
            this.txtEstadoCivil.AnimateReadOnly = false;
            this.txtEstadoCivil.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEstadoCivil.Depth = 0;
            this.txtEstadoCivil.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEstadoCivil.Hint = "Estado Civil:";
            this.txtEstadoCivil.LeadingIcon = null;
            this.txtEstadoCivil.Location = new System.Drawing.Point(576, 127);
            this.txtEstadoCivil.MaxLength = 18;
            this.txtEstadoCivil.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEstadoCivil.Multiline = false;
            this.txtEstadoCivil.Name = "txtEstadoCivil";
            this.txtEstadoCivil.Size = new System.Drawing.Size(282, 50);
            this.txtEstadoCivil.TabIndex = 102;
            this.txtEstadoCivil.Text = "";
            this.txtEstadoCivil.TrailingIcon = null;
            // 
            // txtSexo
            // 
            this.txtSexo.AnimateReadOnly = false;
            this.txtSexo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSexo.Depth = 0;
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
            // pConsultaGeneral
            // 
            this.pConsultaGeneral.Controls.Add(this.rbtActivos);
            this.pConsultaGeneral.Controls.Add(this.rbtInactivos);
            this.pConsultaGeneral.Controls.Add(this.rbtTodos);
            this.pConsultaGeneral.Controls.Add(this.label2);
            this.pConsultaGeneral.Controls.Add(this.dataGridView1);
            this.pConsultaGeneral.Location = new System.Drawing.Point(0, 0);
            this.pConsultaGeneral.Name = "pConsultaGeneral";
            this.pConsultaGeneral.Size = new System.Drawing.Size(929, 570);
            this.pConsultaGeneral.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(141)))));
            this.label2.Location = new System.Drawing.Point(21, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(370, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Todos los Colaboradores Activos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(855, 353);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pSeccionesDatos
            // 
            this.pSeccionesDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(141)))));
            this.pSeccionesDatos.Controls.Add(this.btnConsultaIndividual);
            this.pSeccionesDatos.Controls.Add(this.btnConsultaGral);
            this.pSeccionesDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSeccionesDatos.Location = new System.Drawing.Point(0, 100);
            this.pSeccionesDatos.Name = "pSeccionesDatos";
            this.pSeccionesDatos.Size = new System.Drawing.Size(929, 45);
            this.pSeccionesDatos.TabIndex = 9;
            // 
            // btnConsultaIndividual
            // 
            this.btnConsultaIndividual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultaIndividual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultaIndividual.FlatAppearance.BorderSize = 0;
            this.btnConsultaIndividual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaIndividual.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaIndividual.ForeColor = System.Drawing.Color.White;
            this.btnConsultaIndividual.Location = new System.Drawing.Point(461, 0);
            this.btnConsultaIndividual.Name = "btnConsultaIndividual";
            this.btnConsultaIndividual.Size = new System.Drawing.Size(180, 40);
            this.btnConsultaIndividual.TabIndex = 4;
            this.btnConsultaIndividual.Text = "Consulta Individual";
            this.btnConsultaIndividual.UseVisualStyleBackColor = true;
            this.btnConsultaIndividual.Click += new System.EventHandler(this.btnConsultaIndividual_Click);
            this.btnConsultaIndividual.Enter += new System.EventHandler(this.btnMouseEnter);
            this.btnConsultaIndividual.Leave += new System.EventHandler(this.btnMouseLeave);
            // 
            // btnConsultaGral
            // 
            this.btnConsultaGral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultaGral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultaGral.FlatAppearance.BorderSize = 0;
            this.btnConsultaGral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaGral.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaGral.ForeColor = System.Drawing.Color.White;
            this.btnConsultaGral.Location = new System.Drawing.Point(279, 0);
            this.btnConsultaGral.Name = "btnConsultaGral";
            this.btnConsultaGral.Size = new System.Drawing.Size(180, 40);
            this.btnConsultaGral.TabIndex = 3;
            this.btnConsultaGral.Text = "Consulta General";
            this.btnConsultaGral.UseVisualStyleBackColor = true;
            this.btnConsultaGral.Click += new System.EventHandler(this.btnConsultaGral_Click);
            this.btnConsultaGral.Enter += new System.EventHandler(this.btnMouseEnter);
            this.btnConsultaGral.Leave += new System.EventHandler(this.btnMouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(929, 100);
            this.panel2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(141)))));
            this.label1.Location = new System.Drawing.Point(276, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar Colaboradores";
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
            // rbtTodos
            // 
            this.rbtTodos.AutoSize = true;
            this.rbtTodos.Checked = true;
            this.rbtTodos.Location = new System.Drawing.Point(26, 70);
            this.rbtTodos.Name = "rbtTodos";
            this.rbtTodos.Size = new System.Drawing.Size(55, 17);
            this.rbtTodos.TabIndex = 2;
            this.rbtTodos.TabStop = true;
            this.rbtTodos.Text = "Todos";
            this.rbtTodos.UseVisualStyleBackColor = true;
            this.rbtTodos.CheckedChanged += new System.EventHandler(this.rbtTodos_CheckedChanged);
            // 
            // rbtInactivos
            // 
            this.rbtInactivos.AutoSize = true;
            this.rbtInactivos.Location = new System.Drawing.Point(149, 70);
            this.rbtInactivos.Name = "rbtInactivos";
            this.rbtInactivos.Size = new System.Drawing.Size(68, 17);
            this.rbtInactivos.TabIndex = 3;
            this.rbtInactivos.Text = "Inactivos";
            this.rbtInactivos.UseVisualStyleBackColor = true;
            this.rbtInactivos.CheckedChanged += new System.EventHandler(this.rbtInactivos_CheckedChanged);
            // 
            // rbtActivos
            // 
            this.rbtActivos.AutoSize = true;
            this.rbtActivos.Location = new System.Drawing.Point(283, 70);
            this.rbtActivos.Name = "rbtActivos";
            this.rbtActivos.Size = new System.Drawing.Size(60, 17);
            this.rbtActivos.TabIndex = 4;
            this.rbtActivos.Text = "Activos";
            this.rbtActivos.UseVisualStyleBackColor = true;
            this.rbtActivos.CheckedChanged += new System.EventHandler(this.rbtActivos_CheckedChanged);
            // 
            // frmConsultarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 715);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultarEmpleados";
            this.Text = "frmConsultarEmpleados";
            this.panel1.ResumeLayout(false);
            this.paContenedor.ResumeLayout(false);
            this.pConsultaIndividual.ResumeLayout(false);
            this.pConsultaIndividual.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.pConsultaGeneral.ResumeLayout(false);
            this.pConsultaGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pSeccionesDatos.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pSeccionesDatos;
        private System.Windows.Forms.Button btnConsultaGral;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel paContenedor;
        private System.Windows.Forms.Button btnConsultaIndividual;
        private System.Windows.Forms.Panel pConsultaGeneral;
        private System.Windows.Forms.Panel pConsultaIndividual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private MaterialSkin.Controls.MaterialTextBox txtFechaNac;
        private MaterialSkin.Controls.MaterialTextBox txtNombre;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton2;
        private MaterialSkin.Controls.MaterialTextBox txtNoNomina;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialTextBox txtEstadoCivil;
        private MaterialSkin.Controls.MaterialTextBox txtSexo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialTextBox txtAntiguedad;
        private MaterialSkin.Controls.MaterialTextBox txtPuesto;
        private MaterialSkin.Controls.MaterialTextBox txtTurno;
        private MaterialSkin.Controls.MaterialTextBox txtTelefono;
        private MaterialSkin.Controls.MaterialTextBox txtCp;
        private MaterialSkin.Controls.MaterialTextBox txtDomicilio;
        private MaterialSkin.Controls.MaterialTextBox txtNss;
        private MaterialSkin.Controls.MaterialTextBox txtFechaIngreso;
        private System.Windows.Forms.RadioButton rbtActivos;
        private System.Windows.Forms.RadioButton rbtInactivos;
        private System.Windows.Forms.RadioButton rbtTodos;
    }
}