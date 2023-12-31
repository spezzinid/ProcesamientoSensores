﻿namespace ProcesamientoDatosSensores
{
    partial class frmProcesamientoSensores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcesamientoSensores));
            this.grparchivojson = new System.Windows.Forms.GroupBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.txtPathJson = new System.Windows.Forms.TextBox();
            this.clbArchivosSalida = new System.Windows.Forms.CheckedListBox();
            this.grpbotonera = new System.Windows.Forms.GroupBox();
            this.btnResumenSesores = new System.Windows.Forms.Button();
            this.btnGenerarArchivos = new System.Windows.Forms.Button();
            this.btnAgregarArchivoSalida = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grparchivojson.SuspendLayout();
            this.grpbotonera.SuspendLayout();
            this.SuspendLayout();
            // 
            // grparchivojson
            // 
            this.grparchivojson.Controls.Add(this.btnExaminar);
            this.grparchivojson.Controls.Add(this.txtPathJson);
            this.grparchivojson.Location = new System.Drawing.Point(5, 1);
            this.grparchivojson.Name = "grparchivojson";
            this.grparchivojson.Size = new System.Drawing.Size(358, 47);
            this.grparchivojson.TabIndex = 0;
            this.grparchivojson.TabStop = false;
            this.grparchivojson.Text = "Seleccione el archivo en formato json con información de sensores";
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(236, 16);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(118, 21);
            this.btnExaminar.TabIndex = 1;
            this.btnExaminar.Text = "EXAMINAR";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // txtPathJson
            // 
            this.txtPathJson.Location = new System.Drawing.Point(11, 16);
            this.txtPathJson.Name = "txtPathJson";
            this.txtPathJson.ReadOnly = true;
            this.txtPathJson.Size = new System.Drawing.Size(219, 20);
            this.txtPathJson.TabIndex = 0;
            this.txtPathJson.Enter += new System.EventHandler(this.txtPathJson_Enter);
            // 
            // clbArchivosSalida
            // 
            this.clbArchivosSalida.FormattingEnabled = true;
            this.clbArchivosSalida.Location = new System.Drawing.Point(5, 62);
            this.clbArchivosSalida.Name = "clbArchivosSalida";
            this.clbArchivosSalida.Size = new System.Drawing.Size(200, 124);
            this.clbArchivosSalida.TabIndex = 1;
            // 
            // grpbotonera
            // 
            this.grpbotonera.Controls.Add(this.btnResumenSesores);
            this.grpbotonera.Controls.Add(this.btnGenerarArchivos);
            this.grpbotonera.Controls.Add(this.btnAgregarArchivoSalida);
            this.grpbotonera.Location = new System.Drawing.Point(211, 56);
            this.grpbotonera.Name = "grpbotonera";
            this.grpbotonera.Size = new System.Drawing.Size(152, 130);
            this.grpbotonera.TabIndex = 2;
            this.grpbotonera.TabStop = false;
            // 
            // btnResumenSesores
            // 
            this.btnResumenSesores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResumenSesores.Location = new System.Drawing.Point(6, 48);
            this.btnResumenSesores.Name = "btnResumenSesores";
            this.btnResumenSesores.Size = new System.Drawing.Size(142, 34);
            this.btnResumenSesores.TabIndex = 3;
            this.btnResumenSesores.Text = "RESUMEN SENSORES";
            this.btnResumenSesores.UseVisualStyleBackColor = true;
            this.btnResumenSesores.Click += new System.EventHandler(this.btnResumenSesores_Click);
            // 
            // btnGenerarArchivos
            // 
            this.btnGenerarArchivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarArchivos.Location = new System.Drawing.Point(6, 88);
            this.btnGenerarArchivos.Name = "btnGenerarArchivos";
            this.btnGenerarArchivos.Size = new System.Drawing.Size(142, 34);
            this.btnGenerarArchivos.TabIndex = 2;
            this.btnGenerarArchivos.Text = "GENERAR ARCHIVOS";
            this.btnGenerarArchivos.UseVisualStyleBackColor = true;
            this.btnGenerarArchivos.Click += new System.EventHandler(this.btnGenerarArchivos_Click);
            // 
            // btnAgregarArchivoSalida
            // 
            this.btnAgregarArchivoSalida.Location = new System.Drawing.Point(6, 16);
            this.btnAgregarArchivoSalida.Name = "btnAgregarArchivoSalida";
            this.btnAgregarArchivoSalida.Size = new System.Drawing.Size(142, 21);
            this.btnAgregarArchivoSalida.TabIndex = 0;
            this.btnAgregarArchivoSalida.Text = "Agregar Salida";
            this.btnAgregarArchivoSalida.UseVisualStyleBackColor = true;
            this.btnAgregarArchivoSalida.Click += new System.EventHandler(this.btnAgregarArchivoSalida_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Marque doble click";
            // 
            // frmProcesamientoSensores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 191);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpbotonera);
            this.Controls.Add(this.clbArchivosSalida);
            this.Controls.Add(this.grparchivojson);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProcesamientoSensores";
            this.Text = "Procesamiento Sensores";
            this.grparchivojson.ResumeLayout(false);
            this.grparchivojson.PerformLayout();
            this.grpbotonera.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grparchivojson;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.TextBox txtPathJson;
        private System.Windows.Forms.CheckedListBox clbArchivosSalida;
        private System.Windows.Forms.GroupBox grpbotonera;
        private System.Windows.Forms.Button btnResumenSesores;
        private System.Windows.Forms.Button btnGenerarArchivos;
        private System.Windows.Forms.Button btnAgregarArchivoSalida;
        private System.Windows.Forms.Label label1;
    }
}

