namespace AppRadiobutton
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
            this.rdOption1 = new System.Windows.Forms.RadioButton();
            this.rdOption2 = new System.Windows.Forms.RadioButton();
            this.rdOption3 = new System.Windows.Forms.RadioButton();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdOption1
            // 
            this.rdOption1.AutoSize = true;
            this.rdOption1.Location = new System.Drawing.Point(99, 93);
            this.rdOption1.Name = "rdOption1";
            this.rdOption1.Size = new System.Drawing.Size(65, 17);
            this.rdOption1.TabIndex = 0;
            this.rdOption1.TabStop = true;
            this.rdOption1.Text = "640*480";
            this.rdOption1.UseVisualStyleBackColor = true;
            // 
            // rdOption2
            // 
            this.rdOption2.AutoSize = true;
            this.rdOption2.Location = new System.Drawing.Point(99, 140);
            this.rdOption2.Name = "rdOption2";
            this.rdOption2.Size = new System.Drawing.Size(65, 17);
            this.rdOption2.TabIndex = 1;
            this.rdOption2.TabStop = true;
            this.rdOption2.Text = "800*600";
            this.rdOption2.UseVisualStyleBackColor = true;
            // 
            // rdOption3
            // 
            this.rdOption3.AutoSize = true;
            this.rdOption3.Location = new System.Drawing.Point(99, 178);
            this.rdOption3.Name = "rdOption3";
            this.rdOption3.Size = new System.Drawing.Size(71, 17);
            this.rdOption3.TabIndex = 2;
            this.rdOption3.TabStop = true;
            this.rdOption3.Text = "1024*768";
            this.rdOption3.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(99, 218);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 438);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.rdOption3);
            this.Controls.Add(this.rdOption2);
            this.Controls.Add(this.rdOption1);
            this.Name = "Form1";
            this.Text = "Programa Resoluciones";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdOption1;
        private System.Windows.Forms.RadioButton rdOption2;
        private System.Windows.Forms.RadioButton rdOption3;
        private System.Windows.Forms.Button btnConfirmar;
    }
}

