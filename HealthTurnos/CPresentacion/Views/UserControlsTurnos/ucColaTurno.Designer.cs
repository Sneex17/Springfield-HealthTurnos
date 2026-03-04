namespace CPresentacion.Views.UserControlsTurnos
{
    partial class ucColaTurno
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.viewDatosTurnos = new System.Windows.Forms.DataGridView();
            this.panelInfo.SuspendLayout();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewDatosTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // labelText
            // 
            this.labelText.Size = new System.Drawing.Size(155, 26);
            this.labelText.Text = "Cola de turnos";
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.viewDatosTurnos);
            this.panelContainer.VisibleChanged += new System.EventHandler(this.panelContainer_VisibleChanged);
            // 
            // viewDatosTurnos
            // 
            this.viewDatosTurnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewDatosTurnos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.viewDatosTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewDatosTurnos.Location = new System.Drawing.Point(47, 51);
            this.viewDatosTurnos.Name = "viewDatosTurnos";
            this.viewDatosTurnos.Size = new System.Drawing.Size(842, 393);
            this.viewDatosTurnos.TabIndex = 39;
            // 
            // ucColaTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ucColaTurno";
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewDatosTurnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView viewDatosTurnos;
    }
}
