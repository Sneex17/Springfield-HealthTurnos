namespace CPresentacion.Views
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.tabRegistrarTurno = new System.Windows.Forms.TabPage();
            this.tabPaciente = new System.Windows.Forms.TabPage();
            this.tabAtenderPacientes = new System.Windows.Forms.TabPage();
            this.tabColaTurnos = new System.Windows.Forms.TabPage();
            this.tabEmpleados = new System.Windows.Forms.TabPage();
            this.tabEspecialidades = new System.Windows.Forms.TabPage();
            this.tabMedicos = new System.Windows.Forms.TabPage();
            this.tabAsistente = new System.Windows.Forms.TabPage();
            this.tabRoles = new System.Windows.Forms.TabPage();
            this.tabUsuarios = new System.Windows.Forms.TabPage();
            this.tabReportes = new System.Windows.Forms.TabPage();
            this.BuCerrar = new MaterialSkin.Controls.MaterialButton();
            this.groupBInfo = new ReaLTaiizor.Controls.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureLogoUser = new System.Windows.Forms.PictureBox();
            this.iconSplitButton1 = new FontAwesome.Sharp.IconSplitButton();
            this.lbUsername = new System.Windows.Forms.Label();
            this.materialTabControl1.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.groupBInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogoUser)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabHome);
            this.materialTabControl1.Controls.Add(this.tabRegistrarTurno);
            this.materialTabControl1.Controls.Add(this.tabPaciente);
            this.materialTabControl1.Controls.Add(this.tabAtenderPacientes);
            this.materialTabControl1.Controls.Add(this.tabColaTurnos);
            this.materialTabControl1.Controls.Add(this.tabEmpleados);
            this.materialTabControl1.Controls.Add(this.tabEspecialidades);
            this.materialTabControl1.Controls.Add(this.tabMedicos);
            this.materialTabControl1.Controls.Add(this.tabAsistente);
            this.materialTabControl1.Controls.Add(this.tabRoles);
            this.materialTabControl1.Controls.Add(this.tabUsuarios);
            this.materialTabControl1.Controls.Add(this.tabReportes);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(944, 583);
            this.materialTabControl1.TabIndex = 0;
            this.materialTabControl1.SelectedIndexChanged += new System.EventHandler(this.materialTabControl1_SelectedIndexChanged);
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.groupBInfo);
            this.tabHome.Controls.Add(this.BuCerrar);
            this.tabHome.Location = new System.Drawing.Point(4, 40);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabHome.Size = new System.Drawing.Size(936, 539);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // tabRegistrarTurno
            // 
            this.tabRegistrarTurno.Location = new System.Drawing.Point(4, 40);
            this.tabRegistrarTurno.Name = "tabRegistrarTurno";
            this.tabRegistrarTurno.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabRegistrarTurno.Size = new System.Drawing.Size(936, 539);
            this.tabRegistrarTurno.TabIndex = 1;
            this.tabRegistrarTurno.Text = "Registrar turno";
            this.tabRegistrarTurno.UseVisualStyleBackColor = true;
            // 
            // tabPaciente
            // 
            this.tabPaciente.Location = new System.Drawing.Point(4, 40);
            this.tabPaciente.Name = "tabPaciente";
            this.tabPaciente.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPaciente.Size = new System.Drawing.Size(936, 539);
            this.tabPaciente.TabIndex = 2;
            this.tabPaciente.Text = "Consulta paciente";
            this.tabPaciente.UseVisualStyleBackColor = true;
            // 
            // tabAtenderPacientes
            // 
            this.tabAtenderPacientes.Location = new System.Drawing.Point(4, 40);
            this.tabAtenderPacientes.Name = "tabAtenderPacientes";
            this.tabAtenderPacientes.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabAtenderPacientes.Size = new System.Drawing.Size(936, 539);
            this.tabAtenderPacientes.TabIndex = 3;
            this.tabAtenderPacientes.Text = "Atender pacientes";
            this.tabAtenderPacientes.UseVisualStyleBackColor = true;
            // 
            // tabColaTurnos
            // 
            this.tabColaTurnos.Location = new System.Drawing.Point(4, 40);
            this.tabColaTurnos.Name = "tabColaTurnos";
            this.tabColaTurnos.Size = new System.Drawing.Size(936, 539);
            this.tabColaTurnos.TabIndex = 4;
            this.tabColaTurnos.Text = "Colar de turnos";
            this.tabColaTurnos.UseVisualStyleBackColor = true;
            // 
            // tabEmpleados
            // 
            this.tabEmpleados.Location = new System.Drawing.Point(4, 40);
            this.tabEmpleados.Name = "tabEmpleados";
            this.tabEmpleados.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabEmpleados.Size = new System.Drawing.Size(936, 539);
            this.tabEmpleados.TabIndex = 5;
            this.tabEmpleados.Text = "Gest. de empleados";
            this.tabEmpleados.UseVisualStyleBackColor = true;
            // 
            // tabEspecialidades
            // 
            this.tabEspecialidades.Location = new System.Drawing.Point(4, 40);
            this.tabEspecialidades.Name = "tabEspecialidades";
            this.tabEspecialidades.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabEspecialidades.Size = new System.Drawing.Size(936, 539);
            this.tabEspecialidades.TabIndex = 8;
            this.tabEspecialidades.Text = "Gest. de especialidades";
            this.tabEspecialidades.UseVisualStyleBackColor = true;
            // 
            // tabMedicos
            // 
            this.tabMedicos.Location = new System.Drawing.Point(4, 40);
            this.tabMedicos.Name = "tabMedicos";
            this.tabMedicos.Size = new System.Drawing.Size(936, 539);
            this.tabMedicos.TabIndex = 6;
            this.tabMedicos.Text = "Gest. de médicos";
            this.tabMedicos.UseVisualStyleBackColor = true;
            // 
            // tabAsistente
            // 
            this.tabAsistente.Location = new System.Drawing.Point(4, 40);
            this.tabAsistente.Name = "tabAsistente";
            this.tabAsistente.Size = new System.Drawing.Size(936, 539);
            this.tabAsistente.TabIndex = 7;
            this.tabAsistente.Text = "Gest. de asistentes";
            this.tabAsistente.UseVisualStyleBackColor = true;
            // 
            // tabRoles
            // 
            this.tabRoles.Location = new System.Drawing.Point(4, 40);
            this.tabRoles.Name = "tabRoles";
            this.tabRoles.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabRoles.Size = new System.Drawing.Size(936, 539);
            this.tabRoles.TabIndex = 10;
            this.tabRoles.Text = "Gest. Roles";
            this.tabRoles.UseVisualStyleBackColor = true;
            // 
            // tabUsuarios
            // 
            this.tabUsuarios.Location = new System.Drawing.Point(4, 40);
            this.tabUsuarios.Name = "tabUsuarios";
            this.tabUsuarios.Size = new System.Drawing.Size(936, 539);
            this.tabUsuarios.TabIndex = 9;
            this.tabUsuarios.Text = "Gest. de Usuarios";
            this.tabUsuarios.UseVisualStyleBackColor = true;
            // 
            // tabReportes
            // 
            this.tabReportes.Location = new System.Drawing.Point(4, 40);
            this.tabReportes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabReportes.Name = "tabReportes";
            this.tabReportes.Size = new System.Drawing.Size(936, 539);
            this.tabReportes.TabIndex = 11;
            this.tabReportes.Text = "Reportes";
            this.tabReportes.UseVisualStyleBackColor = true;
            // 
            // BuCerrar
            // 
            this.BuCerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BuCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuCerrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BuCerrar.Depth = 0;
            this.BuCerrar.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuCerrar.HighEmphasis = true;
            this.BuCerrar.Icon = null;
            this.BuCerrar.Location = new System.Drawing.Point(798, 494);
            this.BuCerrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BuCerrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BuCerrar.Name = "BuCerrar";
            this.BuCerrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BuCerrar.Size = new System.Drawing.Size(131, 36);
            this.BuCerrar.TabIndex = 42;
            this.BuCerrar.Text = "Cerrar sesión";
            this.BuCerrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BuCerrar.UseAccentColor = false;
            this.BuCerrar.UseVisualStyleBackColor = true;
            this.BuCerrar.Click += new System.EventHandler(this.BuCerrar_Click);
            // 
            // groupBInfo
            // 
            this.groupBInfo.BackColor = System.Drawing.Color.Transparent;
            this.groupBInfo.BackGColor = System.Drawing.Color.DodgerBlue;
            this.groupBInfo.BaseColor = System.Drawing.Color.Transparent;
            this.groupBInfo.BorderColorG = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.groupBInfo.BorderColorH = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(180)))), ((int)(((byte)(186)))));
            this.groupBInfo.Controls.Add(this.lbUsername);
            this.groupBInfo.Controls.Add(this.pictureLogoUser);
            this.groupBInfo.Controls.Add(this.label1);
            this.groupBInfo.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBInfo.ForeColor = System.Drawing.Color.Black;
            this.groupBInfo.HeaderColor = System.Drawing.Color.CornflowerBlue;
            this.groupBInfo.Location = new System.Drawing.Point(665, 6);
            this.groupBInfo.MinimumSize = new System.Drawing.Size(136, 50);
            this.groupBInfo.Name = "groupBInfo";
            this.groupBInfo.Padding = new System.Windows.Forms.Padding(5, 28, 5, 5);
            this.groupBInfo.Size = new System.Drawing.Size(265, 102);
            this.groupBInfo.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.groupBInfo.TabIndex = 44;
            this.groupBInfo.Text = "Mi Información";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 45;
            this.label1.Text = "Usuario:";
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
            // iconSplitButton1
            // 
            this.iconSplitButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconSplitButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconSplitButton1.IconColor = System.Drawing.Color.Black;
            this.iconSplitButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSplitButton1.IconSize = 48;
            this.iconSplitButton1.Name = "iconSplitButton1";
            this.iconSplitButton1.Rotation = 0D;
            this.iconSplitButton1.Size = new System.Drawing.Size(23, 23);
            this.iconSplitButton1.Text = "iconSplitButton1";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.lbUsername.ForeColor = System.Drawing.Color.White;
            this.lbUsername.Location = new System.Drawing.Point(7, 52);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(42, 21);
            this.lbUsername.TabIndex = 47;
            this.lbUsername.Text = "Text";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerTabControl = this.materialTabControl1;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.materialTabControl1.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            this.groupBInfo.ResumeLayout(false);
            this.groupBInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogoUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabRegistrarTurno;
        private System.Windows.Forms.TabPage tabPaciente;
        private System.Windows.Forms.TabPage tabAtenderPacientes;
        private System.Windows.Forms.TabPage tabColaTurnos;
        private System.Windows.Forms.TabPage tabEmpleados;
        private System.Windows.Forms.TabPage tabMedicos;
        private System.Windows.Forms.TabPage tabAsistente;
        private System.Windows.Forms.TabPage tabEspecialidades;
        private System.Windows.Forms.TabPage tabUsuarios;
        private System.Windows.Forms.TabPage tabRoles;
        private System.Windows.Forms.TabPage tabReportes;
        private MaterialSkin.Controls.MaterialButton BuCerrar;
        private ReaLTaiizor.Controls.GroupBox groupBInfo;
        private FontAwesome.Sharp.IconSplitButton iconSplitButton1;
        private System.Windows.Forms.PictureBox pictureLogoUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbUsername;
    }
}