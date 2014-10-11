namespace Appnombres
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
            this.lbldigite = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.cmbpaises = new System.Windows.Forms.ComboBox();
            this.btnmostar = new System.Windows.Forms.Button();
            this.lblpais = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbldigite
            // 
            this.lbldigite.AutoSize = true;
            this.lbldigite.Location = new System.Drawing.Point(23, 37);
            this.lbldigite.Name = "lbldigite";
            this.lbldigite.Size = new System.Drawing.Size(85, 13);
            this.lbldigite.TabIndex = 0;
            this.lbldigite.Text = "Digite el Nombre";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(126, 37);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 1;
            // 
            // cmbpaises
            // 
            this.cmbpaises.FormattingEnabled = true;
            this.cmbpaises.Items.AddRange(new object[] {
            "colombia",
            "venezuela",
            "brasil",
            "argentina",
            "cuba",
            "usa",
            "suecia",
            "alemania"});
            this.cmbpaises.Location = new System.Drawing.Point(126, 87);
            this.cmbpaises.Name = "cmbpaises";
            this.cmbpaises.Size = new System.Drawing.Size(121, 21);
            this.cmbpaises.TabIndex = 2;
            // 
            // btnmostar
            // 
            this.btnmostar.Location = new System.Drawing.Point(105, 157);
            this.btnmostar.Name = "btnmostar";
            this.btnmostar.Size = new System.Drawing.Size(75, 23);
            this.btnmostar.TabIndex = 3;
            this.btnmostar.Text = "mostrar";
            this.btnmostar.UseVisualStyleBackColor = true;
            this.btnmostar.Click += new System.EventHandler(this.btnmostar_Click);
            // 
            // lblpais
            // 
            this.lblpais.AutoSize = true;
            this.lblpais.Location = new System.Drawing.Point(23, 90);
            this.lblpais.Name = "lblpais";
            this.lblpais.Size = new System.Drawing.Size(90, 13);
            this.lblpais.TabIndex = 4;
            this.lblpais.Text = "Listado de Paises";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblpais);
            this.Controls.Add(this.btnmostar);
            this.Controls.Add(this.cmbpaises);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lbldigite);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "paises y nombre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldigite;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.ComboBox cmbpaises;
        private System.Windows.Forms.Button btnmostar;
        private System.Windows.Forms.Label lblpais;
    }
}

