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
            this.BuVerPass = new FontAwesome.Sharp.IconButton();
            this.iconPassword = new FontAwesome.Sharp.IconPictureBox();
            this.textbPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.iconUser = new FontAwesome.Sharp.IconPictureBox();
            this.textbUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelFondo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFondo
            // 
            this.panelFondo.BackgroundImage = global::CPresentacion.Properties.Resources.Fondo_Login;
            this.panelFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelFondo.Controls.Add(this.panel1);
            this.panelFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFondo.Location = new System.Drawing.Point(0, 0);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(782, 453);
            this.panelFondo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BuVerPass);
            this.panel1.Controls.Add(this.iconPassword);
            this.panel1.Controls.Add(this.textbPassword);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.iconUser);
            this.panel1.Controls.Add(this.textbUsuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(248, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 428);
            this.panel1.TabIndex = 0;
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
            this.BuVerPass.Location = new System.Drawing.Point(239, 210);
            this.BuVerPass.Name = "BuVerPass";
            this.BuVerPass.Size = new System.Drawing.Size(38, 32);
            this.BuVerPass.TabIndex = 6;
            this.BuVerPass.UseVisualStyleBackColor = false;
            this.BuVerPass.Click += new System.EventHandler(this.BuVerPass_Click);
            // 
            // iconPassword
            // 
            this.iconPassword.BackColor = System.Drawing.Color.Transparent;
            this.iconPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconPassword.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconPassword.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPassword.Location = new System.Drawing.Point(3, 207);
            this.iconPassword.Name = "iconPassword";
            this.iconPassword.Size = new System.Drawing.Size(32, 32);
            this.iconPassword.TabIndex = 5;
            this.iconPassword.TabStop = false;
            // 
            // textbPassword
            // 
            this.textbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbPassword.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbPassword.Location = new System.Drawing.Point(41, 213);
            this.textbPassword.Name = "textbPassword";
            this.textbPassword.Size = new System.Drawing.Size(192, 26);
            this.textbPassword.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(37, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // iconUser
            // 
            this.iconUser.BackColor = System.Drawing.Color.Transparent;
            this.iconUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconUser.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconUser.Location = new System.Drawing.Point(3, 148);
            this.iconUser.Name = "iconUser";
            this.iconUser.Size = new System.Drawing.Size(32, 32);
            this.iconUser.TabIndex = 2;
            this.iconUser.TabStop = false;
            // 
            // textbUsuario
            // 
            this.textbUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbUsuario.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbUsuario.Location = new System.Drawing.Point(41, 154);
            this.textbUsuario.Name = "textbUsuario";
            this.textbUsuario.Size = new System.Drawing.Size(192, 26);
            this.textbUsuario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(37, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Simpsonfont", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(17, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 40);
            this.label3.TabIndex = 7;
            this.label3.Text = "The Springfield";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Simpsonfont", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(34, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 40);
            this.label4.TabIndex = 8;
            this.label4.Text = "HealthTurnos";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.panelFondo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 500);
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
    }
}

