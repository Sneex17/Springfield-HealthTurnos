namespace CPresentacion.Views.fmDialogos
{
    partial class fmMensajeBienvenida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMensajeBienvenida));
            this.label1 = new System.Windows.Forms.Label();
            this.BuAceptar = new ReaLTaiizor.Controls.CyberButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido a \r\nHealthTurnos!!";
            // 
            // BuAceptar
            // 
            this.BuAceptar.Alpha = 20;
            this.BuAceptar.BackColor = System.Drawing.Color.Transparent;
            this.BuAceptar.Background = true;
            this.BuAceptar.Background_WidthPen = 4F;
            this.BuAceptar.BackgroundPen = true;
            this.BuAceptar.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(203)))));
            this.BuAceptar.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(82)))), ((int)(((byte)(186)))));
            this.BuAceptar.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(82)))), ((int)(((byte)(186)))));
            this.BuAceptar.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(82)))), ((int)(((byte)(186)))));
            this.BuAceptar.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(82)))), ((int)(((byte)(186)))));
            this.BuAceptar.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.BuAceptar.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.BuAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuAceptar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.BuAceptar.Effect_1 = true;
            this.BuAceptar.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BuAceptar.Effect_1_Transparency = 25;
            this.BuAceptar.Effect_2 = true;
            this.BuAceptar.Effect_2_ColorBackground = System.Drawing.Color.White;
            this.BuAceptar.Effect_2_Transparency = 20;
            this.BuAceptar.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.BuAceptar.Lighting = false;
            this.BuAceptar.LinearGradient_Background = false;
            this.BuAceptar.LinearGradientPen = false;
            this.BuAceptar.Location = new System.Drawing.Point(34, 87);
            this.BuAceptar.Name = "BuAceptar";
            this.BuAceptar.PenWidth = 15;
            this.BuAceptar.Rounding = true;
            this.BuAceptar.RoundingInt = 70;
            this.BuAceptar.Size = new System.Drawing.Size(127, 37);
            this.BuAceptar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.BuAceptar.TabIndex = 11;
            this.BuAceptar.Tag = "Cyber";
            this.BuAceptar.TextButton = "Cerrar";
            this.BuAceptar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BuAceptar.Timer_Effect_1 = 5;
            this.BuAceptar.Timer_RGB = 300;
            this.BuAceptar.Click += new System.EventHandler(this.BuAceptar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CPresentacion.Properties.Resources.MedicoSaludando;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(212, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 112);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // fmMensajeBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(325, 136);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BuAceptar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmMensajeBienvenida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mensaje de Bienvenida";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.CyberButton BuAceptar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}