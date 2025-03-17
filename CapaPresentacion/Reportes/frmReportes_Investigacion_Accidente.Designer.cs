namespace CapaPresentacion.Reportes
{
    partial class frmReportes_Investigacion_Accidente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportes_Investigacion_Accidente));
            this.pContenedor = new System.Windows.Forms.Panel();
            this.pReportViewer = new System.Windows.Forms.Panel();
            this.rvInvestigacionAccidente = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pCombobox = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbReportes = new MaterialSkin.Controls.MaterialComboBox();
            this.pSeccionesDatos = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.rdbAño = new System.Windows.Forms.RadioButton();
            this.cmbAños = new System.Windows.Forms.ComboBox();
            this.pContenedor.SuspendLayout();
            this.pReportViewer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pCombobox.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pContenedor
            // 
            this.pContenedor.BackColor = System.Drawing.Color.White;
            this.pContenedor.Controls.Add(this.pReportViewer);
            this.pContenedor.Controls.Add(this.panel1);
            this.pContenedor.Controls.Add(this.pCombobox);
            this.pContenedor.Controls.Add(this.pSeccionesDatos);
            this.pContenedor.Controls.Add(this.panel2);
            this.pContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContenedor.Location = new System.Drawing.Point(0, 0);
            this.pContenedor.Name = "pContenedor";
            this.pContenedor.Size = new System.Drawing.Size(945, 666);
            this.pContenedor.TabIndex = 0;
            // 
            // pReportViewer
            // 
            this.pReportViewer.Controls.Add(this.rvInvestigacionAccidente);
            this.pReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pReportViewer.Location = new System.Drawing.Point(0, 311);
            this.pReportViewer.Name = "pReportViewer";
            this.pReportViewer.Size = new System.Drawing.Size(945, 355);
            this.pReportViewer.TabIndex = 11;
            // 
            // rvInvestigacionAccidente
            // 
            this.rvInvestigacionAccidente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvInvestigacionAccidente.Location = new System.Drawing.Point(0, 0);
            this.rvInvestigacionAccidente.Name = "rvInvestigacionAccidente";
            this.rvInvestigacionAccidente.ServerReport.BearerToken = null;
            this.rvInvestigacionAccidente.Size = new System.Drawing.Size(945, 355);
            this.rvInvestigacionAccidente.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.cmbAños);
            this.panel1.Controls.Add(this.rdbAño);
            this.panel1.Controls.Add(this.rdbTodos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 211);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 100);
            this.panel1.TabIndex = 10;
            // 
            // pCombobox
            // 
            this.pCombobox.Controls.Add(this.label2);
            this.pCombobox.Controls.Add(this.cmbReportes);
            this.pCombobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pCombobox.Location = new System.Drawing.Point(0, 136);
            this.pCombobox.Name = "pCombobox";
            this.pCombobox.Size = new System.Drawing.Size(945, 75);
            this.pCombobox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(141)))));
            this.label2.Location = new System.Drawing.Point(259, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Reportes:";
            // 
            // cmbReportes
            // 
            this.cmbReportes.AutoResize = false;
            this.cmbReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbReportes.Depth = 0;
            this.cmbReportes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbReportes.DropDownHeight = 174;
            this.cmbReportes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportes.DropDownWidth = 121;
            this.cmbReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbReportes.FormattingEnabled = true;
            this.cmbReportes.Hint = "Reportes";
            this.cmbReportes.IntegralHeight = false;
            this.cmbReportes.ItemHeight = 43;
            this.cmbReportes.Items.AddRange(new object[] {
            "Accidentes por año"});
            this.cmbReportes.Location = new System.Drawing.Point(367, 15);
            this.cmbReportes.MaxDropDownItems = 4;
            this.cmbReportes.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbReportes.Name = "cmbReportes";
            this.cmbReportes.Size = new System.Drawing.Size(249, 49);
            this.cmbReportes.StartIndex = 0;
            this.cmbReportes.TabIndex = 0;
            this.cmbReportes.SelectedIndexChanged += new System.EventHandler(this.materialComboBox1_SelectedIndexChanged);
            // 
            // pSeccionesDatos
            // 
            this.pSeccionesDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(141)))));
            this.pSeccionesDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSeccionesDatos.Location = new System.Drawing.Point(0, 100);
            this.pSeccionesDatos.Name = "pSeccionesDatos";
            this.pSeccionesDatos.Size = new System.Drawing.Size(945, 36);
            this.pSeccionesDatos.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(945, 100);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(141)))));
            this.label1.Location = new System.Drawing.Point(300, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(573, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reportes Investigación Accidente";
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
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Checked = true;
            this.rdbTodos.Location = new System.Drawing.Point(29, 16);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(97, 17);
            this.rdbTodos.TabIndex = 0;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "Todos los años";
            this.rdbTodos.UseVisualStyleBackColor = true;
            this.rdbTodos.Visible = false;
            this.rdbTodos.CheckedChanged += new System.EventHandler(this.rdbTodos_CheckedChanged);
            // 
            // rdbAño
            // 
            this.rdbAño.AutoSize = true;
            this.rdbAño.Location = new System.Drawing.Point(157, 16);
            this.rdbAño.Name = "rdbAño";
            this.rdbAño.Size = new System.Drawing.Size(95, 17);
            this.rdbAño.TabIndex = 1;
            this.rdbAño.Text = "Año especifico";
            this.rdbAño.UseVisualStyleBackColor = true;
            this.rdbAño.Visible = false;
            this.rdbAño.CheckedChanged += new System.EventHandler(this.rdbAño_CheckedChanged);
            // 
            // cmbAños
            // 
            this.cmbAños.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAños.FormattingEnabled = true;
            this.cmbAños.Location = new System.Drawing.Point(157, 49);
            this.cmbAños.Name = "cmbAños";
            this.cmbAños.Size = new System.Drawing.Size(121, 21);
            this.cmbAños.TabIndex = 2;
            this.cmbAños.Visible = false;
            this.cmbAños.SelectedIndexChanged += new System.EventHandler(this.cmbAños_SelectedIndexChanged);
            // 
            // frmReportes_Investigacion_Accidente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 666);
            this.Controls.Add(this.pContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReportes_Investigacion_Accidente";
            this.Text = "frmReportes_Investigacion_Accidente";
            this.Load += new System.EventHandler(this.frmReportes_Investigacion_Accidente_Load);
            this.pContenedor.ResumeLayout(false);
            this.pReportViewer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pCombobox.ResumeLayout(false);
            this.pCombobox.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pContenedor;
        private System.Windows.Forms.Panel pSeccionesDatos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pReportViewer;
        private Microsoft.Reporting.WinForms.ReportViewer rvInvestigacionAccidente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pCombobox;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialComboBox cmbReportes;
        private System.Windows.Forms.RadioButton rdbAño;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.ComboBox cmbAños;
    }
}