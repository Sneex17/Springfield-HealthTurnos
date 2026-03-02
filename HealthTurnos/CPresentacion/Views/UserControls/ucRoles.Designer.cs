namespace CPresentacion.Views.UserControls
{
    partial class ucRoles
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
            this.BuGuardar = new FontAwesome.Sharp.IconButton();
            this.textbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textbIdRol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.viewDatosRoles = new System.Windows.Forms.DataGridView();
            this.panelInfo.SuspendLayout();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewDatosRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // labelText
            // 
            this.labelText.Size = new System.Drawing.Size(290, 26);
            this.labelText.Text = "Gestión de roles de usuarios";
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.BuGuardar);
            this.panelContainer.Controls.Add(this.textbNombre);
            this.panelContainer.Controls.Add(this.label2);
            this.panelContainer.Controls.Add(this.textbIdRol);
            this.panelContainer.Controls.Add(this.label1);
            this.panelContainer.Controls.Add(this.viewDatosRoles);
            // 
            // BuGuardar
            // 
            this.BuGuardar.BackColor = System.Drawing.Color.SeaGreen;
            this.BuGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuGuardar.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.BuGuardar.ForeColor = System.Drawing.Color.White;
            this.BuGuardar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BuGuardar.IconColor = System.Drawing.Color.White;
            this.BuGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BuGuardar.IconSize = 32;
            this.BuGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuGuardar.Location = new System.Drawing.Point(712, 53);
            this.BuGuardar.Name = "BuGuardar";
            this.BuGuardar.Size = new System.Drawing.Size(179, 47);
            this.BuGuardar.TabIndex = 22;
            this.BuGuardar.Text = "Registrar";
            this.BuGuardar.UseVisualStyleBackColor = false;
            this.BuGuardar.Click += new System.EventHandler(this.BuGuardar_Click);
            // 
            // textbNombre
            // 
            this.textbNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textbNombre.Location = new System.Drawing.Point(244, 60);
            this.textbNombre.Name = "textbNombre";
            this.textbNombre.Size = new System.Drawing.Size(190, 26);
            this.textbNombre.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(240, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nombre";
            // 
            // textbIdRol
            // 
            this.textbIdRol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbIdRol.Enabled = false;
            this.textbIdRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textbIdRol.Location = new System.Drawing.Point(49, 60);
            this.textbIdRol.Name = "textbIdRol";
            this.textbIdRol.Size = new System.Drawing.Size(190, 26);
            this.textbIdRol.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(45, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Id Rol";
            // 
            // viewDatosRoles
            // 
            this.viewDatosRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewDatosRoles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.viewDatosRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewDatosRoles.Location = new System.Drawing.Point(49, 230);
            this.viewDatosRoles.Name = "viewDatosRoles";
            this.viewDatosRoles.Size = new System.Drawing.Size(842, 222);
            this.viewDatosRoles.TabIndex = 15;
            this.viewDatosRoles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewDatosRoles_CellDoubleClick);
            // 
            // ucRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ucRoles";
            this.VisibleChanged += new System.EventHandler(this.ucRoles_VisibleChanged);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewDatosRoles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton BuGuardar;
        private System.Windows.Forms.TextBox textbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbIdRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView viewDatosRoles;
    }
}
