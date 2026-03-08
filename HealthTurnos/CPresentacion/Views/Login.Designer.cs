namespace CPresentacion
{
    partial class Login
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panelFondo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BuIngresar = new ReaLTaiizor.Controls.CyberButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BuVerPass = new FontAwesome.Sharp.IconButton();
            this.iconPassword = new FontAwesome.Sharp.IconPictureBox();
            this.textbPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.iconUser = new FontAwesome.Sharp.IconPictureBox();
            this.textbUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckSoyPaciente = new ReaLTaiizor.Controls.AloneCheckBox();
            this.panelFondo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFondo
            // 
            this.panelFondo.BackColor = System.Drawing.Color.Transparent;
            this.panelFondo.BackgroundImage = global::CPresentacion.Properties.Resources.FondoLogin;
            this.panelFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelFondo.Controls.Add(this.panel1);
            this.panelFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFondo.Location = new System.Drawing.Point(0, 0);
            this.panelFondo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(662, 375);
            this.panelFondo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.CheckSoyPaciente);
            this.panel1.Controls.Add(this.BuIngresar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BuVerPass);
            this.panel1.Controls.Add(this.iconPassword);
            this.panel1.Controls.Add(this.textbPassword);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.iconUser);
            this.panel1.Controls.Add(this.textbUsuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(206, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 348);
            this.panel1.TabIndex = 0;
            // 
            // BuIngresar
            // 
            this.BuIngresar.Alpha = 20;
            this.BuIngresar.BackColor = System.Drawing.Color.Transparent;
            this.BuIngresar.Background = true;
            this.BuIngresar.Background_WidthPen = 4F;
            this.BuIngresar.BackgroundPen = true;
            this.BuIngresar.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(203)))));
            this.BuIngresar.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(82)))), ((int)(((byte)(186)))));
            this.BuIngresar.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(82)))), ((int)(((byte)(186)))));
            this.BuIngresar.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(82)))), ((int)(((byte)(186)))));
            this.BuIngresar.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(82)))), ((int)(((byte)(186)))));
            this.BuIngresar.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.BuIngresar.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.BuIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuIngresar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.BuIngresar.Effect_1 = true;
            this.BuIngresar.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BuIngresar.Effect_1_Transparency = 25;
            this.BuIngresar.Effect_2 = true;
            this.BuIngresar.Effect_2_ColorBackground = System.Drawing.Color.White;
            this.BuIngresar.Effect_2_Transparency = 20;
            this.BuIngresar.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuIngresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.BuIngresar.Lighting = false;
            this.BuIngresar.LinearGradient_Background = false;
            this.BuIngresar.LinearGradientPen = false;
            this.BuIngresar.Location = new System.Drawing.Point(46, 218);
            this.BuIngresar.Name = "BuIngresar";
            this.BuIngresar.PenWidth = 15;
            this.BuIngresar.Rounding = true;
            this.BuIngresar.RoundingInt = 70;
            this.BuIngresar.Size = new System.Drawing.Size(158, 50);
            this.BuIngresar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.BuIngresar.TabIndex = 10;
            this.BuIngresar.Tag = "Cyber";
            this.BuIngresar.TextButton = "Ingresar";
            this.BuIngresar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BuIngresar.Timer_Effect_1 = 5;
            this.BuIngresar.Timer_RGB = 300;
            this.BuIngresar.Click += new System.EventHandler(this.BuIngresar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Simpsonfont", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(203)))));
            this.label4.Location = new System.Drawing.Point(43, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "HealthTurnos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Simpsonfont", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(203)))));
            this.label3.Location = new System.Drawing.Point(30, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "The Springfield";
            // 
            // BuVerPass
            // 
            this.BuVerPass.BackColor = System.Drawing.Color.Transparent;
            this.BuVerPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuVerPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuVerPass.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.BuVerPass.IconColor = System.Drawing.Color.Black;
            this.BuVerPass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BuVerPass.IconSize = 32;
            this.BuVerPass.Location = new System.Drawing.Point(211, 179);
            this.BuVerPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BuVerPass.Name = "BuVerPass";
            this.BuVerPass.Size = new System.Drawing.Size(28, 26);
            this.BuVerPass.TabIndex = 6;
            this.BuVerPass.UseVisualStyleBackColor = false;
            this.BuVerPass.Click += new System.EventHandler(this.BuVerPass_Click);
            // 
            // iconPassword
            // 
            this.iconPassword.BackColor = System.Drawing.Color.Transparent;
            this.iconPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(203)))));
            this.iconPassword.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconPassword.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(203)))));
            this.iconPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPassword.IconSize = 26;
            this.iconPassword.Location = new System.Drawing.Point(2, 178);
            this.iconPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconPassword.Name = "iconPassword";
            this.iconPassword.Size = new System.Drawing.Size(26, 28);
            this.iconPassword.TabIndex = 5;
            this.iconPassword.TabStop = false;
            // 
            // textbPassword
            // 
            this.textbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbPassword.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.textbPassword.Location = new System.Drawing.Point(31, 178);
            this.textbPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textbPassword.Name = "textbPassword";
            this.textbPassword.Size = new System.Drawing.Size(176, 27);
            this.textbPassword.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(28, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // iconUser
            // 
            this.iconUser.BackColor = System.Drawing.Color.Transparent;
            this.iconUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(203)))));
            this.iconUser.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(203)))));
            this.iconUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconUser.IconSize = 26;
            this.iconUser.Location = new System.Drawing.Point(2, 125);
            this.iconUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconUser.Name = "iconUser";
            this.iconUser.Size = new System.Drawing.Size(26, 28);
            this.iconUser.TabIndex = 2;
            this.iconUser.TabStop = false;
            // 
            // textbUsuario
            // 
            this.textbUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbUsuario.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.textbUsuario.Location = new System.Drawing.Point(31, 125);
            this.textbUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textbUsuario.Name = "textbUsuario";
            this.textbUsuario.Size = new System.Drawing.Size(176, 27);
            this.textbUsuario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(28, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // CheckSoyPaciente
            // 
            this.CheckSoyPaciente.BackColor = System.Drawing.Color.Transparent;
            this.CheckSoyPaciente.Checked = false;
            this.CheckSoyPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckSoyPaciente.EnabledCalc = true;
            this.CheckSoyPaciente.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckSoyPaciente.ForeColor = System.Drawing.Color.Black;
            this.CheckSoyPaciente.Location = new System.Drawing.Point(65, 318);
            this.CheckSoyPaciente.Name = "CheckSoyPaciente";
            this.CheckSoyPaciente.Size = new System.Drawing.Size(118, 17);
            this.CheckSoyPaciente.TabIndex = 11;
            this.CheckSoyPaciente.Text = "Soy un paciente";
            this.CheckSoyPaciente.CheckedChanged += new ReaLTaiizor.Controls.AloneCheckBox.CheckedChangedEventHandler(this.CheckSoyPaciente_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 375);
            this.Controls.Add(this.panelFondo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(679, 454);
            this.MinimumSize = new System.Drawing.Size(604, 414);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HealthTurnos";
            this.panelFondo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFondo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textbUsuario;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconUser;
        private FontAwesome.Sharp.IconPictureBox iconPassword;
        private System.Windows.Forms.TextBox textbPassword;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton BuVerPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ReaLTaiizor.Controls.CyberButton BuIngresar;
        private ReaLTaiizor.Controls.AloneCheckBox CheckSoyPaciente;
    }
}

