namespace CPresentacion.Views.UserControls
{
    partial class ucAsistentes
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BuGuardar = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textbEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textbApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textbIdEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.viewDatosAsistentes = new System.Windows.Forms.DataGridView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panelInfo.SuspendLayout();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewDatosAsistentes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelText
            // 
            this.labelText.Size = new System.Drawing.Size(224, 26);
            this.labelText.Text = "Gestión de asistentes";
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.comboBox2);
            this.panelContainer.Controls.Add(this.comboBox1);
            this.panelContainer.Controls.Add(this.BuGuardar);
            this.panelContainer.Controls.Add(this.label4);
            this.panelContainer.Controls.Add(this.label5);
            this.panelContainer.Controls.Add(this.textbEmail);
            this.panelContainer.Controls.Add(this.label6);
            this.panelContainer.Controls.Add(this.textbApellido);
            this.panelContainer.Controls.Add(this.label3);
            this.panelContainer.Controls.Add(this.textbNombre);
            this.panelContainer.Controls.Add(this.label2);
            this.panelContainer.Controls.Add(this.textbIdEmpleado);
            this.panelContainer.Controls.Add(this.label1);
            this.panelContainer.Controls.Add(this.viewDatosAsistentes);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(439, 139);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(190, 28);
            this.comboBox1.TabIndex = 43;
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
            this.BuGuardar.TabIndex = 42;
            this.BuGuardar.Text = "Registrar";
            this.BuGuardar.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(435, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 21);
            this.label4.TabIndex = 41;
            this.label4.Text = "Área";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(240, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 21);
            this.label5.TabIndex = 39;
            this.label5.Text = "Turno";
            // 
            // textbEmail
            // 
            this.textbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbEmail.Enabled = false;
            this.textbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textbEmail.Location = new System.Drawing.Point(49, 140);
            this.textbEmail.Name = "textbEmail";
            this.textbEmail.Size = new System.Drawing.Size(190, 26);
            this.textbEmail.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(45, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 21);
            this.label6.TabIndex = 37;
            this.label6.Text = "Email";
            // 
            // textbApellido
            // 
            this.textbApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textbApellido.Location = new System.Drawing.Point(439, 60);
            this.textbApellido.Name = "textbApellido";
            this.textbApellido.Size = new System.Drawing.Size(190, 26);
            this.textbApellido.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(435, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 35;
            this.label3.Text = "Apellido";
            // 
            // textbNombre
            // 
            this.textbNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textbNombre.Location = new System.Drawing.Point(244, 60);
            this.textbNombre.Name = "textbNombre";
            this.textbNombre.Size = new System.Drawing.Size(190, 26);
            this.textbNombre.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(240, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 33;
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
            this.textbIdEmpleado.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(45, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "Id Empleado";
            // 
            // viewDatosAsistentes
            // 
            this.viewDatosAsistentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewDatosAsistentes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.viewDatosAsistentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewDatosAsistentes.Location = new System.Drawing.Point(49, 230);
            this.viewDatosAsistentes.Name = "viewDatosAsistentes";
            this.viewDatosAsistentes.Size = new System.Drawing.Size(842, 222);
            this.viewDatosAsistentes.TabIndex = 30;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(244, 140);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(190, 28);
            this.comboBox2.TabIndex = 44;
            // 
            // ucAsistentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ucAsistentes";
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewDatosAsistentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private FontAwesome.Sharp.IconButton BuGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textbEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textbApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbIdEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView viewDatosAsistentes;
    }
}
