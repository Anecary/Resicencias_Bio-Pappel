using System.Drawing;

namespace CapaPresentacion
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.pMenu = new System.Windows.Forms.Panel();
            this.pSubmenuReportes = new System.Windows.Forms.Panel();
            this.btnReportes = new System.Windows.Forms.Button();
            this.pSubmenuEmpleados = new System.Windows.Forms.Panel();
            this.btnSecciones = new System.Windows.Forms.Button();
            this.btnPuestos = new System.Windows.Forms.Button();
            this.btnActualizarEmpleado = new System.Windows.Forms.Button();
            this.btnConsultarEmpleados = new System.Windows.Forms.Button();
            this.btnAltaEmpleados = new System.Windows.Forms.Button();
            this.btnNuevoEmpleado = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.pSubmenuCumplimientoLegal = new System.Windows.Forms.Panel();
            this.btnCumpliminetoLegal = new System.Windows.Forms.Button();
            this.pSubmenuNotaMedica = new System.Windows.Forms.Panel();
            this.btnConsultarHistorico = new System.Windows.Forms.Button();
            this.btnNuevaNotaMedica = new System.Windows.Forms.Button();
            this.btnNotaMedica = new System.Windows.Forms.Button();
            this.pSubmenuExpediente = new System.Windows.Forms.Panel();
            this.btnExpediente = new System.Windows.Forms.Button();
            this.pSubmenuAccidentes = new System.Windows.Forms.Panel();
            this.btnConsultarAccidentes = new System.Windows.Forms.Button();
            this.btnNewAccidente = new System.Windows.Forms.Button();
            this.btnInvAccidente = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.psuperior = new System.Windows.Forms.Panel();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.pContenedor = new System.Windows.Forms.Panel();
            this.pInicio = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pMenu.SuspendLayout();
            this.pSubmenuEmpleados.SuspendLayout();
            this.pSubmenuNotaMedica.SuspendLayout();
            this.pSubmenuAccidentes.SuspendLayout();
            this.pLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.psuperior.SuspendLayout();
            this.pContenedor.SuspendLayout();
            this.pInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pMenu
            // 
            this.pMenu.AutoScroll = true;
            this.pMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.pMenu.Controls.Add(this.pSubmenuReportes);
            this.pMenu.Controls.Add(this.btnReportes);
            this.pMenu.Controls.Add(this.pSubmenuEmpleados);
            this.pMenu.Controls.Add(this.btnEmpleados);
            this.pMenu.Controls.Add(this.pSubmenuCumplimientoLegal);
            this.pMenu.Controls.Add(this.btnCumpliminetoLegal);
            this.pMenu.Controls.Add(this.pSubmenuNotaMedica);
            this.pMenu.Controls.Add(this.btnNotaMedica);
            this.pMenu.Controls.Add(this.pSubmenuExpediente);
            this.pMenu.Controls.Add(this.btnExpediente);
            this.pMenu.Controls.Add(this.pSubmenuAccidentes);
            this.pMenu.Controls.Add(this.btnInvAccidente);
            this.pMenu.Controls.Add(this.btnHome);
            this.pMenu.Controls.Add(this.pLogo);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(250, 700);
            this.pMenu.TabIndex = 0;
            // 
            // pSubmenuReportes
            // 
            this.pSubmenuReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSubmenuReportes.Location = new System.Drawing.Point(0, 876);
            this.pSubmenuReportes.Name = "pSubmenuReportes";
            this.pSubmenuReportes.Size = new System.Drawing.Size(233, 35);
            this.pSubmenuReportes.TabIndex = 15;
            this.pSubmenuReportes.Visible = false;
            // 
            // btnReportes
            // 
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 826);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnReportes.Size = new System.Drawing.Size(233, 50);
            this.btnReportes.TabIndex = 14;
            this.btnReportes.Text = " Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = true;
            // 
            // pSubmenuEmpleados
            // 
            this.pSubmenuEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.pSubmenuEmpleados.Controls.Add(this.btnSecciones);
            this.pSubmenuEmpleados.Controls.Add(this.btnPuestos);
            this.pSubmenuEmpleados.Controls.Add(this.btnActualizarEmpleado);
            this.pSubmenuEmpleados.Controls.Add(this.btnConsultarEmpleados);
            this.pSubmenuEmpleados.Controls.Add(this.btnAltaEmpleados);
            this.pSubmenuEmpleados.Controls.Add(this.btnNuevoEmpleado);
            this.pSubmenuEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSubmenuEmpleados.Location = new System.Drawing.Point(0, 606);
            this.pSubmenuEmpleados.Name = "pSubmenuEmpleados";
            this.pSubmenuEmpleados.Size = new System.Drawing.Size(233, 220);
            this.pSubmenuEmpleados.TabIndex = 13;
            this.pSubmenuEmpleados.Visible = false;
            // 
            // btnSecciones
            // 
            this.btnSecciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSecciones.FlatAppearance.BorderSize = 0;
            this.btnSecciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecciones.Image = ((System.Drawing.Image)(resources.GetObject("btnSecciones.Image")));
            this.btnSecciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSecciones.Location = new System.Drawing.Point(0, 175);
            this.btnSecciones.Name = "btnSecciones";
            this.btnSecciones.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSecciones.Size = new System.Drawing.Size(233, 35);
            this.btnSecciones.TabIndex = 4;
            this.btnSecciones.Text = "Secciones";
            this.btnSecciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSecciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSecciones.UseVisualStyleBackColor = true;
            this.btnSecciones.Click += new System.EventHandler(this.btnSecciones_Click);
            // 
            // btnPuestos
            // 
            this.btnPuestos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPuestos.FlatAppearance.BorderSize = 0;
            this.btnPuestos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPuestos.Image = ((System.Drawing.Image)(resources.GetObject("btnPuestos.Image")));
            this.btnPuestos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPuestos.Location = new System.Drawing.Point(0, 140);
            this.btnPuestos.Name = "btnPuestos";
            this.btnPuestos.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnPuestos.Size = new System.Drawing.Size(233, 35);
            this.btnPuestos.TabIndex = 3;
            this.btnPuestos.Text = "Puestos";
            this.btnPuestos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPuestos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPuestos.UseVisualStyleBackColor = true;
            this.btnPuestos.Click += new System.EventHandler(this.btnPuestos_Click);
            // 
            // btnActualizarEmpleado
            // 
            this.btnActualizarEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnActualizarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnActualizarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarEmpleado.Image")));
            this.btnActualizarEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarEmpleado.Location = new System.Drawing.Point(0, 105);
            this.btnActualizarEmpleado.Name = "btnActualizarEmpleado";
            this.btnActualizarEmpleado.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnActualizarEmpleado.Size = new System.Drawing.Size(233, 35);
            this.btnActualizarEmpleado.TabIndex = 6;
            this.btnActualizarEmpleado.Text = " Actualizar Empleado";
            this.btnActualizarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizarEmpleado.UseVisualStyleBackColor = true;
            this.btnActualizarEmpleado.Click += new System.EventHandler(this.btnActualizarEmpleado_Click);
            // 
            // btnConsultarEmpleados
            // 
            this.btnConsultarEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarEmpleados.FlatAppearance.BorderSize = 0;
            this.btnConsultarEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarEmpleados.Image")));
            this.btnConsultarEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarEmpleados.Location = new System.Drawing.Point(0, 70);
            this.btnConsultarEmpleados.Name = "btnConsultarEmpleados";
            this.btnConsultarEmpleados.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnConsultarEmpleados.Size = new System.Drawing.Size(233, 35);
            this.btnConsultarEmpleados.TabIndex = 5;
            this.btnConsultarEmpleados.Text = " Consultar Empleado";
            this.btnConsultarEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultarEmpleados.UseVisualStyleBackColor = true;
            this.btnConsultarEmpleados.Click += new System.EventHandler(this.btnConsultarEmpleados_Click);
            // 
            // btnAltaEmpleados
            // 
            this.btnAltaEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAltaEmpleados.FlatAppearance.BorderSize = 0;
            this.btnAltaEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("btnAltaEmpleados.Image")));
            this.btnAltaEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaEmpleados.Location = new System.Drawing.Point(0, 35);
            this.btnAltaEmpleados.Name = "btnAltaEmpleados";
            this.btnAltaEmpleados.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAltaEmpleados.Size = new System.Drawing.Size(233, 35);
            this.btnAltaEmpleados.TabIndex = 2;
            this.btnAltaEmpleados.Text = " Altas Empleado";
            this.btnAltaEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAltaEmpleados.UseVisualStyleBackColor = true;
            this.btnAltaEmpleados.Click += new System.EventHandler(this.btnAltaEmpleados_Click);
            // 
            // btnNuevoEmpleado
            // 
            this.btnNuevoEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNuevoEmpleado.FlatAppearance.BorderSize = 0;
            this.btnNuevoEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoEmpleado.Image")));
            this.btnNuevoEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoEmpleado.Location = new System.Drawing.Point(0, 0);
            this.btnNuevoEmpleado.Name = "btnNuevoEmpleado";
            this.btnNuevoEmpleado.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnNuevoEmpleado.Size = new System.Drawing.Size(233, 35);
            this.btnNuevoEmpleado.TabIndex = 1;
            this.btnNuevoEmpleado.Text = " Nuevo Empleado";
            this.btnNuevoEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoEmpleado.UseVisualStyleBackColor = true;
            this.btnNuevoEmpleado.Click += new System.EventHandler(this.btnNuevoEmpleado_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpleados.Image")));
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(0, 556);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnEmpleados.Size = new System.Drawing.Size(233, 50);
            this.btnEmpleados.TabIndex = 12;
            this.btnEmpleados.Text = " Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // pSubmenuCumplimientoLegal
            // 
            this.pSubmenuCumplimientoLegal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.pSubmenuCumplimientoLegal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSubmenuCumplimientoLegal.Location = new System.Drawing.Point(0, 521);
            this.pSubmenuCumplimientoLegal.Name = "pSubmenuCumplimientoLegal";
            this.pSubmenuCumplimientoLegal.Size = new System.Drawing.Size(233, 35);
            this.pSubmenuCumplimientoLegal.TabIndex = 11;
            this.pSubmenuCumplimientoLegal.Visible = false;
            // 
            // btnCumpliminetoLegal
            // 
            this.btnCumpliminetoLegal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCumpliminetoLegal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCumpliminetoLegal.FlatAppearance.BorderSize = 0;
            this.btnCumpliminetoLegal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCumpliminetoLegal.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCumpliminetoLegal.Image = ((System.Drawing.Image)(resources.GetObject("btnCumpliminetoLegal.Image")));
            this.btnCumpliminetoLegal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCumpliminetoLegal.Location = new System.Drawing.Point(0, 471);
            this.btnCumpliminetoLegal.Name = "btnCumpliminetoLegal";
            this.btnCumpliminetoLegal.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnCumpliminetoLegal.Size = new System.Drawing.Size(233, 50);
            this.btnCumpliminetoLegal.TabIndex = 10;
            this.btnCumpliminetoLegal.Text = "Cumplimiento Legal";
            this.btnCumpliminetoLegal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCumpliminetoLegal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCumpliminetoLegal.UseVisualStyleBackColor = true;
            // 
            // pSubmenuNotaMedica
            // 
            this.pSubmenuNotaMedica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.pSubmenuNotaMedica.Controls.Add(this.btnConsultarHistorico);
            this.pSubmenuNotaMedica.Controls.Add(this.btnNuevaNotaMedica);
            this.pSubmenuNotaMedica.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSubmenuNotaMedica.Location = new System.Drawing.Point(0, 402);
            this.pSubmenuNotaMedica.Name = "pSubmenuNotaMedica";
            this.pSubmenuNotaMedica.Size = new System.Drawing.Size(233, 69);
            this.pSubmenuNotaMedica.TabIndex = 9;
            this.pSubmenuNotaMedica.Visible = false;
            // 
            // btnConsultarHistorico
            // 
            this.btnConsultarHistorico.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarHistorico.FlatAppearance.BorderSize = 0;
            this.btnConsultarHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarHistorico.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarHistorico.Image")));
            this.btnConsultarHistorico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarHistorico.Location = new System.Drawing.Point(0, 35);
            this.btnConsultarHistorico.Name = "btnConsultarHistorico";
            this.btnConsultarHistorico.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnConsultarHistorico.Size = new System.Drawing.Size(233, 35);
            this.btnConsultarHistorico.TabIndex = 2;
            this.btnConsultarHistorico.Text = "Consultar Históricos";
            this.btnConsultarHistorico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarHistorico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultarHistorico.UseVisualStyleBackColor = true;
            this.btnConsultarHistorico.Click += new System.EventHandler(this.btnConsultarHistorico_Click);
            // 
            // btnNuevaNotaMedica
            // 
            this.btnNuevaNotaMedica.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNuevaNotaMedica.FlatAppearance.BorderSize = 0;
            this.btnNuevaNotaMedica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaNotaMedica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaNotaMedica.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevaNotaMedica.Image")));
            this.btnNuevaNotaMedica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaNotaMedica.Location = new System.Drawing.Point(0, 0);
            this.btnNuevaNotaMedica.Name = "btnNuevaNotaMedica";
            this.btnNuevaNotaMedica.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnNuevaNotaMedica.Size = new System.Drawing.Size(233, 35);
            this.btnNuevaNotaMedica.TabIndex = 1;
            this.btnNuevaNotaMedica.Text = " Nueva Nota Médica";
            this.btnNuevaNotaMedica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaNotaMedica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevaNotaMedica.UseVisualStyleBackColor = true;
            this.btnNuevaNotaMedica.Click += new System.EventHandler(this.btnNuevaNotaMedica_Click);
            // 
            // btnNotaMedica
            // 
            this.btnNotaMedica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotaMedica.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNotaMedica.FlatAppearance.BorderSize = 0;
            this.btnNotaMedica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotaMedica.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotaMedica.Image = ((System.Drawing.Image)(resources.GetObject("btnNotaMedica.Image")));
            this.btnNotaMedica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotaMedica.Location = new System.Drawing.Point(0, 352);
            this.btnNotaMedica.Name = "btnNotaMedica";
            this.btnNotaMedica.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnNotaMedica.Size = new System.Drawing.Size(233, 50);
            this.btnNotaMedica.TabIndex = 8;
            this.btnNotaMedica.Text = " Nota Médica";
            this.btnNotaMedica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotaMedica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotaMedica.UseVisualStyleBackColor = true;
            this.btnNotaMedica.Click += new System.EventHandler(this.btnNotaMedica_Click);
            // 
            // pSubmenuExpediente
            // 
            this.pSubmenuExpediente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.pSubmenuExpediente.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSubmenuExpediente.Location = new System.Drawing.Point(0, 323);
            this.pSubmenuExpediente.Name = "pSubmenuExpediente";
            this.pSubmenuExpediente.Size = new System.Drawing.Size(233, 29);
            this.pSubmenuExpediente.TabIndex = 7;
            this.pSubmenuExpediente.Visible = false;
            // 
            // btnExpediente
            // 
            this.btnExpediente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExpediente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExpediente.FlatAppearance.BorderSize = 0;
            this.btnExpediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpediente.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpediente.Image = ((System.Drawing.Image)(resources.GetObject("btnExpediente.Image")));
            this.btnExpediente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpediente.Location = new System.Drawing.Point(0, 273);
            this.btnExpediente.Name = "btnExpediente";
            this.btnExpediente.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnExpediente.Size = new System.Drawing.Size(233, 50);
            this.btnExpediente.TabIndex = 6;
            this.btnExpediente.Text = " Expediente";
            this.btnExpediente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpediente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExpediente.UseVisualStyleBackColor = true;
            this.btnExpediente.Click += new System.EventHandler(this.btnExpediente_Click);
            // 
            // pSubmenuAccidentes
            // 
            this.pSubmenuAccidentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.pSubmenuAccidentes.Controls.Add(this.btnConsultarAccidentes);
            this.pSubmenuAccidentes.Controls.Add(this.btnNewAccidente);
            this.pSubmenuAccidentes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSubmenuAccidentes.Location = new System.Drawing.Point(0, 200);
            this.pSubmenuAccidentes.Name = "pSubmenuAccidentes";
            this.pSubmenuAccidentes.Size = new System.Drawing.Size(233, 73);
            this.pSubmenuAccidentes.TabIndex = 5;
            this.pSubmenuAccidentes.Visible = false;
            // 
            // btnConsultarAccidentes
            // 
            this.btnConsultarAccidentes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarAccidentes.FlatAppearance.BorderSize = 0;
            this.btnConsultarAccidentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarAccidentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarAccidentes.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarAccidentes.Image")));
            this.btnConsultarAccidentes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarAccidentes.Location = new System.Drawing.Point(0, 35);
            this.btnConsultarAccidentes.Name = "btnConsultarAccidentes";
            this.btnConsultarAccidentes.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnConsultarAccidentes.Size = new System.Drawing.Size(233, 35);
            this.btnConsultarAccidentes.TabIndex = 1;
            this.btnConsultarAccidentes.Text = "Consultar Accidentes";
            this.btnConsultarAccidentes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarAccidentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultarAccidentes.UseVisualStyleBackColor = true;
            this.btnConsultarAccidentes.Click += new System.EventHandler(this.btnConsultarAccidentes_Click);
            // 
            // btnNewAccidente
            // 
            this.btnNewAccidente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewAccidente.FlatAppearance.BorderSize = 0;
            this.btnNewAccidente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewAccidente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewAccidente.Image = ((System.Drawing.Image)(resources.GetObject("btnNewAccidente.Image")));
            this.btnNewAccidente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewAccidente.Location = new System.Drawing.Point(0, 0);
            this.btnNewAccidente.Name = "btnNewAccidente";
            this.btnNewAccidente.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnNewAccidente.Size = new System.Drawing.Size(233, 35);
            this.btnNewAccidente.TabIndex = 0;
            this.btnNewAccidente.Text = " Nuevo Accidente";
            this.btnNewAccidente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewAccidente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewAccidente.UseVisualStyleBackColor = true;
            this.btnNewAccidente.Click += new System.EventHandler(this.btnNewAccidente_Click);
            // 
            // btnInvAccidente
            // 
            this.btnInvAccidente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInvAccidente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInvAccidente.FlatAppearance.BorderSize = 0;
            this.btnInvAccidente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvAccidente.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvAccidente.Image = ((System.Drawing.Image)(resources.GetObject("btnInvAccidente.Image")));
            this.btnInvAccidente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvAccidente.Location = new System.Drawing.Point(0, 150);
            this.btnInvAccidente.Name = "btnInvAccidente";
            this.btnInvAccidente.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnInvAccidente.Size = new System.Drawing.Size(233, 50);
            this.btnInvAccidente.TabIndex = 4;
            this.btnInvAccidente.Text = " Accidente";
            this.btnInvAccidente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvAccidente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInvAccidente.UseVisualStyleBackColor = true;
            this.btnInvAccidente.Click += new System.EventHandler(this.btnInvAccidente_Click);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 100);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(233, 50);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = " Inicio";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pLogo
            // 
            this.pLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.pLogo.Controls.Add(this.pictureBox1);
            this.pLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLogo.Location = new System.Drawing.Point(0, 0);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(233, 100);
            this.pLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // psuperior
            // 
            this.psuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.psuperior.Controls.Add(this.btnCerrar);
            this.psuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.psuperior.Location = new System.Drawing.Point(250, 0);
            this.psuperior.Name = "psuperior";
            this.psuperior.Size = new System.Drawing.Size(950, 29);
            this.psuperior.TabIndex = 1;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnCerrar.IconColor = System.Drawing.Color.Black;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 30;
            this.btnCerrar.Location = new System.Drawing.Point(909, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(41, 29);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pContenedor
            // 
            this.pContenedor.Controls.Add(this.pInicio);
            this.pContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContenedor.Location = new System.Drawing.Point(250, 29);
            this.pContenedor.Name = "pContenedor";
            this.pContenedor.Size = new System.Drawing.Size(945, 666);
            this.pContenedor.TabIndex = 2;
            // 
            // pInicio
            // 
            this.pInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pInicio.Controls.Add(this.pictureBox2);
            this.pInicio.Depth = 0;
            this.pInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pInicio.Location = new System.Drawing.Point(0, 0);
            this.pInicio.Margin = new System.Windows.Forms.Padding(14);
            this.pInicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.pInicio.Name = "pInicio";
            this.pInicio.Padding = new System.Windows.Forms.Padding(14);
            this.pInicio.Size = new System.Drawing.Size(945, 666);
            this.pInicio.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(268, 178);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(404, 224);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1195, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 671);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(250, 695);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(945, 5);
            this.panel2.TabIndex = 4;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.pContenedor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.psuperior);
            this.Controls.Add(this.pMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pMenu.ResumeLayout(false);
            this.pSubmenuEmpleados.ResumeLayout(false);
            this.pSubmenuNotaMedica.ResumeLayout(false);
            this.pSubmenuAccidentes.ResumeLayout(false);
            this.pLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.psuperior.ResumeLayout(false);
            this.pContenedor.ResumeLayout(false);
            this.pInicio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Panel pLogo;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pSubmenuNotaMedica;
        private System.Windows.Forms.Button btnNotaMedica;
        private System.Windows.Forms.Panel pSubmenuExpediente;
        private System.Windows.Forms.Button btnExpediente;
        private System.Windows.Forms.Panel pSubmenuAccidentes;
        private System.Windows.Forms.Button btnInvAccidente;
        private System.Windows.Forms.Panel psuperior;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pContenedor;
        private System.Windows.Forms.Panel pSubmenuEmpleados;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Panel pSubmenuCumplimientoLegal;
        private System.Windows.Forms.Button btnCumpliminetoLegal;
        private System.Windows.Forms.Panel pSubmenuReportes;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnNewAccidente;
        private System.Windows.Forms.Button btnConsultarAccidentes;
        private MaterialSkin.Controls.MaterialCard pInicio;
        private System.Windows.Forms.Button btnNuevoEmpleado;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAltaEmpleados;
        private System.Windows.Forms.Button btnNuevaNotaMedica;
        private System.Windows.Forms.Button btnConsultarHistorico;
        private System.Windows.Forms.Button btnSecciones;
        private System.Windows.Forms.Button btnPuestos;
        private System.Windows.Forms.Button btnConsultarEmpleados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnActualizarEmpleado;
    }
}

