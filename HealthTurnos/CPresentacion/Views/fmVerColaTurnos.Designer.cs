namespace CPresentacion.Views
{
    partial class fmVerColaTurnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmVerColaTurnos));
            this.viewColaTurnos = new System.Windows.Forms.DataGridView();
            this.BuSalir = new ReaLTaiizor.Controls.CyberButton();
            ((System.ComponentModel.ISupportInitialize)(this.viewColaTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // viewColaTurnos
            // 
            this.viewColaTurnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewColaTurnos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.viewColaTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewColaTurnos.Location = new System.Drawing.Point(23, 91);
            this.viewColaTurnos.Name = "viewColaTurnos";
            this.viewColaTurnos.Size = new System.Drawing.Size(900, 340);
            this.viewColaTurnos.TabIndex = 40;
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
            this.BuSalir.Location = new System.Drawing.Point(32, 437);
            this.BuSalir.Name = "BuSalir";
            this.BuSalir.PenWidth = 15;
            this.BuSalir.Rounding = true;
            this.BuSalir.RoundingInt = 70;
            this.BuSalir.Size = new System.Drawing.Size(152, 46);
            this.BuSalir.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.BuSalir.TabIndex = 61;
            this.BuSalir.Tag = "Cyber";
            this.BuSalir.TextButton = "Salir";
            this.BuSalir.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BuSalir.Timer_Effect_1 = 5;
            this.BuSalir.Timer_RGB = 300;
            this.BuSalir.Click += new System.EventHandler(this.BuSalir_Click);
            // 
            // fmVerColaTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 500);
            this.Controls.Add(this.BuSalir);
            this.Controls.Add(this.viewColaTurnos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmVerColaTurnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cola de turnos";
            ((System.ComponentModel.ISupportInitialize)(this.viewColaTurnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView viewColaTurnos;
        private ReaLTaiizor.Controls.CyberButton BuSalir;
    }
}