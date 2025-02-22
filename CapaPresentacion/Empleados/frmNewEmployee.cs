using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using MaterialSkin;
using MaterialSkin.Controls;

namespace CapaPresentacion
{
    public partial class frmNewEmployee : MaterialForm  
    {
        public frmNewEmployee()
        {
            InitializeComponent();
            ConfigurarMaterialSkin();
            //RedondearPanel(panel2);
            
        }
        //private void RedondearPanel(Panel panel)
        //{
        //    GraphicsPath path = new GraphicsPath();
        //    int radio = 20; // Ajusta el radio según lo necesites

        //    path.AddArc(0, 0, radio, radio, 180, 90);
        //    path.AddArc(panel.Width - radio, 0, radio, radio, 270, 90);
        //    path.AddArc(panel.Width - radio, panel.Height - radio, radio, radio, 0, 90);
        //    path.AddArc(0, panel.Height - radio, radio, radio, 90, 90);
        //    path.CloseFigure();

        //    panel.Region = new Region(path);
        //}
        private void ConfigurarMaterialSkin()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this); 

            // Cambia los colores del tema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue600,   
                Primary.Blue700,
                Primary.Blue200,
                Accent.LightBlue200,
                TextShade.WHITE
            );
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;  // Puedes probar DARK
           }
    }
}
