namespace CPresentacion.Views.UserControlsMedicos
{
    partial class ucAtenderPaciente
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
            this.textbEstado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rbObservaciones = new System.Windows.Forms.RichTextBox();
            this.cbxProximoEstado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textbSexoPaciente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textbNombrePaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textbIdPaciente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BuFinalizar = new FontAwesome.Sharp.IconButton();
            this.textbFecha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.texbIdTurno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textbPrioridadPaciente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BuCargarPaciente = new FontAwesome.Sharp.IconButton();
            this.panelInfo.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInfo
            // 
            this.panelInfo.Size = new System.Drawing.Size(1664, 85);
            // 
            // labelText
            // 
            this.labelText.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelText.Size = new System.Drawing.Size(234, 33);
            this.labelText.Text = "Atender paciente";
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.BuCargarPaciente);
            this.panelContainer.Controls.Add(this.textbPrioridadPaciente);
            this.panelContainer.Controls.Add(this.label6);
            this.panelContainer.Controls.Add(this.textbFecha);
            this.panelContainer.Controls.Add(this.label4);
            this.panelContainer.Controls.Add(this.texbIdTurno);
            this.panelContainer.Controls.Add(this.label5);
            this.panelContainer.Controls.Add(this.BuFinalizar);
            this.panelContainer.Controls.Add(this.textbEstado);
            this.panelContainer.Controls.Add(this.label9);
            this.panelContainer.Controls.Add(this.label8);
            this.panelContainer.Controls.Add(this.rbObservaciones);
            this.panelContainer.Controls.Add(this.cbxProximoEstado);
            this.panelContainer.Controls.Add(this.label7);
            this.panelContainer.Controls.Add(this.textbSexoPaciente);
            this.panelContainer.Controls.Add(this.label3);
            this.panelContainer.Controls.Add(this.textbNombrePaciente);
            this.panelContainer.Controls.Add(this.label2);
            this.panelContainer.Controls.Add(this.textbIdPaciente);
            this.panelContainer.Controls.Add(this.label1);
            this.panelContainer.Size = new System.Drawing.Size(1664, 759);
            this.panelContainer.VisibleChanged += new System.EventHandler(this.panelContainer_VisibleChanged);
            // 
            // textbEstado
            // 
            this.textbEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbEstado.Enabled = false;
            this.textbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textbEstado.Location = new System.Drawing.Point(537, 188);
            this.textbEstado.Margin = new System.Windows.Forms.Padding(4);
            this.textbEstado.Name = "textbEstado";
            this.textbEstado.Size = new System.Drawing.Size(226, 31);
            this.textbEstado.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(532, 159);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 26);
            this.label9.TabIndex = 55;
            this.label9.Text = "Estado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(51, 159);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 26);
            this.label8.TabIndex = 54;
            this.label8.Text = "Observaciones";
            // 
            // rbObservaciones
            // 
            this.rbObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rbObservaciones.Location = new System.Drawing.Point(56, 194);
            this.rbObservaciones.Margin = new System.Windows.Forms.Padding(4);
            this.rbObservaciones.Name = "rbObservaciones";
            this.rbObservaciones.Size = new System.Drawing.Size(465, 105);
            this.rbObservaciones.TabIndex = 53;
            this.rbObservaciones.Text = "";
            // 
            // cbxProximoEstado
            // 
            this.cbxProximoEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F);
            this.cbxProximoEstado.FormattingEnabled = true;
            this.cbxProximoEstado.Location = new System.Drawing.Point(537, 266);
            this.cbxProximoEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cbxProximoEstado.Name = "cbxProximoEstado";
            this.cbxProximoEstado.Size = new System.Drawing.Size(225, 33);
            this.cbxProximoEstado.TabIndex = 52;
            this.cbxProximoEstado.Text = "Seleccionar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(532, 238);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 26);
            this.label7.TabIndex = 51;
            this.label7.Text = "Proximo estado";
            // 
            // textbSexoPaciente
            // 
            this.textbSexoPaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbSexoPaciente.Enabled = false;
            this.textbSexoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textbSexoPaciente.Location = new System.Drawing.Point(537, 116);
            this.textbSexoPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.textbSexoPaciente.Name = "textbSexoPaciente";
            this.textbSexoPaciente.Size = new System.Drawing.Size(226, 31);
            this.textbSexoPaciente.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(532, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 26);
            this.label3.TabIndex = 42;
            this.label3.Text = "Sexo";
            // 
            // textbNombrePaciente
            // 
            this.textbNombrePaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbNombrePaciente.Enabled = false;
            this.textbNombrePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textbNombrePaciente.Location = new System.Drawing.Point(296, 116);
            this.textbNombrePaciente.Margin = new System.Windows.Forms.Padding(4);
            this.textbNombrePaciente.Name = "textbNombrePaciente";
            this.textbNombrePaciente.Size = new System.Drawing.Size(226, 31);
            this.textbNombrePaciente.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(291, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 26);
            this.label2.TabIndex = 40;
            this.label2.Text = "Nombre";
            // 
            // textbIdPaciente
            // 
            this.textbIdPaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbIdPaciente.Enabled = false;
            this.textbIdPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textbIdPaciente.Location = new System.Drawing.Point(56, 116);
            this.textbIdPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.textbIdPaciente.Name = "textbIdPaciente";
            this.textbIdPaciente.Size = new System.Drawing.Size(226, 31);
            this.textbIdPaciente.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(51, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 26);
            this.label1.TabIndex = 38;
            this.label1.Text = "Id Paciente";
            // 
            // BuFinalizar
            // 
            this.BuFinalizar.BackColor = System.Drawing.Color.SeaGreen;
            this.BuFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuFinalizar.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.BuFinalizar.ForeColor = System.Drawing.Color.White;
            this.BuFinalizar.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            this.BuFinalizar.IconColor = System.Drawing.Color.White;
            this.BuFinalizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BuFinalizar.IconSize = 32;
            this.BuFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuFinalizar.Location = new System.Drawing.Point(917, 48);
            this.BuFinalizar.Margin = new System.Windows.Forms.Padding(4);
            this.BuFinalizar.Name = "BuFinalizar";
            this.BuFinalizar.Size = new System.Drawing.Size(273, 58);
            this.BuFinalizar.TabIndex = 58;
            this.BuFinalizar.Text = "Finalizar consulta";
            this.BuFinalizar.UseVisualStyleBackColor = false;
            this.BuFinalizar.Click += new System.EventHandler(this.BuFinalizar_Click);
            // 
            // textbFecha
            // 
            this.textbFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbFecha.Enabled = false;
            this.textbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textbFecha.Location = new System.Drawing.Point(296, 48);
            this.textbFecha.Margin = new System.Windows.Forms.Padding(4);
            this.textbFecha.Name = "textbFecha";
            this.textbFecha.Size = new System.Drawing.Size(226, 31);
            this.textbFecha.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(291, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 26);
            this.label4.TabIndex = 61;
            this.label4.Text = "Fecha";
            // 
            // texbIdTurno
            // 
            this.texbIdTurno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texbIdTurno.Enabled = false;
            this.texbIdTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.texbIdTurno.Location = new System.Drawing.Point(56, 48);
            this.texbIdTurno.Margin = new System.Windows.Forms.Padding(4);
            this.texbIdTurno.Name = "texbIdTurno";
            this.texbIdTurno.Size = new System.Drawing.Size(226, 31);
            this.texbIdTurno.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(51, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 26);
            this.label5.TabIndex = 59;
            this.label5.Text = "Id Turno";
            // 
            // textbPrioridadPaciente
            // 
            this.textbPrioridadPaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbPrioridadPaciente.Enabled = false;
            this.textbPrioridadPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textbPrioridadPaciente.Location = new System.Drawing.Point(537, 48);
            this.textbPrioridadPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.textbPrioridadPaciente.Name = "textbPrioridadPaciente";
            this.textbPrioridadPaciente.Size = new System.Drawing.Size(226, 31);
            this.textbPrioridadPaciente.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(532, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 26);
            this.label6.TabIndex = 63;
            this.label6.Text = "Prioridad";
            // 
            // BuCargarPaciente
            // 
            this.BuCargarPaciente.BackColor = System.Drawing.Color.SeaGreen;
            this.BuCargarPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuCargarPaciente.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.BuCargarPaciente.ForeColor = System.Drawing.Color.White;
            this.BuCargarPaciente.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
            this.BuCargarPaciente.IconColor = System.Drawing.Color.White;
            this.BuCargarPaciente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BuCargarPaciente.IconSize = 32;
            this.BuCargarPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuCargarPaciente.Location = new System.Drawing.Point(917, 143);
            this.BuCargarPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.BuCargarPaciente.Name = "BuCargarPaciente";
            this.BuCargarPaciente.Size = new System.Drawing.Size(273, 58);
            this.BuCargarPaciente.TabIndex = 65;
            this.BuCargarPaciente.Text = "Cargar paciente";
            this.BuCargarPaciente.UseVisualStyleBackColor = false;
            this.BuCargarPaciente.Click += new System.EventHandler(this.BuCargarPaciente_Click);
            // 
            // ucAtenderPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(1664, 844);
            this.MinimumSize = new System.Drawing.Size(1664, 844);
            this.Name = "ucAtenderPaciente";
            this.Size = new System.Drawing.Size(1664, 844);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton BuFinalizar;
        private System.Windows.Forms.TextBox textbEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rbObservaciones;
        private System.Windows.Forms.ComboBox cbxProximoEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textbSexoPaciente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbNombrePaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbIdPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox texbIdTurno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textbPrioridadPaciente;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton BuCargarPaciente;
    }
}
