using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProcesamientoDatosSensores
{
    public partial class frmArchivosCompatibles : Form
    {
        public List<string> seleccionados { get; set; }
        public frmArchivosCompatibles(CheckedListBox clbArchivosSalida)
        {
            InitializeComponent();
            seleccionados = new List<string>();
            CargarListaArchivos();
       }

        private void CargarListaArchivos()
        {
            int index = clbArchivos.Items.Add("XLS");
            clbArchivos.SetItemChecked(index, false);
            index = clbArchivos.Items.Add("TXT");
            clbArchivos.SetItemChecked(index, false);
          }
        
        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            MapearDatos();
            this.Close();
        }

        private void MapearDatos()
        {
            for (int i = 0; i < clbArchivos.CheckedItems.Count; i++)
            {
                seleccionados.Add(clbArchivos.CheckedItems[i].ToString());
            }
        }
    }
}
