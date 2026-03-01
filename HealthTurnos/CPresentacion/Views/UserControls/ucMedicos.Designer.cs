namespace CPresentacion.Views.UserControls
{
    partial class ucMedicos
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
            this.label4 = new System.Windows.Forms.Label();
            this.texbNLicencia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textbEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textbApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textbIdEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.viewDatosMedicos = new System.Windows.Forms.DataGridView();
            this.cbxEspecialidad = new System.Windows.Forms.ComboBox();
            this.BuBuscar = new FontAwesome.Sharp.IconButton();
            this.textIdBuscar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.materialSwitchActualizar = new MaterialSkin.Controls.MaterialSwitch();
            this.panelInfo.SuspendLayout();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewDatosMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // labelText
            // 
            this.labelText.Size = new System.Drawing.Size(207, 26);
            this.labelText.Text = "Gestión de médicos";
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.materialSwitchActualizar);
            this.panelContainer.Controls.Add(this.textIdBuscar);
            this.panelContainer.Controls.Add(this.label7);
            this.panelContainer.Controls.Add(this.BuBuscar);
            this.panelContainer.Controls.Add(this.cbxEspecialidad);
            this.panelContainer.Controls.Add(this.BuGuardar);
            this.panelContainer.Controls.Add(this.label4);
            this.panelContainer.Controls.Add(this.texbNLicencia);
            this.panelContainer.Controls.Add(this.label5);
            this.panelContainer.Controls.Add(this.textbEmail);
            this.panelContainer.Controls.Add(this.label6);
            this.panelContainer.Controls.Add(this.textbApellido);
            this.panelContainer.Controls.Add(this.label3);
            this.panelContainer.Controls.Add(this.textbNombre);
            this.panelContainer.Controls.Add(this.label2);
            this.panelContainer.Controls.Add(this.textbIdEmpleado);
            this.panelContainer.Controls.Add(this.label1);
            this.panelContainer.Controls.Add(this.viewDatosMedicos);
            this.panelContainer.VisibleChanged += new System.EventHandler(this.panelContainer_VisibleChanged);
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
            this.BuGuardar.TabIndex = 28;
            this.BuGuardar.Text = "Guardar";
            this.BuGuardar.UseVisualStyleBackColor = false;
            this.BuGuardar.Click += new System.EventHandler(this.BuGuardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(435, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 21);
            this.label4.TabIndex = 26;
            this.label4.Text = "Especialidad";
            // 
            // texbNLicencia
            // 
            this.texbNLicencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texbNLicencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.texbNLicencia.Location = new System.Drawing.Point(244, 140);
            this.texbNLicencia.Name = "texbNLicencia";
            this.texbNLicencia.Size = new System.Drawing.Size(190, 26);
            this.texbNLicencia.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(240, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 21);
            this.label5.TabIndex = 24;
            this.label5.Text = "N Licencia";
            // 
            // textbEmail
            // 
            this.textbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbEmail.Enabled = false;
            this.textbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textbEmail.Location = new System.Drawing.Point(49, 140);
            this.textbEmail.Name = "textbEmail";
            this.textbEmail.Size = new System.Drawing.Size(190, 26);
            this.textbEmail.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(45, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 21);
            this.label6.TabIndex = 22;
            this.label6.Text = "Email";
            // 
            // textbApellido
            // 
            this.textbApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbApellido.Enabled = false;
            this.textbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textbApellido.Location = new System.Drawing.Point(439, 60);
            this.textbApellido.Name = "textbApellido";
            this.textbApellido.Size = new System.Drawing.Size(190, 26);
            this.textbApellido.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(435, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Apellido";
            // 
            // textbNombre
            // 
            this.textbNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbNombre.Enabled = false;
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
            // textbIdEmpleado
            // 
            this.textbIdEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbIdEmpleado.Enabled = false;
            this.textbIdEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textbIdEmpleado.Location = new System.Drawing.Point(49, 60);
            this.textbIdEmpleado.Name = "textbIdEmpleado";
            this.textbIdEmpleado.Size = new System.Drawing.Size(190, 26);
            this.textbIdEmpleado.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(45, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Id Empleado";
            // 
            // viewDatosMedicos
            // 
            this.viewDatosMedicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewDatosMedicos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.viewDatosMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewDatosMedicos.Location = new System.Drawing.Point(49, 230);
            this.viewDatosMedicos.Name = "viewDatosMedicos";
            this.viewDatosMedicos.Size = new System.Drawing.Size(842, 222);
            this.viewDatosMedicos.TabIndex = 15;
            this.viewDatosMedicos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewDatosMedicos_CellDoubleClick);
            // 
            // cbxEspecialidad
            // 
            this.cbxEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F);
            this.cbxEspecialidad.FormattingEnabled = true;
            this.cbxEspecialidad.Location = new System.Drawing.Point(439, 139);
            this.cbxEspecialidad.Name = "cbxEspecialidad";
            this.cbxEspecialidad.Size = new System.Drawing.Size(190, 28);
            this.cbxEspecialidad.TabIndex = 29;
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
            this.BuBuscar.TabIndex = 30;
            this.BuBuscar.Text = "Buscar";
            this.BuBuscar.UseVisualStyleBackColor = false;
            this.BuBuscar.Click += new System.EventHandler(this.BuBuscar_Click);
            // 
            // textIdBuscar
            // 
            this.textIdBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textIdBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textIdBuscar.Location = new System.Drawing.Point(661, 140);
            this.textIdBuscar.Name = "textIdBuscar";
            this.textIdBuscar.Size = new System.Drawing.Size(103, 26);
            this.textIdBuscar.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(657, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 21);
            this.label7.TabIndex = 31;
            this.label7.Text = "Id Empleado";
            // 
            // materialSwitchActualizar
            // 
            this.materialSwitchActualizar.AutoSize = true;
            this.materialSwitchActualizar.Depth = 0;
            this.materialSwitchActualizar.Location = new System.Drawing.Point(712, 13);
            this.materialSwitchActualizar.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitchActualizar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitchActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitchActualizar.Name = "materialSwitchActualizar";
            this.materialSwitchActualizar.Ripple = true;
            this.materialSwitchActualizar.Size = new System.Drawing.Size(129, 37);
            this.materialSwitchActualizar.TabIndex = 34;
            this.materialSwitchActualizar.Text = "Actualizar";
            this.materialSwitchActualizar.UseVisualStyleBackColor = true;
            // 
            // ucMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ucMedicos";
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewDatosMedicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton BuGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox texbNLicencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textbEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textbApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbIdEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView viewDatosMedicos;
        private System.Windows.Forms.ComboBox cbxEspecialidad;
        private FontAwesome.Sharp.IconButton BuBuscar;
        private System.Windows.Forms.TextBox textIdBuscar;
        private System.Windows.Forms.Label label7;
        private MaterialSkin.Controls.MaterialSwitch materialSwitchActualizar;
    }
}
