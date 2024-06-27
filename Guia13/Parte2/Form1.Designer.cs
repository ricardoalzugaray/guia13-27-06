namespace Parte2
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
            this.btnAtencionCliente = new System.Windows.Forms.Button();
            this.btnVerResultados = new System.Windows.Forms.Button();
            this.btnPrepararDistribucion = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbCodigoPostal = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtencionCliente
            // 
            this.btnAtencionCliente.Location = new System.Drawing.Point(239, 26);
            this.btnAtencionCliente.Name = "btnAtencionCliente";
            this.btnAtencionCliente.Size = new System.Drawing.Size(134, 67);
            this.btnAtencionCliente.TabIndex = 0;
            this.btnAtencionCliente.Text = "Atención al Cliente";
            this.btnAtencionCliente.UseVisualStyleBackColor = true;
            // 
            // btnVerResultados
            // 
            this.btnVerResultados.Location = new System.Drawing.Point(227, 19);
            this.btnVerResultados.Name = "btnVerResultados";
            this.btnVerResultados.Size = new System.Drawing.Size(134, 63);
            this.btnVerResultados.TabIndex = 1;
            this.btnVerResultados.Text = "Ver Resultados";
            this.btnVerResultados.UseVisualStyleBackColor = true;
            // 
            // btnPrepararDistribucion
            // 
            this.btnPrepararDistribucion.Location = new System.Drawing.Point(227, 117);
            this.btnPrepararDistribucion.Name = "btnPrepararDistribucion";
            this.btnPrepararDistribucion.Size = new System.Drawing.Size(134, 61);
            this.btnPrepararDistribucion.TabIndex = 2;
            this.btnPrepararDistribucion.Text = "Preparar Dsitribución";
            this.btnPrepararDistribucion.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCodigoPostal);
            this.groupBox1.Controls.Add(this.btnVerResultados);
            this.groupBox1.Controls.Add(this.btnPrepararDistribucion);
            this.groupBox1.Location = new System.Drawing.Point(11, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 209);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Por Empresa de Distribución";
            // 
            // tbCodigoPostal
            // 
            this.tbCodigoPostal.Location = new System.Drawing.Point(6, 41);
            this.tbCodigoPostal.Name = "tbCodigoPostal";
            this.tbCodigoPostal.Size = new System.Drawing.Size(157, 20);
            this.tbCodigoPostal.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 316);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAtencionCliente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAtencionCliente;
        private System.Windows.Forms.Button btnVerResultados;
        private System.Windows.Forms.Button btnPrepararDistribucion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbCodigoPostal;
    }
}

