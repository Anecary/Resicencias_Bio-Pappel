namespace CapaPresentacion.Utilerias
{
    partial class frmImportarEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportarEmpleados));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCargarExcel = new CapaPresentacion.BotonPersonalizado();
            this.dgvPuestos = new System.Windows.Forms.DataGridView();
            this.btnSubir = new CapaPresentacion.BotonPersonalizado();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargarExcel
            // 
            this.btnCargarExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCargarExcel.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCargarExcel.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.btnCargarExcel.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnCargarExcel.BorderRadius = 10;
            this.btnCargarExcel.BorderSize = 2;
            this.btnCargarExcel.FlatAppearance.BorderSize = 0;
            this.btnCargarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarExcel.ForeColor = System.Drawing.Color.White;
            this.btnCargarExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnCargarExcel.Image")));
            this.btnCargarExcel.Location = new System.Drawing.Point(12, 465);
            this.btnCargarExcel.Name = "btnCargarExcel";
            this.btnCargarExcel.Size = new System.Drawing.Size(159, 45);
            this.btnCargarExcel.TabIndex = 3;
            this.btnCargarExcel.Text = "Cargar excel";
            this.btnCargarExcel.TextColor = System.Drawing.Color.White;
            this.btnCargarExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCargarExcel.UseVisualStyleBackColor = false;
            this.btnCargarExcel.Click += new System.EventHandler(this.btnCargarExcel_Click);
            // 
            // dgvPuestos
            // 
            this.dgvPuestos.AllowUserToAddRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPuestos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPuestos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPuestos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvPuestos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPuestos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPuestos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPuestos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPuestos.ColumnHeadersHeight = 40;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPuestos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPuestos.EnableHeadersVisualStyles = false;
            this.dgvPuestos.Location = new System.Drawing.Point(12, 15);
            this.dgvPuestos.Name = "dgvPuestos";
            this.dgvPuestos.ReadOnly = true;
            this.dgvPuestos.RowHeadersVisible = false;
            this.dgvPuestos.RowHeadersWidth = 51;
            this.dgvPuestos.RowTemplate.Height = 35;
            this.dgvPuestos.Size = new System.Drawing.Size(838, 444);
            this.dgvPuestos.TabIndex = 154;
            // 
            // btnSubir
            // 
            this.btnSubir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubir.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSubir.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.btnSubir.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnSubir.BorderRadius = 10;
            this.btnSubir.BorderSize = 2;
            this.btnSubir.Enabled = false;
            this.btnSubir.FlatAppearance.BorderSize = 0;
            this.btnSubir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubir.ForeColor = System.Drawing.Color.White;
            this.btnSubir.Image = ((System.Drawing.Image)(resources.GetObject("btnSubir.Image")));
            this.btnSubir.Location = new System.Drawing.Point(187, 465);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(207, 45);
            this.btnSubir.TabIndex = 155;
            this.btnSubir.Text = "Subir informacion";
            this.btnSubir.TextColor = System.Drawing.Color.White;
            this.btnSubir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSubir.UseVisualStyleBackColor = false;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // frmImportarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 578);
            this.Controls.Add(this.btnSubir);
            this.Controls.Add(this.dgvPuestos);
            this.Controls.Add(this.btnCargarExcel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmImportarEmpleados";
            this.Text = "frmImportarEmpleados";
            this.Load += new System.EventHandler(this.frmImportarEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BotonPersonalizado btnCargarExcel;
        private System.Windows.Forms.DataGridView dgvPuestos;
        private BotonPersonalizado btnSubir;
    }
}