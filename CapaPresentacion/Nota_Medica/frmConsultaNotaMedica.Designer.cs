namespace CapaPresentacion.Nota_Medica
{
    partial class frmConsultaNotaMedica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaNotaMedica));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pContenedor = new System.Windows.Forms.Panel();
            this.pBase = new System.Windows.Forms.Panel();
            this.pConsultaNotaGeneral = new System.Windows.Forms.Panel();
            this.topePagina = new System.Windows.Forms.Label();
            this.pConsultaGeneral = new System.Windows.Forms.Panel();
            this.btnBuscarEmpleado = new CapaPresentacion.BotonPersonalizado();
            this.tgvConsultaGeneral = new System.Windows.Forms.DataGridView();
            this.txtDomicilio = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPuesto = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTelefono = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEdad = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNSS = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEstadoCivil = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSexo = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNoExpediente = new MaterialSkin.Controls.MaterialTextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.txtNumeroNomina = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNombreEmpleado = new MaterialSkin.Controls.MaterialTextBox();
            this.pConsultaNotaIndividual = new System.Windows.Forms.Panel();
            this.pConsultaIndividual = new System.Windows.Forms.Panel();
            this.btnBuscarNotaMedica = new CapaPresentacion.BotonPersonalizado();
            this.txtDescripcion = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCausaConsulta = new MaterialSkin.Controls.MaterialTextBox();
            this.txtProceso = new MaterialSkin.Controls.MaterialTextBox();
            this.txtFechaNota = new MaterialSkin.Controls.MaterialTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiagnostico = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.label4 = new System.Windows.Forms.Label();
            this.txtObservaciones = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdConsulta = new MaterialSkin.Controls.MaterialTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pSeccionesDatos = new System.Windows.Forms.Panel();
            this.btnPanelGeneral = new System.Windows.Forms.Button();
            this.btnPanelIndividual = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pContenedor.SuspendLayout();
            this.pBase.SuspendLayout();
            this.pConsultaNotaGeneral.SuspendLayout();
            this.pConsultaGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tgvConsultaGeneral)).BeginInit();
            this.pConsultaNotaIndividual.SuspendLayout();
            this.pConsultaIndividual.SuspendLayout();
            this.pSeccionesDatos.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pContenedor);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1260, 820);
            this.panel1.TabIndex = 4;
            // 
            // pContenedor
            // 
            this.pContenedor.Controls.Add(this.pBase);
            this.pContenedor.Controls.Add(this.pSeccionesDatos);
            this.pContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContenedor.Location = new System.Drawing.Point(0, 123);
            this.pContenedor.Margin = new System.Windows.Forms.Padding(4);
            this.pContenedor.Name = "pContenedor";
            this.pContenedor.Size = new System.Drawing.Size(1260, 697);
            this.pContenedor.TabIndex = 8;
            // 
            // pBase
            // 
            this.pBase.Controls.Add(this.pConsultaNotaGeneral);
            this.pBase.Controls.Add(this.pConsultaNotaIndividual);
            this.pBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBase.Location = new System.Drawing.Point(0, 55);
            this.pBase.Name = "pBase";
            this.pBase.Size = new System.Drawing.Size(1260, 642);
            this.pBase.TabIndex = 36;
            // 
            // pConsultaNotaGeneral
            // 
            this.pConsultaNotaGeneral.AutoScroll = true;
            this.pConsultaNotaGeneral.Controls.Add(this.topePagina);
            this.pConsultaNotaGeneral.Controls.Add(this.pConsultaGeneral);
            this.pConsultaNotaGeneral.Location = new System.Drawing.Point(0, 0);
            this.pConsultaNotaGeneral.Margin = new System.Windows.Forms.Padding(4);
            this.pConsultaNotaGeneral.Name = "pConsultaNotaGeneral";
            this.pConsultaNotaGeneral.Size = new System.Drawing.Size(1260, 820);
            this.pConsultaNotaGeneral.TabIndex = 139;
            // 
            // topePagina
            // 
            this.topePagina.AutoSize = true;
            this.topePagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topePagina.ForeColor = System.Drawing.Color.Transparent;
            this.topePagina.Location = new System.Drawing.Point(-4, 1200);
            this.topePagina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.topePagina.Name = "topePagina";
            this.topePagina.Size = new System.Drawing.Size(133, 20);
            this.topePagina.TabIndex = 112;
            this.topePagina.Text = "Tipo de Lesión";
            // 
            // pConsultaGeneral
            // 
            this.pConsultaGeneral.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pConsultaGeneral.Controls.Add(this.btnBuscarEmpleado);
            this.pConsultaGeneral.Controls.Add(this.tgvConsultaGeneral);
            this.pConsultaGeneral.Controls.Add(this.txtDomicilio);
            this.pConsultaGeneral.Controls.Add(this.txtPuesto);
            this.pConsultaGeneral.Controls.Add(this.txtTelefono);
            this.pConsultaGeneral.Controls.Add(this.txtEdad);
            this.pConsultaGeneral.Controls.Add(this.txtNSS);
            this.pConsultaGeneral.Controls.Add(this.txtEstadoCivil);
            this.pConsultaGeneral.Controls.Add(this.txtSexo);
            this.pConsultaGeneral.Controls.Add(this.txtNoExpediente);
            this.pConsultaGeneral.Controls.Add(this.label42);
            this.pConsultaGeneral.Controls.Add(this.txtNumeroNomina);
            this.pConsultaGeneral.Controls.Add(this.txtNombreEmpleado);
            this.pConsultaGeneral.Location = new System.Drawing.Point(13, 14);
            this.pConsultaGeneral.Margin = new System.Windows.Forms.Padding(4);
            this.pConsultaGeneral.Name = "pConsultaGeneral";
            this.pConsultaGeneral.Size = new System.Drawing.Size(1194, 730);
            this.pConsultaGeneral.TabIndex = 116;
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.btnBuscarEmpleado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.btnBuscarEmpleado.BorderColor = System.Drawing.Color.LavenderBlush;
            this.btnBuscarEmpleado.BorderRadius = 20;
            this.btnBuscarEmpleado.BorderSize = 0;
            this.btnBuscarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnBuscarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnBuscarEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarEmpleado.Image")));
            this.btnBuscarEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(524, 82);
            this.btnBuscarEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(53, 49);
            this.btnBuscarEmpleado.TabIndex = 126;
            this.btnBuscarEmpleado.TextColor = System.Drawing.Color.White;
            this.btnBuscarEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarEmpleado.UseVisualStyleBackColor = false;
            this.btnBuscarEmpleado.Click += new System.EventHandler(this.btnBuscarEmpleado_Click);
            // 
            // tgvConsultaGeneral
            // 
            this.tgvConsultaGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tgvConsultaGeneral.Location = new System.Drawing.Point(24, 407);
            this.tgvConsultaGeneral.Name = "tgvConsultaGeneral";
            this.tgvConsultaGeneral.RowHeadersWidth = 51;
            this.tgvConsultaGeneral.RowTemplate.Height = 24;
            this.tgvConsultaGeneral.Size = new System.Drawing.Size(1135, 269);
            this.tgvConsultaGeneral.TabIndex = 117;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.AnimateReadOnly = false;
            this.txtDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDomicilio.Depth = 0;
            this.txtDomicilio.Enabled = false;
            this.txtDomicilio.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDomicilio.Hint = "Domicilio:";
            this.txtDomicilio.LeadingIcon = null;
            this.txtDomicilio.Location = new System.Drawing.Point(606, 161);
            this.txtDomicilio.Margin = new System.Windows.Forms.Padding(4);
            this.txtDomicilio.MaxLength = 18;
            this.txtDomicilio.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDomicilio.Multiline = false;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(553, 50);
            this.txtDomicilio.TabIndex = 115;
            this.txtDomicilio.Text = "";
            this.txtDomicilio.TrailingIcon = null;
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
            this.txtPuesto.Location = new System.Drawing.Point(895, 336);
            this.txtPuesto.Margin = new System.Windows.Forms.Padding(4);
            this.txtPuesto.MaxLength = 200;
            this.txtPuesto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPuesto.Multiline = false;
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(264, 50);
            this.txtPuesto.TabIndex = 111;
            this.txtPuesto.Text = "";
            this.txtPuesto.TrailingIcon = null;
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
            this.txtTelefono.Location = new System.Drawing.Point(313, 249);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.MaxLength = 200;
            this.txtTelefono.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(264, 50);
            this.txtTelefono.TabIndex = 108;
            this.txtTelefono.Text = "";
            this.txtTelefono.TrailingIcon = null;
            // 
            // txtEdad
            // 
            this.txtEdad.AnimateReadOnly = false;
            this.txtEdad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEdad.Depth = 0;
            this.txtEdad.Enabled = false;
            this.txtEdad.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEdad.Hint = "Edad:";
            this.txtEdad.LeadingIcon = null;
            this.txtEdad.Location = new System.Drawing.Point(606, 249);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(4);
            this.txtEdad.MaxLength = 50;
            this.txtEdad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEdad.Multiline = false;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(264, 50);
            this.txtEdad.TabIndex = 107;
            this.txtEdad.Text = "";
            this.txtEdad.TrailingIcon = null;
            // 
            // txtNSS
            // 
            this.txtNSS.AnimateReadOnly = false;
            this.txtNSS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNSS.Depth = 0;
            this.txtNSS.Enabled = false;
            this.txtNSS.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNSS.Hint = "No. IMSS:";
            this.txtNSS.LeadingIcon = null;
            this.txtNSS.Location = new System.Drawing.Point(606, 336);
            this.txtNSS.Margin = new System.Windows.Forms.Padding(4);
            this.txtNSS.MaxLength = 50;
            this.txtNSS.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNSS.Multiline = false;
            this.txtNSS.Name = "txtNSS";
            this.txtNSS.Size = new System.Drawing.Size(264, 50);
            this.txtNSS.TabIndex = 106;
            this.txtNSS.Text = "";
            this.txtNSS.TrailingIcon = null;
            // 
            // txtEstadoCivil
            // 
            this.txtEstadoCivil.AnimateReadOnly = false;
            this.txtEstadoCivil.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEstadoCivil.Depth = 0;
            this.txtEstadoCivil.Enabled = false;
            this.txtEstadoCivil.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEstadoCivil.Hint = "Estado Civil:";
            this.txtEstadoCivil.LeadingIcon = null;
            this.txtEstadoCivil.Location = new System.Drawing.Point(24, 249);
            this.txtEstadoCivil.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstadoCivil.MaxLength = 50;
            this.txtEstadoCivil.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEstadoCivil.Multiline = false;
            this.txtEstadoCivil.Name = "txtEstadoCivil";
            this.txtEstadoCivil.Size = new System.Drawing.Size(264, 50);
            this.txtEstadoCivil.TabIndex = 105;
            this.txtEstadoCivil.Text = "";
            this.txtEstadoCivil.TrailingIcon = null;
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
            this.txtSexo.Location = new System.Drawing.Point(895, 249);
            this.txtSexo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSexo.MaxLength = 50;
            this.txtSexo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSexo.Multiline = false;
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(264, 50);
            this.txtSexo.TabIndex = 104;
            this.txtSexo.Text = "";
            this.txtSexo.TrailingIcon = null;
            // 
            // txtNoExpediente
            // 
            this.txtNoExpediente.AnimateReadOnly = false;
            this.txtNoExpediente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNoExpediente.Depth = 0;
            this.txtNoExpediente.Enabled = false;
            this.txtNoExpediente.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNoExpediente.Hint = "No. Expediente: ";
            this.txtNoExpediente.LeadingIcon = null;
            this.txtNoExpediente.Location = new System.Drawing.Point(24, 336);
            this.txtNoExpediente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoExpediente.MaxLength = 18;
            this.txtNoExpediente.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNoExpediente.Multiline = false;
            this.txtNoExpediente.Name = "txtNoExpediente";
            this.txtNoExpediente.Size = new System.Drawing.Size(553, 50);
            this.txtNoExpediente.TabIndex = 103;
            this.txtNoExpediente.Text = "";
            this.txtNoExpediente.TrailingIcon = null;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.Color.DarkCyan;
            this.label42.Location = new System.Drawing.Point(18, 26);
            this.label42.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(250, 31);
            this.label42.TabIndex = 96;
            this.label42.Text = "Consulta General:";
            // 
            // txtNumeroNomina
            // 
            this.txtNumeroNomina.AnimateReadOnly = false;
            this.txtNumeroNomina.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumeroNomina.Depth = 0;
            this.txtNumeroNomina.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumeroNomina.Hint = "No. Nomina: ";
            this.txtNumeroNomina.LeadingIcon = null;
            this.txtNumeroNomina.Location = new System.Drawing.Point(24, 81);
            this.txtNumeroNomina.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroNomina.MaxLength = 18;
            this.txtNumeroNomina.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNumeroNomina.Multiline = false;
            this.txtNumeroNomina.Name = "txtNumeroNomina";
            this.txtNumeroNomina.Size = new System.Drawing.Size(481, 50);
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
            this.txtNombreEmpleado.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreEmpleado.Hint = "Nombre del colaborador:";
            this.txtNombreEmpleado.LeadingIcon = null;
            this.txtNombreEmpleado.Location = new System.Drawing.Point(24, 161);
            this.txtNombreEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreEmpleado.MaxLength = 50;
            this.txtNombreEmpleado.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreEmpleado.Multiline = false;
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(553, 50);
            this.txtNombreEmpleado.TabIndex = 99;
            this.txtNombreEmpleado.Text = "";
            this.txtNombreEmpleado.TrailingIcon = null;
            // 
            // pConsultaNotaIndividual
            // 
            this.pConsultaNotaIndividual.AutoScroll = true;
            this.pConsultaNotaIndividual.Controls.Add(this.pConsultaIndividual);
            this.pConsultaNotaIndividual.Controls.Add(this.label5);
            this.pConsultaNotaIndividual.Location = new System.Drawing.Point(0, 0);
            this.pConsultaNotaIndividual.Margin = new System.Windows.Forms.Padding(4);
            this.pConsultaNotaIndividual.Name = "pConsultaNotaIndividual";
            this.pConsultaNotaIndividual.Size = new System.Drawing.Size(1260, 820);
            this.pConsultaNotaIndividual.TabIndex = 137;
            // 
            // pConsultaIndividual
            // 
            this.pConsultaIndividual.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pConsultaIndividual.Controls.Add(this.btnBuscarNotaMedica);
            this.pConsultaIndividual.Controls.Add(this.txtDescripcion);
            this.pConsultaIndividual.Controls.Add(this.txtCausaConsulta);
            this.pConsultaIndividual.Controls.Add(this.txtProceso);
            this.pConsultaIndividual.Controls.Add(this.txtFechaNota);
            this.pConsultaIndividual.Controls.Add(this.label3);
            this.pConsultaIndividual.Controls.Add(this.txtDiagnostico);
            this.pConsultaIndividual.Controls.Add(this.label4);
            this.pConsultaIndividual.Controls.Add(this.txtObservaciones);
            this.pConsultaIndividual.Controls.Add(this.label2);
            this.pConsultaIndividual.Controls.Add(this.txtIdConsulta);
            this.pConsultaIndividual.Location = new System.Drawing.Point(13, 14);
            this.pConsultaIndividual.Margin = new System.Windows.Forms.Padding(4);
            this.pConsultaIndividual.Name = "pConsultaIndividual";
            this.pConsultaIndividual.Size = new System.Drawing.Size(1194, 881);
            this.pConsultaIndividual.TabIndex = 117;
            // 
            // btnBuscarNotaMedica
            // 
            this.btnBuscarNotaMedica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.btnBuscarNotaMedica.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.btnBuscarNotaMedica.BorderColor = System.Drawing.Color.LavenderBlush;
            this.btnBuscarNotaMedica.BorderRadius = 20;
            this.btnBuscarNotaMedica.BorderSize = 0;
            this.btnBuscarNotaMedica.FlatAppearance.BorderSize = 0;
            this.btnBuscarNotaMedica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarNotaMedica.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarNotaMedica.ForeColor = System.Drawing.Color.White;
            this.btnBuscarNotaMedica.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarNotaMedica.Image")));
            this.btnBuscarNotaMedica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarNotaMedica.Location = new System.Drawing.Point(524, 81);
            this.btnBuscarNotaMedica.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarNotaMedica.Name = "btnBuscarNotaMedica";
            this.btnBuscarNotaMedica.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnBuscarNotaMedica.Size = new System.Drawing.Size(53, 49);
            this.btnBuscarNotaMedica.TabIndex = 142;
            this.btnBuscarNotaMedica.TextColor = System.Drawing.Color.White;
            this.btnBuscarNotaMedica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarNotaMedica.UseVisualStyleBackColor = false;
            this.btnBuscarNotaMedica.Click += new System.EventHandler(this.btnBuscarNotaMedica_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AnimateReadOnly = false;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Depth = 0;
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescripcion.Hint = "Descripción:";
            this.txtDescripcion.LeadingIcon = null;
            this.txtDescripcion.Location = new System.Drawing.Point(606, 164);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.MaxLength = 200;
            this.txtDescripcion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescripcion.Multiline = false;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(553, 50);
            this.txtDescripcion.TabIndex = 141;
            this.txtDescripcion.Text = "";
            this.txtDescripcion.TrailingIcon = null;
            // 
            // txtCausaConsulta
            // 
            this.txtCausaConsulta.AnimateReadOnly = false;
            this.txtCausaConsulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCausaConsulta.Depth = 0;
            this.txtCausaConsulta.Enabled = false;
            this.txtCausaConsulta.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCausaConsulta.Hint = "Causa de consulta:";
            this.txtCausaConsulta.LeadingIcon = null;
            this.txtCausaConsulta.Location = new System.Drawing.Point(24, 164);
            this.txtCausaConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.txtCausaConsulta.MaxLength = 200;
            this.txtCausaConsulta.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCausaConsulta.Multiline = false;
            this.txtCausaConsulta.Name = "txtCausaConsulta";
            this.txtCausaConsulta.Size = new System.Drawing.Size(553, 50);
            this.txtCausaConsulta.TabIndex = 140;
            this.txtCausaConsulta.Text = "";
            this.txtCausaConsulta.TrailingIcon = null;
            // 
            // txtProceso
            // 
            this.txtProceso.AnimateReadOnly = false;
            this.txtProceso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProceso.Depth = 0;
            this.txtProceso.Enabled = false;
            this.txtProceso.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtProceso.Hint = "Proceso:";
            this.txtProceso.LeadingIcon = null;
            this.txtProceso.Location = new System.Drawing.Point(606, 245);
            this.txtProceso.Margin = new System.Windows.Forms.Padding(4);
            this.txtProceso.MaxLength = 200;
            this.txtProceso.MouseState = MaterialSkin.MouseState.OUT;
            this.txtProceso.Multiline = false;
            this.txtProceso.Name = "txtProceso";
            this.txtProceso.Size = new System.Drawing.Size(553, 50);
            this.txtProceso.TabIndex = 138;
            this.txtProceso.Text = "";
            this.txtProceso.TrailingIcon = null;
            // 
            // txtFechaNota
            // 
            this.txtFechaNota.AnimateReadOnly = false;
            this.txtFechaNota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFechaNota.Depth = 0;
            this.txtFechaNota.Enabled = false;
            this.txtFechaNota.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFechaNota.Hint = "Fecha:";
            this.txtFechaNota.LeadingIcon = null;
            this.txtFechaNota.Location = new System.Drawing.Point(24, 245);
            this.txtFechaNota.Margin = new System.Windows.Forms.Padding(4);
            this.txtFechaNota.MaxLength = 200;
            this.txtFechaNota.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFechaNota.Multiline = false;
            this.txtFechaNota.Name = "txtFechaNota";
            this.txtFechaNota.Size = new System.Drawing.Size(553, 50);
            this.txtFechaNota.TabIndex = 137;
            this.txtFechaNota.Text = "";
            this.txtFechaNota.TrailingIcon = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(19, 553);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 29);
            this.label3.TabIndex = 132;
            this.label3.Text = "Diagnóstico:";
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.AnimateReadOnly = false;
            this.txtDiagnostico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDiagnostico.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDiagnostico.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiagnostico.Depth = 0;
            this.txtDiagnostico.Enabled = false;
            this.txtDiagnostico.HideSelection = true;
            this.txtDiagnostico.Location = new System.Drawing.Point(23, 599);
            this.txtDiagnostico.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiagnostico.MaxLength = 32767;
            this.txtDiagnostico.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.PasswordChar = '\0';
            this.txtDiagnostico.ReadOnly = false;
            this.txtDiagnostico.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDiagnostico.SelectedText = "";
            this.txtDiagnostico.SelectionLength = 0;
            this.txtDiagnostico.SelectionStart = 0;
            this.txtDiagnostico.ShortcutsEnabled = true;
            this.txtDiagnostico.Size = new System.Drawing.Size(1107, 161);
            this.txtDiagnostico.TabIndex = 131;
            this.txtDiagnostico.TabStop = false;
            this.txtDiagnostico.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDiagnostico.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(18, 321);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 29);
            this.label4.TabIndex = 130;
            this.label4.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.AnimateReadOnly = false;
            this.txtObservaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtObservaciones.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtObservaciones.Depth = 0;
            this.txtObservaciones.Enabled = false;
            this.txtObservaciones.HideSelection = true;
            this.txtObservaciones.Location = new System.Drawing.Point(24, 370);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservaciones.MaxLength = 32767;
            this.txtObservaciones.MouseState = MaterialSkin.MouseState.OUT;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.PasswordChar = '\0';
            this.txtObservaciones.ReadOnly = false;
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtObservaciones.SelectedText = "";
            this.txtObservaciones.SelectionLength = 0;
            this.txtObservaciones.SelectionStart = 0;
            this.txtObservaciones.ShortcutsEnabled = true;
            this.txtObservaciones.Size = new System.Drawing.Size(1108, 161);
            this.txtObservaciones.TabIndex = 129;
            this.txtObservaciones.TabStop = false;
            this.txtObservaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtObservaciones.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(18, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 31);
            this.label2.TabIndex = 96;
            this.label2.Text = "Consulta Individual:";
            // 
            // txtIdConsulta
            // 
            this.txtIdConsulta.AnimateReadOnly = false;
            this.txtIdConsulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdConsulta.Depth = 0;
            this.txtIdConsulta.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdConsulta.Hint = "IdConsulta: ";
            this.txtIdConsulta.LeadingIcon = null;
            this.txtIdConsulta.Location = new System.Drawing.Point(24, 81);
            this.txtIdConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdConsulta.MaxLength = 18;
            this.txtIdConsulta.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIdConsulta.Multiline = false;
            this.txtIdConsulta.Name = "txtIdConsulta";
            this.txtIdConsulta.Size = new System.Drawing.Size(481, 50);
            this.txtIdConsulta.TabIndex = 97;
            this.txtIdConsulta.Text = "";
            this.txtIdConsulta.TrailingIcon = null;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(-4, 1200);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 20);
            this.label5.TabIndex = 112;
            this.label5.Text = "Tipo de Lesión";
            // 
            // pSeccionesDatos
            // 
            this.pSeccionesDatos.BackColor = System.Drawing.Color.DarkCyan;
            this.pSeccionesDatos.Controls.Add(this.btnPanelGeneral);
            this.pSeccionesDatos.Controls.Add(this.btnPanelIndividual);
            this.pSeccionesDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSeccionesDatos.ForeColor = System.Drawing.Color.DarkCyan;
            this.pSeccionesDatos.Location = new System.Drawing.Point(0, 0);
            this.pSeccionesDatos.Margin = new System.Windows.Forms.Padding(4);
            this.pSeccionesDatos.Name = "pSeccionesDatos";
            this.pSeccionesDatos.Size = new System.Drawing.Size(1260, 55);
            this.pSeccionesDatos.TabIndex = 35;
            // 
            // btnPanelGeneral
            // 
            this.btnPanelGeneral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPanelGeneral.FlatAppearance.BorderSize = 0;
            this.btnPanelGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanelGeneral.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanelGeneral.ForeColor = System.Drawing.Color.White;
            this.btnPanelGeneral.Location = new System.Drawing.Point(250, 0);
            this.btnPanelGeneral.Margin = new System.Windows.Forms.Padding(4);
            this.btnPanelGeneral.Name = "btnPanelGeneral";
            this.btnPanelGeneral.Size = new System.Drawing.Size(250, 49);
            this.btnPanelGeneral.TabIndex = 14;
            this.btnPanelGeneral.Text = "Consulta General";
            this.btnPanelGeneral.UseVisualStyleBackColor = true;
            this.btnPanelGeneral.Click += new System.EventHandler(this.btnPanelGeneral_Click);
            this.btnPanelGeneral.Enter += new System.EventHandler(this.btnMouseEnter);
            this.btnPanelGeneral.Leave += new System.EventHandler(this.btnMouseLeave);
            // 
            // btnPanelIndividual
            // 
            this.btnPanelIndividual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPanelIndividual.FlatAppearance.BorderSize = 0;
            this.btnPanelIndividual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanelIndividual.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanelIndividual.ForeColor = System.Drawing.Color.White;
            this.btnPanelIndividual.Location = new System.Drawing.Point(750, 0);
            this.btnPanelIndividual.Margin = new System.Windows.Forms.Padding(4);
            this.btnPanelIndividual.Name = "btnPanelIndividual";
            this.btnPanelIndividual.Size = new System.Drawing.Size(250, 49);
            this.btnPanelIndividual.TabIndex = 11;
            this.btnPanelIndividual.Text = "Consulta Individual";
            this.btnPanelIndividual.UseVisualStyleBackColor = true;
            this.btnPanelIndividual.Click += new System.EventHandler(this.btnPanelIndividual_Click);
            this.btnPanelIndividual.Enter += new System.EventHandler(this.btnMouseEnter);
            this.btnPanelIndividual.Leave += new System.EventHandler(this.btnMouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1260, 123);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(464, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 58);
            this.label1.TabIndex = 6;
            this.label1.Text = "Consultar Notas Médicas";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(337, 123);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // frmConsultaNotaMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 820);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmConsultaNotaMedica";
            this.Load += new System.EventHandler(this.frmConsultaNotaMedica_Load);
            this.panel1.ResumeLayout(false);
            this.pContenedor.ResumeLayout(false);
            this.pBase.ResumeLayout(false);
            this.pConsultaNotaGeneral.ResumeLayout(false);
            this.pConsultaNotaGeneral.PerformLayout();
            this.pConsultaGeneral.ResumeLayout(false);
            this.pConsultaGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tgvConsultaGeneral)).EndInit();
            this.pConsultaNotaIndividual.ResumeLayout(false);
            this.pConsultaNotaIndividual.PerformLayout();
            this.pConsultaIndividual.ResumeLayout(false);
            this.pConsultaIndividual.PerformLayout();
            this.pSeccionesDatos.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pContenedor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pSeccionesDatos;
        private System.Windows.Forms.Button btnPanelGeneral;
        private System.Windows.Forms.Button btnPanelIndividual;
        private System.Windows.Forms.Panel pBase;
        private System.Windows.Forms.Panel pConsultaNotaIndividual;
        private System.Windows.Forms.Panel pConsultaIndividual;
        private MaterialSkin.Controls.MaterialTextBox txtDescripcion;
        private MaterialSkin.Controls.MaterialTextBox txtCausaConsulta;
        private MaterialSkin.Controls.MaterialTextBox txtProceso;
        private MaterialSkin.Controls.MaterialTextBox txtFechaNota;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtDiagnostico;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtObservaciones;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialTextBox txtIdConsulta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pConsultaNotaGeneral;
        private System.Windows.Forms.Label topePagina;
        private System.Windows.Forms.Panel pConsultaGeneral;
        private BotonPersonalizado btnBuscarEmpleado;
        private System.Windows.Forms.DataGridView tgvConsultaGeneral;
        private MaterialSkin.Controls.MaterialTextBox txtDomicilio;
        private MaterialSkin.Controls.MaterialTextBox txtPuesto;
        private MaterialSkin.Controls.MaterialTextBox txtTelefono;
        private MaterialSkin.Controls.MaterialTextBox txtEdad;
        private MaterialSkin.Controls.MaterialTextBox txtNSS;
        private MaterialSkin.Controls.MaterialTextBox txtEstadoCivil;
        private MaterialSkin.Controls.MaterialTextBox txtSexo;
        private MaterialSkin.Controls.MaterialTextBox txtNoExpediente;
        private System.Windows.Forms.Label label42;
        private MaterialSkin.Controls.MaterialTextBox txtNumeroNomina;
        private MaterialSkin.Controls.MaterialTextBox txtNombreEmpleado;
        private BotonPersonalizado btnBuscarNotaMedica;
    }
}