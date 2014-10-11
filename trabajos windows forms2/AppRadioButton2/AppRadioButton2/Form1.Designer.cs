namespace AppRadioButton2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblnumero1 = new System.Windows.Forms.Label();
            this.lblnumero2 = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.numero1 = new System.Windows.Forms.TextBox();
            this.numero2 = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.TextBox();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.rdsuma = new System.Windows.Forms.RadioButton();
            this.rdresta = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblnumero1
            // 
            this.lblnumero1.AutoSize = true;
            this.lblnumero1.Location = new System.Drawing.Point(42, 48);
            this.lblnumero1.Name = "lblnumero1";
            this.lblnumero1.Size = new System.Drawing.Size(48, 13);
            this.lblnumero1.TabIndex = 0;
            this.lblnumero1.Text = "numero1";
            // 
            // lblnumero2
            // 
            this.lblnumero2.AutoSize = true;
            this.lblnumero2.Location = new System.Drawing.Point(42, 92);
            this.lblnumero2.Name = "lblnumero2";
            this.lblnumero2.Size = new System.Drawing.Size(48, 13);
            this.lblnumero2.TabIndex = 1;
            this.lblnumero2.Text = "numero2";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(40, 134);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(50, 13);
            this.lblresultado.TabIndex = 2;
            this.lblresultado.Text = "resultado";
            // 
            // numero1
            // 
            this.numero1.Location = new System.Drawing.Point(114, 48);
            this.numero1.Name = "numero1";
            this.numero1.Size = new System.Drawing.Size(100, 20);
            this.numero1.TabIndex = 3;
            this.numero1.Text = " ";
            // 
            // numero2
            // 
            this.numero2.Location = new System.Drawing.Point(114, 92);
            this.numero2.Name = "numero2";
            this.numero2.Size = new System.Drawing.Size(100, 20);
            this.numero2.TabIndex = 4;
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(114, 134);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(100, 20);
            this.resultado.TabIndex = 5;
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(294, 134);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(75, 23);
            this.btnmostrar.TabIndex = 6;
            this.btnmostrar.Text = "mostrar";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // rdsuma
            // 
            this.rdsuma.AutoSize = true;
            this.rdsuma.Location = new System.Drawing.Point(294, 44);
            this.rdsuma.Name = "rdsuma";
            this.rdsuma.Size = new System.Drawing.Size(50, 17);
            this.rdsuma.TabIndex = 7;
            this.rdsuma.TabStop = true;
            this.rdsuma.Text = "suma";
            this.rdsuma.UseVisualStyleBackColor = true;
            // 
            // rdresta
            // 
            this.rdresta.AutoSize = true;
            this.rdresta.Location = new System.Drawing.Point(294, 97);
            this.rdresta.Name = "rdresta";
            this.rdresta.Size = new System.Drawing.Size(48, 17);
            this.rdresta.TabIndex = 8;
            this.rdresta.TabStop = true;
            this.rdresta.Text = "resta";
            this.rdresta.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 262);
            this.Controls.Add(this.rdresta);
            this.Controls.Add(this.rdsuma);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.numero2);
            this.Controls.Add(this.numero1);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lblnumero2);
            this.Controls.Add(this.lblnumero1);
            this.Name = "Form1";
            this.Text = "suma y resta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnumero1;
        private System.Windows.Forms.Label lblnumero2;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.TextBox numero1;
        private System.Windows.Forms.TextBox numero2;
        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.RadioButton rdsuma;
        private System.Windows.Forms.RadioButton rdresta;
    }
}

