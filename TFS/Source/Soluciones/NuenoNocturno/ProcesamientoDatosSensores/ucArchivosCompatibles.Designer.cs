namespace ProcesamientoDatosSensores
{
    partial class ucArchivosCompatibles
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.clbArchivos = new System.Windows.Forms.CheckedListBox();
            this.lblArchCom = new System.Windows.Forms.Label();
            this.lblcomentario = new System.Windows.Forms.Label();
            this.btnconfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clbArchivos
            // 
            this.clbArchivos.FormattingEnabled = true;
            this.clbArchivos.Location = new System.Drawing.Point(17, 57);
            this.clbArchivos.Name = "clbArchivos";
            this.clbArchivos.Size = new System.Drawing.Size(167, 124);
            this.clbArchivos.TabIndex = 0;
            // 
            // lblArchCom
            // 
            this.lblArchCom.AutoSize = true;
            this.lblArchCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblArchCom.Location = new System.Drawing.Point(14, 4);
            this.lblArchCom.Name = "lblArchCom";
            this.lblArchCom.Size = new System.Drawing.Size(143, 17);
            this.lblArchCom.TabIndex = 1;
            this.lblArchCom.Text = "Archivos Compatibles";
            // 
            // lblcomentario
            // 
            this.lblcomentario.AutoSize = true;
            this.lblcomentario.Location = new System.Drawing.Point(17, 25);
            this.lblcomentario.Name = "lblcomentario";
            this.lblcomentario.Size = new System.Drawing.Size(144, 13);
            this.lblcomentario.TabIndex = 2;
            this.lblcomentario.Text = "Maque para agregar a la lista";
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.Location = new System.Drawing.Point(43, 188);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(114, 25);
            this.btnconfirmar.TabIndex = 3;
            this.btnconfirmar.Text = "Confirmar";
            this.btnconfirmar.UseVisualStyleBackColor = true;
            // 
            // ucArchivosCompatibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnconfirmar);
            this.Controls.Add(this.lblcomentario);
            this.Controls.Add(this.lblArchCom);
            this.Controls.Add(this.clbArchivos);
            this.Name = "ucArchivosCompatibles";
            this.Size = new System.Drawing.Size(205, 216);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbArchivos;
        private System.Windows.Forms.Label lblArchCom;
        private System.Windows.Forms.Label lblcomentario;
        private System.Windows.Forms.Button btnconfirmar;
    }
}
