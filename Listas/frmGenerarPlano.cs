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
    public partial class frmGenerarPlano : Form
    {
        BindingList<Fuente> Fuentes ;
        BindingSource bs = new BindingSource();
        public frmGenerarPlano()
        {
            InitializeComponent();
        }

        private void frmGenerarPlano_Load(object sender, EventArgs e)
        {
            try
            {
                Fuentes = new BindingList<Fuente>( Funciones.getFuentes());
                bs.DataSource = Fuentes;
                gridDatos.DataSource = bs;               
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "SERFINANSA::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

  

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                List<String> Seleccionadas = (from fuente in Fuentes where fuente.seleccionado select fuente.codigo).ToList();               
                if (Seleccionadas.Count > 1) { MessageBox.Show("Solo puede seleccionar una sola fuente", "SERFINANSA::.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                SaveFileDialog sd = new SaveFileDialog();                
                DialogResult result = sd.ShowDialog();
                if (result != DialogResult.OK) return;                
                Funciones.generateFile(sd.FileName, Seleccionadas);
                MessageBox.Show("El archivo fué generado satisfactoriamente.", "SERFINANSA::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "SERFINANSA::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gridDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

          
        if ( e.ColumnIndex== 0 )// columna de checkbox
        {
            int currentcolumnclicked = e.ColumnIndex;
            int currentrowclicked = e.RowIndex;
            foreach (var x in Fuentes)
            {
                x.seleccionado = false;                
            }
            gridDatos.CurrentRow.Cells[0].Value = !(bool    )gridDatos.CurrentRow.Cells[0].Value;
            gridDatos.Refresh();
        }
    

        }
    }
}
