using CapaPresentacion.Empleados;

namespace CapaPresentacion.Nota_Medica
{
    partial class frmNotaMedica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotaMedica));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pContenedor = new System.Windows.Forms.Panel();
            this.pNuevaConsultaMedica = new System.Windows.Forms.Panel();
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.btnGuardar = new MaterialSkin.Controls.MaterialButton();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.materialTextBox3 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.materialComboBox4 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialComboBox3 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialComboBox2 = new MaterialSkin.Controls.MaterialComboBox();
            this.txtDomicilio = new MaterialSkin.Controls.MaterialTextBox();
            this.txtIMSS = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.btnBuscarExpediente = new MaterialSkin.Controls.MaterialButton();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.btnBuscarEmpleado = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNoNomina = new MaterialSkin.Controls.MaterialTextBox();
            this.pSeccionesDatos = new System.Windows.Forms.Panel();
            this.pConsultaExpMedico = new System.Windows.Forms.Panel();
            this.btnConsultaExpMedico = new System.Windows.Forms.Button();
            this.btnNuevaNotaMedica = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pContenedor.SuspendLayout();
            this.pNuevaConsultaMedica.SuspendLayout();
            this.pSeccionesDatos.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(141)))));
            this.label1.Location = new System.Drawing.Point(593, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota Médica";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pContenedor);
            this.panel1.Controls.Add(this.pSeccionesDatos);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1245, 778);
            this.panel1.TabIndex = 4;
            // 
            // pContenedor
            // 
            this.pContenedor.Controls.Add(this.pNuevaConsultaMedica);
            this.pContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContenedor.Location = new System.Drawing.Point(0, 178);
            this.pContenedor.Margin = new System.Windows.Forms.Padding(4);
            this.pContenedor.Name = "pContenedor";
            this.pContenedor.Size = new System.Drawing.Size(1238, 594);
            this.pContenedor.TabIndex = 8;
            // 
            // pNuevaConsultaMedica
            // 
            this.pNuevaConsultaMedica.AutoScroll = true;
            this.pNuevaConsultaMedica.Controls.Add(this.btnCancelar);
            this.pNuevaConsultaMedica.Controls.Add(this.btnGuardar);
            this.pNuevaConsultaMedica.Controls.Add(this.richTextBox2);
            this.pNuevaConsultaMedica.Controls.Add(this.materialLabel4);
            this.pNuevaConsultaMedica.Controls.Add(this.materialLabel3);
            this.pNuevaConsultaMedica.Controls.Add(this.richTextBox1);
            this.pNuevaConsultaMedica.Controls.Add(this.materialTextBox3);
            this.pNuevaConsultaMedica.Controls.Add(this.materialLabel2);
            this.pNuevaConsultaMedica.Controls.Add(this.dateTimePicker1);
            this.pNuevaConsultaMedica.Controls.Add(this.materialComboBox4);
            this.pNuevaConsultaMedica.Controls.Add(this.materialTextBox2);
            this.pNuevaConsultaMedica.Controls.Add(this.materialComboBox3);
            this.pNuevaConsultaMedica.Controls.Add(this.materialComboBox2);
            this.pNuevaConsultaMedica.Controls.Add(this.txtDomicilio);
            this.pNuevaConsultaMedica.Controls.Add(this.txtIMSS);
            this.pNuevaConsultaMedica.Controls.Add(this.materialTextBox1);
            this.pNuevaConsultaMedica.Controls.Add(this.btnBuscarExpediente);
            this.pNuevaConsultaMedica.Controls.Add(this.materialComboBox1);
            this.pNuevaConsultaMedica.Controls.Add(this.btnBuscarEmpleado);
            this.pNuevaConsultaMedica.Controls.Add(this.materialLabel1);
            this.pNuevaConsultaMedica.Controls.Add(this.txtNoNomina);
            this.pNuevaConsultaMedica.Location = new System.Drawing.Point(0, 1);
            this.pNuevaConsultaMedica.Margin = new System.Windows.Forms.Padding(4);
            this.pNuevaConsultaMedica.Name = "pNuevaConsultaMedica";
            this.pNuevaConsultaMedica.Size = new System.Drawing.Size(1239, 593);
            this.pNuevaConsultaMedica.TabIndex = 34;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = false;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.HighEmphasis = true;
            this.btnCancelar.Icon = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Icon")));
            this.btnCancelar.Location = new System.Drawing.Point(632, 853);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar.Size = new System.Drawing.Size(150, 50);
            this.btnCancelar.TabIndex = 81;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelar.UseAccentColor = true;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = false;
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.HighEmphasis = true;
            this.btnGuardar.Icon = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Icon")));
            this.btnGuardar.Location = new System.Drawing.Point(420, 853);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGuardar.Size = new System.Drawing.Size(150, 50);
            this.btnGuardar.TabIndex = 80;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuardar.UseAccentColor = true;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(632, 524);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(527, 310);
            this.richTextBox2.TabIndex = 78;
            this.richTextBox2.Text = "";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.ForeColor = System.Drawing.Color.Green;
            this.materialLabel4.HighEmphasis = true;
            this.materialLabel4.Location = new System.Drawing.Point(628, 479);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(138, 24);
            this.materialLabel4.TabIndex = 77;
            this.materialLabel4.Text = "Observaciones:";
            this.materialLabel4.UseAccent = true;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.ForeColor = System.Drawing.Color.Green;
            this.materialLabel3.HighEmphasis = true;
            this.materialLabel3.Location = new System.Drawing.Point(39, 479);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(111, 24);
            this.materialLabel3.TabIndex = 76;
            this.materialLabel3.Text = "Diagnóstico:";
            this.materialLabel3.UseAccent = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(43, 524);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(527, 310);
            this.richTextBox1.TabIndex = 75;
            this.richTextBox1.Text = "";
            // 
            // materialTextBox3
            // 
            this.materialTextBox3.AnimateReadOnly = false;
            this.materialTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox3.Depth = 0;
            this.materialTextBox3.Enabled = false;
            this.materialTextBox3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox3.Hint = "Proceso";
            this.materialTextBox3.LeadingIcon = null;
            this.materialTextBox3.Location = new System.Drawing.Point(632, 385);
            this.materialTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.materialTextBox3.MaxLength = 18;
            this.materialTextBox3.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox3.Multiline = false;
            this.materialTextBox3.Name = "materialTextBox3";
            this.materialTextBox3.Size = new System.Drawing.Size(527, 50);
            this.materialTextBox3.TabIndex = 74;
            this.materialTextBox3.Text = "";
            this.materialTextBox3.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.ForeColor = System.Drawing.Color.Green;
            this.materialLabel2.HighEmphasis = true;
            this.materialLabel2.Location = new System.Drawing.Point(646, 153);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(159, 24);
            this.materialLabel2.TabIndex = 73;
            this.materialLabel2.Text = "Fecha de Ingreso:";
            this.materialLabel2.UseAccent = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(837, 154);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(280, 22);
            this.dateTimePicker1.TabIndex = 72;
            // 
            // materialComboBox4
            // 
            this.materialComboBox4.AutoResize = false;
            this.materialComboBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox4.Depth = 0;
            this.materialComboBox4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox4.DropDownHeight = 174;
            this.materialComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox4.DropDownWidth = 121;
            this.materialComboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox4.FormattingEnabled = true;
            this.materialComboBox4.Hint = "Puesto:";
            this.materialComboBox4.IntegralHeight = false;
            this.materialComboBox4.ItemHeight = 43;
            this.materialComboBox4.Location = new System.Drawing.Point(43, 384);
            this.materialComboBox4.MaxDropDownItems = 4;
            this.materialComboBox4.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox4.Name = "materialComboBox4";
            this.materialComboBox4.Size = new System.Drawing.Size(527, 49);
            this.materialComboBox4.StartIndex = 0;
            this.materialComboBox4.TabIndex = 71;
            // 
            // materialTextBox2
            // 
            this.materialTextBox2.AnimateReadOnly = false;
            this.materialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox2.Depth = 0;
            this.materialTextBox2.Enabled = false;
            this.materialTextBox2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox2.Hint = "Teléfono:";
            this.materialTextBox2.LeadingIcon = null;
            this.materialTextBox2.Location = new System.Drawing.Point(43, 300);
            this.materialTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.materialTextBox2.MaxLength = 18;
            this.materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2.Multiline = false;
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.Size = new System.Drawing.Size(527, 50);
            this.materialTextBox2.TabIndex = 70;
            this.materialTextBox2.Text = "";
            this.materialTextBox2.TrailingIcon = null;
            // 
            // materialComboBox3
            // 
            this.materialComboBox3.AutoResize = false;
            this.materialComboBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox3.Depth = 0;
            this.materialComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox3.DropDownHeight = 174;
            this.materialComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox3.DropDownWidth = 121;
            this.materialComboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox3.FormattingEnabled = true;
            this.materialComboBox3.Hint = "Sexo?:";
            this.materialComboBox3.IntegralHeight = false;
            this.materialComboBox3.ItemHeight = 43;
            this.materialComboBox3.Location = new System.Drawing.Point(912, 296);
            this.materialComboBox3.MaxDropDownItems = 4;
            this.materialComboBox3.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox3.Name = "materialComboBox3";
            this.materialComboBox3.Size = new System.Drawing.Size(247, 49);
            this.materialComboBox3.StartIndex = 0;
            this.materialComboBox3.TabIndex = 69;
            // 
            // materialComboBox2
            // 
            this.materialComboBox2.AutoResize = false;
            this.materialComboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox2.Depth = 0;
            this.materialComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox2.DropDownHeight = 174;
            this.materialComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox2.DropDownWidth = 121;
            this.materialComboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox2.FormattingEnabled = true;
            this.materialComboBox2.Hint = "Estado Civil:";
            this.materialComboBox2.IntegralHeight = false;
            this.materialComboBox2.ItemHeight = 43;
            this.materialComboBox2.Location = new System.Drawing.Point(632, 296);
            this.materialComboBox2.MaxDropDownItems = 4;
            this.materialComboBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox2.Name = "materialComboBox2";
            this.materialComboBox2.Size = new System.Drawing.Size(247, 49);
            this.materialComboBox2.StartIndex = 0;
            this.materialComboBox2.TabIndex = 68;
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
            this.txtDomicilio.Location = new System.Drawing.Point(43, 219);
            this.txtDomicilio.Margin = new System.Windows.Forms.Padding(4);
            this.txtDomicilio.MaxLength = 18;
            this.txtDomicilio.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDomicilio.Multiline = false;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(527, 50);
            this.txtDomicilio.TabIndex = 67;
            this.txtDomicilio.Text = "";
            this.txtDomicilio.TrailingIcon = null;
            // 
            // txtIMSS
            // 
            this.txtIMSS.AnimateReadOnly = false;
            this.txtIMSS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIMSS.Depth = 0;
            this.txtIMSS.Enabled = false;
            this.txtIMSS.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIMSS.Hint = "IMSS:";
            this.txtIMSS.LeadingIcon = null;
            this.txtIMSS.Location = new System.Drawing.Point(632, 219);
            this.txtIMSS.Margin = new System.Windows.Forms.Padding(4);
            this.txtIMSS.MaxLength = 18;
            this.txtIMSS.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIMSS.Multiline = false;
            this.txtIMSS.Name = "txtIMSS";
            this.txtIMSS.Size = new System.Drawing.Size(527, 50);
            this.txtIMSS.TabIndex = 66;
            this.txtIMSS.Text = "";
            this.txtIMSS.TrailingIcon = null;
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Enabled = false;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.Hint = "Nombre:";
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(43, 143);
            this.materialTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.materialTextBox1.MaxLength = 18;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(527, 50);
            this.materialTextBox1.TabIndex = 65;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // btnBuscarExpediente
            // 
            this.btnBuscarExpediente.AutoSize = false;
            this.btnBuscarExpediente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarExpediente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscarExpediente.Depth = 0;
            this.btnBuscarExpediente.HighEmphasis = true;
            this.btnBuscarExpediente.Icon = ((System.Drawing.Image)(resources.GetObject("btnBuscarExpediente.Icon")));
            this.btnBuscarExpediente.Location = new System.Drawing.Point(1009, 67);
            this.btnBuscarExpediente.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnBuscarExpediente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarExpediente.Name = "btnBuscarExpediente";
            this.btnBuscarExpediente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuscarExpediente.Size = new System.Drawing.Size(150, 50);
            this.btnBuscarExpediente.TabIndex = 64;
            this.btnBuscarExpediente.Text = "Buscar";
            this.btnBuscarExpediente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscarExpediente.UseAccentColor = true;
            this.btnBuscarExpediente.UseVisualStyleBackColor = true;
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
            this.materialComboBox1.Hint = "No. Expediente:";
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Location = new System.Drawing.Point(632, 67);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(353, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 63;
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.AutoSize = false;
            this.btnBuscarEmpleado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarEmpleado.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscarEmpleado.Depth = 0;
            this.btnBuscarEmpleado.HighEmphasis = true;
            this.btnBuscarEmpleado.Icon = ((System.Drawing.Image)(resources.GetObject("btnBuscarEmpleado.Icon")));
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(420, 67);
            this.btnBuscarEmpleado.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnBuscarEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(150, 50);
            this.btnBuscarEmpleado.TabIndex = 62;
            this.btnBuscarEmpleado.Text = "Buscar";
            this.btnBuscarEmpleado.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscarEmpleado.UseAccentColor = true;
            this.btnBuscarEmpleado.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.ForeColor = System.Drawing.Color.Green;
            this.materialLabel1.HighEmphasis = true;
            this.materialLabel1.Location = new System.Drawing.Point(38, 20);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(195, 29);
            this.materialLabel1.TabIndex = 61;
            this.materialLabel1.Text = "Datos Personales:";
            this.materialLabel1.UseAccent = true;
            // 
            // txtNoNomina
            // 
            this.txtNoNomina.AnimateReadOnly = false;
            this.txtNoNomina.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNoNomina.Depth = 0;
            this.txtNoNomina.Enabled = false;
            this.txtNoNomina.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNoNomina.Hint = "Número de Nomina: ";
            this.txtNoNomina.LeadingIcon = null;
            this.txtNoNomina.Location = new System.Drawing.Point(43, 67);
            this.txtNoNomina.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoNomina.MaxLength = 18;
            this.txtNoNomina.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNoNomina.Multiline = false;
            this.txtNoNomina.Name = "txtNoNomina";
            this.txtNoNomina.Size = new System.Drawing.Size(353, 50);
            this.txtNoNomina.TabIndex = 58;
            this.txtNoNomina.Text = "";
            this.txtNoNomina.TrailingIcon = null;
            // 
            // pSeccionesDatos
            // 
            this.pSeccionesDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(141)))));
            this.pSeccionesDatos.Controls.Add(this.pConsultaExpMedico);
            this.pSeccionesDatos.Controls.Add(this.btnConsultaExpMedico);
            this.pSeccionesDatos.Controls.Add(this.btnNuevaNotaMedica);
            this.pSeccionesDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSeccionesDatos.Location = new System.Drawing.Point(0, 123);
            this.pSeccionesDatos.Margin = new System.Windows.Forms.Padding(4);
            this.pSeccionesDatos.Name = "pSeccionesDatos";
            this.pSeccionesDatos.Size = new System.Drawing.Size(1238, 55);
            this.pSeccionesDatos.TabIndex = 5;
            // 
            // pConsultaExpMedico
            // 
            this.pConsultaExpMedico.Location = new System.Drawing.Point(0, 55);
            this.pConsultaExpMedico.Name = "pConsultaExpMedico";
            this.pConsultaExpMedico.Size = new System.Drawing.Size(1238, 594);
            this.pConsultaExpMedico.TabIndex = 79;
            this.pConsultaExpMedico.Visible = false;
            // 
            // btnConsultaExpMedico
            // 
            this.btnConsultaExpMedico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultaExpMedico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultaExpMedico.FlatAppearance.BorderSize = 0;
            this.btnConsultaExpMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaExpMedico.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaExpMedico.ForeColor = System.Drawing.Color.White;
            this.btnConsultaExpMedico.Location = new System.Drawing.Point(632, 4);
            this.btnConsultaExpMedico.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultaExpMedico.Name = "btnConsultaExpMedico";
            this.btnConsultaExpMedico.Size = new System.Drawing.Size(349, 49);
            this.btnConsultaExpMedico.TabIndex = 3;
            this.btnConsultaExpMedico.Text = "Consultar Expediente Médico";
            this.btnConsultaExpMedico.UseVisualStyleBackColor = true;
            this.btnConsultaExpMedico.Click += new System.EventHandler(this.btnConsultaExpMedico_Click);
            this.btnConsultaExpMedico.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnConsultaExpMedico.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // btnNuevaNotaMedica
            // 
            this.btnNuevaNotaMedica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevaNotaMedica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaNotaMedica.FlatAppearance.BorderSize = 0;
            this.btnNuevaNotaMedica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaNotaMedica.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaNotaMedica.ForeColor = System.Drawing.Color.White;
            this.btnNuevaNotaMedica.Location = new System.Drawing.Point(300, 2);
            this.btnNuevaNotaMedica.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevaNotaMedica.Name = "btnNuevaNotaMedica";
            this.btnNuevaNotaMedica.Size = new System.Drawing.Size(270, 49);
            this.btnNuevaNotaMedica.TabIndex = 2;
            this.btnNuevaNotaMedica.Text = "Nueva Nota Médica";
            this.btnNuevaNotaMedica.UseVisualStyleBackColor = true;
            this.btnNuevaNotaMedica.Click += new System.EventHandler(this.btnNuevaNotaMedica_Click);
            this.btnNuevaNotaMedica.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnNuevaNotaMedica.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1238, 123);
            this.panel2.TabIndex = 4;
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
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 772);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1238, 6);
            this.panel5.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1238, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(7, 778);
            this.panel3.TabIndex = 6;
            // 
            // frmNotaMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 778);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNotaMedica";
            this.Load += new System.EventHandler(this.frmNotaMedica_Load);
            this.panel1.ResumeLayout(false);
            this.pContenedor.ResumeLayout(false);
            this.pNuevaConsultaMedica.ResumeLayout(false);
            this.pNuevaConsultaMedica.PerformLayout();
            this.pSeccionesDatos.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pSeccionesDatos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNuevaNotaMedica;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pContenedor;
        private System.Windows.Forms.Button btnConsultaExpMedico;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pNuevaConsultaMedica;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox4;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox3;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox2;
        private MaterialSkin.Controls.MaterialTextBox txtDomicilio;
        private MaterialSkin.Controls.MaterialTextBox txtIMSS;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialButton btnBuscarExpediente;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialButton btnBuscarEmpleado;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtNoNomina;
        private System.Windows.Forms.Panel pConsultaExpMedico;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialButton btnGuardar;
    }
}