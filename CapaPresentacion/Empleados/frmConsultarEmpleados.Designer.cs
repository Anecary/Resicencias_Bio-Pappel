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
            this.pSeccionesDatos = new System.Windows.Forms.Panel();
            this.btnInfoLaboral = new System.Windows.Forms.Button();
            this.btnInfoPersonal = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pSeccionesDatos.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pSeccionesDatos
            // 
            this.pSeccionesDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(141)))));
            this.pSeccionesDatos.Controls.Add(this.btnInfoLaboral);
            this.pSeccionesDatos.Controls.Add(this.btnInfoPersonal);
            this.pSeccionesDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSeccionesDatos.Location = new System.Drawing.Point(0, 100);
            this.pSeccionesDatos.Name = "pSeccionesDatos";
            this.pSeccionesDatos.Size = new System.Drawing.Size(1034, 45);
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
            this.btnInfoLaboral.Location = new System.Drawing.Point(547, 2);
            this.btnInfoLaboral.Name = "btnInfoLaboral";
            this.btnInfoLaboral.Size = new System.Drawing.Size(265, 40);
            this.btnInfoLaboral.TabIndex = 3;
            this.btnInfoLaboral.Text = "Datos Laborales";
            this.btnInfoLaboral.UseVisualStyleBackColor = true;
            // 
            // btnInfoPersonal
            // 
            this.btnInfoPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfoPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfoPersonal.FlatAppearance.BorderSize = 0;
            this.btnInfoPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoPersonal.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoPersonal.ForeColor = System.Drawing.Color.White;
            this.btnInfoPersonal.Location = new System.Drawing.Point(282, 2);
            this.btnInfoPersonal.Name = "btnInfoPersonal";
            this.btnInfoPersonal.Size = new System.Drawing.Size(265, 40);
            this.btnInfoPersonal.TabIndex = 2;
            this.btnInfoPersonal.Text = "Datos Personales";
            this.btnInfoPersonal.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1034, 100);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(141)))));
            this.label1.Location = new System.Drawing.Point(437, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar Empleados";
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
            // frmConsultarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 720);
            this.Controls.Add(this.pSeccionesDatos);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultarEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultarEmpleados";
            this.pSeccionesDatos.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pSeccionesDatos;
        private System.Windows.Forms.Button btnInfoLaboral;
        private System.Windows.Forms.Button btnInfoPersonal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}