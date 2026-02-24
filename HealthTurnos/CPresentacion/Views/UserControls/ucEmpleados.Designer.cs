namespace CPresentacion.Views.UserControls
{
    partial class ucEmpleados
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
            this.viewDatosEmpleados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textbIdEmpleado = new System.Windows.Forms.TextBox();
            this.textbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textbApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.texbTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textbEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateFechaIngerso = new System.Windows.Forms.DateTimePicker();
            this.BuGuardar = new FontAwesome.Sharp.IconButton();
            this.panelInfo.SuspendLayout();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewDatosEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // labelText
            // 
            this.labelText.Size = new System.Drawing.Size(233, 26);
            this.labelText.Text = "Gestión de empleados";
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.BuGuardar);
            this.panelContainer.Controls.Add(this.dateFechaIngerso);
            this.panelContainer.Controls.Add(this.label4);
            this.panelContainer.Controls.Add(this.texbTelefono);
            this.panelContainer.Controls.Add(this.label5);
            this.panelContainer.Controls.Add(this.textbEmail);
            this.panelContainer.Controls.Add(this.label6);
            this.panelContainer.Controls.Add(this.textbApellido);
            this.panelContainer.Controls.Add(this.label3);
            this.panelContainer.Controls.Add(this.textbNombre);
            this.panelContainer.Controls.Add(this.label2);
            this.panelContainer.Controls.Add(this.textbIdEmpleado);
            this.panelContainer.Controls.Add(this.label1);
            this.panelContainer.Controls.Add(this.viewDatosEmpleados);
            // 
            // viewDatosEmpleados
            // 
            this.viewDatosEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewDatosEmpleados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.viewDatosEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewDatosEmpleados.Location = new System.Drawing.Point(47, 224);
            this.viewDatosEmpleados.Name = "viewDatosEmpleados";
            this.viewDatosEmpleados.Size = new System.Drawing.Size(842, 222);
            this.viewDatosEmpleados.TabIndex = 0;
            this.viewDatosEmpleados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewDatosEmpleados_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(43, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id Empleado";
            // 
            // textbIdEmpleado
            // 
            this.textbIdEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbIdEmpleado.Enabled = false;
            this.textbIdEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textbIdEmpleado.Location = new System.Drawing.Point(47, 54);
            this.textbIdEmpleado.Name = "textbIdEmpleado";
            this.textbIdEmpleado.Size = new System.Drawing.Size(190, 26);
            this.textbIdEmpleado.TabIndex = 2;
            // 
            // textbNombre
            // 
            this.textbNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textbNombre.Location = new System.Drawing.Point(242, 54);
            this.textbNombre.Name = "textbNombre";
            this.textbNombre.Size = new System.Drawing.Size(190, 26);
            this.textbNombre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(238, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // textbApellido
            // 
            this.textbApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textbApellido.Location = new System.Drawing.Point(437, 54);
            this.textbApellido.Name = "textbApellido";
            this.textbApellido.Size = new System.Drawing.Size(190, 26);
            this.textbApellido.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(433, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(433, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fecha de ingreso";
            // 
            // texbTelefono
            // 
            this.texbTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.texbTelefono.Location = new System.Drawing.Point(242, 134);
            this.texbTelefono.Name = "texbTelefono";
            this.texbTelefono.Size = new System.Drawing.Size(190, 26);
            this.texbTelefono.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(238, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Telefóno";
            // 
            // textbEmail
            // 
            this.textbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbEmail.Enabled = false;
            this.textbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textbEmail.Location = new System.Drawing.Point(47, 134);
            this.textbEmail.Name = "textbEmail";
            this.textbEmail.Size = new System.Drawing.Size(190, 26);
            this.textbEmail.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(43, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Email";
            // 
            // dateFechaIngerso
            // 
            this.dateFechaIngerso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.dateFechaIngerso.Location = new System.Drawing.Point(437, 134);
            this.dateFechaIngerso.Name = "dateFechaIngerso";
            this.dateFechaIngerso.Size = new System.Drawing.Size(190, 26);
            this.dateFechaIngerso.TabIndex = 13;
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
            this.BuGuardar.Location = new System.Drawing.Point(710, 47);
            this.BuGuardar.Name = "BuGuardar";
            this.BuGuardar.Size = new System.Drawing.Size(179, 47);
            this.BuGuardar.TabIndex = 14;
            this.BuGuardar.Text = "Registrar";
            this.BuGuardar.UseVisualStyleBackColor = false;
            this.BuGuardar.Click += new System.EventHandler(this.BuGuardar_Click);
            // 
            // ucEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ucEmpleados";
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewDatosEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView viewDatosEmpleados;
        private System.Windows.Forms.TextBox textbIdEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateFechaIngerso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox texbTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textbEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textbApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbNombre;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton BuGuardar;
    }
}
