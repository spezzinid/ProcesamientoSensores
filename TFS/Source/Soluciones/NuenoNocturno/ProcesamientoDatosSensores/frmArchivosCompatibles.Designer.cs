namespace ProcesamientoDatosSensores
{
    partial class frmArchivosCompatibles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArchivosCompatibles));
            this.btnconfirmar = new System.Windows.Forms.Button();
            this.lblcomentario = new System.Windows.Forms.Label();
            this.lblArchCom = new System.Windows.Forms.Label();
            this.clbArchivos = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.Location = new System.Drawing.Point(46, 131);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(114, 25);
            this.btnconfirmar.TabIndex = 7;
            this.btnconfirmar.Text = "Confirmar";
            this.btnconfirmar.UseVisualStyleBackColor = true;
            this.btnconfirmar.Click += new System.EventHandler(this.btnconfirmar_Click);
            // 
            // lblcomentario
            // 
            this.lblcomentario.AutoSize = true;
            this.lblcomentario.Location = new System.Drawing.Point(5, 20);
            this.lblcomentario.Name = "lblcomentario";
            this.lblcomentario.Size = new System.Drawing.Size(207, 13);
            this.lblcomentario.TabIndex = 6;
            this.lblcomentario.Text = "Marque(doble click) para agregar a la lista.";
            // 
            // lblArchCom
            // 
            this.lblArchCom.AutoSize = true;
            this.lblArchCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblArchCom.Location = new System.Drawing.Point(2, -1);
            this.lblArchCom.Name = "lblArchCom";
            this.lblArchCom.Size = new System.Drawing.Size(143, 17);
            this.lblArchCom.TabIndex = 5;
            this.lblArchCom.Text = "Archivos Compatibles";
            // 
            // clbArchivos
            // 
            this.clbArchivos.FormattingEnabled = true;
            this.clbArchivos.Location = new System.Drawing.Point(8, 43);
            this.clbArchivos.Name = "clbArchivos";
            this.clbArchivos.Size = new System.Drawing.Size(193, 79);
            this.clbArchivos.TabIndex = 4;
            // 
            // frmArchivosCompatibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 162);
            this.Controls.Add(this.btnconfirmar);
            this.Controls.Add(this.lblcomentario);
            this.Controls.Add(this.lblArchCom);
            this.Controls.Add(this.clbArchivos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmArchivosCompatibles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnconfirmar;
        private System.Windows.Forms.Label lblcomentario;
        private System.Windows.Forms.Label lblArchCom;
        private System.Windows.Forms.CheckedListBox clbArchivos;
    }
}