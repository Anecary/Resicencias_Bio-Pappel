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
            this.pSeccionesDatos = new System.Windows.Forms.Panel();
            this.btnInfoLaboral = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.paContenedor = new System.Windows.Forms.Panel();
            this.pConsultaIndividual = new System.Windows.Forms.Panel();
            this.pConsultaGeneral = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pSeccionesDatos.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.paContenedor.SuspendLayout();
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
            // pSeccionesDatos
            // 
            this.pSeccionesDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(141)))));
            this.pSeccionesDatos.Controls.Add(this.button1);
            this.pSeccionesDatos.Controls.Add(this.btnInfoLaboral);
            this.pSeccionesDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSeccionesDatos.Location = new System.Drawing.Point(0, 100);
            this.pSeccionesDatos.Name = "pSeccionesDatos";
            this.pSeccionesDatos.Size = new System.Drawing.Size(929, 45);
            this.pSeccionesDatos.TabIndex = 9;
            // 
            // btnInfoLaboral
            // 
            this.btnInfoLaboral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfoLaboral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfoLaboral.FlatAppearance.BorderSize = 0;
            this.btnInfoLaboral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoLaboral.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoLaboral.ForeColor = System.Drawing.Color.White;
            this.btnInfoLaboral.Location = new System.Drawing.Point(279, 0);
            this.btnInfoLaboral.Name = "btnInfoLaboral";
            this.btnInfoLaboral.Size = new System.Drawing.Size(160, 40);
            this.btnInfoLaboral.TabIndex = 3;
            this.btnInfoLaboral.Text = "Consulta General";
            this.btnInfoLaboral.UseVisualStyleBackColor = true;
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
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(452, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Consulta Individual";
            this.button1.UseVisualStyleBackColor = true;
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
            this.pConsultaIndividual.Location = new System.Drawing.Point(0, 0);
            this.pConsultaIndividual.Name = "pConsultaIndividual";
            this.pConsultaIndividual.Size = new System.Drawing.Size(929, 570);
            this.pConsultaIndividual.TabIndex = 0;
            // 
            // pConsultaGeneral
            // 
            this.pConsultaGeneral.Location = new System.Drawing.Point(0, 0);
            this.pConsultaGeneral.Name = "pConsultaGeneral";
            this.pConsultaGeneral.Size = new System.Drawing.Size(929, 570);
            this.pConsultaGeneral.TabIndex = 1;
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
            this.pSeccionesDatos.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.paContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pSeccionesDatos;
        private System.Windows.Forms.Button btnInfoLaboral;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel paContenedor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pConsultaGeneral;
        private System.Windows.Forms.Panel pConsultaIndividual;
    }
}