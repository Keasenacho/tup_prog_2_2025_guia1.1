namespace Ejercicio3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbVerResumen = new System.Windows.Forms.ListBox();
            this.btnRegistrarPeaje = new System.Windows.Forms.Button();
            this.btnVerResumen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbVerResumen
            // 
            this.lbVerResumen.FormattingEnabled = true;
            this.lbVerResumen.Location = new System.Drawing.Point(64, 12);
            this.lbVerResumen.Name = "lbVerResumen";
            this.lbVerResumen.Size = new System.Drawing.Size(491, 368);
            this.lbVerResumen.TabIndex = 0;
            // 
            // btnRegistrarPeaje
            // 
            this.btnRegistrarPeaje.Location = new System.Drawing.Point(564, 78);
            this.btnRegistrarPeaje.Name = "btnRegistrarPeaje";
            this.btnRegistrarPeaje.Size = new System.Drawing.Size(116, 23);
            this.btnRegistrarPeaje.TabIndex = 1;
            this.btnRegistrarPeaje.Text = "Registrar Peaje";
            this.btnRegistrarPeaje.UseVisualStyleBackColor = true;
            this.btnRegistrarPeaje.Click += new System.EventHandler(this.btnRegistrarPeaje_Click);
            // 
            // btnVerResumen
            // 
            this.btnVerResumen.Location = new System.Drawing.Point(582, 107);
            this.btnVerResumen.Name = "btnVerResumen";
            this.btnVerResumen.Size = new System.Drawing.Size(98, 23);
            this.btnVerResumen.TabIndex = 2;
            this.btnVerResumen.Text = "VerResumen";
            this.btnVerResumen.UseVisualStyleBackColor = true;
            this.btnVerResumen.Click += new System.EventHandler(this.btnVerResumen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVerResumen);
            this.Controls.Add(this.btnRegistrarPeaje);
            this.Controls.Add(this.lbVerResumen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRegistrarPeaje;
        private System.Windows.Forms.Button btnVerResumen;
        public System.Windows.Forms.ListBox lbVerResumen;
    }
}

