namespace CapaPresentacion.Restaurar_Y_Respaldar
{
    partial class frmNotificacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotificacion));
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pRight = new System.Windows.Forms.Panel();
            this.pImagen = new System.Windows.Forms.Panel();
            this.lblImagen = new System.Windows.Forms.Label();
            this.pbCrut = new System.Windows.Forms.PictureBox();
            this.pbErr = new System.Windows.Forms.PictureBox();
            this.pbSuc = new System.Windows.Forms.PictureBox();
            this.pPrincipal.SuspendLayout();
            this.pImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbErr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSuc)).BeginInit();
            this.SuspendLayout();
            // 
            // pPrincipal
            // 
            this.pPrincipal.BackColor = System.Drawing.Color.White;
            this.pPrincipal.Controls.Add(this.lblMsg);
            this.pPrincipal.Controls.Add(this.lblTitulo);
            this.pPrincipal.Controls.Add(this.btnCerrar);
            this.pPrincipal.Controls.Add(this.pRight);
            this.pPrincipal.Location = new System.Drawing.Point(62, 4);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(410, 121);
            this.pPrincipal.TabIndex = 0;
            // 
            // lblMsg
            // 
            this.lblMsg.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.Gray;
            this.lblMsg.Location = new System.Drawing.Point(126, 30);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(277, 86);
            this.lblMsg.TabIndex = 3;
            this.lblMsg.Text = "label1";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(128, 3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(65, 25);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "label1";
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(380, -6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(23, 28);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            this.btnCerrar.MouseEnter += new System.EventHandler(this.btnCerrar_MouseEnter);
            this.btnCerrar.MouseLeave += new System.EventHandler(this.btnCerrar_MouseLeave);
            // 
            // pRight
            // 
            this.pRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.pRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pRight.Location = new System.Drawing.Point(403, 0);
            this.pRight.Name = "pRight";
            this.pRight.Size = new System.Drawing.Size(7, 121);
            this.pRight.TabIndex = 0;
            // 
            // pImagen
            // 
            this.pImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.pImagen.Controls.Add(this.lblImagen);
            this.pImagen.Controls.Add(this.pbSuc);
            this.pImagen.Controls.Add(this.pbCrut);
            this.pImagen.Controls.Add(this.pbErr);
            this.pImagen.Location = new System.Drawing.Point(1, 27);
            this.pImagen.Name = "pImagen";
            this.pImagen.Size = new System.Drawing.Size(182, 69);
            this.pImagen.TabIndex = 0;
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagen.Location = new System.Drawing.Point(65, 23);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(115, 31);
            this.lblImagen.TabIndex = 4;
            this.lblImagen.Text = "Actualizado";
            this.lblImagen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblImagen.UseCompatibleTextRendering = true;
            // 
            // pbCrut
            // 
            this.pbCrut.Image = ((System.Drawing.Image)(resources.GetObject("pbCrut.Image")));
            this.pbCrut.Location = new System.Drawing.Point(2, 4);
            this.pbCrut.Name = "pbCrut";
            this.pbCrut.Size = new System.Drawing.Size(60, 60);
            this.pbCrut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCrut.TabIndex = 7;
            this.pbCrut.TabStop = false;
            // 
            // pbErr
            // 
            this.pbErr.Image = ((System.Drawing.Image)(resources.GetObject("pbErr.Image")));
            this.pbErr.Location = new System.Drawing.Point(2, 4);
            this.pbErr.Name = "pbErr";
            this.pbErr.Size = new System.Drawing.Size(60, 60);
            this.pbErr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbErr.TabIndex = 6;
            this.pbErr.TabStop = false;
            // 
            // pbSuc
            // 
            this.pbSuc.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbSuc.ErrorImage")));
            this.pbSuc.Image = ((System.Drawing.Image)(resources.GetObject("pbSuc.Image")));
            this.pbSuc.Location = new System.Drawing.Point(2, 4);
            this.pbSuc.Name = "pbSuc";
            this.pbSuc.Size = new System.Drawing.Size(60, 60);
            this.pbSuc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSuc.TabIndex = 5;
            this.pbSuc.TabStop = false;
            // 
            // frmNotificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(472, 125);
            this.Controls.Add(this.pImagen);
            this.Controls.Add(this.pPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNotificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmNotificacion";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.Load += new System.EventHandler(this.frmNotificacion_Load);
            this.pPrincipal.ResumeLayout(false);
            this.pPrincipal.PerformLayout();
            this.pImagen.ResumeLayout(false);
            this.pImagen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbErr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pPrincipal;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel pRight;
        private System.Windows.Forms.Panel pImagen;
        private System.Windows.Forms.PictureBox pbErr;
        private System.Windows.Forms.PictureBox pbSuc;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.PictureBox pbCrut;
    }
}