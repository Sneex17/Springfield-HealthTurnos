namespace CPresentacion.Views.UserControls
{
    partial class ucHome
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
            this.groupBInfo = new ReaLTaiizor.Controls.GroupBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.pictureLogoUser = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BuCerrar = new FontAwesome.Sharp.IconButton();
            this.panelInfo.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.groupBInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogoUser)).BeginInit();
            this.SuspendLayout();
            // 
            // labelText
            // 
            this.labelText.Size = new System.Drawing.Size(135, 26);
            this.labelText.Text = "Bienvenido!!";
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.BuCerrar);
            this.panelContainer.Controls.Add(this.groupBInfo);
            // 
            // groupBInfo
            // 
            this.groupBInfo.BackColor = System.Drawing.Color.Transparent;
            this.groupBInfo.BackGColor = System.Drawing.Color.LightGray;
            this.groupBInfo.BaseColor = System.Drawing.Color.Transparent;
            this.groupBInfo.BorderColorG = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.groupBInfo.BorderColorH = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(180)))), ((int)(((byte)(186)))));
            this.groupBInfo.Controls.Add(this.lbUsername);
            this.groupBInfo.Controls.Add(this.pictureLogoUser);
            this.groupBInfo.Controls.Add(this.label1);
            this.groupBInfo.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBInfo.ForeColor = System.Drawing.Color.Black;
            this.groupBInfo.HeaderColor = System.Drawing.Color.CornflowerBlue;
            this.groupBInfo.Location = new System.Drawing.Point(660, 6);
            this.groupBInfo.MinimumSize = new System.Drawing.Size(136, 50);
            this.groupBInfo.Name = "groupBInfo";
            this.groupBInfo.Padding = new System.Windows.Forms.Padding(5, 28, 5, 5);
            this.groupBInfo.Size = new System.Drawing.Size(265, 102);
            this.groupBInfo.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.groupBInfo.TabIndex = 45;
            this.groupBInfo.Text = "Mi Información";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.lbUsername.ForeColor = System.Drawing.Color.Black;
            this.lbUsername.Location = new System.Drawing.Point(7, 52);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(42, 21);
            this.lbUsername.TabIndex = 47;
            this.lbUsername.Text = "Text";
            // 
            // pictureLogoUser
            // 
            this.pictureLogoUser.BackgroundImage = global::CPresentacion.Properties.Resources.LogoUsuarios;
            this.pictureLogoUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureLogoUser.Location = new System.Drawing.Point(185, 31);
            this.pictureLogoUser.Name = "pictureLogoUser";
            this.pictureLogoUser.Size = new System.Drawing.Size(72, 59);
            this.pictureLogoUser.TabIndex = 46;
            this.pictureLogoUser.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 45;
            this.label1.Text = "Usuario:";
            // 
            // BuCerrar
            // 
            this.BuCerrar.BackColor = System.Drawing.Color.RoyalBlue;
            this.BuCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuCerrar.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.BuCerrar.ForeColor = System.Drawing.Color.White;
            this.BuCerrar.IconChar = FontAwesome.Sharp.IconChar.Dedent;
            this.BuCerrar.IconColor = System.Drawing.Color.White;
            this.BuCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BuCerrar.IconSize = 32;
            this.BuCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuCerrar.Location = new System.Drawing.Point(746, 428);
            this.BuCerrar.Name = "BuCerrar";
            this.BuCerrar.Size = new System.Drawing.Size(179, 47);
            this.BuCerrar.TabIndex = 46;
            this.BuCerrar.Text = "Cerrar sessión";
            this.BuCerrar.UseVisualStyleBackColor = false;
            this.BuCerrar.Click += new System.EventHandler(this.BuCerrar_Click);
            // 
            // ucHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ucHome";
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.groupBInfo.ResumeLayout(false);
            this.groupBInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogoUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.GroupBox groupBInfo;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.PictureBox pictureLogoUser;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BuCerrar;
    }
}
