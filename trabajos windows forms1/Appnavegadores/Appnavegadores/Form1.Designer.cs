namespace Appnavegadores
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
            this.chkChrome = new System.Windows.Forms.CheckBox();
            this.chkOpera = new System.Windows.Forms.CheckBox();
            this.chkExplorer = new System.Windows.Forms.CheckBox();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkChrome
            // 
            this.chkChrome.AutoSize = true;
            this.chkChrome.Location = new System.Drawing.Point(35, 36);
            this.chkChrome.Name = "chkChrome";
            this.chkChrome.Size = new System.Drawing.Size(62, 17);
            this.chkChrome.TabIndex = 0;
            this.chkChrome.Text = "Chrome";
            this.chkChrome.UseVisualStyleBackColor = true;
            // 
            // chkOpera
            // 
            this.chkOpera.AutoSize = true;
            this.chkOpera.Location = new System.Drawing.Point(35, 71);
            this.chkOpera.Name = "chkOpera";
            this.chkOpera.Size = new System.Drawing.Size(55, 17);
            this.chkOpera.TabIndex = 1;
            this.chkOpera.Text = "Opera";
            this.chkOpera.UseVisualStyleBackColor = true;
            // 
            // chkExplorer
            // 
            this.chkExplorer.AutoSize = true;
            this.chkExplorer.Location = new System.Drawing.Point(35, 114);
            this.chkExplorer.Name = "chkExplorer";
            this.chkExplorer.Size = new System.Drawing.Size(64, 17);
            this.chkExplorer.TabIndex = 2;
            this.chkExplorer.Text = "Explorer";
            this.chkExplorer.UseVisualStyleBackColor = true;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(35, 192);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(131, 23);
            this.btn.TabIndex = 3;
            this.btn.Text = "Mostrar exploradores";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 320);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.chkExplorer);
            this.Controls.Add(this.chkOpera);
            this.Controls.Add(this.chkChrome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkChrome;
        private System.Windows.Forms.CheckBox chkOpera;
        private System.Windows.Forms.CheckBox chkExplorer;
        private System.Windows.Forms.Button btn;
    }
}

