namespace CPresentacion.Views
{
    partial class fmInicioPaciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmInicioPaciente));
            this.BuNuevoTurno = new FontAwesome.Sharp.IconButton();
            this.BuVerColaTurnos = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BuSalir = new ReaLTaiizor.Controls.CyberButton();
            this.SuspendLayout();
            // 
            // BuNuevoTurno
            // 
            this.BuNuevoTurno.BackColor = System.Drawing.Color.RoyalBlue;
            this.BuNuevoTurno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuNuevoTurno.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.BuNuevoTurno.ForeColor = System.Drawing.Color.White;
            this.BuNuevoTurno.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BuNuevoTurno.IconColor = System.Drawing.Color.White;
            this.BuNuevoTurno.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BuNuevoTurno.IconSize = 32;
            this.BuNuevoTurno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuNuevoTurno.Location = new System.Drawing.Point(300, 219);
            this.BuNuevoTurno.Name = "BuNuevoTurno";
            this.BuNuevoTurno.Size = new System.Drawing.Size(206, 47);
            this.BuNuevoTurno.TabIndex = 57;
            this.BuNuevoTurno.Text = "Registrar un turno";
            this.BuNuevoTurno.UseVisualStyleBackColor = false;
            this.BuNuevoTurno.Click += new System.EventHandler(this.BuNuevoTurno_Click);
            // 
            // BuVerColaTurnos
            // 
            this.BuVerColaTurnos.BackColor = System.Drawing.Color.RoyalBlue;
            this.BuVerColaTurnos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuVerColaTurnos.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.BuVerColaTurnos.ForeColor = System.Drawing.Color.White;
            this.BuVerColaTurnos.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.BuVerColaTurnos.IconColor = System.Drawing.Color.White;
            this.BuVerColaTurnos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BuVerColaTurnos.IconSize = 32;
            this.BuVerColaTurnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuVerColaTurnos.Location = new System.Drawing.Point(75, 219);
            this.BuVerColaTurnos.Name = "BuVerColaTurnos";
            this.BuVerColaTurnos.Size = new System.Drawing.Size(206, 47);
            this.BuVerColaTurnos.TabIndex = 56;
            this.BuVerColaTurnos.Text = "Ver cola de turnos";
            this.BuVerColaTurnos.UseVisualStyleBackColor = false;
            this.BuVerColaTurnos.Click += new System.EventHandler(this.BuVerColaTurnos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(148, 176);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 21);
            this.label1.TabIndex = 58;
            this.label1.Text = "¿Qué desea realizar como paciente?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Black", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(152, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 52);
            this.label2.TabIndex = 59;
            this.label2.Text = "Bienvenido a  Springfield \r\nHealthTurnos";
            // 
            // BuSalir
            // 
            this.BuSalir.Alpha = 20;
            this.BuSalir.BackColor = System.Drawing.Color.Transparent;
            this.BuSalir.Background = true;
            this.BuSalir.Background_WidthPen = 4F;
            this.BuSalir.BackgroundPen = true;
            this.BuSalir.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(203)))));
            this.BuSalir.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(82)))), ((int)(((byte)(186)))));
            this.BuSalir.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(82)))), ((int)(((byte)(186)))));
            this.BuSalir.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(82)))), ((int)(((byte)(186)))));
            this.BuSalir.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(82)))), ((int)(((byte)(186)))));
            this.BuSalir.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.BuSalir.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.BuSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuSalir.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.BuSalir.Effect_1 = true;
            this.BuSalir.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BuSalir.Effect_1_Transparency = 25;
            this.BuSalir.Effect_2 = true;
            this.BuSalir.Effect_2_ColorBackground = System.Drawing.Color.White;
            this.BuSalir.Effect_2_Transparency = 20;
            this.BuSalir.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.BuSalir.Lighting = false;
            this.BuSalir.LinearGradient_Background = false;
            this.BuSalir.LinearGradientPen = false;
            this.BuSalir.Location = new System.Drawing.Point(18, 310);
            this.BuSalir.Name = "BuSalir";
            this.BuSalir.PenWidth = 15;
            this.BuSalir.Rounding = true;
            this.BuSalir.RoundingInt = 70;
            this.BuSalir.Size = new System.Drawing.Size(152, 46);
            this.BuSalir.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.BuSalir.TabIndex = 60;
            this.BuSalir.Tag = "Cyber";
            this.BuSalir.TextButton = "Salir";
            this.BuSalir.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BuSalir.Timer_Effect_1 = 5;
            this.BuSalir.Timer_RGB = 300;
            this.BuSalir.Click += new System.EventHandler(this.BuSalir_Click);
            // 
            // fmInicioPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 374);
            this.Controls.Add(this.BuSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BuNuevoTurno);
            this.Controls.Add(this.BuVerColaTurnos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmInicioPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu de bienvenida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton BuNuevoTurno;
        private FontAwesome.Sharp.IconButton BuVerColaTurnos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ReaLTaiizor.Controls.CyberButton BuSalir;
    }
}