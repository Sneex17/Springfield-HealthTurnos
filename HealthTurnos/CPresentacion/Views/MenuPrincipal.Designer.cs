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
            this.tabMedicos = new System.Windows.Forms.TabPage();
            this.tabAsistente = new System.Windows.Forms.TabPage();
            this.materialTabControl1.SuspendLayout();
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
            this.materialTabControl1.Controls.Add(this.tabMedicos);
            this.materialTabControl1.Controls.Add(this.tabAsistente);
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
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(936, 557);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // tabRegistrarTurno
            // 
            this.tabRegistrarTurno.Location = new System.Drawing.Point(4, 22);
            this.tabRegistrarTurno.Name = "tabRegistrarTurno";
            this.tabRegistrarTurno.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistrarTurno.Size = new System.Drawing.Size(936, 557);
            this.tabRegistrarTurno.TabIndex = 1;
            this.tabRegistrarTurno.Text = "Registrar turno";
            this.tabRegistrarTurno.UseVisualStyleBackColor = true;
            // 
            // tabPaciente
            // 
            this.tabPaciente.Location = new System.Drawing.Point(4, 22);
            this.tabPaciente.Name = "tabPaciente";
            this.tabPaciente.Padding = new System.Windows.Forms.Padding(3);
            this.tabPaciente.Size = new System.Drawing.Size(936, 557);
            this.tabPaciente.TabIndex = 2;
            this.tabPaciente.Text = "Consulta paciente";
            this.tabPaciente.UseVisualStyleBackColor = true;
            // 
            // tabAtenderPacientes
            // 
            this.tabAtenderPacientes.Location = new System.Drawing.Point(4, 22);
            this.tabAtenderPacientes.Name = "tabAtenderPacientes";
            this.tabAtenderPacientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabAtenderPacientes.Size = new System.Drawing.Size(936, 557);
            this.tabAtenderPacientes.TabIndex = 3;
            this.tabAtenderPacientes.Text = "Atender pacientes";
            this.tabAtenderPacientes.UseVisualStyleBackColor = true;
            // 
            // tabColaTurnos
            // 
            this.tabColaTurnos.Location = new System.Drawing.Point(4, 22);
            this.tabColaTurnos.Name = "tabColaTurnos";
            this.tabColaTurnos.Size = new System.Drawing.Size(936, 557);
            this.tabColaTurnos.TabIndex = 4;
            this.tabColaTurnos.Text = "Colar de turnos";
            this.tabColaTurnos.UseVisualStyleBackColor = true;
            // 
            // tabEmpleados
            // 
            this.tabEmpleados.Location = new System.Drawing.Point(4, 22);
            this.tabEmpleados.Name = "tabEmpleados";
            this.tabEmpleados.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmpleados.Size = new System.Drawing.Size(936, 557);
            this.tabEmpleados.TabIndex = 5;
            this.tabEmpleados.Text = "Gestión de empleados";
            this.tabEmpleados.UseVisualStyleBackColor = true;
            // 
            // tabMedicos
            // 
            this.tabMedicos.Location = new System.Drawing.Point(4, 22);
            this.tabMedicos.Name = "tabMedicos";
            this.tabMedicos.Size = new System.Drawing.Size(936, 557);
            this.tabMedicos.TabIndex = 6;
            this.tabMedicos.Text = "Gestión de médicos";
            this.tabMedicos.UseVisualStyleBackColor = true;
            // 
            // tabAsistente
            // 
            this.tabAsistente.Location = new System.Drawing.Point(4, 22);
            this.tabAsistente.Name = "tabAsistente";
            this.tabAsistente.Size = new System.Drawing.Size(936, 557);
            this.tabAsistente.TabIndex = 7;
            this.tabAsistente.Text = "Gestión de asistentes";
            this.tabAsistente.UseVisualStyleBackColor = true;
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
    }
}