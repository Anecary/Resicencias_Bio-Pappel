namespace CapaPresentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pMenu = new System.Windows.Forms.Panel();
            this.pLogo = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.pMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pMenu.Controls.Add(this.iconButton1);
            this.pMenu.Controls.Add(this.pLogo);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(220, 661);
            this.pMenu.TabIndex = 0;
            // 
            // pLogo
            // 
            this.pLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.pLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLogo.Location = new System.Drawing.Point(0, 0);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(220, 100);
            this.pLogo.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.H;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(85, 106);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(132, 71);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "iconButton1";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.pMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Panel pLogo;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}

