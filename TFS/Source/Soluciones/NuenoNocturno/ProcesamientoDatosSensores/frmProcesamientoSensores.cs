using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;




namespace ProcesamientoDatosSensores
{
    public partial class frmProcesamientoSensores : Form
    {
        public frmProcesamientoSensores()
        {
            InitializeComponent();
            CargarArchivosSalida();
        }

        private void CargarArchivosSalida()
        {
            int index = clbArchivosSalida.Items.Add("CSV");
            clbArchivosSalida.SetItemChecked(index, true);
            index = clbArchivosSalida.Items.Add("XML");
            clbArchivosSalida.SetItemChecked(index, false);
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            int size = -1; OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Seleccione archivo json info sensores";
            openFileDialog1.InitialDirectory = @"c:\";
            openFileDialog1.Filter = "JSON files (*.json)|*.json";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                this.txtPathJson.Text = file;
                try
                {
                    string text = File.ReadAllText(file); size = text.Length;

                }
                catch (IOException ex)
                {
                    throw ex;
                }
            }
        }

        private void txtPathJson_Enter(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            Control o = (Control)sender;
            if (o.Name == "txtPathJson")
            {
                tt.Show(this.txtPathJson.Text, o, 3000);
            }
        }

        private void btnResumenSesores_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtPathJson.Text != "")
                {
                    using (StreamReader jsonStream = File.OpenText(this.txtPathJson.Text))
                    {
                        var json = jsonStream.ReadToEnd();
                        DataTable dt = (DataTable)JsonConvert.DeserializeObject<DataTable>(json);
                        //aca es donde obtengo los valores de media y otros datos.
                        ResumenSensores resumen = ObtenerResumenSensores(dt);
                        string jsonWrite = JsonConvert.SerializeObject(resumen);

                        SaveFileDialog saveDialog = new SaveFileDialog();
                        saveDialog.InitialDirectory = @"C:\Users\user01\OneDrive\Documents";
                        saveDialog.Title = "Guardar Archivo Json Resumen de Sensores";
                        saveDialog.Filter = "JSON files (*.json)|*.json";
                        Stream fileStream;
                        if (saveDialog.ShowDialog() == DialogResult.OK)
                        {
                            if ((fileStream = saveDialog.OpenFile()) != null)
                            {
                                fileStream.Close();
                                System.IO.File.WriteAllText(saveDialog.FileName, jsonWrite); //escribo el archivo
                                MessageBox.Show("El archivo se generó correctamente.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                }
                else
                    MessageBox.Show("Seleccione un archivo json con información de sensores.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Archivo json no compatible. Error: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private ResumenSensores ObtenerResumenSensores(DataTable dt)
        {
            ResumenSensores resumen = new ResumenSensores();
            decimal sumatotalValores = 0; decimal sumatotalValoresZ1 = 0; decimal sumatotalValoresZ2 = 0;
            decimal sumatotalValoresZ3 = 0; decimal sumatotalValoresZ4 = 0; short cantZ1 = 0; short cantZ2 = 0;
            short cantZ3 = 0; short cantZ4 = 0; decimal valorMayor = 0; string idValorMayor = ""; short cantSensoresActivos = 0;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (Convert.ToDecimal(dt.Rows[i].ItemArray[4]) > valorMayor)
                {
                    valorMayor = Convert.ToDecimal(dt.Rows[i].ItemArray[4]);
                    idValorMayor = dt.Rows[i].ItemArray[1].ToString(); //id mayor valor
                }
                sumatotalValores += Convert.ToDecimal(dt.Rows[i].ItemArray[4]); // suma total de los valores
                switch (dt.Rows[i].ItemArray[3].ToString()) //sumas totales por 4 zonas.
                {
                    case ("Z01"): sumatotalValoresZ1 += Convert.ToDecimal(dt.Rows[i].ItemArray[4]); cantZ1++; break;
                    case ("Z02"): sumatotalValoresZ2 += Convert.ToDecimal(dt.Rows[i].ItemArray[4]); cantZ2++; break;
                    case ("Z03"): sumatotalValoresZ3 += Convert.ToDecimal(dt.Rows[i].ItemArray[4]); cantZ3++; break;
                    case ("Z04"): sumatotalValoresZ4 += Convert.ToDecimal(dt.Rows[i].ItemArray[4]); cantZ4++; break;
                }
                if (Convert.ToBoolean(dt.Rows[i].ItemArray[2])) // sensores activos
                    cantSensoresActivos++;
            }
            resumen.IdSensorMayorValor = idValorMayor;
            resumen.ValorMedio = sumatotalValores / dt.Rows.Count;
            resumen.ValorMedioZ1 = sumatotalValoresZ1 / cantZ1;
            resumen.ValorMedioZ2 = sumatotalValoresZ2 / cantZ2;
            resumen.ValorMedioZ3 = sumatotalValoresZ3 / cantZ3;
            resumen.ValorMedioZ4 = sumatotalValoresZ4 / cantZ4;
            resumen.CantSensoresActivos = cantSensoresActivos;
            return resumen;
        }

        private void btnGenerarArchivos_Click(object sender, EventArgs e)
        {
            if (this.txtPathJson.Text != "")
            {
                for (int i = 0; i < clbArchivosSalida.CheckedItems.Count; i++)
                {
                    switch (clbArchivosSalida.CheckedItems[i].ToString())
                    {
                        case ("CSV"): GenerarArchivoCSV(); break;
                        case ("XML"): GenerarArchivoXML(); break;
                        case ("XLS"): GenerarArchivoXLS(); break;
                        case ("TXT"): GenerarArchivoTXT(); break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un archivo json con información de sensores.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void GenerarArchivoXLS()
        {
            using (StreamReader jsonStream = File.OpenText(this.txtPathJson.Text))
            {
                var json = jsonStream.ReadToEnd();
                DataTable dt = (DataTable)JsonConvert.DeserializeObject<DataTable>(json);

                StringBuilder sb = new StringBuilder();
                foreach (DataColumn column in dt.Columns)
                {
                    sb.Append(column.ColumnName + ",");
                }
                sb.Remove(sb.Length - 1, 1);
                sb.Append(Environment.NewLine);

                foreach (DataRow row in dt.Rows)
                {
                    foreach (DataColumn column in dt.Columns)
                    {
                        sb.Append(row[column].ToString() + ",");
                    }
                    sb.Remove(sb.Length - 1, 1);
                    sb.Append(Environment.NewLine);
                }

                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.InitialDirectory = @"C:\Users\user01\OneDrive\Documents";
                saveDialog.Title = "Guardar";
                saveDialog.Filter = "XLS files (*.xls)|*.xls";
                Stream fileStream;
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    if ((fileStream = saveDialog.OpenFile()) != null)
                    {
                        fileStream.Close();
                        File.WriteAllText(saveDialog.FileName, sb.ToString()); //escribo el archivo
                        MessageBox.Show("El archivo se generó correctamente.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void GenerarArchivoTXT()
        {
            using (StreamReader jsonStream = File.OpenText(this.txtPathJson.Text))
            {
                var json = jsonStream.ReadToEnd();
                DataTable dt = (DataTable)JsonConvert.DeserializeObject<DataTable>(json);
                if (dt.Rows.Count != 0)
                {
                    SaveFileDialog saveDialog = new SaveFileDialog();
                    saveDialog.InitialDirectory = @"C:\Users\user01\OneDrive\Documents";
                    saveDialog.Title = "Guardar";
                    saveDialog.Filter = "TXT files (*.txt)|*.txt";
                    Stream fileStream;
                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        string nombreArchivo = saveDialog.FileName;
                        if ((fileStream = saveDialog.OpenFile()) != null)
                        {
                            int i = 0;
                            StreamWriter sw = null;
                            fileStream.Close();
                            sw = new StreamWriter(nombreArchivo, false);

                            for (i = 0; i < dt.Columns.Count - 1; i++)
                            {
                                sw.Write(dt.Columns[i].ColumnName + ",");
                            }
                            sw.Write(dt.Columns[i].ColumnName); //escribo el archivo
                            sw.WriteLine();

                            foreach (DataRow row in dt.Rows)
                            {
                                object[] array = row.ItemArray;

                                for (i = 0; i < array.Length - 1; i++)
                                {
                                    sw.Write(array[i].ToString() + ",");
                                }
                                sw.Write(array[i].ToString()); //escribo el archivo
                                sw.WriteLine(); 
                            }

                            sw.Close();
                            MessageBox.Show("El archivo se generó correctamente.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró información", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GenerarArchivoXML()
        {
            using (StreamReader jsonStream = File.OpenText(this.txtPathJson.Text))
            {
                var json = jsonStream.ReadToEnd();
                DataTable dt = (DataTable)JsonConvert.DeserializeObject<DataTable>(json);
                if (dt.Rows.Count != 0)
                {
                    SaveFileDialog saveDialog = new SaveFileDialog();
                    saveDialog.InitialDirectory = @"C:\Users\user01\OneDrive\Documents";
                    saveDialog.Title = "Guardar";
                    saveDialog.Filter = "XML files (*.xml)|*.xml";
                    Stream fileStream;
                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        if ((fileStream = saveDialog.OpenFile()) != null)
                        {
                            fileStream.Close();
                            DataSet dS = new DataSet();
                            dS.DataSetName = "RecordSet";
                            dS.Tables.Add(dt);
                            StringWriter sw = new StringWriter();
                            dS.WriteXml(sw, XmlWriteMode.IgnoreSchema); //escribo el archivo
                            string s = sw.ToString();
                            File.WriteAllText(saveDialog.FileName,s);
                            MessageBox.Show("El archivo se generó correctamente.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró información", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GenerarArchivoCSV()
        {
            using (StreamReader jsonStream = File.OpenText(this.txtPathJson.Text))
            {
                var json = jsonStream.ReadToEnd();
                DataTable dt = (DataTable)JsonConvert.DeserializeObject<DataTable>(json);

                StringBuilder sb = new StringBuilder();
                foreach (DataColumn column in dt.Columns)
                {
                    sb.Append(column.ColumnName + ",");
                }
                sb.Remove(sb.Length - 1, 1);
                sb.Append(Environment.NewLine);

                foreach (DataRow row in dt.Rows)
                {
                    foreach (DataColumn column in dt.Columns)
                    {
                        sb.Append(row[column].ToString() + ",");
                    }
                    sb.Remove(sb.Length - 1, 1);
                    sb.Append(Environment.NewLine);
                }

                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.InitialDirectory = @"C:\Users\user01\OneDrive\Documents";
                saveDialog.Title = "Guardar";
                saveDialog.Filter = "CSV files (*.csv)|*.csv";
                Stream fileStream;
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    if ((fileStream = saveDialog.OpenFile()) != null)
                    {
                        fileStream.Close();
                        File.WriteAllText(saveDialog.FileName, sb.ToString()); //escribo el archivo
                        MessageBox.Show("El archivo se generó correctamente.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void btnAgregarArchivoSalida_Click(object sender, EventArgs e)
        {
            frmArchivosCompatibles frmArchivosCompatibles = new frmArchivosCompatibles(this.clbArchivosSalida);
            frmArchivosCompatibles.ShowDialog();
            for (int i = 0; i < frmArchivosCompatibles.seleccionados.Count; i++)
            {
                if (!Existe(frmArchivosCompatibles.seleccionados[i]))
                {
                    clbArchivosSalida.Items.Add(frmArchivosCompatibles.seleccionados[i]);
                    clbArchivosSalida.Refresh();
                }
            }
        }

        private bool Existe(string p)
        {
            bool existe = false;
            for (int i = 0; i < clbArchivosSalida.Items.Count; i++)
            {
                if (clbArchivosSalida.Items[i].ToString() == p)
                    existe = true;
            }
            return existe;
        }

        
    }
}
