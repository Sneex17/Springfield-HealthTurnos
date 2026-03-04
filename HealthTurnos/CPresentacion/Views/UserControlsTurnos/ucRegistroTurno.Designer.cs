namespace CPresentacion.Views.UserControlsTurnos
{
    partial class ucRegistroTurno
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
            this.textbSexoPaciente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textbNombrePaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textbIdPaciente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textbEspecialidadMedico = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textbNombreMedico = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textbIdMedico = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BuBuscarPaciente = new FontAwesome.Sharp.IconButton();
            this.cbxProridad = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rbObservaciones = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textbEstado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BuBuscarMedico = new FontAwesome.Sharp.IconButton();
            this.BuGuardar = new FontAwesome.Sharp.IconButton();
            this.viewDatosTurnos = new System.Windows.Forms.DataGridView();
            this.panelInfo.SuspendLayout();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewDatosTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInfo
            // 
            this.panelInfo.Size = new System.Drawing.Size(1664, 85);
            // 
            // labelText
            // 
            this.labelText.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelText.Size = new System.Drawing.Size(187, 26);
            this.labelText.Text = "Gestión de turnos";
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.viewDatosTurnos);
            this.panelContainer.Controls.Add(this.BuGuardar);
            this.panelContainer.Controls.Add(this.BuBuscarMedico);
            this.panelContainer.Controls.Add(this.textbEstado);
            this.panelContainer.Controls.Add(this.label9);
            this.panelContainer.Controls.Add(this.label8);
            this.panelContainer.Controls.Add(this.rbObservaciones);
            this.panelContainer.Controls.Add(this.cbxProridad);
            this.panelContainer.Controls.Add(this.label7);
            this.panelContainer.Controls.Add(this.textbEspecialidadMedico);
            this.panelContainer.Controls.Add(this.label4);
            this.panelContainer.Controls.Add(this.textbNombreMedico);
            this.panelContainer.Controls.Add(this.label5);
            this.panelContainer.Controls.Add(this.textbIdMedico);
            this.panelContainer.Controls.Add(this.label6);
            this.panelContainer.Controls.Add(this.BuBuscarPaciente);
            this.panelContainer.Controls.Add(this.textbSexoPaciente);
            this.panelContainer.Controls.Add(this.label3);
            this.panelContainer.Controls.Add(this.textbNombrePaciente);
            this.panelContainer.Controls.Add(this.label2);
            this.panelContainer.Controls.Add(this.textbIdPaciente);
            this.panelContainer.Controls.Add(this.label1);
            this.panelContainer.Size = new System.Drawing.Size(1664, 759);
            // 
            // textbSexoPaciente
            // 
            this.textbSexoPaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbSexoPaciente.Enabled = false;
            this.textbSexoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textbSexoPaciente.Location = new System.Drawing.Point(547, 54);
            this.textbSexoPaciente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textbSexoPaciente.Name = "textbSexoPaciente";
            this.textbSexoPaciente.Size = new System.Drawing.Size(226, 26);
            this.textbSexoPaciente.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(541, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Sexo";
            // 
            // textbNombrePaciente
            // 
            this.textbNombrePaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbNombrePaciente.Enabled = false;
            this.textbNombrePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textbNombrePaciente.Location = new System.Drawing.Point(305, 54);
            this.textbNombrePaciente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textbNombrePaciente.Name = "textbNombrePaciente";
            this.textbNombrePaciente.Size = new System.Drawing.Size(226, 26);
            this.textbNombrePaciente.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(300, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre";
            // 
            // textbIdPaciente
            // 
            this.textbIdPaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbIdPaciente.Enabled = false;
            this.textbIdPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textbIdPaciente.Location = new System.Drawing.Point(65, 54);
            this.textbIdPaciente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textbIdPaciente.Name = "textbIdPaciente";
            this.textbIdPaciente.Size = new System.Drawing.Size(226, 26);
            this.textbIdPaciente.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(60, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Id Paciente";
            // 
            // textbEspecialidadMedico
            // 
            this.textbEspecialidadMedico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbEspecialidadMedico.Enabled = false;
            this.textbEspecialidadMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textbEspecialidadMedico.Location = new System.Drawing.Point(547, 134);
            this.textbEspecialidadMedico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textbEspecialidadMedico.Name = "textbEspecialidadMedico";
            this.textbEspecialidadMedico.Size = new System.Drawing.Size(226, 26);
            this.textbEspecialidadMedico.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(541, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 21);
            this.label4.TabIndex = 26;
            this.label4.Text = "Especialidad";
            // 
            // textbNombreMedico
            // 
            this.textbNombreMedico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbNombreMedico.Enabled = false;
            this.textbNombreMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textbNombreMedico.Location = new System.Drawing.Point(305, 134);
            this.textbNombreMedico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textbNombreMedico.Name = "textbNombreMedico";
            this.textbNombreMedico.Size = new System.Drawing.Size(226, 26);
            this.textbNombreMedico.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(300, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 21);
            this.label5.TabIndex = 24;
            this.label5.Text = "Nombre";
            // 
            // textbIdMedico
            // 
            this.textbIdMedico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbIdMedico.Enabled = false;
            this.textbIdMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textbIdMedico.Location = new System.Drawing.Point(65, 134);
            this.textbIdMedico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textbIdMedico.Name = "textbIdMedico";
            this.textbIdMedico.Size = new System.Drawing.Size(226, 26);
            this.textbIdMedico.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(60, 105);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 21);
            this.label6.TabIndex = 22;
            this.label6.Text = "Id Médico";
            // 
            // BuBuscarPaciente
            // 
            this.BuBuscarPaciente.BackColor = System.Drawing.Color.SeaGreen;
            this.BuBuscarPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuBuscarPaciente.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.BuBuscarPaciente.ForeColor = System.Drawing.Color.White;
            this.BuBuscarPaciente.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.BuBuscarPaciente.IconColor = System.Drawing.Color.White;
            this.BuBuscarPaciente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BuBuscarPaciente.IconSize = 32;
            this.BuBuscarPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuBuscarPaciente.Location = new System.Drawing.Point(952, 25);
            this.BuBuscarPaciente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BuBuscarPaciente.Name = "BuBuscarPaciente";
            this.BuBuscarPaciente.Size = new System.Drawing.Size(255, 58);
            this.BuBuscarPaciente.TabIndex = 21;
            this.BuBuscarPaciente.Text = "Buscar paciente";
            this.BuBuscarPaciente.UseVisualStyleBackColor = false;
            this.BuBuscarPaciente.Click += new System.EventHandler(this.BuBuscarPaciente_Click);
            // 
            // cbxProridad
            // 
            this.cbxProridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F);
            this.cbxProridad.FormattingEnabled = true;
            this.cbxProridad.Location = new System.Drawing.Point(547, 292);
            this.cbxProridad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxProridad.Name = "cbxProridad";
            this.cbxProridad.Size = new System.Drawing.Size(225, 28);
            this.cbxProridad.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(541, 263);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 21);
            this.label7.TabIndex = 30;
            this.label7.Text = "Prioridad";
            // 
            // rbObservaciones
            // 
            this.rbObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rbObservaciones.Location = new System.Drawing.Point(65, 220);
            this.rbObservaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbObservaciones.Name = "rbObservaciones";
            this.rbObservaciones.Size = new System.Drawing.Size(465, 105);
            this.rbObservaciones.TabIndex = 32;
            this.rbObservaciones.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(60, 185);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 21);
            this.label8.TabIndex = 33;
            this.label8.Text = "Observaciones";
            // 
            // textbEstado
            // 
            this.textbEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbEstado.Enabled = false;
            this.textbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textbEstado.Location = new System.Drawing.Point(547, 214);
            this.textbEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textbEstado.Name = "textbEstado";
            this.textbEstado.Size = new System.Drawing.Size(226, 26);
            this.textbEstado.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(541, 185);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 21);
            this.label9.TabIndex = 34;
            this.label9.Text = "Estado";
            // 
            // BuBuscarMedico
            // 
            this.BuBuscarMedico.BackColor = System.Drawing.Color.SeaGreen;
            this.BuBuscarMedico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuBuscarMedico.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.BuBuscarMedico.ForeColor = System.Drawing.Color.White;
            this.BuBuscarMedico.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.BuBuscarMedico.IconColor = System.Drawing.Color.White;
            this.BuBuscarMedico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BuBuscarMedico.IconSize = 32;
            this.BuBuscarMedico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuBuscarMedico.Location = new System.Drawing.Point(952, 91);
            this.BuBuscarMedico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BuBuscarMedico.Name = "BuBuscarMedico";
            this.BuBuscarMedico.Size = new System.Drawing.Size(255, 58);
            this.BuBuscarMedico.TabIndex = 36;
            this.BuBuscarMedico.Text = "Buscar médico";
            this.BuBuscarMedico.UseVisualStyleBackColor = false;
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
            this.BuGuardar.Location = new System.Drawing.Point(952, 202);
            this.BuGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BuGuardar.Name = "BuGuardar";
            this.BuGuardar.Size = new System.Drawing.Size(255, 58);
            this.BuGuardar.TabIndex = 37;
            this.BuGuardar.Text = "Registrar";
            this.BuGuardar.UseVisualStyleBackColor = false;
            this.BuGuardar.Click += new System.EventHandler(this.BuGuardar_Click);
            // 
            // viewDatosTurnos
            // 
            this.viewDatosTurnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewDatosTurnos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.viewDatosTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewDatosTurnos.Location = new System.Drawing.Point(63, 373);
            this.viewDatosTurnos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewDatosTurnos.Name = "viewDatosTurnos";
            this.viewDatosTurnos.Size = new System.Drawing.Size(1123, 181);
            this.viewDatosTurnos.TabIndex = 38;
            // 
            // ucRegistroTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximumSize = new System.Drawing.Size(1664, 844);
            this.MinimumSize = new System.Drawing.Size(1664, 844);
            this.Name = "ucRegistroTurno";
            this.Size = new System.Drawing.Size(1664, 844);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewDatosTurnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textbEspecialidadMedico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textbNombreMedico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textbIdMedico;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton BuBuscarPaciente;
        private System.Windows.Forms.TextBox textbSexoPaciente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbNombrePaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbIdPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxProridad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rbObservaciones;
        private FontAwesome.Sharp.IconButton BuGuardar;
        private FontAwesome.Sharp.IconButton BuBuscarMedico;
        private System.Windows.Forms.TextBox textbEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView viewDatosTurnos;
    }
}
