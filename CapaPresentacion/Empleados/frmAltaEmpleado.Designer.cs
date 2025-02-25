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
            this.pSeccionesDatos = new System.Windows.Forms.Panel();
            this.btnInfoLaboral = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pDatosLaborales = new System.Windows.Forms.Panel();
            this.materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialComboBox2 = new MaterialSkin.Controls.MaterialComboBox();
            this.btnGrabar = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.panel1.SuspendLayout();
            this.pSeccionesDatos.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pDatosLaborales.SuspendLayout();
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
            // pSeccionesDatos
            // 
            this.pSeccionesDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(141)))));
            this.pSeccionesDatos.Controls.Add(this.btnInfoLaboral);
            this.pSeccionesDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSeccionesDatos.Location = new System.Drawing.Point(0, 100);
            this.pSeccionesDatos.Name = "pSeccionesDatos";
            this.pSeccionesDatos.Size = new System.Drawing.Size(945, 45);
            this.pSeccionesDatos.TabIndex = 7;
            // 
            // btnInfoLaboral
            // 
            this.btnInfoLaboral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfoLaboral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfoLaboral.FlatAppearance.BorderSize = 0;
            this.btnInfoLaboral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoLaboral.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoLaboral.ForeColor = System.Drawing.Color.White;
            this.btnInfoLaboral.Location = new System.Drawing.Point(400, 2);
            this.btnInfoLaboral.Name = "btnInfoLaboral";
            this.btnInfoLaboral.Size = new System.Drawing.Size(176, 40);
            this.btnInfoLaboral.TabIndex = 3;
            this.btnInfoLaboral.Text = "Datos Laborales";
            this.btnInfoLaboral.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(945, 100);
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
            this.pictureBox2.Size = new System.Drawing.Size(253, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pDatosLaborales
            // 
            this.pDatosLaborales.Controls.Add(this.materialButton1);
            this.pDatosLaborales.Controls.Add(this.btnGrabar);
            this.pDatosLaborales.Controls.Add(this.materialTextBox2);
            this.pDatosLaborales.Controls.Add(this.materialLabel1);
            this.pDatosLaborales.Controls.Add(this.materialLabel6);
            this.pDatosLaborales.Controls.Add(this.dateTimePicker1);
            this.pDatosLaborales.Controls.Add(this.materialTextBox1);
            this.pDatosLaborales.Controls.Add(this.materialComboBox2);
            this.pDatosLaborales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDatosLaborales.Location = new System.Drawing.Point(0, 145);
            this.pDatosLaborales.Name = "pDatosLaborales";
            this.pDatosLaborales.Size = new System.Drawing.Size(945, 609);
            this.pDatosLaborales.TabIndex = 36;
            // 
            // materialTextBox2
            // 
            this.materialTextBox2.AnimateReadOnly = false;
            this.materialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox2.Depth = 0;
            this.materialTextBox2.Enabled = false;
            this.materialTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox2.Hint = "Turno: ";
            this.materialTextBox2.LeadingIcon = null;
            this.materialTextBox2.Location = new System.Drawing.Point(453, 140);
            this.materialTextBox2.MaxLength = 18;
            this.materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2.Multiline = false;
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.Size = new System.Drawing.Size(333, 50);
            this.materialTextBox2.TabIndex = 56;
            this.materialTextBox2.Text = "";
            this.materialTextBox2.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.ForeColor = System.Drawing.Color.Green;
            this.materialLabel1.HighEmphasis = true;
            this.materialLabel1.Location = new System.Drawing.Point(12, 16);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(181, 29);
            this.materialLabel1.TabIndex = 55;
            this.materialLabel1.Text = "Datos Laborales:";
            this.materialLabel1.UseAccent = true;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.ForeColor = System.Drawing.Color.Green;
            this.materialLabel6.Location = new System.Drawing.Point(450, 90);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(125, 19);
            this.materialLabel6.TabIndex = 54;
            this.materialLabel6.Text = "Fecha de Ingreso:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(581, 90);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(210, 20);
            this.dateTimePicker1.TabIndex = 53;
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Enabled = false;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.Hint = "Numero de Nomina: ";
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(44, 73);
            this.materialTextBox1.MaxLength = 18;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(333, 50);
            this.materialTextBox1.TabIndex = 52;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
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
            this.materialComboBox2.Hint = "Puestos";
            this.materialComboBox2.IntegralHeight = false;
            this.materialComboBox2.ItemHeight = 43;
            this.materialComboBox2.Location = new System.Drawing.Point(42, 141);
            this.materialComboBox2.MaxDropDownItems = 4;
            this.materialComboBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox2.Name = "materialComboBox2";
            this.materialComboBox2.Size = new System.Drawing.Size(335, 49);
            this.materialComboBox2.StartIndex = 0;
            this.materialComboBox2.TabIndex = 51;
            // 
            // btnGrabar
            // 
            this.btnGrabar.AutoSize = false;
            this.btnGrabar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGrabar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGrabar.Depth = 0;
            this.btnGrabar.HighEmphasis = true;
            this.btnGrabar.Icon = ((System.Drawing.Image)(resources.GetObject("btnGrabar.Icon")));
            this.btnGrabar.Location = new System.Drawing.Point(300, 422);
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
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = ((System.Drawing.Image)(resources.GetObject("materialButton1.Icon")));
            this.materialButton1.Location = new System.Drawing.Point(453, 422);
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
            this.pSeccionesDatos.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pDatosLaborales.ResumeLayout(false);
            this.pDatosLaborales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pSeccionesDatos;
        private System.Windows.Forms.Button btnInfoLaboral;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pDatosLaborales;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton btnGrabar;
    }
}