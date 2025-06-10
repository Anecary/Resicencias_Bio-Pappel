namespace CapaPresentacion.Expediente
{
    partial class frmExportarExpediente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExportarExpediente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnExportarExpediente = new CapaPresentacion.BotonPersonalizado();
            this.btnSeleccionarTodo = new CapaPresentacion.BotonPersonalizado();
            this.dgvVistaExpedientes = new System.Windows.Forms.DataGridView();
            this.rowSeleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rowTabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowCampo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowCampoOriginal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAnularSeleccion = new CapaPresentacion.BotonPersonalizado();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaExpedientes)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1260, 788);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 166);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1260, 622);
            this.panel5.TabIndex = 102;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.btnExportarExpediente);
            this.panel4.Controls.Add(this.btnSeleccionarTodo);
            this.panel4.Controls.Add(this.dgvVistaExpedientes);
            this.panel4.Controls.Add(this.btnAnularSeleccion);
            this.panel4.Location = new System.Drawing.Point(13, 8);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1210, 766);
            this.panel4.TabIndex = 155;
            // 
            // btnExportarExpediente
            // 
            this.btnExportarExpediente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExportarExpediente.BackColor = System.Drawing.Color.DarkCyan;
            this.btnExportarExpediente.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.btnExportarExpediente.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnExportarExpediente.BorderRadius = 10;
            this.btnExportarExpediente.BorderSize = 2;
            this.btnExportarExpediente.FlatAppearance.BorderSize = 0;
            this.btnExportarExpediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarExpediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarExpediente.ForeColor = System.Drawing.Color.White;
            this.btnExportarExpediente.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarExpediente.Image")));
            this.btnExportarExpediente.Location = new System.Drawing.Point(924, 23);
            this.btnExportarExpediente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExportarExpediente.Name = "btnExportarExpediente";
            this.btnExportarExpediente.Size = new System.Drawing.Size(200, 55);
            this.btnExportarExpediente.TabIndex = 155;
            this.btnExportarExpediente.Text = "Exportar";
            this.btnExportarExpediente.TextColor = System.Drawing.Color.White;
            this.btnExportarExpediente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportarExpediente.UseVisualStyleBackColor = false;
            this.btnExportarExpediente.Click += new System.EventHandler(this.btnExportarExpediente_Click);
            // 
            // btnSeleccionarTodo
            // 
            this.btnSeleccionarTodo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSeleccionarTodo.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSeleccionarTodo.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.btnSeleccionarTodo.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnSeleccionarTodo.BorderRadius = 10;
            this.btnSeleccionarTodo.BorderSize = 2;
            this.btnSeleccionarTodo.FlatAppearance.BorderSize = 0;
            this.btnSeleccionarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarTodo.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarTodo.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionarTodo.Image")));
            this.btnSeleccionarTodo.Location = new System.Drawing.Point(43, 23);
            this.btnSeleccionarTodo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSeleccionarTodo.Name = "btnSeleccionarTodo";
            this.btnSeleccionarTodo.Size = new System.Drawing.Size(285, 55);
            this.btnSeleccionarTodo.TabIndex = 101;
            this.btnSeleccionarTodo.Text = "Seleccionar Todo";
            this.btnSeleccionarTodo.TextColor = System.Drawing.Color.White;
            this.btnSeleccionarTodo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeleccionarTodo.UseVisualStyleBackColor = false;
            this.btnSeleccionarTodo.Click += new System.EventHandler(this.btnSeleccionarTodo_Click);
            // 
            // dgvVistaExpedientes
            // 
            this.dgvVistaExpedientes.AllowUserToAddRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvVistaExpedientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVistaExpedientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVistaExpedientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVistaExpedientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvVistaExpedientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVistaExpedientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvVistaExpedientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVistaExpedientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvVistaExpedientes.ColumnHeadersHeight = 40;
            this.dgvVistaExpedientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowSeleccion,
            this.rowTabla,
            this.rowCampo,
            this.rowCampoOriginal});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVistaExpedientes.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvVistaExpedientes.EnableHeadersVisualStyles = false;
            this.dgvVistaExpedientes.Location = new System.Drawing.Point(15, 103);
            this.dgvVistaExpedientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvVistaExpedientes.Name = "dgvVistaExpedientes";
            this.dgvVistaExpedientes.RowHeadersVisible = false;
            this.dgvVistaExpedientes.RowHeadersWidth = 51;
            this.dgvVistaExpedientes.RowTemplate.Height = 35;
            this.dgvVistaExpedientes.Size = new System.Drawing.Size(1177, 625);
            this.dgvVistaExpedientes.TabIndex = 154;
            // 
            // rowSeleccion
            // 
            this.rowSeleccion.HeaderText = "Seleccionar";
            this.rowSeleccion.MinimumWidth = 6;
            this.rowSeleccion.Name = "rowSeleccion";
            // 
            // rowTabla
            // 
            this.rowTabla.HeaderText = "Tabla";
            this.rowTabla.MinimumWidth = 6;
            this.rowTabla.Name = "rowTabla";
            this.rowTabla.ReadOnly = true;
            // 
            // rowCampo
            // 
            this.rowCampo.HeaderText = "Campo";
            this.rowCampo.MinimumWidth = 6;
            this.rowCampo.Name = "rowCampo";
            this.rowCampo.ReadOnly = true;
            // 
            // rowCampoOriginal
            // 
            this.rowCampoOriginal.HeaderText = "Campo Original";
            this.rowCampoOriginal.MinimumWidth = 6;
            this.rowCampoOriginal.Name = "rowCampoOriginal";
            this.rowCampoOriginal.ReadOnly = true;
            this.rowCampoOriginal.Visible = false;
            // 
            // btnAnularSeleccion
            // 
            this.btnAnularSeleccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAnularSeleccion.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAnularSeleccion.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.btnAnularSeleccion.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnAnularSeleccion.BorderRadius = 10;
            this.btnAnularSeleccion.BorderSize = 2;
            this.btnAnularSeleccion.FlatAppearance.BorderSize = 0;
            this.btnAnularSeleccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnularSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnularSeleccion.ForeColor = System.Drawing.Color.White;
            this.btnAnularSeleccion.Image = ((System.Drawing.Image)(resources.GetObject("btnAnularSeleccion.Image")));
            this.btnAnularSeleccion.Location = new System.Drawing.Point(457, 23);
            this.btnAnularSeleccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnularSeleccion.Name = "btnAnularSeleccion";
            this.btnAnularSeleccion.Size = new System.Drawing.Size(252, 55);
            this.btnAnularSeleccion.TabIndex = 102;
            this.btnAnularSeleccion.Text = " Anular Selección";
            this.btnAnularSeleccion.TextColor = System.Drawing.Color.White;
            this.btnAnularSeleccion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnularSeleccion.UseVisualStyleBackColor = false;
            this.btnAnularSeleccion.Click += new System.EventHandler(this.btnAnularSeleccion_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 123);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1260, 43);
            this.panel3.TabIndex = 97;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1260, 123);
            this.panel2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.label1.Location = new System.Drawing.Point(460, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exportar expediente";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(337, 123);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // frmExportarExpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 788);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmExportarExpediente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmExportarExpediente";
            this.Load += new System.EventHandler(this.frmExportarExpediente_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaExpedientes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private BotonPersonalizado btnAnularSeleccion;
        private BotonPersonalizado btnSeleccionarTodo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvVistaExpedientes;
        private BotonPersonalizado btnExportarExpediente;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rowSeleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowCampo;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowCampoOriginal;
    }
}