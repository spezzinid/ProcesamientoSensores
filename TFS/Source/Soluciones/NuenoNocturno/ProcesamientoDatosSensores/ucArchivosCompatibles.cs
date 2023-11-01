using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProcesamientoDatosSensores
{
    public partial class ucArchivosCompatibles : UserControl
    {
        public ucArchivosCompatibles(CheckedListBox clbArchivosSalida)
        {
            InitializeComponent();

            int index = clbArchivos.Items.Add("XLS");
            clbArchivosSalida.SetItemChecked(index, false);
            index = clbArchivos.Items.Add("TXT");
            clbArchivos.SetItemChecked(index, false);
            index = clbArchivos.Items.Add("PDF");
            clbArchivos.SetItemChecked(index, false);
            index = clbArchivos.Items.Add("DOC");
            clbArchivos.SetItemChecked(index, false);
        }
    }
}
