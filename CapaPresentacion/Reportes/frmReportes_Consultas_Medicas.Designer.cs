namespace CapaPresentacion.Reportes
{
    partial class frmReportes_Consultas_Medicas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportes_Consultas_Medicas));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pSeccionesDatos = new System.Windows.Forms.Panel();
            this.pCombobox = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbReportes_Notas = new MaterialSkin.Controls.MaterialComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxAos = new System.Windows.Forms.ComboBox();
            this.pReportViewer = new System.Windows.Forms.Panel();
            this.rvNotaMedica = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pCombobox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pReportViewer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(924, 100);
            this.panel2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.label1.Location = new System.Drawing.Point(300, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reportes de Notas Médicas ";
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
            // pSeccionesDatos
            // 
            this.pSeccionesDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.pSeccionesDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSeccionesDatos.Location = new System.Drawing.Point(0, 100);
            this.pSeccionesDatos.Name = "pSeccionesDatos";
            this.pSeccionesDatos.Size = new System.Drawing.Size(924, 36);
            this.pSeccionesDatos.TabIndex = 9;
            // 
            // pCombobox
            // 
            this.pCombobox.Controls.Add(this.label2);
            this.pCombobox.Controls.Add(this.cmbReportes_Notas);
            this.pCombobox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pCombobox.Location = new System.Drawing.Point(0, 136);
            this.pCombobox.Name = "pCombobox";
            this.pCombobox.Size = new System.Drawing.Size(924, 75);
            this.pCombobox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.label2.Location = new System.Drawing.Point(205, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Reportes:";
            // 
            // cmbReportes_Notas
            // 
            this.cmbReportes_Notas.AutoResize = false;
            this.cmbReportes_Notas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbReportes_Notas.Depth = 0;
            this.cmbReportes_Notas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbReportes_Notas.DropDownHeight = 174;
            this.cmbReportes_Notas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportes_Notas.DropDownWidth = 121;
            this.cmbReportes_Notas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbReportes_Notas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbReportes_Notas.FormattingEnabled = true;
            this.cmbReportes_Notas.Hint = "Reportes";
            this.cmbReportes_Notas.IntegralHeight = false;
            this.cmbReportes_Notas.ItemHeight = 43;
            this.cmbReportes_Notas.Items.AddRange(new object[] {
            "Reporte de Consultas Semanales",
            "Reporte de Consultas por Día de la Semana",
            "Reporte de Consultas por Procesos",
            "Reporte de Consultas por Hora",
            "Reporte de Consultas por Año"});
            this.cmbReportes_Notas.Location = new System.Drawing.Point(364, 15);
            this.cmbReportes_Notas.MaxDropDownItems = 4;
            this.cmbReportes_Notas.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbReportes_Notas.Name = "cmbReportes_Notas";
            this.cmbReportes_Notas.Size = new System.Drawing.Size(395, 49);
            this.cmbReportes_Notas.StartIndex = 0;
            this.cmbReportes_Notas.TabIndex = 0;
            this.cmbReportes_Notas.SelectedIndexChanged += new System.EventHandler(this.cmbReportes_Notas_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cboxAos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 211);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 100);
            this.panel1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(103)))), ((int)(((byte)(105)))));
            this.label3.Location = new System.Drawing.Point(12, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seleccione el año:";
            // 
            // cboxAos
            // 
            this.cboxAos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxAos.FormattingEnabled = true;
            this.cboxAos.Items.AddRange(new object[] {
            "2025",
            "2024"});
            this.cboxAos.Location = new System.Drawing.Point(167, 34);
            this.cboxAos.Name = "cboxAos";
            this.cboxAos.Size = new System.Drawing.Size(170, 21);
            this.cboxAos.TabIndex = 2;
            // 
            // pReportViewer
            // 
            this.pReportViewer.Controls.Add(this.rvNotaMedica);
            this.pReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pReportViewer.Location = new System.Drawing.Point(0, 311);
            this.pReportViewer.Name = "pReportViewer";
            this.pReportViewer.Size = new System.Drawing.Size(924, 201);
            this.pReportViewer.TabIndex = 12;
            // 
            // rvNotaMedica
            // 
            this.rvNotaMedica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvNotaMedica.Location = new System.Drawing.Point(0, 0);
            this.rvNotaMedica.Name = "rvNotaMedica";
            this.rvNotaMedica.ServerReport.BearerToken = null;
            this.rvNotaMedica.Size = new System.Drawing.Size(924, 201);
            this.rvNotaMedica.TabIndex = 0;
            this.rvNotaMedica.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // frmReportes_Consultas_Medicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(924, 512);
            this.Controls.Add(this.pReportViewer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pCombobox);
            this.Controls.Add(this.pSeccionesDatos);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReportes_Consultas_Medicas";
            this.Text = "frmReportes_Consultas_Medicas";
            this.Load += new System.EventHandler(this.frmReportes_Consultas_Medicas_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pCombobox.ResumeLayout(false);
            this.pCombobox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pReportViewer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pSeccionesDatos;
        private System.Windows.Forms.Panel pCombobox;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialComboBox cmbReportes_Notas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxAos;
        private System.Windows.Forms.Panel pReportViewer;
        private Microsoft.Reporting.WinForms.ReportViewer rvNotaMedica;
    }
}