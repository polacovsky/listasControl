using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Listas
{
    public partial class frmResumenLista : Form
    {
        private string Fuente;
        private BindingSource bsDatos = new BindingSource();
        private BindingList<NovedadCompilado> listaCompilado;

        public frmResumenLista(String Fuente)
        {
            InitializeComponent();
            this.Fuente = Fuente;
        }
        
        private void frmResumenLista_Load(object sender, EventArgs e)
        {
            listaCompilado = new BindingList<NovedadCompilado>(Funciones.get_ResumenLista( Fuente));
            bsDatos.DataSource = listaCompilado;
            gridDatos.AutoGenerateColumns = false;
            gridDatos.DataSource = bsDatos;
            lblTotalReg.Text =  (from m in listaCompilado select m.cantidad).Sum().ToString(); 
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
