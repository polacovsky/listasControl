using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace App
{
    public partial class frmPrincipal : Form
    {
        MdiClient ctlMDI;
        
        #region "CONSTRUCTOR Y LOAD"
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            foreach (object ctl in this.Controls)
            {
                try
                {
                    ctlMDI = (MdiClient)ctl;
                    ctlMDI.Paint += PintarFondo;
                }
                catch (InvalidCastException)
                {
                }
            }
        }
        #endregion

        #region "EVENTOS MENU PRINCIPAL"
        private void origenesDeListasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listas.frmConfiguracionListas frm = new Listas.frmConfiguracionListas();
            frm.ShowDialog();
        }

        private void ofacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listas.frmCargarOfac frm = new Listas.frmCargarOfac();
            frm.MdiParent = this;
            frm.Show();
        }

         private void onuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listas.frmCargarOnu frm = new Listas.frmCargarOnu();
            frm.MdiParent = this;
            frm.Show();  
        }

         private void generarToolStripMenuItem_Click(object sender, EventArgs e)
         {
             Listas.frmGenerarPlano frm = new Listas.frmGenerarPlano();
             frm.MdiParent = this;
             frm.Show();  
         }
        #endregion
    
        #region "FUNCION PINTAR FONDO Y EVENTO RESIZE"
        private void PintarFondo(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            try
            {
                System.Drawing.Drawing2D.LinearGradientBrush GradientePanel = new System.Drawing.Drawing2D.LinearGradientBrush(new RectangleF(0, 0, ctlMDI.Width, ctlMDI.Height), Color.LightGray, Color.White, System.Drawing.Drawing2D.LinearGradientMode.Vertical);
                e.Graphics.FillRectangle(GradientePanel, new RectangleF(0, 0, ctlMDI.Width, ctlMDI.Height));
                Image img = App.Properties.Resources.logoserfinansa;
                e.Graphics.DrawImage(img, new Rectangle((ctlMDI.Width - 300), (ctlMDI.Height - 60), 242, 46));
            }
            catch (Exception)
            {
            }
        }

        private void frmPrincipal_Resize(object sender, System.EventArgs e)
        {
            try
            {
                if ((this.ctlMDI != null))
                {
                    this.PintarFondo(this.ctlMDI, new PaintEventArgs(this.ctlMDI.CreateGraphics(), new Rectangle(this.ctlMDI.Location, this.ctlMDI.Size)));
                }
            }
            catch (Exception)
            {
            }
        }
        #endregion

        #region "CERRAR"
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea salir de la aplicación?", "SERFINANSA::.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            Close();
        }
        #endregion

        private void generarHistoricosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listas.frmGenerarPlanoHistorico fr = new Listas.frmGenerarPlanoHistorico();
            fr.ShowDialog();
        }

        private void paisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuracion.frmPaises_IBS frm = new Configuracion.frmPaises_IBS();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tiposIdentificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuracion.frmTiposID_IBS frm = new Configuracion.frmTiposID_IBS();
            frm.MdiParent = this;
            frm.Show();
        }

        private void causalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuracion.frmCausales_IBS frm = new Configuracion.frmCausales_IBS();
            frm.MdiParent = this;
            frm.Show();
        }

        private void causalesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Configuracion.frmHomoCausales frm = new Configuracion.frmHomoCausales();
            frm.MdiParent = this;
            frm.Show();
            
        }

        private void tipoIdentificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuracion.frmHomoTiposID frm = new Configuracion.frmHomoTiposID();
            frm.MdiParent = this;
            frm.Show();
        }

        private void listaActualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listas.frmListaActual frm = new Listas.frmListaActual();
            frm.MdiParent = this;
            frm.Show();
            
        }

        private void paisesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Configuracion.frmHomoPaises frm = new Configuracion.frmHomoPaises();
            frm.MdiParent = this;
            frm.Show();
            
        }

        private void rutasDeLasListasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listas.frmConfiguracionListas frm = new Listas.frmConfiguracionListas();
            frm.MdiParent = this;
            frm.Show();
        }

     

    }
}
