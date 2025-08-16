namespace Guia1._1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalcularCosto = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.tbValorDeFabricacion = new System.Windows.Forms.TextBox();
            this.nupModelo = new System.Windows.Forms.NumericUpDown();
            this.nupAño = new System.Windows.Forms.NumericUpDown();
            this.tbDepreciacion = new System.Windows.Forms.TextBox();
            this.tbVidaUtil = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAño)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo (año)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Año a calcular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor de fabricacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vida util (años)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tasa de depreciacion";
            // 
            // btnCalcularCosto
            // 
            this.btnCalcularCosto.Location = new System.Drawing.Point(92, 187);
            this.btnCalcularCosto.Name = "btnCalcularCosto";
            this.btnCalcularCosto.Size = new System.Drawing.Size(93, 23);
            this.btnCalcularCosto.TabIndex = 6;
            this.btnCalcularCosto.Text = "Calcular costo";
            this.btnCalcularCosto.UseVisualStyleBackColor = true;
            this.btnCalcularCosto.Click += new System.EventHandler(this.btnCalcularCosto_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Location = new System.Drawing.Point(222, 186);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(142, 31);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(100, 20);
            this.tbMarca.TabIndex = 8;
            // 
            // tbValorDeFabricacion
            // 
            this.tbValorDeFabricacion.Location = new System.Drawing.Point(174, 119);
            this.tbValorDeFabricacion.Name = "tbValorDeFabricacion";
            this.tbValorDeFabricacion.Size = new System.Drawing.Size(100, 20);
            this.tbValorDeFabricacion.TabIndex = 9;
            // 
            // nupModelo
            // 
            this.nupModelo.Location = new System.Drawing.Point(142, 56);
            this.nupModelo.Name = "nupModelo";
            this.nupModelo.Size = new System.Drawing.Size(120, 20);
            this.nupModelo.TabIndex = 10;
            this.nupModelo.ValueChanged += new System.EventHandler(this.nupModelo_ValueChanged);
            // 
            // nupAño
            // 
            this.nupAño.Location = new System.Drawing.Point(142, 87);
            this.nupAño.Name = "nupAño";
            this.nupAño.Size = new System.Drawing.Size(120, 20);
            this.nupAño.TabIndex = 11;
            // 
            // tbDepreciacion
            // 
            this.tbDepreciacion.Location = new System.Drawing.Point(407, 31);
            this.tbDepreciacion.Name = "tbDepreciacion";
            this.tbDepreciacion.Size = new System.Drawing.Size(100, 20);
            this.tbDepreciacion.TabIndex = 12;
            // 
            // tbVidaUtil
            // 
            this.tbVidaUtil.Location = new System.Drawing.Point(407, 57);
            this.tbVidaUtil.Name = "tbVidaUtil";
            this.tbVidaUtil.Size = new System.Drawing.Size(100, 20);
            this.tbVidaUtil.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 375);
            this.Controls.Add(this.tbVidaUtil);
            this.Controls.Add(this.tbDepreciacion);
            this.Controls.Add(this.nupAño);
            this.Controls.Add(this.nupModelo);
            this.Controls.Add(this.tbValorDeFabricacion);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCalcularCosto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calcular costo";
            ((System.ComponentModel.ISupportInitialize)(this.nupModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAño)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalcularCosto;
        private System.Windows.Forms.Button btnCerrar;
        public System.Windows.Forms.TextBox tbMarca;
        public System.Windows.Forms.NumericUpDown nupModelo;
        public System.Windows.Forms.NumericUpDown nupAño;
        public System.Windows.Forms.TextBox tbValorDeFabricacion;
        public System.Windows.Forms.TextBox tbDepreciacion;
        public System.Windows.Forms.TextBox tbVidaUtil;
    }
}

