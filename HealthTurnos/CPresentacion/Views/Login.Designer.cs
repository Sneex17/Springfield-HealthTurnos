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
            this.panelFondo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(882, 453);
            this.panelFondo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
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
            this.panel1.Location = new System.Drawing.Point(275, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 428);
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
            this.BuIngresar.Location = new System.Drawing.Point(61, 268);
            this.BuIngresar.Margin = new System.Windows.Forms.Padding(4);
            this.BuIngresar.Name = "BuIngresar";
            this.BuIngresar.PenWidth = 15;
            this.BuIngresar.Rounding = true;
            this.BuIngresar.RoundingInt = 70;
            this.BuIngresar.Size = new System.Drawing.Size(211, 62);
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
            this.label4.Location = new System.Drawing.Point(57, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 40);
            this.label4.TabIndex = 8;
            this.label4.Text = "HealthTurnos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Simpsonfont", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(203)))));
            this.label3.Location = new System.Drawing.Point(40, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 40);
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
            this.BuVerPass.Location = new System.Drawing.Point(281, 220);
            this.BuVerPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BuVerPass.Name = "BuVerPass";
            this.BuVerPass.Size = new System.Drawing.Size(37, 32);
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
            this.iconPassword.IconSize = 35;
            this.iconPassword.Location = new System.Drawing.Point(3, 219);
            this.iconPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconPassword.Name = "iconPassword";
            this.iconPassword.Size = new System.Drawing.Size(35, 35);
            this.iconPassword.TabIndex = 5;
            this.iconPassword.TabStop = false;
            // 
            // textbPassword
            // 
            this.textbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbPassword.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.textbPassword.Location = new System.Drawing.Point(41, 219);
            this.textbPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textbPassword.Name = "textbPassword";
            this.textbPassword.Size = new System.Drawing.Size(234, 32);
            this.textbPassword.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(37, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 26);
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
            this.iconUser.IconSize = 35;
            this.iconUser.Location = new System.Drawing.Point(3, 154);
            this.iconUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconUser.Name = "iconUser";
            this.iconUser.Size = new System.Drawing.Size(35, 35);
            this.iconUser.TabIndex = 2;
            this.iconUser.TabStop = false;
            // 
            // textbUsuario
            // 
            this.textbUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbUsuario.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.textbUsuario.Location = new System.Drawing.Point(41, 154);
            this.textbUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textbUsuario.Name = "textbUsuario";
            this.textbUsuario.Size = new System.Drawing.Size(234, 32);
            this.textbUsuario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(37, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.panelFondo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(900, 550);
            this.MinimumSize = new System.Drawing.Size(800, 500);
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
    }
}

