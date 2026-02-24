namespace CPresentacion.Plantillas
{
    partial class ucGestion
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
            this.panelInfo = new System.Windows.Forms.Panel();
            this.BuCerrarVentada = new FontAwesome.Sharp.IconButton();
            this.labelText = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelInfo.Controls.Add(this.BuCerrarVentada);
            this.panelInfo.Controls.Add(this.labelText);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(936, 69);
            this.panelInfo.TabIndex = 0;
            // 
            // BuCerrarVentada
            // 
            this.BuCerrarVentada.BackColor = System.Drawing.Color.Tan;
            this.BuCerrarVentada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuCerrarVentada.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.BuCerrarVentada.ForeColor = System.Drawing.Color.White;
            this.BuCerrarVentada.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.BuCerrarVentada.IconColor = System.Drawing.Color.White;
            this.BuCerrarVentada.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BuCerrarVentada.IconSize = 32;
            this.BuCerrarVentada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuCerrarVentada.Location = new System.Drawing.Point(784, 11);
            this.BuCerrarVentada.Name = "BuCerrarVentada";
            this.BuCerrarVentada.Size = new System.Drawing.Size(123, 47);
            this.BuCerrarVentada.TabIndex = 16;
            this.BuCerrarVentada.Text = "Cerrar";
            this.BuCerrarVentada.UseVisualStyleBackColor = false;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.ForeColor = System.Drawing.Color.White;
            this.labelText.Location = new System.Drawing.Point(84, 23);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(54, 26);
            this.labelText.TabIndex = 0;
            this.labelText.Text = "Text";
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 69);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(936, 488);
            this.panelContainer.TabIndex = 1;
            // 
            // ucGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelInfo);
            this.MaximumSize = new System.Drawing.Size(936, 557);
            this.MinimumSize = new System.Drawing.Size(936, 557);
            this.Name = "ucGestion";
            this.Size = new System.Drawing.Size(936, 557);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelInfo;
        public System.Windows.Forms.Label labelText;
        public System.Windows.Forms.Panel panelContainer;
        public FontAwesome.Sharp.IconButton BuCerrarVentada;
    }
}
