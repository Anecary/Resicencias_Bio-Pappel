namespace CapaPresentacion.Nota_Medica
{
    partial class frmConsultaHistorico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaHistorico));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pContenedor = new System.Windows.Forms.Panel();
            this.pConsultaHistoricos = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.btnConsultaGeneral = new MaterialSkin.Controls.MaterialButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_Expediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNoNomina = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.btnConsultaIndividual = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.panel1.SuspendLayout();
            this.pContenedor.SuspendLayout();
            this.pConsultaHistoricos.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(77)))), ((int)(((byte)(141)))));
            this.label1.Location = new System.Drawing.Point(431, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(672, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta del Historial Médico";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pContenedor);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1245, 778);
            this.panel1.TabIndex = 4;
            // 
            // pContenedor
            // 
            this.pContenedor.Controls.Add(this.pConsultaHistoricos);
            this.pContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContenedor.Location = new System.Drawing.Point(0, 123);
            this.pContenedor.Margin = new System.Windows.Forms.Padding(4);
            this.pContenedor.Name = "pContenedor";
            this.pContenedor.Size = new System.Drawing.Size(1238, 649);
            this.pContenedor.TabIndex = 8;
            // 
            // pConsultaHistoricos
            // 
            this.pConsultaHistoricos.AutoScroll = true;
            this.pConsultaHistoricos.Controls.Add(this.materialCard2);
            this.pConsultaHistoricos.Controls.Add(this.materialCard1);
            this.pConsultaHistoricos.Location = new System.Drawing.Point(0, 1);
            this.pConsultaHistoricos.Margin = new System.Windows.Forms.Padding(4);
            this.pConsultaHistoricos.Name = "pConsultaHistoricos";
            this.pConsultaHistoricos.Size = new System.Drawing.Size(1239, 648);
            this.pConsultaHistoricos.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1238, 123);
            this.panel2.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(337, 123);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 772);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1238, 6);
            this.panel5.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1238, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(7, 778);
            this.panel3.TabIndex = 6;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btnConsultaGeneral);
            this.materialCard1.Controls.Add(this.dataGridView1);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.txtNoNomina);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(23, 13);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1172, 333);
            this.materialCard1.TabIndex = 86;
            // 
            // btnConsultaGeneral
            // 
            this.btnConsultaGeneral.AutoSize = false;
            this.btnConsultaGeneral.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConsultaGeneral.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConsultaGeneral.Depth = 0;
            this.btnConsultaGeneral.HighEmphasis = true;
            this.btnConsultaGeneral.Icon = ((System.Drawing.Image)(resources.GetObject("btnConsultaGeneral.Icon")));
            this.btnConsultaGeneral.Location = new System.Drawing.Point(429, 66);
            this.btnConsultaGeneral.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnConsultaGeneral.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConsultaGeneral.Name = "btnConsultaGeneral";
            this.btnConsultaGeneral.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnConsultaGeneral.Size = new System.Drawing.Size(150, 50);
            this.btnConsultaGeneral.TabIndex = 88;
            this.btnConsultaGeneral.Text = "Buscar";
            this.btnConsultaGeneral.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConsultaGeneral.UseAccentColor = true;
            this.btnConsultaGeneral.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idConsulta,
            this.num_Expediente,
            this.fecha});
            this.dataGridView1.Location = new System.Drawing.Point(31, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1116, 170);
            this.dataGridView1.TabIndex = 87;
            // 
            // idConsulta
            // 
            this.idConsulta.HeaderText = "IdConsulta";
            this.idConsulta.MinimumWidth = 6;
            this.idConsulta.Name = "idConsulta";
            this.idConsulta.ReadOnly = true;
            this.idConsulta.Width = 125;
            // 
            // num_Expediente
            // 
            this.num_Expediente.HeaderText = "No. Expediente";
            this.num_Expediente.MinimumWidth = 6;
            this.num_Expediente.Name = "num_Expediente";
            this.num_Expediente.ReadOnly = true;
            this.num_Expediente.Width = 125;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha ";
            this.fecha.MinimumWidth = 6;
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 125;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.ForeColor = System.Drawing.Color.Green;
            this.materialLabel1.HighEmphasis = true;
            this.materialLabel1.Location = new System.Drawing.Point(26, 14);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(190, 29);
            this.materialLabel1.TabIndex = 86;
            this.materialLabel1.Text = "Consulta General:";
            this.materialLabel1.UseAccent = true;
            // 
            // txtNoNomina
            // 
            this.txtNoNomina.AnimateReadOnly = false;
            this.txtNoNomina.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNoNomina.Depth = 0;
            this.txtNoNomina.Enabled = false;
            this.txtNoNomina.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNoNomina.Hint = "Número de Nomina: ";
            this.txtNoNomina.LeadingIcon = null;
            this.txtNoNomina.Location = new System.Drawing.Point(31, 66);
            this.txtNoNomina.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoNomina.MaxLength = 18;
            this.txtNoNomina.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNoNomina.Multiline = false;
            this.txtNoNomina.Name = "txtNoNomina";
            this.txtNoNomina.Size = new System.Drawing.Size(353, 50);
            this.txtNoNomina.TabIndex = 85;
            this.txtNoNomina.Text = "";
            this.txtNoNomina.TrailingIcon = null;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.btnConsultaIndividual);
            this.materialCard2.Controls.Add(this.materialLabel2);
            this.materialCard2.Controls.Add(this.richTextBox2);
            this.materialCard2.Controls.Add(this.materialLabel4);
            this.materialCard2.Controls.Add(this.materialLabel3);
            this.materialCard2.Controls.Add(this.richTextBox1);
            this.materialCard2.Controls.Add(this.materialComboBox1);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(23, 377);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(1172, 533);
            this.materialCard2.TabIndex = 87;
            // 
            // btnConsultaIndividual
            // 
            this.btnConsultaIndividual.AutoSize = false;
            this.btnConsultaIndividual.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConsultaIndividual.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConsultaIndividual.Depth = 0;
            this.btnConsultaIndividual.HighEmphasis = true;
            this.btnConsultaIndividual.Icon = ((System.Drawing.Image)(resources.GetObject("btnConsultaIndividual.Icon")));
            this.btnConsultaIndividual.Location = new System.Drawing.Point(429, 73);
            this.btnConsultaIndividual.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnConsultaIndividual.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConsultaIndividual.Name = "btnConsultaIndividual";
            this.btnConsultaIndividual.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnConsultaIndividual.Size = new System.Drawing.Size(150, 50);
            this.btnConsultaIndividual.TabIndex = 92;
            this.btnConsultaIndividual.Text = "Buscar";
            this.btnConsultaIndividual.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConsultaIndividual.UseAccentColor = true;
            this.btnConsultaIndividual.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel2.ForeColor = System.Drawing.Color.Green;
            this.materialLabel2.HighEmphasis = true;
            this.materialLabel2.Location = new System.Drawing.Point(26, 21);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(212, 29);
            this.materialLabel2.TabIndex = 91;
            this.materialLabel2.Text = "Consulta Individual:";
            this.materialLabel2.UseAccent = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(620, 197);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(527, 310);
            this.richTextBox2.TabIndex = 90;
            this.richTextBox2.Text = "";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.ForeColor = System.Drawing.Color.Green;
            this.materialLabel4.HighEmphasis = true;
            this.materialLabel4.Location = new System.Drawing.Point(616, 152);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(138, 24);
            this.materialLabel4.TabIndex = 89;
            this.materialLabel4.Text = "Observaciones:";
            this.materialLabel4.UseAccent = true;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.ForeColor = System.Drawing.Color.Green;
            this.materialLabel3.HighEmphasis = true;
            this.materialLabel3.Location = new System.Drawing.Point(27, 152);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(111, 24);
            this.materialLabel3.TabIndex = 88;
            this.materialLabel3.Text = "Diagnóstico:";
            this.materialLabel3.UseAccent = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(31, 197);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(527, 310);
            this.richTextBox1.TabIndex = 87;
            this.richTextBox1.Text = "";
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.Hint = "Id. Consulta:";
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Location = new System.Drawing.Point(31, 73);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(353, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 86;
            // 
            // frmConsultaHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 778);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmConsultaHistorico";
            this.Load += new System.EventHandler(this.frmConsultaHistorico_Load);
            this.panel1.ResumeLayout(false);
            this.pContenedor.ResumeLayout(false);
            this.pConsultaHistoricos.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pContenedor;
        private System.Windows.Forms.Panel pConsultaHistoricos;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialButton btnConsultaIndividual;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton btnConsultaGeneral;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_Expediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtNoNomina;
    }
}