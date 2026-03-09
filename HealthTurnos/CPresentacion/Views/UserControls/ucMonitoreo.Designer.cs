namespace CPresentacion.Views.UserControls
{
    partial class ucMonitoreo
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.cyberGroupBox1 = new ReaLTaiizor.Controls.CyberGroupBox();
            this.lbCountUsuarios = new System.Windows.Forms.Label();
            this.lbCountEmpleados = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cyberGroupBox2 = new ReaLTaiizor.Controls.CyberGroupBox();
            this.lbCountTurnosEmergencia = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbCountTurnosPrioritarios = new System.Windows.Forms.Label();
            this.lbCountTurnosNormales = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbCountTurnosCancelados = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbCountTurnosAtendidos = new System.Windows.Forms.Label();
            this.lbCountTurnosEnAtencion = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbCountTurnosPendientes = new System.Windows.Forms.Label();
            this.lbCountTurnos = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.GraficaTurnos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelInfo.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.cyberGroupBox1.SuspendLayout();
            this.cyberGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraficaTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // labelText
            // 
            this.labelText.Size = new System.Drawing.Size(266, 26);
            this.labelText.Text = "Monitoreo de estadísticas";
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.GraficaTurnos);
            this.panelContainer.Controls.Add(this.cyberGroupBox2);
            this.panelContainer.Controls.Add(this.cyberGroupBox1);
            // 
            // cyberGroupBox1
            // 
            this.cyberGroupBox1.Alpha = 20;
            this.cyberGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.cyberGroupBox1.Background = true;
            this.cyberGroupBox1.Background_WidthPen = 3F;
            this.cyberGroupBox1.BackgroundPen = true;
            this.cyberGroupBox1.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberGroupBox1.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberGroupBox1.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberGroupBox1.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberGroupBox1.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberGroupBox1.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberGroupBox1.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberGroupBox1.Controls.Add(this.lbCountUsuarios);
            this.cyberGroupBox1.Controls.Add(this.lbCountEmpleados);
            this.cyberGroupBox1.Controls.Add(this.label3);
            this.cyberGroupBox1.Controls.Add(this.label2);
            this.cyberGroupBox1.Controls.Add(this.label1);
            this.cyberGroupBox1.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.cyberGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cyberGroupBox1.Lighting = false;
            this.cyberGroupBox1.LinearGradient_Background = false;
            this.cyberGroupBox1.LinearGradientPen = false;
            this.cyberGroupBox1.Location = new System.Drawing.Point(69, 352);
            this.cyberGroupBox1.Name = "cyberGroupBox1";
            this.cyberGroupBox1.PenWidth = 15;
            this.cyberGroupBox1.RGB = false;
            this.cyberGroupBox1.Rounding = true;
            this.cyberGroupBox1.RoundingInt = 60;
            this.cyberGroupBox1.Size = new System.Drawing.Size(296, 105);
            this.cyberGroupBox1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.cyberGroupBox1.TabIndex = 1;
            this.cyberGroupBox1.Tag = "Cyber";
            this.cyberGroupBox1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cyberGroupBox1.Timer_RGB = 300;
            // 
            // lbCountUsuarios
            // 
            this.lbCountUsuarios.AutoSize = true;
            this.lbCountUsuarios.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.lbCountUsuarios.Location = new System.Drawing.Point(168, 64);
            this.lbCountUsuarios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCountUsuarios.Name = "lbCountUsuarios";
            this.lbCountUsuarios.Size = new System.Drawing.Size(57, 21);
            this.lbCountUsuarios.TabIndex = 7;
            this.lbCountUsuarios.Text = "Count";
            // 
            // lbCountEmpleados
            // 
            this.lbCountEmpleados.AutoSize = true;
            this.lbCountEmpleados.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.lbCountEmpleados.Location = new System.Drawing.Point(26, 64);
            this.lbCountEmpleados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCountEmpleados.Name = "lbCountEmpleados";
            this.lbCountEmpleados.Size = new System.Drawing.Size(57, 21);
            this.lbCountEmpleados.TabIndex = 6;
            this.lbCountEmpleados.Text = "Count";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(168, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Usuarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(51, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Detalles administrativos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Empleados";
            // 
            // cyberGroupBox2
            // 
            this.cyberGroupBox2.Alpha = 20;
            this.cyberGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.cyberGroupBox2.Background = true;
            this.cyberGroupBox2.Background_WidthPen = 3F;
            this.cyberGroupBox2.BackgroundPen = true;
            this.cyberGroupBox2.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberGroupBox2.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberGroupBox2.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberGroupBox2.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberGroupBox2.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberGroupBox2.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberGroupBox2.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberGroupBox2.Controls.Add(this.lbCountTurnosEmergencia);
            this.cyberGroupBox2.Controls.Add(this.label5);
            this.cyberGroupBox2.Controls.Add(this.lbCountTurnosPrioritarios);
            this.cyberGroupBox2.Controls.Add(this.lbCountTurnosNormales);
            this.cyberGroupBox2.Controls.Add(this.label13);
            this.cyberGroupBox2.Controls.Add(this.label15);
            this.cyberGroupBox2.Controls.Add(this.lbCountTurnosCancelados);
            this.cyberGroupBox2.Controls.Add(this.label14);
            this.cyberGroupBox2.Controls.Add(this.lbCountTurnosAtendidos);
            this.cyberGroupBox2.Controls.Add(this.lbCountTurnosEnAtencion);
            this.cyberGroupBox2.Controls.Add(this.label11);
            this.cyberGroupBox2.Controls.Add(this.label12);
            this.cyberGroupBox2.Controls.Add(this.lbCountTurnosPendientes);
            this.cyberGroupBox2.Controls.Add(this.lbCountTurnos);
            this.cyberGroupBox2.Controls.Add(this.label6);
            this.cyberGroupBox2.Controls.Add(this.label7);
            this.cyberGroupBox2.Controls.Add(this.label8);
            this.cyberGroupBox2.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.cyberGroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cyberGroupBox2.Lighting = false;
            this.cyberGroupBox2.LinearGradient_Background = false;
            this.cyberGroupBox2.LinearGradientPen = false;
            this.cyberGroupBox2.Location = new System.Drawing.Point(38, 26);
            this.cyberGroupBox2.Name = "cyberGroupBox2";
            this.cyberGroupBox2.PenWidth = 15;
            this.cyberGroupBox2.RGB = false;
            this.cyberGroupBox2.Rounding = true;
            this.cyberGroupBox2.RoundingInt = 60;
            this.cyberGroupBox2.Size = new System.Drawing.Size(472, 288);
            this.cyberGroupBox2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.cyberGroupBox2.TabIndex = 8;
            this.cyberGroupBox2.Tag = "Cyber";
            this.cyberGroupBox2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cyberGroupBox2.Timer_RGB = 300;
            // 
            // lbCountTurnosEmergencia
            // 
            this.lbCountTurnosEmergencia.AutoSize = true;
            this.lbCountTurnosEmergencia.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.lbCountTurnosEmergencia.Location = new System.Drawing.Point(328, 123);
            this.lbCountTurnosEmergencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCountTurnosEmergencia.Name = "lbCountTurnosEmergencia";
            this.lbCountTurnosEmergencia.Size = new System.Drawing.Size(57, 21);
            this.lbCountTurnosEmergencia.TabIndex = 19;
            this.lbCountTurnosEmergencia.Text = "Count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(328, 99);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Emergencia";
            // 
            // lbCountTurnosPrioritarios
            // 
            this.lbCountTurnosPrioritarios.AutoSize = true;
            this.lbCountTurnosPrioritarios.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.lbCountTurnosPrioritarios.Location = new System.Drawing.Point(168, 123);
            this.lbCountTurnosPrioritarios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCountTurnosPrioritarios.Name = "lbCountTurnosPrioritarios";
            this.lbCountTurnosPrioritarios.Size = new System.Drawing.Size(57, 21);
            this.lbCountTurnosPrioritarios.TabIndex = 17;
            this.lbCountTurnosPrioritarios.Text = "Count";
            // 
            // lbCountTurnosNormales
            // 
            this.lbCountTurnosNormales.AutoSize = true;
            this.lbCountTurnosNormales.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.lbCountTurnosNormales.Location = new System.Drawing.Point(26, 123);
            this.lbCountTurnosNormales.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCountTurnosNormales.Name = "lbCountTurnosNormales";
            this.lbCountTurnosNormales.Size = new System.Drawing.Size(57, 21);
            this.lbCountTurnosNormales.TabIndex = 16;
            this.lbCountTurnosNormales.Text = "Count";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(168, 99);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 21);
            this.label13.TabIndex = 15;
            this.label13.Text = "Prioritarios";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(26, 99);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 21);
            this.label15.TabIndex = 14;
            this.label15.Text = "Normales";
            // 
            // lbCountTurnosCancelados
            // 
            this.lbCountTurnosCancelados.AutoSize = true;
            this.lbCountTurnosCancelados.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.lbCountTurnosCancelados.Location = new System.Drawing.Point(328, 197);
            this.lbCountTurnosCancelados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCountTurnosCancelados.Name = "lbCountTurnosCancelados";
            this.lbCountTurnosCancelados.Size = new System.Drawing.Size(57, 21);
            this.lbCountTurnosCancelados.TabIndex = 13;
            this.lbCountTurnosCancelados.Text = "Count";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(328, 173);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 21);
            this.label14.TabIndex = 12;
            this.label14.Text = "Cancelados";
            // 
            // lbCountTurnosAtendidos
            // 
            this.lbCountTurnosAtendidos.AutoSize = true;
            this.lbCountTurnosAtendidos.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.lbCountTurnosAtendidos.Location = new System.Drawing.Point(186, 197);
            this.lbCountTurnosAtendidos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCountTurnosAtendidos.Name = "lbCountTurnosAtendidos";
            this.lbCountTurnosAtendidos.Size = new System.Drawing.Size(57, 21);
            this.lbCountTurnosAtendidos.TabIndex = 11;
            this.lbCountTurnosAtendidos.Text = "Count";
            // 
            // lbCountTurnosEnAtencion
            // 
            this.lbCountTurnosEnAtencion.AutoSize = true;
            this.lbCountTurnosEnAtencion.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.lbCountTurnosEnAtencion.Location = new System.Drawing.Point(328, 64);
            this.lbCountTurnosEnAtencion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCountTurnosEnAtencion.Name = "lbCountTurnosEnAtencion";
            this.lbCountTurnosEnAtencion.Size = new System.Drawing.Size(57, 21);
            this.lbCountTurnosEnAtencion.TabIndex = 10;
            this.lbCountTurnosEnAtencion.Text = "Count";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(186, 173);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 21);
            this.label11.TabIndex = 9;
            this.label11.Text = "Atendidos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(328, 40);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 21);
            this.label12.TabIndex = 8;
            this.label12.Text = "En atención";
            // 
            // lbCountTurnosPendientes
            // 
            this.lbCountTurnosPendientes.AutoSize = true;
            this.lbCountTurnosPendientes.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.lbCountTurnosPendientes.Location = new System.Drawing.Point(168, 64);
            this.lbCountTurnosPendientes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCountTurnosPendientes.Name = "lbCountTurnosPendientes";
            this.lbCountTurnosPendientes.Size = new System.Drawing.Size(57, 21);
            this.lbCountTurnosPendientes.TabIndex = 7;
            this.lbCountTurnosPendientes.Text = "Count";
            // 
            // lbCountTurnos
            // 
            this.lbCountTurnos.AutoSize = true;
            this.lbCountTurnos.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.lbCountTurnos.Location = new System.Drawing.Point(26, 64);
            this.lbCountTurnos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCountTurnos.Name = "lbCountTurnos";
            this.lbCountTurnos.Size = new System.Drawing.Size(57, 21);
            this.lbCountTurnos.TabIndex = 6;
            this.lbCountTurnos.Text = "Count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(168, 40);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Pendientes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(51, 6);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "Detalles de los turnos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(26, 40);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "Total";
            // 
            // GraficaTurnos
            // 
            chartArea1.Name = "ChartArea1";
            this.GraficaTurnos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.GraficaTurnos.Legends.Add(legend1);
            this.GraficaTurnos.Location = new System.Drawing.Point(599, 0);
            this.GraficaTurnos.Name = "GraficaTurnos";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            this.GraficaTurnos.Series.Add(series1);
            this.GraficaTurnos.Size = new System.Drawing.Size(337, 289);
            this.GraficaTurnos.TabIndex = 9;
            this.GraficaTurnos.Text = "chart1";
            title1.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Gráfica de turnos";
            this.GraficaTurnos.Titles.Add(title1);
            // 
            // ucMonitoreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ucMonitoreo";
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.cyberGroupBox1.ResumeLayout(false);
            this.cyberGroupBox1.PerformLayout();
            this.cyberGroupBox2.ResumeLayout(false);
            this.cyberGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraficaTurnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox2;
        private System.Windows.Forms.Label lbCountTurnosAtendidos;
        private System.Windows.Forms.Label lbCountTurnosEnAtencion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbCountTurnosPendientes;
        private System.Windows.Forms.Label lbCountTurnos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbCountUsuarios;
        private System.Windows.Forms.Label lbCountEmpleados;
        private System.Windows.Forms.Label lbCountTurnosCancelados;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbCountTurnosEmergencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbCountTurnosPrioritarios;
        private System.Windows.Forms.Label lbCountTurnosNormales;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraficaTurnos;
    }
}
