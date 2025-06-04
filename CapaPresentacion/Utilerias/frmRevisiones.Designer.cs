namespace CapaPresentacion.Utilerias
{
    partial class frmRevisiones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRevisiones));
            this.pContenedor = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pPuestos = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.dgvRevisiones = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectorFechaPersonalizado1 = new CapaPresentacion.selectorFechaPersonalizado();
            this.dtpFechaIngreso = new CapaPresentacion.selectorFechaPersonalizado();
            this.txtCodigo = new CapaPresentacion.TextPersonalizado();
            this.txtNumRevision = new CapaPresentacion.TextPersonalizado();
            this.btnGuardar = new CapaPresentacion.BotonPersonalizado();
            this.pContenedor.SuspendLayout();
            this.pPuestos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevisiones)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pContenedor
            // 
            this.pContenedor.AutoScroll = true;
            this.pContenedor.Controls.Add(this.label3);
            this.pContenedor.Controls.Add(this.pPuestos);
            this.pContenedor.Controls.Add(this.panel3);
            this.pContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContenedor.Location = new System.Drawing.Point(0, 100);
            this.pContenedor.Name = "pContenedor";
            this.pContenedor.Size = new System.Drawing.Size(934, 532);
            this.pContenedor.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 661);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 153;
            this.label3.Text = "Id. Puesto:";
            // 
            // pPuestos
            // 
            this.pPuestos.Controls.Add(this.label5);
            this.pPuestos.Controls.Add(this.label4);
            this.pPuestos.Controls.Add(this.selectorFechaPersonalizado1);
            this.pPuestos.Controls.Add(this.dtpFechaIngreso);
            this.pPuestos.Controls.Add(this.label2);
            this.pPuestos.Controls.Add(this.txtCodigo);
            this.pPuestos.Controls.Add(this.label66);
            this.pPuestos.Controls.Add(this.txtNumRevision);
            this.pPuestos.Controls.Add(this.btnGuardar);
            this.pPuestos.Controls.Add(this.dgvRevisiones);
            this.pPuestos.Location = new System.Drawing.Point(24, 52);
            this.pPuestos.Name = "pPuestos";
            this.pPuestos.Size = new System.Drawing.Size(886, 602);
            this.pPuestos.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.label5.Location = new System.Drawing.Point(492, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 16);
            this.label5.TabIndex = 166;
            this.label5.Text = "Fecha de Revisión";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.label4.Location = new System.Drawing.Point(50, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 16);
            this.label4.TabIndex = 165;
            this.label4.Text = "Fecha de Emisión";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.label2.Location = new System.Drawing.Point(492, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 154;
            this.label2.Text = "Código";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label66.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.label66.Location = new System.Drawing.Point(50, 22);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(126, 16);
            this.label66.TabIndex = 152;
            this.label66.Text = "Número Revisión";
            // 
            // dgvRevisiones
            // 
            this.dgvRevisiones.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvRevisiones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRevisiones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRevisiones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvRevisiones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRevisiones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvRevisiones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRevisiones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRevisiones.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRevisiones.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRevisiones.EnableHeadersVisualStyles = false;
            this.dgvRevisiones.Location = new System.Drawing.Point(19, 277);
            this.dgvRevisiones.Name = "dgvRevisiones";
            this.dgvRevisiones.ReadOnly = true;
            this.dgvRevisiones.RowHeadersVisible = false;
            this.dgvRevisiones.RowHeadersWidth = 51;
            this.dgvRevisiones.RowTemplate.Height = 35;
            this.dgvRevisiones.Size = new System.Drawing.Size(849, 281);
            this.dgvRevisiones.TabIndex = 95;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(917, 35);
            this.panel3.TabIndex = 95;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(934, 100);
            this.panel2.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(253, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.label1.Location = new System.Drawing.Point(466, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Revisiones";
            // 
            // selectorFechaPersonalizado1
            // 
            this.selectorFechaPersonalizado1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.selectorFechaPersonalizado1.BorderColor = System.Drawing.Color.DarkCyan;
            this.selectorFechaPersonalizado1.BorderSize = 1;
            this.selectorFechaPersonalizado1.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.selectorFechaPersonalizado1.CalendarTitleBackColor = System.Drawing.Color.DarkCyan;
            this.selectorFechaPersonalizado1.Enabled = false;
            this.selectorFechaPersonalizado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.selectorFechaPersonalizado1.Location = new System.Drawing.Point(495, 130);
            this.selectorFechaPersonalizado1.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.selectorFechaPersonalizado1.MinimumSize = new System.Drawing.Size(4, 35);
            this.selectorFechaPersonalizado1.Name = "selectorFechaPersonalizado1";
            this.selectorFechaPersonalizado1.Size = new System.Drawing.Size(304, 35);
            this.selectorFechaPersonalizado1.SkinColor = System.Drawing.Color.WhiteSmoke;
            this.selectorFechaPersonalizado1.TabIndex = 164;
            this.selectorFechaPersonalizado1.TextColor = System.Drawing.Color.DimGray;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpFechaIngreso.BorderColor = System.Drawing.Color.DarkCyan;
            this.dtpFechaIngreso.BorderSize = 1;
            this.dtpFechaIngreso.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dtpFechaIngreso.CalendarTitleBackColor = System.Drawing.Color.DarkCyan;
            this.dtpFechaIngreso.Enabled = false;
            this.dtpFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.dtpFechaIngreso.Location = new System.Drawing.Point(53, 130);
            this.dtpFechaIngreso.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.dtpFechaIngreso.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(321, 35);
            this.dtpFechaIngreso.SkinColor = System.Drawing.Color.WhiteSmoke;
            this.dtpFechaIngreso.TabIndex = 163;
            this.dtpFechaIngreso.TextColor = System.Drawing.Color.DimGray;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigo.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodigo.BorderColor = System.Drawing.Color.Gray;
            this.txtCodigo.BorderFocusColor = System.Drawing.Color.DarkCyan;
            this.txtCodigo.BorderRadius = 12;
            this.txtCodigo.BorderSize = 2;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.DimGray;
            this.txtCodigo.Location = new System.Drawing.Point(492, 37);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.MaxLength = 30;
            this.txtCodigo.Multiline = false;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCodigo.PasswordChar = false;
            this.txtCodigo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodigo.PlaceholderText = "";
            this.txtCodigo.Size = new System.Drawing.Size(307, 35);
            this.txtCodigo.TabIndex = 153;
            this.txtCodigo.UnderlinedStyle = true;
            // 
            // txtNumRevision
            // 
            this.txtNumRevision.BackColor = System.Drawing.Color.White;
            this.txtNumRevision.BorderColor = System.Drawing.Color.Gray;
            this.txtNumRevision.BorderFocusColor = System.Drawing.Color.DarkCyan;
            this.txtNumRevision.BorderRadius = 12;
            this.txtNumRevision.BorderSize = 2;
            this.txtNumRevision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumRevision.ForeColor = System.Drawing.Color.DimGray;
            this.txtNumRevision.Location = new System.Drawing.Point(46, 38);
            this.txtNumRevision.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumRevision.MaxLength = 3;
            this.txtNumRevision.Multiline = false;
            this.txtNumRevision.Name = "txtNumRevision";
            this.txtNumRevision.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNumRevision.PasswordChar = false;
            this.txtNumRevision.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNumRevision.PlaceholderText = "";
            this.txtNumRevision.Size = new System.Drawing.Size(328, 35);
            this.txtNumRevision.TabIndex = 151;
            this.txtNumRevision.UnderlinedStyle = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.btnGuardar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.btnGuardar.BorderColor = System.Drawing.Color.LavenderBlush;
            this.btnGuardar.BorderRadius = 20;
            this.btnGuardar.BorderSize = 0;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(337, 200);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnGuardar.Size = new System.Drawing.Size(184, 53);
            this.btnGuardar.TabIndex = 149;
            this.btnGuardar.Text = " Guardar";
            this.btnGuardar.TextColor = System.Drawing.Color.White;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmRevisiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 632);
            this.Controls.Add(this.pContenedor);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRevisiones";
            this.Text = "frmRevisiones";
            this.pContenedor.ResumeLayout(false);
            this.pContenedor.PerformLayout();
            this.pPuestos.ResumeLayout(false);
            this.pPuestos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevisiones)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pContenedor;
        private System.Windows.Forms.Panel pPuestos;
        private System.Windows.Forms.Label label2;
        private TextPersonalizado txtCodigo;
        private TextPersonalizado txtNumRevision;
        private BotonPersonalizado btnGuardar;
        private System.Windows.Forms.DataGridView dgvRevisiones;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private selectorFechaPersonalizado selectorFechaPersonalizado1;
        private selectorFechaPersonalizado dtpFechaIngreso;
    }
}