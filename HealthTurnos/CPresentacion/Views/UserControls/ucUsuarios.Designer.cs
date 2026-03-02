namespace CPresentacion.Views.UserControls
{
    partial class ucUsuarios
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
            this.textIdBuscar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BuBuscar = new FontAwesome.Sharp.IconButton();
            this.cbxRoles = new System.Windows.Forms.ComboBox();
            this.BuGuardar = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.texbNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textbIdEmpleado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textbPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textbUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textbIdUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.viewDatosUsuarios = new System.Windows.Forms.DataGridView();
            this.panelInfo.SuspendLayout();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewDatosUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // labelText
            // 
            this.labelText.Size = new System.Drawing.Size(326, 26);
            this.labelText.Text = "Gestión de usuarios del sistema";
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.textIdBuscar);
            this.panelContainer.Controls.Add(this.label7);
            this.panelContainer.Controls.Add(this.BuBuscar);
            this.panelContainer.Controls.Add(this.cbxRoles);
            this.panelContainer.Controls.Add(this.BuGuardar);
            this.panelContainer.Controls.Add(this.label4);
            this.panelContainer.Controls.Add(this.texbNombre);
            this.panelContainer.Controls.Add(this.label5);
            this.panelContainer.Controls.Add(this.textbIdEmpleado);
            this.panelContainer.Controls.Add(this.label6);
            this.panelContainer.Controls.Add(this.textbPass);
            this.panelContainer.Controls.Add(this.label3);
            this.panelContainer.Controls.Add(this.textbUsuario);
            this.panelContainer.Controls.Add(this.label2);
            this.panelContainer.Controls.Add(this.textbIdUsuario);
            this.panelContainer.Controls.Add(this.label1);
            this.panelContainer.Controls.Add(this.viewDatosUsuarios);
            // 
            // textIdBuscar
            // 
            this.textIdBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textIdBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textIdBuscar.Location = new System.Drawing.Point(661, 140);
            this.textIdBuscar.Name = "textIdBuscar";
            this.textIdBuscar.Size = new System.Drawing.Size(103, 26);
            this.textIdBuscar.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(657, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 21);
            this.label7.TabIndex = 48;
            this.label7.Text = "Id Empleado";
            // 
            // BuBuscar
            // 
            this.BuBuscar.BackColor = System.Drawing.Color.SeaGreen;
            this.BuBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuBuscar.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.BuBuscar.ForeColor = System.Drawing.Color.White;
            this.BuBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.BuBuscar.IconColor = System.Drawing.Color.White;
            this.BuBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BuBuscar.IconSize = 32;
            this.BuBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuBuscar.Location = new System.Drawing.Point(770, 119);
            this.BuBuscar.Name = "BuBuscar";
            this.BuBuscar.Size = new System.Drawing.Size(121, 47);
            this.BuBuscar.TabIndex = 47;
            this.BuBuscar.Text = "Buscar";
            this.BuBuscar.UseVisualStyleBackColor = false;
            this.BuBuscar.Click += new System.EventHandler(this.BuBuscar_Click);
            // 
            // cbxRoles
            // 
            this.cbxRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F);
            this.cbxRoles.FormattingEnabled = true;
            this.cbxRoles.Location = new System.Drawing.Point(439, 139);
            this.cbxRoles.Name = "cbxRoles";
            this.cbxRoles.Size = new System.Drawing.Size(190, 28);
            this.cbxRoles.TabIndex = 46;
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
            this.BuGuardar.TabIndex = 45;
            this.BuGuardar.Text = "Registrar";
            this.BuGuardar.UseVisualStyleBackColor = false;
            this.BuGuardar.Click += new System.EventHandler(this.BuGuardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(435, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 44;
            this.label4.Text = "Roles";
            // 
            // texbNombre
            // 
            this.texbNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texbNombre.Enabled = false;
            this.texbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.texbNombre.Location = new System.Drawing.Point(244, 140);
            this.texbNombre.Name = "texbNombre";
            this.texbNombre.Size = new System.Drawing.Size(190, 26);
            this.texbNombre.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(240, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 21);
            this.label5.TabIndex = 42;
            this.label5.Text = "Nombre Completo";
            // 
            // textbIdEmpleado
            // 
            this.textbIdEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbIdEmpleado.Enabled = false;
            this.textbIdEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textbIdEmpleado.Location = new System.Drawing.Point(49, 140);
            this.textbIdEmpleado.Name = "textbIdEmpleado";
            this.textbIdEmpleado.Size = new System.Drawing.Size(190, 26);
            this.textbIdEmpleado.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(45, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 21);
            this.label6.TabIndex = 40;
            this.label6.Text = "Id Empleado";
            // 
            // textbPass
            // 
            this.textbPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textbPass.Location = new System.Drawing.Point(439, 60);
            this.textbPass.Name = "textbPass";
            this.textbPass.Size = new System.Drawing.Size(190, 26);
            this.textbPass.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(435, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 38;
            this.label3.Text = "Contraseña";
            // 
            // textbUsuario
            // 
            this.textbUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbUsuario.Enabled = false;
            this.textbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textbUsuario.Location = new System.Drawing.Point(244, 60);
            this.textbUsuario.Name = "textbUsuario";
            this.textbUsuario.Size = new System.Drawing.Size(190, 26);
            this.textbUsuario.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(240, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 36;
            this.label2.Text = "Usuario";
            // 
            // textbIdUsuario
            // 
            this.textbIdUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbIdUsuario.Enabled = false;
            this.textbIdUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textbIdUsuario.Location = new System.Drawing.Point(49, 60);
            this.textbIdUsuario.Name = "textbIdUsuario";
            this.textbIdUsuario.Size = new System.Drawing.Size(190, 26);
            this.textbIdUsuario.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(45, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 34;
            this.label1.Text = "Id Usuario";
            // 
            // viewDatosUsuarios
            // 
            this.viewDatosUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewDatosUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.viewDatosUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewDatosUsuarios.Location = new System.Drawing.Point(49, 230);
            this.viewDatosUsuarios.Name = "viewDatosUsuarios";
            this.viewDatosUsuarios.Size = new System.Drawing.Size(842, 222);
            this.viewDatosUsuarios.TabIndex = 33;
            this.viewDatosUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewDatosUsuarios_CellDoubleClick);
            // 
            // ucUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ucUsuarios";
            this.VisibleChanged += new System.EventHandler(this.ucUsuarios_VisibleChanged);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewDatosUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textIdBuscar;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton BuBuscar;
        private System.Windows.Forms.ComboBox cbxRoles;
        private FontAwesome.Sharp.IconButton BuGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox texbNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textbIdEmpleado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textbPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbIdUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView viewDatosUsuarios;
    }
}
