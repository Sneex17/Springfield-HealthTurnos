namespace CPresentacion.Views.UserControlsReportes
{
    partial class ucReportes
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
            this.panelControlReportes = new System.Windows.Forms.Panel();
            this.panelRangoFecha = new System.Windows.Forms.Panel();
            this.BuAplicarReportes = new ReaLTaiizor.Controls.CyberButton();
            this.dateTimeFrom = new ReaLTaiizor.Controls.PoisonDateTime();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeTo = new ReaLTaiizor.Controls.PoisonDateTime();
            this.label2 = new System.Windows.Forms.Label();
            this.BuReportesFechas = new ReaLTaiizor.Controls.CyberButton();
            this.BuRTurnosCancelados = new ReaLTaiizor.Controls.CyberButton();
            this.BuRTurnosAtendidos = new ReaLTaiizor.Controls.CyberButton();
            this.reportViewerGeneral = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelInfo.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.panelControlReportes.SuspendLayout();
            this.panelRangoFecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelText
            // 
            this.labelText.Size = new System.Drawing.Size(129, 33);
            this.labelText.Text = "Reportes";
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.reportViewerGeneral);
            // 
            // panelControlReportes
            // 
            this.panelControlReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(82)))), ((int)(((byte)(186)))));
            this.panelControlReportes.Controls.Add(this.panelRangoFecha);
            this.panelControlReportes.Controls.Add(this.BuReportesFechas);
            this.panelControlReportes.Controls.Add(this.BuRTurnosCancelados);
            this.panelControlReportes.Controls.Add(this.BuRTurnosAtendidos);
            this.panelControlReportes.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControlReportes.Location = new System.Drawing.Point(1026, 85);
            this.panelControlReportes.Name = "panelControlReportes";
            this.panelControlReportes.Size = new System.Drawing.Size(222, 601);
            this.panelControlReportes.TabIndex = 2;
            // 
            // panelRangoFecha
            // 
            this.panelRangoFecha.BackColor = System.Drawing.Color.Transparent;
            this.panelRangoFecha.Controls.Add(this.BuAplicarReportes);
            this.panelRangoFecha.Controls.Add(this.dateTimeFrom);
            this.panelRangoFecha.Controls.Add(this.label1);
            this.panelRangoFecha.Controls.Add(this.dateTimeTo);
            this.panelRangoFecha.Controls.Add(this.label2);
            this.panelRangoFecha.Location = new System.Drawing.Point(2, 167);
            this.panelRangoFecha.Name = "panelRangoFecha";
            this.panelRangoFecha.Size = new System.Drawing.Size(219, 190);
            this.panelRangoFecha.TabIndex = 15;
            this.panelRangoFecha.Visible = false;
            // 
            // BuAplicarReportes
            // 
            this.BuAplicarReportes.Alpha = 20;
            this.BuAplicarReportes.BackColor = System.Drawing.Color.Transparent;
            this.BuAplicarReportes.Background = true;
            this.BuAplicarReportes.Background_WidthPen = 4F;
            this.BuAplicarReportes.BackgroundPen = true;
            this.BuAplicarReportes.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(203)))));
            this.BuAplicarReportes.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(82)))), ((int)(((byte)(186)))));
            this.BuAplicarReportes.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(82)))), ((int)(((byte)(186)))));
            this.BuAplicarReportes.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(82)))), ((int)(((byte)(186)))));
            this.BuAplicarReportes.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(82)))), ((int)(((byte)(186)))));
            this.BuAplicarReportes.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.BuAplicarReportes.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.BuAplicarReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuAplicarReportes.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.BuAplicarReportes.Effect_1 = true;
            this.BuAplicarReportes.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BuAplicarReportes.Effect_1_Transparency = 25;
            this.BuAplicarReportes.Effect_2 = true;
            this.BuAplicarReportes.Effect_2_ColorBackground = System.Drawing.Color.White;
            this.BuAplicarReportes.Effect_2_Transparency = 20;
            this.BuAplicarReportes.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuAplicarReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.BuAplicarReportes.Lighting = false;
            this.BuAplicarReportes.LinearGradient_Background = false;
            this.BuAplicarReportes.LinearGradientPen = false;
            this.BuAplicarReportes.Location = new System.Drawing.Point(4, 129);
            this.BuAplicarReportes.Margin = new System.Windows.Forms.Padding(4);
            this.BuAplicarReportes.Name = "BuAplicarReportes";
            this.BuAplicarReportes.PenWidth = 15;
            this.BuAplicarReportes.Rounding = true;
            this.BuAplicarReportes.RoundingInt = 70;
            this.BuAplicarReportes.Size = new System.Drawing.Size(211, 44);
            this.BuAplicarReportes.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.BuAplicarReportes.TabIndex = 11;
            this.BuAplicarReportes.Tag = "Cyber";
            this.BuAplicarReportes.TextButton = "Aplicar";
            this.BuAplicarReportes.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BuAplicarReportes.Timer_Effect_1 = 5;
            this.BuAplicarReportes.Timer_RGB = 300;
            this.BuAplicarReportes.Click += new System.EventHandler(this.BuAplicarReportes_Click);
            // 
            // dateTimeFrom
            // 
            this.dateTimeFrom.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dateTimeFrom.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            this.dateTimeFrom.Location = new System.Drawing.Point(8, 37);
            this.dateTimeFrom.MinimumSize = new System.Drawing.Size(0, 30);
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.Size = new System.Drawing.Size(201, 30);
            this.dateTimeFrom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha de inicio";
            // 
            // dateTimeTo
            // 
            this.dateTimeTo.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dateTimeTo.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            this.dateTimeTo.Location = new System.Drawing.Point(8, 93);
            this.dateTimeTo.MinimumSize = new System.Drawing.Size(0, 30);
            this.dateTimeTo.Name = "dateTimeTo";
            this.dateTimeTo.Size = new System.Drawing.Size(201, 30);
            this.dateTimeTo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha de fin";
            // 
            // BuReportesFechas
            // 
            this.BuReportesFechas.Alpha = 20;
            this.BuReportesFechas.BackColor = System.Drawing.Color.Transparent;
            this.BuReportesFechas.Background = true;
            this.BuReportesFechas.Background_WidthPen = 4F;
            this.BuReportesFechas.BackgroundPen = true;
            this.BuReportesFechas.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(203)))));
            this.BuReportesFechas.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(82)))), ((int)(((byte)(186)))));
            this.BuReportesFechas.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(82)))), ((int)(((byte)(186)))));
            this.BuReportesFechas.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(82)))), ((int)(((byte)(186)))));
            this.BuReportesFechas.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(82)))), ((int)(((byte)(186)))));
            this.BuReportesFechas.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.BuReportesFechas.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.BuReportesFechas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuReportesFechas.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.BuReportesFechas.Effect_1 = true;
            this.BuReportesFechas.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BuReportesFechas.Effect_1_Transparency = 25;
            this.BuReportesFechas.Effect_2 = true;
            this.BuReportesFechas.Effect_2_ColorBackground = System.Drawing.Color.White;
            this.BuReportesFechas.Effect_2_Transparency = 20;
            this.BuReportesFechas.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuReportesFechas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.BuReportesFechas.Lighting = false;
            this.BuReportesFechas.LinearGradient_Background = false;
            this.BuReportesFechas.LinearGradientPen = false;
            this.BuReportesFechas.Location = new System.Drawing.Point(6, 125);
            this.BuReportesFechas.Margin = new System.Windows.Forms.Padding(4);
            this.BuReportesFechas.Name = "BuReportesFechas";
            this.BuReportesFechas.PenWidth = 15;
            this.BuReportesFechas.Rounding = true;
            this.BuReportesFechas.RoundingInt = 70;
            this.BuReportesFechas.Size = new System.Drawing.Size(211, 44);
            this.BuReportesFechas.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.BuReportesFechas.TabIndex = 14;
            this.BuReportesFechas.Tag = "Cyber";
            this.BuReportesFechas.TextButton = "Por rango de fecha";
            this.BuReportesFechas.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BuReportesFechas.Timer_Effect_1 = 5;
            this.BuReportesFechas.Timer_RGB = 300;
            this.BuReportesFechas.Click += new System.EventHandler(this.BuReportesFechas_Click);
            // 
            // BuRTurnosCancelados
            // 
            this.BuRTurnosCancelados.Alpha = 20;
            this.BuRTurnosCancelados.BackColor = System.Drawing.Color.Transparent;
            this.BuRTurnosCancelados.Background = true;
            this.BuRTurnosCancelados.Background_WidthPen = 4F;
            this.BuRTurnosCancelados.BackgroundPen = true;
            this.BuRTurnosCancelados.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(203)))));
            this.BuRTurnosCancelados.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(82)))), ((int)(((byte)(186)))));
            this.BuRTurnosCancelados.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(82)))), ((int)(((byte)(186)))));
            this.BuRTurnosCancelados.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(82)))), ((int)(((byte)(186)))));
            this.BuRTurnosCancelados.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(82)))), ((int)(((byte)(186)))));
            this.BuRTurnosCancelados.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.BuRTurnosCancelados.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.BuRTurnosCancelados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuRTurnosCancelados.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.BuRTurnosCancelados.Effect_1 = true;
            this.BuRTurnosCancelados.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BuRTurnosCancelados.Effect_1_Transparency = 25;
            this.BuRTurnosCancelados.Effect_2 = true;
            this.BuRTurnosCancelados.Effect_2_ColorBackground = System.Drawing.Color.White;
            this.BuRTurnosCancelados.Effect_2_Transparency = 20;
            this.BuRTurnosCancelados.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuRTurnosCancelados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.BuRTurnosCancelados.Lighting = false;
            this.BuRTurnosCancelados.LinearGradient_Background = false;
            this.BuRTurnosCancelados.LinearGradientPen = false;
            this.BuRTurnosCancelados.Location = new System.Drawing.Point(5, 82);
            this.BuRTurnosCancelados.Margin = new System.Windows.Forms.Padding(4);
            this.BuRTurnosCancelados.Name = "BuRTurnosCancelados";
            this.BuRTurnosCancelados.PenWidth = 15;
            this.BuRTurnosCancelados.Rounding = true;
            this.BuRTurnosCancelados.RoundingInt = 70;
            this.BuRTurnosCancelados.Size = new System.Drawing.Size(211, 44);
            this.BuRTurnosCancelados.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.BuRTurnosCancelados.TabIndex = 13;
            this.BuRTurnosCancelados.Tag = "Cyber";
            this.BuRTurnosCancelados.TextButton = "Turnos Cancelados";
            this.BuRTurnosCancelados.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BuRTurnosCancelados.Timer_Effect_1 = 5;
            this.BuRTurnosCancelados.Timer_RGB = 300;
            // 
            // BuRTurnosAtendidos
            // 
            this.BuRTurnosAtendidos.Alpha = 20;
            this.BuRTurnosAtendidos.BackColor = System.Drawing.Color.Transparent;
            this.BuRTurnosAtendidos.Background = true;
            this.BuRTurnosAtendidos.Background_WidthPen = 4F;
            this.BuRTurnosAtendidos.BackgroundPen = true;
            this.BuRTurnosAtendidos.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(203)))));
            this.BuRTurnosAtendidos.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(82)))), ((int)(((byte)(186)))));
            this.BuRTurnosAtendidos.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(82)))), ((int)(((byte)(186)))));
            this.BuRTurnosAtendidos.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(82)))), ((int)(((byte)(186)))));
            this.BuRTurnosAtendidos.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(82)))), ((int)(((byte)(186)))));
            this.BuRTurnosAtendidos.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.BuRTurnosAtendidos.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.BuRTurnosAtendidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuRTurnosAtendidos.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.BuRTurnosAtendidos.Effect_1 = true;
            this.BuRTurnosAtendidos.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BuRTurnosAtendidos.Effect_1_Transparency = 25;
            this.BuRTurnosAtendidos.Effect_2 = true;
            this.BuRTurnosAtendidos.Effect_2_ColorBackground = System.Drawing.Color.White;
            this.BuRTurnosAtendidos.Effect_2_Transparency = 20;
            this.BuRTurnosAtendidos.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuRTurnosAtendidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.BuRTurnosAtendidos.Lighting = false;
            this.BuRTurnosAtendidos.LinearGradient_Background = false;
            this.BuRTurnosAtendidos.LinearGradientPen = false;
            this.BuRTurnosAtendidos.Location = new System.Drawing.Point(5, 40);
            this.BuRTurnosAtendidos.Margin = new System.Windows.Forms.Padding(4);
            this.BuRTurnosAtendidos.Name = "BuRTurnosAtendidos";
            this.BuRTurnosAtendidos.PenWidth = 15;
            this.BuRTurnosAtendidos.Rounding = true;
            this.BuRTurnosAtendidos.RoundingInt = 70;
            this.BuRTurnosAtendidos.Size = new System.Drawing.Size(211, 44);
            this.BuRTurnosAtendidos.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.BuRTurnosAtendidos.TabIndex = 12;
            this.BuRTurnosAtendidos.Tag = "Cyber";
            this.BuRTurnosAtendidos.TextButton = "Turnos Atendidos";
            this.BuRTurnosAtendidos.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BuRTurnosAtendidos.Timer_Effect_1 = 5;
            this.BuRTurnosAtendidos.Timer_RGB = 300;
            this.BuRTurnosAtendidos.Click += new System.EventHandler(this.BuRTurnosAtendidos_Click);
            // 
            // reportViewerGeneral
            // 
            this.reportViewerGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerGeneral.Location = new System.Drawing.Point(0, 0);
            this.reportViewerGeneral.Name = "reportViewerGeneral";
            this.reportViewerGeneral.ServerReport.BearerToken = null;
            this.reportViewerGeneral.Size = new System.Drawing.Size(1248, 601);
            this.reportViewerGeneral.TabIndex = 0;
            // 
            // ucReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControlReportes);
            this.Name = "ucReportes";
            this.Controls.SetChildIndex(this.panelInfo, 0);
            this.Controls.SetChildIndex(this.panelContainer, 0);
            this.Controls.SetChildIndex(this.panelControlReportes, 0);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.panelControlReportes.ResumeLayout(false);
            this.panelRangoFecha.ResumeLayout(false);
            this.panelRangoFecha.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControlReportes;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerGeneral;
        private ReaLTaiizor.Controls.PoisonDateTime dateTimeFrom;
        private System.Windows.Forms.Label label2;
        private ReaLTaiizor.Controls.PoisonDateTime dateTimeTo;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.CyberButton BuAplicarReportes;
        private ReaLTaiizor.Controls.CyberButton BuReportesFechas;
        private ReaLTaiizor.Controls.CyberButton BuRTurnosCancelados;
        private ReaLTaiizor.Controls.CyberButton BuRTurnosAtendidos;
        private System.Windows.Forms.Panel panelRangoFecha;
    }
}
